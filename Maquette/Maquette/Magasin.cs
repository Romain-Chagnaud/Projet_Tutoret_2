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

        int pageDispo = 0;

        public Magasin(Abonné parent)
        {
            InitializeComponent();
            this.parent = parent;
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
                if (i < parent.disponibles.Count)
                {
                    panelDispo.Controls.Add(new AlbumEmpruntable(parent.disponibles[i], this));
                }
            }
            lblPageDispo.Text = pageDispo + "";
        }

        private void btnPreDis_Click(object sender, EventArgs e)
        {
            if (pageDispo > 0)
            {
                pageDispo--;
            }
            afficherAlbums();
        }

        private void btnSuiDis_Click(object sender, EventArgs e)
        {
            if (pageDispo < (parent.disponibles.Count / 8))
            {
                pageDispo++;
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
                
            }
        }
    }
}
