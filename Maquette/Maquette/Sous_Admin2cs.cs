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

        List<ABONNÉS> retards;
        int pageRetard = 0;
        int nbPageRetard;

        public Sous_Admin2cs()
        {
            InitializeComponent();
            retards = Outil.GetRetardataires();
            ActualiserPage();

        }


        private void ActualiserPage()
        {
            if (retards.Count % 2 != 0)
            {
                nbPageRetard = retards.Count / 2;
            }
            else
            {
                nbPageRetard = (retards.Count / 2) - 1;
            }
        }

        private void Sous_Admin2cs_Load(object sender, EventArgs e)
        {
            ChargerRetard();
        }

        private void ChargerRetard()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 2 * pageRetard; i < 2 * (pageRetard + 1); i++)
            {
                if (i < retards.Count)
                {
                    flowLayoutPanel1.Controls.Add(new PresentationAbonne(retards[i]));
                }
            }
            lblPageReco.Text = pageRetard + 1 + "";
        }

        private void btnPreCon_Click(object sender, EventArgs e)
        {
            DecrementerPage();
        }

        private void DecrementerPage()
        {
            if (pageRetard > 0)
            {
                pageRetard--;
            }
            else
            {
                pageRetard = nbPageRetard;
            }
            ChargerRetard();
        }

        private void btnSuiCon_Click(object sender, EventArgs e)
        {
            IncrementerPage();
        }

        private void IncrementerPage()
        {
            if (pageRetard < nbPageRetard)
            {
                pageRetard++;
            }
            else
            {
                pageRetard = 0;
            }
            ChargerRetard();
        }
    }
}
