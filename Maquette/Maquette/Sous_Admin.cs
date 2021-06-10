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
        List<ABONNÉS> abo;
        int pageAbo = 0;

        public Sous_Admin()
        {
            InitializeComponent();
            abo = Outil.getFantomes();
        }

        private void SousAdmin(object sender, EventArgs e)
        {
            ChargerListe();
            //var abos = Outil.getFantomes();

            //flowLayoutPanel1.Controls.Clear();
            //foreach (ABONNÉS ab in abos)
            //{
            //    int i = 0;
            //    AbonneFantome af = new AbonneFantome(ab);
            //    af.Location = new Point(af.Location.Y + i);
            //    flowLayoutPanel1.Controls.Add(af);
            //    i = i + 10;

            //}

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Outil.purgerFantomes();
            flowLayoutPanel1.Controls.Clear();
        }

        // <summary>
        /// Décrémente la page des recommandés
        /// </summary>
        private void DiminuerReco()
        {
            if (pageAbo > 0)
            {
                pageAbo--;
            }
            else
            {
                if ((abo.Count / 2) > 0) { 
                pageAbo = (abo.Count / 2) - 1;
                }
            }
            ChargerListe();
        }

        /// <summary>
        /// Incrémente la page des recommandés
        /// </summary>
        private void AugmenterReco()
        {
            if (pageAbo < (abo.Count / 2))
            {
                pageAbo++;
            }
            else
            {
                pageAbo = 0;
            }
            ChargerListe();

        }

        private void ChargerListe()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 2 * pageAbo; i < 2 * (pageAbo + 1); i++)
            {
                if (i < abo.Count)
                {
                    flowLayoutPanel1.Controls.Add(new AbonneFantome(abo[i]));
                }
            }
            lblPageReco.Text = pageAbo + 1 + "";
        }

        private void btnSuiCon_Click(object sender, EventArgs e)
        {
            AugmenterReco();
        }

        private void btnPreCon_Click(object sender, EventArgs e)
        {
            DiminuerReco();
        }
    }
}


