using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Maquette.Outil;

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
            chargerMusiqueEntities();
            musique = Outil.musique;
            Abonne_Load();
        }

        /// <summary>
        /// Chargement des abonnés
        /// </summary>
        private void Abonne_Load()
        {
            listBox1.Items.Clear();
            var abonnes = getABONNÉSs();

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
                ABONNÉS a = inscription(prenom.Text, nom.Text, login.Text, mdp.Text);
                if (a != null)
                {
                    Abonne_Load();
                    nom.Text = "";
                    prenom.Text = "";
                    login.Text = "";
                    mdp.Text = "";
                }
                else
                {
                    MessageBox.Show("Client déjà existant");
                }
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
                ABONNÉS abo = connexion(log2.Text, mdp2.Text);
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
