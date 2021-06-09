using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Maquette.Outil;

namespace Maquette
{
    public partial class Abonné : Form
    {
        ABONNÉS abonne;

        List<EMPRUNTER> emprunts;
        int pageEmprunts = 0;

        List<ALBUMS> recommendations;
        int pageReco = 0;



        public Abonné(ABONNÉS ab)
        {
            InitializeComponent();
            abonne = ab;
            InitialiserElements();

        }




        #region IHM

        /// <summary>
        /// Méthode ci-dessous : US 9
        /// Méthode pour allonger le délai de tous les emprunts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToutAlg_Click(object sender, EventArgs e)
        {
            AllongerTousEmprunts();
        }

        /// <summary>
        /// Appui sur le bouton "Précédent" des albums empruntés
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPagePre_Click(object sender, EventArgs e)
        {
            DiminuerEmprunt();
        }

        /// <summary>
        /// Appui sur le bouton "Suivant" des albums empruntés
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPageSui_Click(object sender, EventArgs e)
        {
            AugmenterEmprunt();
        }

        /// <summary>
        /// Appui sur le label magasin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblMagasin_Click(object sender, EventArgs e)
        {
            OuvrirMagasin();
        }

        #endregion

        #region Logique

        void InitialiserElements()
        {
            ActualiserListes();
            afficherEmprunts();
            afficherSuggestions();
        }

        private void ActualiserListes()
        {
            emprunts = getEmpruntsEnCoursAbonné(abonne.CODE_ABONNÉ);
            recommendations = getSuggestions(abonne.CODE_ABONNÉ);
        }


        /// <summary>
        /// Méthode ci-dessous : US 2 + 13
        /// Méthode pour afficher tous les emprunts (avec pagination)
        /// </summary>
        public void afficherEmprunts()
        {
            panelEmprunts.Controls.Clear();
            for (int i = 4 * pageEmprunts; i < 4 * (pageEmprunts + 1); i++)
            {
                if (i < emprunts.Count)
                {
                    panelEmprunts.Controls.Add(new AlbumARendre(emprunts[i], this));
                }
            }

            lblPageEmp.Text = pageEmprunts + "";
        }
        /// <summary>
        /// Allonge le délai de tous les emprunts
        /// </summary>
        private void AllongerTousEmprunts()
        {
            foreach (EMPRUNTER emp in emprunts)
            {
                prolongation(emp);
            }
            afficherEmprunts();
        }

        /// <summary>
        /// Augmente le numéro de page pour les emprunts
        /// </summary>
        private void AugmenterEmprunt()
        {
            if (pageEmprunts < (getEmpruntsEnCoursAbonné(abonne.CODE_ABONNÉ).Count / 4))
            {
                pageEmprunts++;
            }
            afficherEmprunts();
        }

        /// <summary>
        /// Diminue le numéro de page pour les emprunts
        /// </summary>
        private void DiminuerEmprunt()
        {
            if (pageEmprunts > 0)
            {
                pageEmprunts--;
            }
            afficherEmprunts();
        }
        #endregion








        /// <summary>
        /// Méthode ci-dessous : US 10
        /// Méthode pour afficher les suggestions
        /// </summary>
        private void afficherSuggestions()
        {
            panelConseil.Controls.Clear();


            if (recommendations.Count > 0)
            {
                lblPasSugg.Visible = false;
                for (int i = 3 * pageReco; i < 3 * (pageReco + 1); i++)
                {
                    if (i < recommendations.Count)
                    {
                        panelConseil.Controls.Add(new AlbumEmpruntable(recommendations[i], this));
                    }
                }
                lblPageReco.Text = pageReco + "";

            }
            else
            {
                AfficherPasReco();
            }
        }

        private void AfficherPasReco()
        {
            lblPasSugg.Visible = true;
            lblPasSugg.Location = new System.Drawing.Point(panelConseil.Location.X + panelGrandConseils.Location.X,
                panelConseil.Location.Y + panelGrandConseils.Location.Y);
            lblPasSugg.Size = panelConseil.Size;
        }




        private void OuvrirMagasin()
        {
            Magasin magasin = new Magasin(this);
            magasin.Show();
            InitialiserElements();
        }



        private void btnPreCon_Click(object sender, EventArgs e)
        {
            DiminuerReco();
        }

        private void btnSuiCon_Click(object sender, EventArgs e)
        {
            AugmenterReco();
        }

        private void AugmenterReco()
        {
            if (pageReco < (getSuggestions(abonne.CODE_ABONNÉ).Count / 3))
            {
                pageReco++;
            }
            afficherSuggestions();
        }

        private void DiminuerReco()
        {
            if (pageReco > 0)
            {
                pageReco--;
            }
            afficherSuggestions();
        }

    }
}
