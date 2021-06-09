using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Maquette.Outil;

namespace Maquette
{
    public partial class Admin : Form
    {
        MusiqueEntities musique;

        public Admin(MusiqueEntities musique)
        {
            InitializeComponent();
            this.musique = musique;
        }

        /// <summary>
        /// Méthode ci-dessous : US 4
        /// Méthode pour connaître les emprunts prolongés
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var emprunts = getProlongés();
            foreach (EMPRUNTER em in emprunts)
            {
                listBox1.Items.Add(em);
            }
        }

        /// <summary>
        /// Méthode ci-dessous : US 5, générer un retard de plus de 10 jours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            var abo = getAbonnéSelonLogin("Mijel");
            var alb = getAlbumSelonTitre("Haendel: Saul");
            nouvelEmprunt(abo, alb);
        }


        /// <summary>
        /// Méthode ci-dessous : US 5
        /// Méthode pour connaître les emprunts en retard de 10 jours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            var emprunts = getEMPRUNTERs();

            foreach (EMPRUNTER em in emprunts)
            {
                DateTime date = em.DATE_RETOUR_ATTENDUE.AddDays(10);
                if (date.CompareTo(DateTime.Now) < 0)
                {
                    listBox2.Items.Add(em);
                }
            }
        }

        /// <summary>
        /// Méthode ci-dessous : US 6
        /// Méthode pour afficher les abonnés n'ayant rien emprunté depuis 1 an
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            var fantomes = getFantomes();
            foreach (ABONNÉS a in fantomes)
            {
                listBox3.Items.Add(a);
            }
            button6.Enabled = true;
        }

        /// <summary>
        /// Méthode ci-dessous : US 8
        /// Méthode pour afficher les albums n'ayant pas été emprunté depuis 1 an
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            var albums = getALBUMSs();

            foreach (ALBUMS al in albums)
            {
                var emprunts = getEmpruntsSelonAlbum(al.CODE_ALBUM);

                if (emprunts.Count == 0)
                {
                    listBox4.Items.Add(al);
                }
                else
                {
                    int compteur = 0;
                    bool aEteEmprunte = false;

                    while (compteur < emprunts.Count && !aEteEmprunte)
                    {
                        EMPRUNTER emp = emprunts[compteur];
                        DateTime date = emp.DATE_EMPRUNT.AddYears(1);

                        if (date.CompareTo(DateTime.Now) > 0)
                        {
                            aEteEmprunte = true;
                        }
                        compteur++;
                    }

                    if (!aEteEmprunte)
                    {
                        listBox4.Items.Add(al);
                    }
                }
            }
        }


        /// <summary>
        /// Méthode ci-dessous : US 6
        /// Méthode pour purger les abonnés n'ayant rien emprunté depuis 1 an
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            foreach (ABONNÉS ab in listBox3.Items)
            {
                musique.ABONNÉS.Remove(ab);
            }
            musique.SaveChanges();
            listBox3.Items.Clear();
            button6.Enabled = false;
        }


        /// <summary>
        /// Méthode ci-dessous : US 7
        /// Méthode pour connaître les 10 albums les plus empruntés de l'année
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
            List<ALBUMS> albumsTriés = getTop10();
            if (albumsTriés.Count >= 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    listBox5.Items.Add(albumsTriés[i]);
                }
            }
            else if (albumsTriés.Count > 0)
            {
                for (int i = 0; i < albumsTriés.Count; i++)
                {
                    listBox5.Items.Add(albumsTriés[i]);
                }
            }
            else
            {
                listBox5.Items.Add("Aucun emprunt");
            }
        }
    }
}
