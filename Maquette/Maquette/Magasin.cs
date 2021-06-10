using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Maquette.Outil;

namespace Maquette
{
    public partial class Magasin : Form
    {
        Abonné parent;
        List<ALBUMS> affichables;
        List<ALBUMS> disponibles;

        int pageDispo = 0;

        public Magasin(Abonné parent)
        {
            InitializeComponent();
            this.parent = parent;
            affichables = new List<ALBUMS>();
            disponibles = parent.disponibles;
            affichables.AddRange(disponibles);
            afficherAlbums();
        }

        #region IHM

        private void lblEspace_Click(object sender, EventArgs e)
        {
            Quitter();
        }

        #endregion
        #region Logique

        private void Quitter()
        {
            parent.ShowInTaskbar = true;
            parent.WindowState = FormWindowState.Normal;

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        protected override void OnShown(EventArgs e)
        {
            Focus();
        }

        #endregion


        /// <summary>        
        /// Méthode ci-dessous : US 1
        /// Méthode pour afficher les albums non-empruntés
        /// </summary>
        private void afficherAlbums()
        {
            panelDispo.Controls.Clear();
            for (int i = 8 * pageDispo; i < 8 * (pageDispo + 1); i++)
            {
                if (i < affichables.Count)
                {
                    panelDispo.Controls.Add(new AlbumEmpruntable(affichables[i], this));
                }
            }
            lblPageDispo.Text = pageDispo + 1 + "";
        }

        private void btnPreDis_Click(object sender, EventArgs e)
        {
            if (pageDispo > 0)
            {
                pageDispo--;
            } else
            {
                pageDispo = (affichables.Count / 8) - 1;
            }
            afficherAlbums();
        }

        private void btnSuiDis_Click(object sender, EventArgs e)
        {
            if (pageDispo < (affichables.Count/ 8)-1)
            {
                pageDispo++;
            } else
            {
                pageDispo = 0;
            }
            afficherAlbums();
        }

        public void EmprunterAlbum(ALBUMS album)
        {
            parent.EmprunterAlbum(album);
            afficherAlbums();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length != 0)
            {
                affichables = disponibles.FindAll(a => a.TITRE_ALBUM.StartsWith(textBox1.Text));
                pageDispo = 0;
                afficherAlbums();
            }
        }
    }
}
