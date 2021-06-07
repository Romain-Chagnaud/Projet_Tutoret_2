﻿using System;
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
    public partial class Connexion : Form
    {
        /// <summary>
        /// Toute cette classe correspond à l'US 1 du sprint 1
        /// </summary>
        MusiqueEntities musique;
        ABONNÉS abonnéConnecté;

        public Connexion()
        {
            InitializeComponent();
            musique = new MusiqueEntities();
            Abonne_Load();
            
            //Test_Interface inter = new Test_Interface(musique);
            //inter.ShowDialog();
        }

        /// <summary>
        /// Chargement des abonnés
        /// </summary>
        private void Abonne_Load()
        {
            listBox1.Items.Clear();
            var abonnes = (from a in musique.ABONNÉS
                           select a).ToList();

            foreach (ABONNÉS a in abonnes)
            {
                listBox1.Items.Add(a);
            }
        }

        /// <summary>
        /// Méthode pour l'inscription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (nom.Text != "" && prenom.Text != "" && login.Text != "" && mdp.Text != "")
            {
                ABONNÉS a = new ABONNÉS();
                a.PRÉNOM_ABONNÉ = prenom.Text;
                a.NOM_ABONNÉ = nom.Text;
                a.LOGIN_ABONNÉ = login.Text;
                a.PASSWORD_ABONNÉ = mdp.Text;               
                musique.ABONNÉS.Add(a);
                musique.SaveChanges();
                Abonne_Load();
                nom.Text = "";
                prenom.Text = "";
                login.Text = "";
                mdp.Text = "";
            }
        }

        /// <summary>
        /// Méthode pour la connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    abonnéConnecté = abo[0];
                    if (abonnéConnecté.LOGIN_ABONNÉ.Trim() == "admin")
                    {
                        Admin admin = new Admin(musique);
                        admin.ShowDialog();
                    }
                    else
                    {
                        Abonné abonne = new Abonné(musique, abonnéConnecté);
                        abonne.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Utilisateur non reconnu.");
                }
            }
        }
    }
}
