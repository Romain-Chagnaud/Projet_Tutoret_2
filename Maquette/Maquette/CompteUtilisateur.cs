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
        /// <summary>
        /// Constructeur de la classe CompteUtilisateur
        /// </summary>
        /// <param name="a"> abonné </param>
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


        #region IHM
        /// <summary>
        /// Méthode qui permet de changer le mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeMDP_Click(object sender, EventArgs e)
        {
            if (vérificationMDP(ancienMDP.Text, abonné))
            {
                if (nouveauMDP.Text == confirmedMDP.Text && Regex.IsMatch(nouveauMDP.Text, "^\\S\\w*\\S$"))
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
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nouveau mot de passene respecte pas les règles de nommages : 32 caractères, caractères spéciaux et alphanumériques autorisés. Pas d'espaces.");
                    }
                }
                else
                {
                    MessageBox.Show("Le nouveau mot de passe et la confirmation sont différents.");
                }
            }
            else
            {
                MessageBox.Show("L'ancien mot de passe n'est pas le bon.");
            }
            ancienMDP.Text = "";
            nouveauMDP.Text = "";
            confirmedMDP.Text = "";
        }

        /// <summary>
        /// Méthode qui permet de changer de pays
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangerPays_Click(object sender, EventArgs e)
        {
            ChangementPays();
        }

        /// <summary>
        /// Méthode qui appel une fonction qui permet de changer l'ancien mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AncMdp_Click(object sender, EventArgs e)
        {
            ChangementAncMdp();
        }
        
        /// <summary>
        /// Méthode qui appel une fonction qui permet de changer le nouveau mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NvMdp_Click(object sender, EventArgs e)
        {
            ChangementNvMdp();
        }
        
        /// <summary>
        /// Méthode qui appel une fonction permet de confirmer le mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfMdp_Click(object sender, EventArgs e)
        {
            ChangemenCofMdp();
        }
        #endregion

        #region Logique
        /// <summary>
        /// Méthode qui permet de changer de pays
        /// </summary>
        private void ChangementPays()
        {
            if (comboPays.SelectedItem != null)
            {
                changerPays((PAYS)comboPays.SelectedItem, abonné);
                MessageBox.Show("Pays changé.");
            }
        }

        /// <summary>
        /// Méthode qui permet de changer l'ancien mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangementAncMdp()
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
        
        /// <summary>
        /// Méthode qui permet de changer le nouveau mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangementNvMdp()
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
        
        /// <summary>
        /// Méthode qui permet de confirmer le mot de passe
        /// </summary>
        private void ChangemenCofMdp()
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
        #endregion
    }
}
