﻿using System;
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
            var emprunts = getEMPRUNTERNonRendus();

            foreach (EMPRUNTER em in emprunts)
            {
                DateTime dateTime = new DateTime(em.DATE_EMPRUNT.Year, em.DATE_EMPRUNT.Month, em.DATE_EMPRUNT.Day);
                if (dateTime.AddDays(em.ALBUMS.GENRES.DÉLAI).Date.CompareTo(em.DATE_RETOUR_ATTENDUE.Date) != 0)
                {
                    listBox1.Items.Add(em);
                }
            }


        }

        /// <summary>
        /// Méthode ci-dessous : US 5, générer un retard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e) {
            var abo = getAbonnéSelonLogin("Mijel");
            var alb = getAlbumSelonTitre("Haendel : Saul");
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
            var abos = getABONNÉSs();

            foreach (ABONNÉS abo in abos)
            {
                /*var emprunts = (from em in musique.EMPRUNTER
                                join a in musique.ABONNÉS
                                on em.CODE_ABONNÉ equals a.CODE_ABONNÉ
                                select em).ToList();*/
                button6.Enabled = true;
                var emprunts = getEmpruntsAbonné(abo.CODE_ABONNÉ);

                if (emprunts.Count > 0)
                {
                    int compteur = 0;
                    bool estActif = false;

                    while (compteur < emprunts.Count && !estActif)
                    {
                        EMPRUNTER emp = emprunts[compteur];
                        DateTime date = emp.DATE_EMPRUNT.AddYears(1);

                        if (date.CompareTo(DateTime.Now) > 0)
                        {
                            estActif = true;
                        }
                        compteur++;
                    }

                    if (!estActif)
                    {
                        listBox3.Items.Add(abo);
                    }
                }

            }
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
            var emprunts = getEMPRUNTERs();
            List<EMPRUNTER> empruntsList = new List<EMPRUNTER>();
            foreach (EMPRUNTER em in emprunts)
            {
                if (em.DATE_EMPRUNT.AddYears(1).CompareTo(DateTime.Now) > 0)
                {
                    empruntsList.Add(em);
                }
            }
            var albumsParEmprunt = empruntsList.GroupBy(em => em.CODE_ALBUM, (key, values) => new { ALBUMS = key, Count = values.Count() });
            var albumsTriés = albumsParEmprunt.OrderByDescending(em => em.Count).ToList();
            if(albumsTriés.Count >= 10)
            {
                for (int i = 0; i<10; i++)
                {
                    int id = albumsTriés[i].ALBUMS; 
                    ALBUMS ab = getAlbumSelonID(id);
                    listBox5.Items.Add(ab);
                }
            } else if (albumsTriés.Count > 0)
            {
                for(int i = 0;i<albumsTriés.Count; i++)
                {
                    int id = albumsTriés[i].ALBUMS;
                    ALBUMS ab = getAlbumSelonID(id);
                    listBox5.Items.Add(ab);
                }
            } else
            {
                listBox5.Items.Add("Aucun emprunt");
            }
        }
    }
}
