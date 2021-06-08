using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Maquette.Outil;

namespace Maquette
{
    public partial class Abonné : Form
    {
        ABONNÉS abonne;

        int pageEmprunts = 0;



        public Abonné(ABONNÉS ab)
        {
            InitializeComponent();
            abonne = ab;
            afficherEmprunts();
            afficherSuggestions();
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

        #endregion

        #region Logique
        /// <summary>
        /// Méthode ci-dessous : US 2 + 13
        /// Méthode pour afficher tous les emprunts (avec pagination)
        /// </summary>
        public void afficherEmprunts()
        {
            panelEmprunts.Controls.Clear();
            var emprunts = getEmpruntsEnCoursAbonné(abonne.CODE_ABONNÉ);
            for (int i = 4 * pageEmprunts; i < 4 * (pageEmprunts + 1); i++)
            {
                if (i < emprunts.Count)
                {
                    panelEmprunts.Controls.Add(new AlbumARendre(emprunts[i]));
                }
            }

            lblPageEmp.Text = (pageEmprunts + 1).ToString();
        }
        /// <summary>
        /// Allonge le délai de tous les emprunts
        /// </summary>
        private void AllongerTousEmprunts()
        {
            foreach (AlbumARendre alb in panelEmprunts.Controls)
            {
                prolongation(alb.emprunt);
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
        /// A refaire !!!!
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// Méthode ci-dessous : US 1
        /// Méthode pour afficher les albums non-empruntés
        /// </summary>
        /*private void afficherAlbums()
        {
            listBox2.Items.Clear();
            var albums = getALBUMSs().OrderBy(a => a.TITRE_ALBUM);


            var empruntés = getIndisponibles();

            foreach (ALBUMS al in albums.Except(empruntés))
            {
                listBox2.Items.Add(al);
            }
        }*/






        /// <summary>
        /// Méthode ci-dessous : US 10
        /// Méthode pour afficher les suggestions
        /// </summary>
        private void afficherSuggestions()
        {
            panelEmprunts.Controls.Clear();
            var albumsRecommandés = getSuggestions(abonne.CODE_ABONNÉ);

            if (albumsRecommandés.Count > 0)
            {
                lblPasSugg.Visible = false;
                foreach (var l in albumsRecommandés)
                {
                    for (int i = 0; i < 10 / albumsRecommandés.Count; i++)
                    {
                        panelConseil.Controls.Add(new AlbumEmpruntable(l.ElementAt(i)));
                    }
                }

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

        private void lblEspace_Click(object sender, EventArgs e)
        {

        }

        private void lblMagasin_Click(object sender, EventArgs e)
        {

        }



    }
}
