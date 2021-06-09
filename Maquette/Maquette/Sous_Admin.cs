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
    public partial class Sous_Admin : Form
    {
        private ABONNÉS abonne;

        public Sous_Admin()
        {
            InitializeComponent();
        }

        private void SousAdmin(object sender, EventArgs e)
        {

            var abos = Outil.getFantomes();

            flowLayoutPanel1.Controls.Clear();
            foreach (ABONNÉS ab in abos)
            {
                int i = 0;
                AbonneFantome af = new AbonneFantome(ab);
                af.Location = new Point(af.Location.Y + i);
                flowLayoutPanel1.Controls.Add(af);
                i = i + 10;

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Outil.purgerFantomes();
            flowLayoutPanel1.Controls.Clear();
        }
    }
}


