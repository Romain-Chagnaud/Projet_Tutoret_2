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

        #region IHM

        /// <summary>
        /// Permet d'afficher les abos Fantômes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SousAdmin_Load(object sender, EventArgs e)
        {
            ChargerListe();
        }

        /// <summary>
        /// Suprime tous les abonnées fantômes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSuppr_Click(object sender, EventArgs e)
        {
            Purge();
        }

        /// <summary>
        /// Clique sur la page suivante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSuiFan_Click(object sender, EventArgs e)
        {
            AugmenterReco();
        }

        /// <summary>
        /// Clique sur la page précendente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreFan_Click(object sender, EventArgs e)
        {
            DiminuerReco();
        }

        #endregion

        #region Logique

        /// <summary>
        /// Actualiser le nombre de page
        /// </summary>
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

        /// <summary>
        /// Décrémente la page 
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
        /// Incrémente la page 
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

        /// <summary>
        /// Permet d'afficher les abos Fantômes
        /// </summary>
        private void ChargerListe()
        {
            pnlFanto.Controls.Clear();
            for (int i = 2 * pageAbo; i < 2 * (pageAbo + 1); i++)
            {
                if (i < abo.Count)
                {
                    pnlFanto.Controls.Add(new PresentationAbonne(abo[i]));
                }
            }
            lblPageFan.Text = pageAbo + 1 + "";
        }

        /// <summary>
        /// Supprime les abos Fantômes
        /// </summary>
        private void Purge()
        {
            Outil.PurgerFantomes();
            pnlFanto.Controls.Clear();
        }

        #endregion

    }
}


