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
        int nbPage;

        public Prologation()
        {
            InitializeComponent();
            prolo = GetProlongés();
            ActualiserPages();
        }


        #region IHM

        /// <summary>
        /// Clic sur le bouton Page Précédente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreCon_Click(object sender, EventArgs e)
        {
            DiminuerReco();
        }

        /// <summary>
        /// Clic sur le bouton Page Suivante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuiCon_Click(object sender, EventArgs e)
        {
            AugmenterReco();

        }

        /// <summary>
        /// Affichage dès le chargement de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Prologation_Load(object sender, EventArgs e)
        {
            AfficherEmprunts();
        }

        #endregion

        #region Logique

        /// <summary>
        /// Actualise le nombre de pages
        /// </summary>
        private void ActualiserPages()
        {
            if (prolo.Count % 3 != 0 || prolo.Count == 0)
            {
                nbPage = prolo.Count / 3;
            }
            else
            {
                nbPage = (prolo.Count / 3) - 1;
            }
        }

        /// <summary>
        /// Affiche tous les emprunts
        /// </summary>
        private void AfficherEmprunts()
        {
            pnlEmp.Controls.Clear();
            for (int i = 2 * pageProlo; i < 2 * (pageProlo + 1); i++)
            {
                if (i < prolo.Count)
                {
                    pnlEmp.Controls.Add(new ProlongationAbo(prolo[i]));
                }
            }
            lblPagePro.Text = pageProlo + 1 + "";
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
            AfficherEmprunts();
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
            AfficherEmprunts();

        }

        #endregion

    }
}
