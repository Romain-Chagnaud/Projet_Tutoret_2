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
    public partial class Prologation : Form
    {
        public ABONNÉS abonne;

        List<EMPRUNTER> prolo;
        int pageProlo = 0;

        public Prologation()
        {
            InitializeComponent();

            prolo = getProlongés();
        }

        private void ChargerListe()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 2 * pageProlo; i < 2 * (pageProlo + 1); i++)
            {
                if (i < prolo.Count)
                {
                    flowLayoutPanel1.Controls.Add(new ProlongationAbo(prolo[i]));
                }
            }
            lblPageReco.Text = pageProlo + 1 + "";
        }



        /// <summary>
        /// Décrémente la page des recommandés
        /// </summary>
        private void DiminuerReco()
        {
            if (pageProlo > 0)
            {
                pageProlo--;
            }
            else
            {
                if ((prolo.Count / 2) > 0)
                {
                    pageProlo = (prolo.Count / 2) - 1;
                }
            }
            ChargerListe();
        }

        private void btnPreCon_Click(object sender, EventArgs e)
        {
            DiminuerReco();
        }
        private void btnSuiCon_Click(object sender, EventArgs e)
        {
            AugmenterReco();

        }
        /// <summary>
        /// Incrémente la page des recommandés
        /// </summary>
        private void AugmenterReco()
        {
            if (pageProlo < (prolo.Count / 2) - 1)
            {
                pageProlo++;
            }
            else
            {
                pageProlo = 0;
            }
            ChargerListe();

        }

        private void Prologation_Load(object sender, EventArgs e)
        {
            ChargerListe();
        }
    }
}
