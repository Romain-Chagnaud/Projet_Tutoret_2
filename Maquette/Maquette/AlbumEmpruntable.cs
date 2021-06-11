using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquette
{
    public partial class AlbumEmpruntable : UserControl
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
            );


        ALBUMS album;
        Magasin magParent = null;
        Abonné aboParent = null;
        public Point location;


        public AlbumEmpruntable(ALBUMS album, Magasin parent)
        {
            InitializeComponent();
            this.album = album;
            this.magParent = parent;

            this.Location = location;

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));

            ChargerElements();
        }

        public AlbumEmpruntable(ALBUMS album, Abonné parent)
        {
            InitializeComponent();
            this.album = album;
            this.aboParent = parent;

            this.Location = location;

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));

            ChargerElements();
        }

        #region IHM

        /// <summary>
        /// Click sur le bouton Voir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVoir_Click(object sender, EventArgs e)
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
            DescriptionAlbum desc = new DescriptionAlbum(album);
            if (desc.ShowDialog() == DialogResult.OK)
            {
                EmprunterAlbum();
            }
        }

        private void EmprunterAlbum()
        {
            if (aboParent != null)
            {
                aboParent.EmprunterAlbum(album);
            } else
            {
                magParent.EmprunterAlbum(album);
            }
        }


        #endregion
    }
}
