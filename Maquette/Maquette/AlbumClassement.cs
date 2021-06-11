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

        public AlbumClassement(ALBUMS album, int value)
        {
            InitializeComponent();
            lblTitre.Text = album.TITRE_ALBUM;
            lblPos.Text = value + "";
            if (album.POCHETTE != null)
            {
                pochette.Image = Image.FromStream(new MemoryStream(album.POCHETTE));
            }

        }
    }
}
