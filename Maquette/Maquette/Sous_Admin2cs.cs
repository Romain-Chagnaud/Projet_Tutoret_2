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
            //listBox2.Items.Clear();
            //var aboRe = Outil.getRetardataires();

            //foreach (ABONNÉS ab in aboRe)
            //{
            //    listBox2.Items.Add(ab); 
            //}

        }


        private void Sous_Admin2cs_Load(object sender, EventArgs e)
        {
            var abos = Outil.getRetardataires();

            flowLayoutPanel1.Controls.Clear();
            foreach (ABONNÉS ab in abos)
            {
                int i = 0;
                AbonneRetardataire af = new AbonneRetardataire(ab);
                af.Location = new Point(af.Location.Y + i);
                flowLayoutPanel1.Controls.Add(af);
                i = i + 10;

            }
        }
    }
}
