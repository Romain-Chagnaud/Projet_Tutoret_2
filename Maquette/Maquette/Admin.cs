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
    public partial class Admin : Form
    {
        MusiqueEntities musique;

        public Admin(MusiqueEntities musique)
        {
            InitializeComponent();
            this.musique = musique;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            var emprunts = (from em in musique.EMPRUNTER
                            where em.DATE_RETOUR == null
                            select em);

            foreach (EMPRUNTER em in emprunts)
            {
                DateTime dateTime = new DateTime(em.DATE_EMPRUNT.Year, em.DATE_EMPRUNT.Month, em.DATE_EMPRUNT.Day);
                if (dateTime.AddDays(em.ALBUMS.GENRES.DÉLAI).Date.CompareTo(em.DATE_RETOUR_ATTENDUE.Date) != 0)
                {
                    listBox1.Items.Add(em);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMPRUNTER em = new EMPRUNTER();
            var abo = (from a in musique.ABONNÉS
                       where a.LOGIN_ABONNÉ == "jean"
                       select a).ToList();

            foreach (ABONNÉS a in abo)
            {
                em.ABONNÉS = a;
            }

            var alb = (from al in musique.ALBUMS
                       where al.TITRE_ALBUM == "Wolf: 22 Lieder"
                       select al);

            foreach (ALBUMS a in alb)
            {
                em.ALBUMS = a;
            }

            em.DATE_EMPRUNT = new DateTime(2021, 1, 28);
            em.DATE_RETOUR_ATTENDUE = new DateTime(2021, 6, 3);

            musique.EMPRUNTER.Add(em);
            musique.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            var emprunts = (from em in musique.EMPRUNTER
                            select em).ToList();

            foreach (EMPRUNTER em in emprunts)
            {
                DateTime date = em.DATE_RETOUR_ATTENDUE.AddDays(10);
                if (date.CompareTo(DateTime.Now) < 0)
                {
                    listBox2.Items.Add(em);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var abos = (from a in musique.ABONNÉS
                        select a).ToList();

            foreach (ABONNÉS abo in abos)
            {
                /*var emprunts = (from em in musique.EMPRUNTER
                                join a in musique.ABONNÉS
                                on em.CODE_ABONNÉ equals a.CODE_ABONNÉ
                                select em).ToList();*/
                var emprunts = (from em in musique.EMPRUNTER
                                where em.CODE_ABONNÉ == abo.CODE_ABONNÉ
                                select em).ToList();

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

        private void button5_Click(object sender, EventArgs e)
        {
            var albums = (from al in musique.ALBUMS
                          select al).ToList();

            foreach (ALBUMS al in albums)
            {
                var emprunts = (from em in musique.EMPRUNTER
                                where em.CODE_ALBUM == al.CODE_ALBUM
                                select em).ToList();

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
    }
}
