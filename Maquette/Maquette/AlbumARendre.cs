using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Maquette.Outil;

namespace Maquette
{
    public partial class AlbumARendre : UserControl
    {
        public EMPRUNTER emprunt;
        readonly Abonné parent;

        public AlbumARendre(EMPRUNTER emprunt, Abonné parent)
        {
            InitializeComponent();
            this.emprunt = emprunt;
            this.parent = parent;
            ChargerElements();
        }

        #region IHM

        /// <summary>
        /// Méthode ci-dessous : US 3
        /// Méthode du bouton pour allonger le délai d'un emprunt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void BtnEtendre_Click(object sender, EventArgs e)
        {
            EtendreDuree();
        }

        /// <summary>
        /// Méthode ci-dessous : US 1-?
        /// Méthode pour rendre un emprunt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRendre_Click(object sender, EventArgs e)
        {
            RendreAlbum();
        }

        #endregion

        #region Logique

        /// <summary>
        /// Initialise l'affichage de l'emprunt
        /// </summary>
        private void ChargerElements()
        {
            ALBUMS album = emprunt.ALBUMS;
            lblTitre.Text = album.TITRE_ALBUM;
            lblDate.Text = emprunt.DATE_RETOUR_ATTENDUE.ToString();
            if (album.POCHETTE != null)
            {
                pochette.Image = Image.FromStream(new MemoryStream(album.POCHETTE));
            }
        }

        /// <summary>
        /// Étend la durée de l'emprunt
        /// </summary>
        private void EtendreDuree()
        {
            if (EstProlongeable(emprunt))
            {
                Prolongation(emprunt);
                parent.AfficherEmprunts();
            }
            else
            {
                MessageBox.Show("Emprunt déjà prolongé, prolongation supplémentaire impossible");
            }

        }

        /// <summary>
        /// Rend l'album
        /// </summary>
        private void RendreAlbum()
        {
            RendreEmprunt(emprunt);
            parent.ActualiserEmprunts();
        }

        #endregion
    }
}
