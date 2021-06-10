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
    public partial class TopAlbum : Form
    {

        List<ALBUMS> albums;
        List<int> count;
        int page = 0;
        int nbPage;

        public TopAlbum()
        {
            InitializeComponent();
            albums = Outil.getTop10Albums();
            count = Outil.getTop10Count();
            ActualiserPage();
            AfficherAlbums();
        }

        private void btnPreCon_Click(object sender, EventArgs e)
        {
            Decrementer();
        }

        private void btnSuiCon_Click(object sender, EventArgs e)
        {
            Incrementer();
        }

        private void AfficherAlbums()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 3 * page; i < 3 * (page + 1); i++)
            {
                if (i < albums.Count && i >= 0)
                {
                    flowLayoutPanel1.Controls.Add(new AlbumClassement(albums[i], count[i]));
                }
            }
            lblPageReco.Text = page + 1 + "";
        }


        private void ActualiserPage()
        {
            if (albums.Count % 4 != 0)
            {
                nbPage = albums.Count / 4;
            }
            else
            {
                nbPage = (albums.Count / 4) - 1;
            }
        }

        private void Incrementer()
        {
            if (page < nbPage)
            {
                page++;
            }
            else
            {
                page = 0;
            }
            AfficherAlbums();
        }



        private void Decrementer()
        {
            if (page > 0)
            {
                page--;
            }
            else
            {
                page = nbPage;
            }
            AfficherAlbums();
        }
    }
}