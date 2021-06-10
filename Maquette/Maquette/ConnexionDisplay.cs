﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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
            Outil.chargerMusiqueEntities();
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
            var abonnes = Outil.getABONNÉSs();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "" && textBoxPass.Text != "")
            {
                ABONNÉS abo = Outil.connexion(textBoxId.Text, textBoxPass.Text);
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

        private void textBoxId_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ConnexionPanel.Visible = false;
            Panel.Visible = true;
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

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

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

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
                if (prenomBox.Text == prenomTrim && nomBox.Text == nomTrim && !EstDansLaChaine(prenomBox.Text, charSpéciaux()) && !EstDansLaChaine(nomBox.Text, charSpéciaux()))
                {
                    ABONNÉS a = Outil.inscription(prenomBox.Text, nomBox.Text, idBox.Text, passBox.Text, comboBoxP.Text.Trim());
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
                } else
                {
                    MessageBox.Show("Ecris bien gros batard");
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
            String liste = "_ ' . , ; : ! ? @ & § ~ ^ ` ¨ | ( ) { } [ ] / < > 0 1 2 3 4 5 6 7 8 9 * + = % µ € $ ¤ £";
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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
