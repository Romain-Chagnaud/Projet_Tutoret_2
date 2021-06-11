using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Maquette.Outil;

namespace Maquette
{
    public partial class CompteUtilisateur : Form
    {
        ABONNÉS abonné;
        public CompteUtilisateur(ABONNÉS a)
        {
            InitializeComponent();
            abonné = a;
            labelNom.Text = a.NOM_ABONNÉ;
            labelPrénom.Text = a.PRÉNOM_ABONNÉ;
            labelLogin.Text = a.LOGIN_ABONNÉ;
            List<PAYS> pays = musique.PAYS.ToList();
            foreach(PAYS p in pays)
            {
                comboPays.Items.Add(p);
            }
            comboPays.SelectedItem = a.PAYS;
        }

        private void changeMDP_Click(object sender, EventArgs e)
        {
            if (vérificationMDP(ancienMDP.Text, abonné))
            {
                if (nouveauMDP.Text == confirmedMDP.Text && Regex.IsMatch(nouveauMDP.Text, "^\\S\\w*\\S$"))
                {
                    String mdp=changerMDP(nouveauMDP.Text, abonné);
                    if (mdp == null)
                    {
                        MessageBox.Show("Nouveau mot de passe trop long.");
                    } else
                    {
                        MessageBox.Show("Mot de passe changé.");
                    }
                } else
                {
                    MessageBox.Show("Le nouveau mot de passe et la confirmation sont différents.");
                }
            } else
            {
                MessageBox.Show("L'ancien mot de passe n'est pas le bon.");                            
            }
            ancienMDP.Text = "";
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
            if (ancienMDP.PasswordChar == '●')
            {
                ancienMDP.PasswordChar = '\0';
            }
            else
            {
                ancienMDP.PasswordChar = '●';
            }
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
