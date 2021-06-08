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
            DateTime dateTime = new DateTime(emprunt.DATE_EMPRUNT.Year, emprunt.DATE_EMPRUNT.Month, emprunt.DATE_EMPRUNT.Day);
            if (dateTime.AddDays(emprunt.ALBUMS.GENRES.DÉLAI).Date.CompareTo(emprunt.DATE_RETOUR_ATTENDUE.Date) == 0)
            {
                emprunt.DATE_RETOUR_ATTENDUE = emprunt.DATE_RETOUR_ATTENDUE.AddMonths(1);
                musique.SaveChanges();
                afficherEmprunts();
            }
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
                EMPRUNTER emprunt = (EMPRUNTER)listBox1.SelectedItem;
                DateTime dateTime = new DateTime(emprunt.DATE_EMPRUNT.Year, emprunt.DATE_EMPRUNT.Month, emprunt.DATE_EMPRUNT.Day);
                if (dateTime.AddDays(emprunt.ALBUMS.GENRES.DÉLAI).Date.CompareTo(emprunt.DATE_RETOUR_ATTENDUE.Date) != 0)
                {
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Méthode ci-dessous : US 2
        /// Méthode pour afficher tous les emprunts
        /// </summary>
        private void afficherEmprunts()
        {
            listBox1.Items.Clear();
            var emprunts = getEmpruntsEnCoursAbonné(abonne.CODE_ABONNÉ);
            foreach (var e in emprunts)
            {
                listBox1.Items.Add(e);
            }
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
                DateTime dateTime = new DateTime(emprunt.DATE_EMPRUNT.Year, emprunt.DATE_EMPRUNT.Month, emprunt.DATE_EMPRUNT.Day);
                if (dateTime.AddDays(emprunt.ALBUMS.GENRES.DÉLAI).Date.CompareTo(emprunt.DATE_RETOUR_ATTENDUE.Date) == 0)
                {
                    emprunt.DATE_RETOUR_ATTENDUE = emprunt.DATE_RETOUR_ATTENDUE.AddMonths(1);
                }
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
    }
}
