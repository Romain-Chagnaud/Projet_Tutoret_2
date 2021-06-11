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

namespace Maquette
{
    public partial class AlbumNonEmprunte : UserControl
    {
        ALBUMS album;


        public AlbumNonEmprunte(ALBUMS album)
        {
            InitializeComponent();
            this.album = album;
            ChargerElements();
        }

        #region IHM

        /// <summary>
        /// Click sur le bouton Voir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnVoir_Click(object sender, EventArgs e)
        {
            AfficherDetails();
        }

        #endregion

        #region Logique

        /// <summary>
        /// Initialise l'affichage de l'emprunt
        /// </summary>
        private void ChargerElements()
        {
            lblTitre.Text = album.TITRE_ALBUM;
            if (album.POCHETTE != null)
            {
                pochette.Image = Image.FromStream(new MemoryStream(album.POCHETTE));
            }
        }

        /// <summary>
        /// Affiche les détails d'un album
        /// </summary>
        private void AfficherDetails()
        {
            DescriptionAlbumAdmin desc = new DescriptionAlbumAdmin(album);
            desc.ShowDialog();
        }

        #endregion
    }
}
