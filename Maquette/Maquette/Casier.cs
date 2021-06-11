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
    public partial class Casier : Form


    {
        List<ALBUMS> tout;
        List<ALBUMS> afficher;

        int page = 0;
        int nbPage;


        public Casier()
        {
            InitializeComponent();
            tout = Outil.getALBUMSs();
            afficher = tout;
        }

        private void btnChargement_Click(object sender, EventArgs e)
        {
            ChargerAlbums();
            AfficherAlbums();
        }

        private void btnPreCas_Click(object sender, EventArgs e)
        {
            Decrementer();
        }

        private void btnSuiCas_Click(object sender, EventArgs e)
        {
            Incrementer();
        }

        private void ChargerAlbums()
        {
            afficher = Outil.GetAlbumManquantCasier(txtAllee.Text, (int)numCasier.Value);
            ActualiserPage();
        }

        private void AfficherAlbums()
        {
            pnlAlbums.Controls.Clear();
            for (int i = 6 * page; i < 6 * (page + 1); i++)
            {
                if (i < afficher.Count && i >= 0)
                {
                    pnlAlbums.Controls.Add(new AlbumNonEmprunte(afficher[i]));
                }
            }
            lblPageCas.Text = page + 1 + "";
        }


        private void ActualiserPage()
        {
            if (afficher.Count % 4 != 0)
            {
                nbPage = afficher.Count / 4;
            }
            else
            {
                nbPage = (afficher.Count / 4) - 1;
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
            AfficherAlbums();
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
            AfficherAlbums();
        }
    }
}
