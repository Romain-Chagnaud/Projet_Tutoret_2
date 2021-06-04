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
    public partial class Form1 : Form
    {
        MusiqueEntities musique;

        public Form1()
        {
            InitializeComponent();

            musique = new MusiqueEntities();
            Abonne_Load();
        }

        private void Abonne_Load()
        {
            var abonnes = (from a in musique.ABONNÉS
                           select a).ToList();

            foreach (ABONNÉS a in abonnes)
            {
                listBox1.Items.Add(a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nom.Text != "" && prenom.Text != "" && login.Text != "" && mdp.Text != "")
            {
                ABONNÉS a = new ABONNÉS();
                a.PRÉNOM_ABONNÉ = prenom.Text;
                a.NOM_ABONNÉ = nom.Text;
                a.LOGIN_ABONNÉ = login.Text;
                a.PASSWORD_ABONNÉ = mdp.Text;

                Abonne_Load();
                musique.ABONNÉS.Add(a);
                musique.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (log2.Text != "" && mdp2.Text != "")
            {
                var abo = (from a in musique.ABONNÉS
                           where a.LOGIN_ABONNÉ == log2.Text && a.PASSWORD_ABONNÉ == mdp2.Text
                           select a).ToList();

                if (abo.Count == 1)
                {
                    MessageBox.Show("Bienvenue, " + abo[0]);
                    listBox3.Items.Add(abo[0]);
                    Albums_Load();

                }
                else
                {
                    MessageBox.Show("T'es qui toi ? ");
                }
            }
        }

        private void Albums_Load()
        {
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

                ABONNÉS a = (ABONNÉS)listBox3.Items[0];
                ALBUMS al = (ALBUMS)listBox2.SelectedItem;
                DateTime newDate = date.AddDays(al.GENRES.DÉLAI);

                EMPRUNTER em = new EMPRUNTER();
                em.CODE_ABONNÉ = a.CODE_ABONNÉ;
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
