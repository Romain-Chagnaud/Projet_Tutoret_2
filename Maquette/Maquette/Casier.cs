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


        #region IHM

        /// <summary>
        /// Permet de charger les albums dans les casiers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChargement_Click(object sender, EventArgs e)
        {
            ChargerAlbums();
            AfficherAlbums();
        }

        /// <summary>
        /// Clique sur la page précédente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreCas_Click(object sender, EventArgs e)
        {
            Decrementer();
        }

        /// <summary>
        /// Clique sur la page suivante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuiCas_Click(object sender, EventArgs e)
        {
            Incrementer();
        }
        #endregion

        #region Logique

        /// <summary>
        /// Charge un album
        /// </summary>
        private void ChargerAlbums()
        {
            afficher = Outil.GetAlbumManquantCasier(txtAllee.Text, (int)numCasier.Value);
            ActualiserPage();
        }

        /// <summary>
        /// Affiche les albums 
        /// </summary>
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

        /// <summary>
        /// Actualise le nombre de page 
        /// </summary>
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

        /// <summary>
        /// Incrémente la page
        /// </summary>
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

        /// <summary>
        /// Décrémente la page 
        /// </summary>
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

        #endregion


    }
}
