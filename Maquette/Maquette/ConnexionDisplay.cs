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

        public ConnexionDisplay()
        {
            InitializeComponent();
            Outil.ChargerMusiqueEntities();
            Panel.Visible = false;

            Abonne_Load();

            List<String> pays = Outil.GetPays();

            foreach (var p in pays)
            {
                comboBoxP.Items.Add(p);
            }

            this.ConnexionPanel.BorderStyle = BorderStyle.None;
            this.ConnexionPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, ConnexionPanel.Width, ConnexionPanel.Height, 10, 10));
            this.button1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));
            this.textBoxId.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxId.Width, textBoxId.Height, 3, 3));
            this.textBoxPass.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxPass.Width, textBoxPass.Height, 3, 3));
            this.Panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Panel.Width, Panel.Height, 10, 10));
            this.SignButton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, SignButton.Width, SignButton.Height, 10, 10));
            this.nomBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, nomBox.Width, nomBox.Height, 3, 3));
            this.prenomBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, prenomBox.Width, prenomBox.Height, 3, 3));
            this.idBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, idBox.Width, idBox.Height, 3, 3));
            this.passBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, passBox.Width, passBox.Height, 3, 3));
        }


        private void Abonne_Load()
        {
            var abonnes = Outil.GetABONNÉSs();
        }


        private void button1_Click(object sender, EventArgs e)
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


        private void label1_Click(object sender, EventArgs e)
        {
            ConnexionPanel.Visible = false;
            Panel.Visible = true;
        }


        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(135, 87, 67, 1);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(56, 24, 3, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnexionPanel.Visible = true;
            Panel.Visible = false;
        }


        public static void mBox(string i)
        {
            MessageBox.Show(i);
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            if (nomBox.Text != "" && prenomBox.Text != "" && idBox.Text != "" && passBox.Text != "")
            {
                string prenomTrim = prenomBox.Text.Trim();
                string nomTrim = nomBox.Text.Trim();
                if (prenomBox.Text == prenomTrim && nomBox.Text == nomTrim && !EstDansLaChaine(prenomBox.Text, charSpéciaux())
                    && !EstDansLaChaine(nomBox.Text, charSpéciaux())
                    && prenomTrim.Length > 0 && prenomTrim.Length <= 32 && nomTrim.Length > 0 && nomTrim.Length <= 32 && idBox.Text.Length > 0 && idBox.Text.Length <= 32
                && passBox.Text.Length > 0 && passBox.Text.Length <= 32 && Regex.IsMatch(passBox.Text, "^\\S\\w*\\S$") && Regex.IsMatch(idBox.Text, "^\\S[a-zA-Z0-9]*\\S$"))
                {
                    if (passBox.Text == PassConfirm.Text)
                    {
                        ABONNÉS a = Outil.Inscription(prenomBox.Text, nomBox.Text, idBox.Text, passBox.Text, comboBoxP.Text.Trim());
                        Panel.Visible = false;
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

        private static String[] majMin()
        {
            String liste = "A a À à Â â Ä ä Ã ã B b C c ç D d E e é È è Ê ê Ë ë F f G g H h I i Ì ì Î î Ï ï J j K " +
                "k L l M m N n Ñ ñ O o Ò ò Ô ô Ö ö Õ õ P p Q q R r S s T t U u Ù ù Û û Ü ü V v W w X x Y y ÿ Z z -";
            return liste.Split(' ');
        }

        private static String[] charSpéciaux()
        {
            String liste = "0 1 2 3 4 5 6 7 8 9 _ ' . , ; : ! ? @ & § ~ ^ ` ¨ | ( ) { } [ ] / < > * + = % µ € $ ¤ £";
            return liste.Split(' ');
        }

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

        private static Boolean LoginContientCaractèresSpéciaux(String chaine)
        {
            String liste = "_ ' . , ; : ! ? @ & § ~ ^ ` ¨ | ( ) { } [ ] / < > * + = % µ € $ ¤ £";
            String[] listeTab = liste.Split(' ');
            Boolean contient = false;
            for (int i = 0; i < listeTab.Length; i++)
            {
                if (chaine.Contains(listeTab[i]))
                {
                    contient = true;
                }
            }
            return contient;
        }

        private void afficherButton_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
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
    }
}
