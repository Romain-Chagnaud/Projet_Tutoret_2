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
        List<ABONNÉS> abo;
        int pageAbo = 0;
        int nbPagesAbo;

        public Sous_Admin()
        {
            InitializeComponent();
            abo = Outil.GetFantomes();
            ActualiserNbPages();
        }

        private void SousAdmin_Load(object sender, EventArgs e)
        {
            ChargerListe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Outil.PurgerFantomes();
            flowLayoutPanel1.Controls.Clear();
        }

        private void ActualiserNbPages()
        {
            if (abo.Count % 2 != 0)
            {
                nbPagesAbo = abo.Count / 2;
            }
            else
            {
                nbPagesAbo = (abo.Count / 2) - 1;
            }
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
                pageAbo = nbPagesAbo;
            }
            ChargerListe();
        }

        /// <summary>
        /// Incrémente la page des recommandés
        /// </summary>
        private void AugmenterReco()
        {
            if (pageAbo < nbPagesAbo)
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
                    flowLayoutPanel1.Controls.Add(new PresentationAbonne(abo[i]));
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


