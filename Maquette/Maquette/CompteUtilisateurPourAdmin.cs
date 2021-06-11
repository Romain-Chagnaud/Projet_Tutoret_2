using System;
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
            List<PAYS> pays = GetPays();
            foreach (PAYS p in pays)
            {
                comboPays.Items.Add(p);
            }
            comboPays.SelectedItem = a.PAYS;
        }

        #region IHM

        /// <summary>
        /// Clic sur le bouton Changer Mot de Passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeMDP_Click(object sender, EventArgs e)
        {
            ChangerMdp();
        }

        /// <summary>
        /// Clic sur le bouton Changer de Pays
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangerPays_Click(object sender, EventArgs e)
        {
            ChangerPays();
        }

        /// <summary>
        /// Clic sur l'oeil à coôté du nouveau MDP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNvMdp_Click(object sender, EventArgs e)
        {
            AfficherNvMDP();
        }

        /// <summary>
        /// Clic sur l'oeil à coté de la confirmation du nouveau mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCoNvMdp_Click(object sender, EventArgs e)
        {
            AfficherCoNvMDP();
        }

        #endregion

        #region Logique

        /// <summary>
        /// Change le mot de passe
        /// </summary>
        private void ChangerMdp()
        {
            if (nouveauMDP.Text == confirmedMDP.Text)
            {
                if (Regex.IsMatch(nouveauMDP.Text, "^\\S\\w*\\S$"))
                {
                    String mdp = ChangerMDP(nouveauMDP.Text, abonné);
                    if (mdp == null)
                    {
                        MessageBox.Show("Nouveau mot de passe trop long.");
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe changé.");
                        mdpLabel.Text = Decrypter(abonné.PASSWORD_ABONNÉ);
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
            nouveauMDP.Text = "";
            confirmedMDP.Text = "";
        }

        /// <summary>
        /// Change le pays de l'utilisateur
        /// </summary>
        private void ChangerPays()
        {
            if (comboPays.SelectedItem != null)
            {
                ChangerPays((PAYS)comboPays.SelectedItem, abonné);
                MessageBox.Show("Pays changé.");
            }
        }

        /// <summary>
        /// Révèle le nouveau MDP
        /// </summary>
        private void AfficherNvMDP()
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
        /// Révèle la confirmation du nouveau MDP
        /// </summary>
        private void AfficherCoNvMDP()
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
