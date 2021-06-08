using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Maquette.Outil;

namespace Maquette
{
    public partial class Abonné : Form
    {
        MusiqueEntities musique;
        ABONNÉS abonne;

        int pageEmprunts = 0;



        public Abonné(MusiqueEntities m, ABONNÉS ab)
        {
            InitializeComponent();
            musique = m;
            abonne = ab;
            textBox1.Text = ab.LOGIN_ABONNÉ.Trim();
            textBox2.Text = ab.PASSWORD_ABONNÉ;
            afficherEmprunts();
            afficherAlbums();
            afficherSuggestions();
        }


        /// <summary>
        /// Méthode ci-dessous : US 3
        /// Méthode du bouton pour allonger le délai d'un emprunt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            EMPRUNTER emprunt = (EMPRUNTER)listBox1.SelectedItem;
            prolongation(emprunt);
            afficherEmprunts();
        }

        /// <summary>
        /// Méthode ci-dessous : US 3
        /// Méthode qui désactive le bouton pour allonger le délai d'un emprunt déjà allongé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                button1.Enabled = estProlongeable((EMPRUNTER)listBox1.SelectedItem);
            }
        }

        /// <summary>
        /// Méthode ci-dessous : US 2
        /// Méthode pour afficher tous les emprunts
        /// </summary>
        private void afficherEmprunts()
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
        /// Méthode ci-dessous : US 9
        /// Méthode pour allonger le délai de tous les emprunts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (EMPRUNTER emprunt in listBox1.Items)
            {
                prolongation(emprunt);
            }
            musique.SaveChanges();
            afficherEmprunts();
        }

        /// <summary>
        /// Méthode ci-dessous : US 1
        /// Méthode pour afficher les albums non-empruntés
        /// </summary>
        private void afficherAlbums()
        {
            listBox2.Items.Clear();
            var albums = getALBUMSs().OrderBy(a => a.TITRE_ALBUM);


            var empruntés = getIndisponibles();

            foreach (ALBUMS al in albums.Except(empruntés))
            {
                listBox2.Items.Add(al);
            }
        }

        /// <summary>
        /// Méthode ci-dessous : US 1
        /// Méthode pour emprunter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                ALBUMS al = (ALBUMS)listBox2.SelectedItem;
                EMPRUNTER em = nouvelEmprunt(abonne, al);
                if (em != null)
                {
                    MessageBox.Show(em.ToString());
                } else
                {
                    MessageBox.Show("Album déjà pris");
                }
                afficherAlbums();
                afficherEmprunts();
                afficherSuggestions();
            }
        }

        /// <summary>
        /// Méthode ci-dessous : US 1-?
        /// Méthode pour rendre un emprunt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                rendreEmprunt((EMPRUNTER)listBox1.SelectedItem);
                afficherEmprunts();
            }
        }

        /// <summary>
        /// Méthode ci-dessous : US 10
        /// Méthode pour afficher les suggestions
        /// </summary>
        private void afficherSuggestions()
        {
            listBox3.Items.Clear();
            var albumsRecommandés = getSuggestions(abonne.CODE_ABONNÉ);
            if (albumsRecommandés.Count > 0)
            {
                foreach (var l in albumsRecommandés)
                {
                    for (int i = 0; i < 10 / albumsRecommandés.Count; i++)
                    {
                        listBox3.Items.Add(l[i]);
                    }
                }

            }
            else
            {
                listBox3.Items.Add("Aucun emprunt");
            }
        }

        private void lblEspace_Click(object sender, EventArgs e)
        {

        }

        private void lblMagasin_Click(object sender, EventArgs e)
        {

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
        private void AugmenterEmprunt()
        {
            if (pageEmprunts < (getEmpruntsEnCoursAbonné(abonne.CODE_ABONNÉ).Count / 4))
            {
                pageEmprunts++;
                afficherEmprunts();
            }
        }

        private void DiminuerEmprunt()
        {
            if (pageEmprunts > 0)
            {
                pageEmprunts--;
                afficherEmprunts();
            }
        }
    }
}
