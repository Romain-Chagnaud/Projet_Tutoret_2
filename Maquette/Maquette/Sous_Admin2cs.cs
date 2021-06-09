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
    public partial class Sous_Admin2cs : Form
    {
        public Sous_Admin2cs()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var aboRe = Outil.getRetardataires();

            foreach (ABONNÉS ab in aboRe)
            {
                listBox2.Items.Add(ab); 
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            var abo = Outil.getAbonnéSelonLogin("Mijel");
            var alb = Outil.getAlbumSelonTitre("Haendel: Saul");
            Outil.nouvelEmprunt(abo, alb);
        }
    }
}
