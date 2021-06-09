using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            List<ALBUMS> albumsTriés = Outil.getTop10();
            if (albumsTriés.Count >= 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    listBox5.Items.Add(albumsTriés[i]);
                }
            }
            else if (albumsTriés.Count > 0)
            {
                for (int i = 0; i < albumsTriés.Count; i++)
                {
                    listBox5.Items.Add(albumsTriés[i]);
                }
            }
            else
            {
                listBox5.Items.Add("Aucun emprunt");
            }
        }
    }
}

