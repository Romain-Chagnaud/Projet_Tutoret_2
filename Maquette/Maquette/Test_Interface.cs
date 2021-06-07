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
    public partial class Test_Interface : Form
    {

        MusiqueEntities musique;

        public Test_Interface(MusiqueEntities musique)
        {
            InitializeComponent();
            this.musique = musique;
        }

        private void Test_Interface_Load(object sender, EventArgs e)
        {
            /*
            var albums = (from a in musique.ALBUMS
                          select a).ToList();

            UserControl1[] list = new UserControl1[albums.Count];
            int compteur = 0;
            foreach (ALBUMS al in albums)
            {
                list[compteur] = new UserControl1();
                list[compteur].MyTitre = al.TITRE_ALBUM;
                list[compteur].MyAnnee = (int)al.ANNÉE_ALBUM;
                if (al.POCHETTE != null)
                {
                    //list[compteur].MyImage = Image.FromStream(new MemoryStream(al.POCHETTE));
                }

                flowLayoutPanel1.Controls.Add(list[compteur]);
                compteur++;
            }*/

        }
    }
}
