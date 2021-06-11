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
    public partial class ListeAbonnes : Form
    {
        List<ABONNÉS> abos;
        int page = 0;
        int nbPage;


        public ListeAbonnes()
        {
            InitializeComponent();
            abos = Outil.GetABONNÉSs();
            ActualiserPage();
            AfficherAbos();
        }

        private void AfficherAbos()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = page * 4; i < (page + 1) * 4; i++)
            {
                if (i < abos.Count)
                {
                    flowLayoutPanel1.Controls.Add(new PresentationAbonne(abos[i]));
                }
            }
            lblPageReco.Text = page + 1 + "";
        }

        private void btnPreCon_Click(object sender, EventArgs e)
        {
            Decrementer();
        }

        private void btnSuiCon_Click(object sender, EventArgs e)
        {
            Incrementer();
        }

        private void ActualiserPage()
        {
            if (abos.Count % 4 != 0)
            {
                nbPage = abos.Count / 4;
            }
            else
            {
                nbPage = (abos.Count / 4) - 1;
            }
        }

        private void Incrementer()
        {
            if (page < nbPage)
            {
                page++;
            }
            else
            {
                page = 0;
            }
            AfficherAbos();
        }
        private void Decrementer()
        {
            if (page > 0)
            {
                page--;
            }
            else
            {
                page = nbPage;
            }
            AfficherAbos();
        }
    }
}
