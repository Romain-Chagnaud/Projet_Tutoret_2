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
        int nombreDePages;

        int pageDispo = 0;

        public Magasin(Abonné parent)
        {
            InitializeComponent();
            this.parent = parent;
            affichables = new List<ALBUMS>();            
            affichables.AddRange(parent.disponibles);      
            afficherAlbums();
            actualiserNombreDepages();
        }

        private void actualiserNombreDepages()
        {
            if (affichables.Count % 8 != 0)
            {
                nombreDePages = affichables.Count / 8;
            } else
            {
                nombreDePages = (affichables.Count/8)-1;
            }
        }

        #region IHM

        private void lblEspace_Click(object sender, EventArgs e)
        {
            Quitter();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            PreparerAffichage();
        }

        private void btnPreDis_Click(object sender, EventArgs e)
        {
            Decrementer();
        }
        private void btnSuiDis_Click(object sender, EventArgs e)
        {
            Incrementer();
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

        private void Decrementer()
        {
            if (pageDispo > 0)
            {
                pageDispo--;
            }
            else
            {
                pageDispo = nombreDePages;
            }
            afficherAlbums();
        }

        

        private void Incrementer()
        {
            if (pageDispo < nombreDePages)
            {
                pageDispo++;
            }
            else
            {
                pageDispo = 0;
            }
            afficherAlbums();
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

        

        public void EmprunterAlbum(ALBUMS album)
        {
            parent.EmprunterAlbum(album);          
            PreparerAffichage();
        }

        

        private void PreparerAffichage()
        {
            if (barreRecherche.Text.Trim().Length != 0)
            {
                affichables = parent.disponibles.FindAll(a => a.TITRE_ALBUM.StartsWith(barreRecherche.Text));               
            }
            else
            {
                affichables = parent.disponibles;
            }
            pageDispo = 0;
            actualiserNombreDepages();
            afficherAlbums();
        }        

    }
}
