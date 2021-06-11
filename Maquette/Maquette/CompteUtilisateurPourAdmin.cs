﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static Maquette.Outil;

namespace Maquette
{
    public partial class CompteUtilisateurPourAdmin : Form
    {
        ABONNÉS abonné;
        public CompteUtilisateurPourAdmin(ABONNÉS a)
        {
            InitializeComponent();
            abonné = a;
            labelNom.Text = a.NOM_ABONNÉ;
            labelPrénom.Text = a.PRÉNOM_ABONNÉ;
            labelLogin.Text = a.LOGIN_ABONNÉ;
            mdpLabel.Text = Decrypter(a.PASSWORD_ABONNÉ);
            List<PAYS> pays = musique.PAYS.ToList();
            foreach (PAYS p in pays)
            {
                comboPays.Items.Add(p);
            }
            comboPays.SelectedItem = a.PAYS;
        }

        private void changeMDP_Click(object sender, EventArgs e)
        {

            if (nouveauMDP.Text == confirmedMDP.Text )
            {
                if (Regex.IsMatch(nouveauMDP.Text, "^\\S\\w*\\S$"))
                {
                    String mdp = changerMDP(nouveauMDP.Text, abonné);
                    if (mdp == null)
                    {
                        MessageBox.Show("Nouveau mot de passe trop long.");
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe changé.");
                        mdpLabel.Text = Decrypter(abonné.PASSWORD_ABONNÉ);
                    }
                } else
                {
                    MessageBox.Show("Nouveau mot de passene respecte pas les règles de nommages : 32 caractères, caractères spéciaux et alphanumériques autorisés. Pas d'espaces.");
                }
            }
            else
            {
                MessageBox.Show("Le nouveau mot de passe et la confirmation sont différents.");
            }
            nouveauMDP.Text = "";
            confirmedMDP.Text = "";
        }

        private void changerPays_Click(object sender, EventArgs e)
        {
            if (comboPays.SelectedItem != null)
            {
                changerPays((PAYS)comboPays.SelectedItem, abonné);
                MessageBox.Show("Pays changé.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nouveauMDP.PasswordChar == '●')
            {
                nouveauMDP.PasswordChar = '\0';
            }
            else
            {
                nouveauMDP.PasswordChar = '●';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (confirmedMDP.PasswordChar == '●')
            {
                confirmedMDP.PasswordChar = '\0';
            }
            else
            {
                confirmedMDP.PasswordChar = '●';
            }
        }
    }
}
