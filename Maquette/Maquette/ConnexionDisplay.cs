using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Maquette
{
    
    public partial class ConnexionDisplay : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
            );

        ABONNÉS abonnéConnecté;

        /// <summary>
        /// Constructeur de la classe 
        /// </summary>
        public ConnexionDisplay()
        {
            InitializeComponent();
            Outil.chargerMusiqueEntities();
            InscriptionPannel.Visible = false;
            Abonne_Load();
            List<String> pays = Outil.GetPays();

            foreach (var p in pays)
            {
                comboBoxP.Items.Add(p);
            }

            this.ConnexionPanel.BorderStyle = BorderStyle.None;
            this.ConnexionPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, ConnexionPanel.Width, ConnexionPanel.Height, 10, 10));
            this.lblConnexion.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblConnexion.Width, lblConnexion.Height, 10, 10));
            this.textBoxId.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxId.Width, textBoxId.Height, 3, 3));
            this.textBoxPass.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxPass.Width, textBoxPass.Height, 3, 3));
            this.InscriptionPannel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, InscriptionPannel.Width, InscriptionPannel.Height, 10, 10));
            this.SignButton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, SignButton.Width, SignButton.Height, 10, 10));
            this.nomBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, nomBox.Width, nomBox.Height, 3, 3));
            this.prenomBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, prenomBox.Width, prenomBox.Height, 3, 3));
            this.idBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, idBox.Width, idBox.Height, 3, 3));
            this.passBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, passBox.Width, passBox.Height, 3, 3));
        }

        #region IHM
        /// <summary>
        /// Méthode qui permet d'avoir la liste des abonnés figurants dans la base
        /// </summary>
        private void Abonne_Load()
        {
            var abonnes = Outil.GetABONNÉSs();
        }

        /// <summary>
        /// Méthode qui permet à un utilisateur de se connecter à la base de donnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblConnexion_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "" && textBoxPass.Text != "")
            {
                ABONNÉS abo = Outil.Connexion(textBoxId.Text, textBoxPass.Text);
                textBoxId.Text = "";
                textBoxPass.Text = "";
                if (abo != null)
                {
                    MessageBox.Show("Bienvenue, " + abo);
                    abonnéConnecté = abo;
                    if (abonnéConnecté.LOGIN_ABONNÉ.Trim() == "Admin")
                    {
                        AdminIHM admin = new AdminIHM();
                        admin.ShowDialog();
                    }
                    else
                    {
                        Abonné abonne = new Abonné(abonnéConnecté);
                        abonne.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Utilisateur non reconnu.");
                }
            }
        }

        /// <summary>
        /// Méthode qui permet de s'inscrire sur la base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Inscription_Click(object sender, EventArgs e)
        {
            LancerInscription();
        }

        /// <summary>
        /// Méthode qui colorie le fond du texte de l'inscription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Inscription_MouseHover(object sender, EventArgs e)
        {
            inscription.ForeColor = Color.FromArgb(135, 87, 67, 1);
        }

        /// <summary>
        /// Méthode qui colorie le texte de l'inscription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Inscription_MouseLeave(object sender, EventArgs e)
        {
            inscription.ForeColor = Color.FromArgb(56, 24, 3, 1);
        }

        /// <summary>
        /// Méthode qui permet de revenir sur la page de connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RetourPgConnexion_Click(object sender, EventArgs e)
        {
            DirectionPgCon();
        }
        
        /// <summary>
        /// Méthode qui permet de s'inscrire dans la base de donnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignButton_Click(object sender, EventArgs e)
        {
            if (nomBox.Text != "" && prenomBox.Text != "" && idBox.Text != "" && passBox.Text != "")
            {
                string prenomTrim = prenomBox.Text.Trim();
                string nomTrim = nomBox.Text.Trim();
                if (prenomBox.Text == prenomTrim && nomBox.Text == nomTrim && !EstDansLaChaine(prenomBox.Text, CharSpeciaux())
                    && !EstDansLaChaine(nomBox.Text, CharSpeciaux())
                    && prenomTrim.Length > 0 && prenomTrim.Length <= 32 && nomTrim.Length > 0 && nomTrim.Length <= 32 && idBox.Text.Length > 0 && idBox.Text.Length <= 32
                && passBox.Text.Length > 0 && passBox.Text.Length <= 32 && Regex.IsMatch(passBox.Text, "^\\S\\w*\\S$") && Regex.IsMatch(idBox.Text, "^\\S[a-zA-Z0-9]*\\S$"))
                {
                    if (passBox.Text == PassConfirm.Text)
                    {
                        ABONNÉS a = Outil.inscription(prenomBox.Text, nomBox.Text, idBox.Text, passBox.Text, comboBoxP.Text.Trim());
                        InscriptionPannel.Visible = false;
                        ConnexionPanel.Visible = true;
                        if (a != null)
                        {
                            Abonne_Load();
                            nomBox.Text = "";
                            prenomBox.Text = "";
                            idBox.Text = "";
                            passBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Client déjà existant");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Confirmation du mot de passe différente du mot de passe");
                    }
                }
                else
                {
                    MessageBox.Show("Erreur de saisie, caractères spéciaux autorisés uniquement pour le mot de passe. Pas d'espace dans le login et le mot de passe. Pas de caractères spéciaux dans le login. Nombre max de caractères : 32.");
                }

            }
            else
            {
                MessageBox.Show("Veuillez entrer des informations valides");
            }
        }
       
        /// <summary>
        /// Méthode qui permet de visualiser le mot de passe durant la connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherCoMdp_Click(object sender, EventArgs e)
        {
            AfficherMdpCon();
        }
       
        /// <summary>
        /// Méthode qui permet de visualiser le mot de passe de la rubrique nouveau mdp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherInsNvMdp_Click(object sender, EventArgs e)
        {
            AfficherMdpIns();
        }
       
        /// <summary>
        /// Méthode qui permet de visualiser le mot de passe de la rubrique confirmer mdp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherInsConfMdp_Click(object sender, EventArgs e)
        {
            AfficherMdpConf();
        }
        #endregion

        #region Logique
        /// <summary>
        /// Méthode qui permet d'afficher l'incription
        /// </summary>
        private void LancerInscription()
        {
            ConnexionPanel.Visible = false;
            InscriptionPannel.Visible = true;
        }
        
        /// <summary>
        /// Méthode qui permet de re trouver sur la page de connexion
        /// </summary>
        private void DirectionPgCon()
        {
            ConnexionPanel.Visible = true;
            InscriptionPannel.Visible = false;
        }

        /// <summary>
        /// Méthode qui donne accès aux caractères spéciaux
        /// </summary>
        /// <returns></returns>
        private static String[] CharSpeciaux()
        {
            String liste = "0 1 2 3 4 5 6 7 8 9 _ ' . , ; : ! ? @ & § ~ ^ ` ¨ | ( ) { } [ ] / < > * + = % µ € $ ¤ £";
            return liste.Split(' ');
        }

        /// <summary>
        /// Méthode qui permet de savoir si le prénom et le nom sont dans la chaine
        /// </summary>
        /// <param name="chaine"> chaine de caractere</param>
        /// <param name="liste"> tableau de string </param>
        /// <returns></returns>
        private static Boolean EstDansLaChaine(String chaine, String[] liste)
        {
            Boolean contient = false;
            for (int i = 0; i < liste.Length; i++)
            {
                if (chaine.Contains(liste[i]))
                {
                    contient = true;
                }
            }
            return contient;
        }
       
        /// <summary>
        /// Méthode qui permet d'afficher le mot de passe lors de la connexion
        /// </summary>
        private void AfficherMdpCon()
        {
            if (textBoxPass.PasswordChar == '●')
            {
                textBoxPass.PasswordChar = '\0';
            }
            else
            {
                textBoxPass.PasswordChar = '●';
            }
        }
        
        /// <summary>
        /// Méthode qui permet d'afficher le mot de passe lors de l'inscription
        /// </summary>
        private void AfficherMdpIns()
        {
            if (passBox.PasswordChar == '●')
            {
                passBox.PasswordChar = '\0';
            }
            else
            {
                passBox.PasswordChar = '●';
            }
        }
        
        /// <summary>
        /// Méthode qui permet de visualiser le mot de passe lors de la confirmation
        /// </summary>
        private void AfficherMdpConf()
        {
            if (PassConfirm.PasswordChar == '●')
            {
                PassConfirm.PasswordChar = '\0';
            }
            else
            {
                PassConfirm.PasswordChar = '●';
            }
        }
        #endregion
    }
}
