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
    public partial class DescriptionAlbum : Form
    {
        ALBUMS album;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public DescriptionAlbum(ALBUMS album)
        {
            InitializeComponent();
            this.album = album;

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            this.btnEmprunt.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnEmprunt.Width, btnEmprunt.Height, 10, 10));


            InitialiserContenu();
        }

        private void InitialiserContenu()
        {
            lblTitre.Text = album.TITRE_ALBUM.Trim();
            lblGenre.Text = album.GENRES.LIBELLÉ_GENRE.Trim();
            lblEdit.Text = album.EDITEURS.ToString();
            lblAnnée.Text = album.ANNÉE_ALBUM.ToString();
            lblPrix.Text = album.PRIX_ALBUM.ToString() + " €";
            if (album.POCHETTE != null)
            {
                pochette.Image = Image.FromStream(new MemoryStream(album.POCHETTE));
            }
        }
    }
}
