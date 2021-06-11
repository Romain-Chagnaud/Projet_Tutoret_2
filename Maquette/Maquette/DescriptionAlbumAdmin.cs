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
    public partial class DescriptionAlbumAdmin : Form
    {
        ALBUMS album;

        public DescriptionAlbumAdmin(ALBUMS album)
        {
            InitializeComponent();
            this.album = album;
            InitialiserContenu();
        }

        private void InitialiserContenu()
        {
            lblTitre.Text = album.TITRE_ALBUM.Trim();
            lblGenre.Text = album.GENRES.LIBELLÉ_GENRE.Trim();
            lblEdit.Text = album.EDITEURS.ToString();
            lblAnnée.Text = album.ANNÉE_ALBUM.ToString();
            lblPrix.Text = album.PRIX_ALBUM.ToString();
            if (album.POCHETTE != null)
            {
                pochette.Image = Image.FromStream(new MemoryStream(album.POCHETTE));
            }
        }
    }
}
