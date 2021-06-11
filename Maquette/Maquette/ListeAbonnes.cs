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

        #region IHM

        /// <summary>
        /// Clic sur le bouton Page Précédente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPreAbo_Click(object sender, EventArgs e)
        {
            Decrementer();
        }

        /// <summary>
        /// Clic sur le bouton Page Suivante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSuiAbo_Click(object sender, EventArgs e)
        {
            Incrementer();
        }

        #endregion

        #region Logique

        /// <summary>
        /// Affiche les abonnés de la page actuelle
        /// </summary>
        private void AfficherAbos()
        {
            pnlAbo.Controls.Clear();
            for (int i = page * 4; i < (page + 1) * 4; i++)
            {
                if (i < abos.Count)
                {
                    pnlAbo.Controls.Add(new PresentationAbonne(abos[i]));
                }
            }
            lblPageAbo.Text = page + 1 + "";
        }

        /// <summary>
        /// Actualise le nombre de pages
        /// </summary>
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
            AfficherAbos();
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
            AfficherAbos();
        }

        #endregion






    }
}
