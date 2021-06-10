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
        public ABONNÉS abonne;

        public List<ALBUMS> disponibles;

        List<EMPRUNTER> emprunts;
        int pageEmprunts = 0;
        int nbPagesEmp;

        List<ALBUMS> recommendations;
        int pageReco = 0;
        int nbPagesReco;

        Magasin magasin;



        public Abonné(ABONNÉS ab)
        {
            InitializeComponent();
            abonne = ab;
            lblNom.Text = ab.PRÉNOM_ABONNÉ;
            InitialiserElements();
            ChargerDisponibles();

            magasin = new Magasin(this);
            magasin.Show();
        }




        #region IHM
        public void ChargerDisponibles()
        {
            disponibles = getALBUMSs().OrderBy(a => a.TITRE_ALBUM).Except(getIndisponibles()).ToList();
        }

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

        private void btnPreCon_Click(object sender, EventArgs e)
        {
            DiminuerReco();
        }

        private void btnSuiCon_Click(object sender, EventArgs e)
        {
            AugmenterReco();
        }

        #endregion

        #region Logique

        /// <summary>
        /// Initialise les éléments
        /// </summary>
        void InitialiserElements()
        {
            ActualiserEmprunts();
            ActualiserSuggestion();
            ChargerDisponibles();
        }

        /// <summary>
        /// Actualise les listes
        /// </summary>
        public void ActualiserEmprunts()
        {
            emprunts = getEmpruntsEnCoursAbonné(abonne.CODE_ABONNÉ);
            ActualiserPagesEmprunts();
            afficherEmprunts();

        }

        public void ActualiserSuggestion()
        {
            recommendations = getSuggestions(abonne.CODE_ABONNÉ);
            ActualiserPagesReco();
            AfficherSuggestions();
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

            lblPageEmp.Text = pageEmprunts + 1 + "";
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
            if (pageEmprunts < nbPagesEmp)
            {
                pageEmprunts++;
            }
            else
            {
                pageEmprunts = 0;
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
            else
            {
                if ((nbPagesEmp) > 0)
                {
                    pageEmprunts = nbPagesEmp;
                }

            }
            afficherEmprunts();
        }

        /// <summary>
        /// Méthode ci-dessous : US 10
        /// Méthode pour afficher les suggestions
        /// </summary>
        private void AfficherSuggestions()
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
                lblPageReco.Text = pageReco + 1 + "";

            }
            else
            {
                AfficherPasReco();
            }
        }

        /// <summary>
        /// Affiche le label quand il n'y a aucun disque de recommandé
        /// </summary>
        private void AfficherPasReco()
        {
            lblPasSugg.Visible = true;
            lblPasSugg.Location = new System.Drawing.Point(panelConseil.Location.X + panelGrandConseils.Location.X,
                panelConseil.Location.Y + panelGrandConseils.Location.Y);
            lblPasSugg.Size = panelConseil.Size;
        }

        /// <summary>
        /// Ouvre l'onglet de magasin
        /// </summary>
        private void OuvrirMagasin()
        {
            magasin.ShowInTaskbar = true;
            magasin.WindowState = FormWindowState.Normal;

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        /// <summary>
        /// Incrémente la page des recommandés
        /// </summary>
        private void AugmenterReco()
        {
            if (pageReco < nbPagesReco)
            {
                pageReco++;
            }
            else
            {
                pageReco = 0;

            }
            AfficherSuggestions();
        }

        /// <summary>
        /// Décrémente la page des recommandés
        /// </summary>
        private void DiminuerReco()
        {
            if (pageReco > 0)
            {
                pageReco--;
            }
            else
            {
                if (nbPagesReco > 0)
                {
                    pageReco = nbPagesReco;
                }
            }
            AfficherSuggestions();
        }

        /// <summary>
        /// Emprunte l'album
        /// </summary>
        /// <param name="album">L'album à emprunter</param>
        public void EmprunterAlbum(ALBUMS album)
        {
            nouvelEmprunt(abonne, album);
            InitialiserElements();
        }

        #endregion


        private void ActualiserPagesEmprunts()
        {
            if (emprunts.Count % 4 != 0)
            {
                nbPagesEmp = emprunts.Count / 4;
            }
            else
            {
                nbPagesEmp = (emprunts.Count / 4) - 1;
            }
        }

        private void ActualiserPagesReco()
        {
            if (recommendations.Count % 4 != 0)
            {
                nbPagesReco = recommendations.Count / 4;
            }
            else
            {
                nbPagesReco = (recommendations.Count / 4) - 1;
            }
        }

    }
}
