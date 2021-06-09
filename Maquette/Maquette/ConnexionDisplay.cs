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

        MusiqueEntities musique;
        ABONNÉS abonnéConnecté;

        public ConnexionDisplay(MusiqueEntities musique)
        {
            InitializeComponent();

            Panel.Visible = false;

            musique = musique;
            Outil.musique = musique;

            Abonne_Load();


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
                if (abo != null)
                {
                    MessageBox.Show("Bienvenue, " + abo);
                    abonnéConnecté = abo;
                    if (abonnéConnecté.LOGIN_ABONNÉ.Trim() == "admin")
                    {
                        Admin admin = new Admin(musique);
                        admin.ShowDialog();
                    }
                    else
                    {
                        Abonné abonne = new Abonné(musique, abonnéConnecté);
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

        private void SignButton_Click(object sender, EventArgs e)
        {
            if (nomBox.Text != "" && prenomBox.Text != "" && idBox.Text != "" && passBox.Text != "")
            {
                ABONNÉS a = Outil.inscription(prenomBox.Text, nomBox.Text, idBox.Text, passBox.Text);
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
                MessageBox.Show("Veuillez entrer des informations valides");
            }
        }
    }
}
