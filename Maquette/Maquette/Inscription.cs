using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquette
{
    public partial class Inscription : Form
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
        public Inscription()
        {
            InitializeComponent();

            this.Panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Panel.Width, Panel.Height, 10, 10));
            this.SignButton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, SignButton.Width, SignButton.Height, 10, 10));
            this.nomBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, nomBox.Width, nomBox.Height, 3, 3));
            this.prenomBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, prenomBox.Width, prenomBox.Height, 3, 3));
            this.idBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, idBox.Width, idBox.Height, 3, 3));
            this.passBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, passBox.Width, passBox.Height, 3, 3));
        }

        private void Inscription_Load(object sender, EventArgs e)
        {

        }

        private void Abonne_Load()
        {
            var abonnes = Outil.getABONNÉSs();
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            if (nomBox.Text != "" && prenomBox.Text != "" && idBox.Text != "" && passBox.Text != "")
            {
                ABONNÉS a = Outil.inscription(prenomBox.Text, nomBox.Text, idBox.Text, passBox.Text);
                this.Close();
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
                MessageBox.Show("Veuillez entrer des informations valides");
            }
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
