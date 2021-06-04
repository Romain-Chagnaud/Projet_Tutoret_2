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
            }

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

            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                EMPRUNTER emprunt = (EMPRUNTER)listBox1.SelectedItem;
                textBox3.Text = emprunt.ALBUMS.GENRES.DÉLAI + " ";
                DateTime dateTime = new DateTime(emprunt.DATE_EMPRUNT.Year, emprunt.DATE_EMPRUNT.Month, emprunt.DATE_EMPRUNT.Day);
                if (dateTime.AddDays(emprunt.ALBUMS.GENRES.DÉLAI).Date.CompareTo(emprunt.DATE_RETOUR_ATTENDUE.Date) != 0)
                {
                    button1.Enabled = false;
                } else
                {
                    button1.Enabled = true;
                }
            }

            private void afficherEmprunts()
            {
                listBox1.Items.Clear();
                var emprunts = from e in musique.EMPRUNTER
                               where e.CODE_ABONNÉ == abonne.CODE_ABONNÉ
                               select e;
                foreach (var e in emprunts)
                {
                    listBox1.Items.Add(e);
                }
            }

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

        private void afficherAlbums()
        {
            listBox2.Items.Clear();
            var albums = (from al in musique.ALBUMS
                          select al).ToList();

            foreach (ALBUMS al in albums)
            {
                listBox2.Items.Add(al);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                DateTime date = DateTime.Now;
                ALBUMS al = (ALBUMS)listBox2.SelectedItem;
                DateTime newDate = date.AddDays(al.GENRES.DÉLAI);

                EMPRUNTER em = new EMPRUNTER();
                em.CODE_ABONNÉ = abonne.CODE_ABONNÉ;
                em.CODE_ALBUM = al.CODE_ALBUM;
                em.DATE_EMPRUNT = date;
                em.DATE_RETOUR_ATTENDUE = newDate;
                MessageBox.Show(em.ToString());

                musique.EMPRUNTER.Add(em);
                musique.SaveChanges();
            }
        }
    }
    
}
