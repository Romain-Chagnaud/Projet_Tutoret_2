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
    public partial class AlbumClassement : UserControl
    {
        ALBUMS album;
        int value;

        public AlbumClassement(ALBUMS album, int value)
        {
            InitializeComponent();
            this.album = album;
            this.value = value;
            lblTitre.Text = album.TITRE_ALBUM;
            label1.Text = value + "";
            if (album.POCHETTE != null)
            {
                pochette.Image = Image.FromStream(new MemoryStream(album.POCHETTE));
            }

        }
    }
}
