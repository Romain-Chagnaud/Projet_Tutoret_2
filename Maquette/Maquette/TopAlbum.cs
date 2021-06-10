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
        public TopAlbum()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
            List<ALBUMS> albumsTriés = getTop10Albums();
            List<int> albumsCount = getTop10Count();

            if (albumsTriés.Count >= 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    listBox5.Items.Add(albumsTriés[i]);
                    listBox1.Items.Add(albumsCount[i]);
                }
            }
            else if (albumsTriés.Count > 0)
            {
                for (int i = 0; i < albumsTriés.Count; i++)
                {
                    listBox5.Items.Add(albumsTriés[i]); 
                    listBox1.Items.Add(albumsCount[i]);
                }
            }
            else
            {
                listBox5.Items.Add("Aucun emprunt");
            }
        }
    }
}

