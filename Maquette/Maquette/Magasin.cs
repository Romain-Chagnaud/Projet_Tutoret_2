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

        List<ALBUMS> affichables;
        int nombreDePages;
        int pageDispo = 0;

        readonly Abonné parent;

        public Magasin(Abonné parent)
        {
            InitializeComponent();
            this.parent = parent;
            affichables = new List<ALBUMS>();
            affichables.AddRange(parent.disponibles);
            AfficherAlbums();
            actualiserNombreDepages();
        }

        private void actualiserNombreDepages()
        {
            if (affichables.Count % 8 != 0 || affichables.Count == 0)
            {
                nombreDePages = affichables.Count / 8;
            }
            else
            {
                nombreDePages = (affichables.Count / 8) - 1;
            }
        }

        #region IHM

        /// <summary>
        /// Clic sur le label "Mon Espace"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblEspace_Click(object sender, EventArgs e)
        {
            AfficherEspace();
        }

        /// <summary>
        /// Clic sur le bouton de recherche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRecherche_Click(object sender, EventArgs e)
        {
            PreparerAffichage();
        }

        /// <summary>
        /// Clic sur le bouton Page Précédente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPreDis_Click(object sender, EventArgs e)
        {
            Decrementer();
        }

        /// <summary>
        /// Clic sur le bouton Page Suivante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSuiDis_Click(object sender, EventArgs e)
        {
            Incrementer();
        }

        #endregion

        #region Logique

        /// <summary>
        /// Change l'affichage sur la fenêtre Mon Espace
        /// </summary>
        private void AfficherEspace()
        {
            parent.ShowInTaskbar = true;
            parent.WindowState = FormWindowState.Normal;

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        /// Méthode ci-dessous : US 1
        /// Méthode pour afficher les albums non-empruntés
        /// </summary>
        private void AfficherAlbums()
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

        /// <summary>
        /// Décrémente la page des albums disponibles
        /// </summary>
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
            AfficherAlbums();
        }

        /// <summary>
        /// Décrémente la page des albums disponibles
        /// </summary>
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
            AfficherAlbums();
        }

        /// <summary>
        /// Permet de gérer l'emprunt d'un album
        /// </summary>
        /// <param name="album"></param>
        public void EmprunterAlbum(ALBUMS album)
        {
            parent.EmprunterAlbum(album);
            PreparerAffichage();
        }


        /// <summary>
        /// Change l'affichage lors de la recherche d'un album
        /// </summary>
        public void PreparerAffichage()
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
            AfficherAlbums();
        }

        #endregion
    }
}
