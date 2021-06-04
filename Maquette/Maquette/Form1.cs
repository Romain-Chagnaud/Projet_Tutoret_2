using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquette
{
    public partial class Form1 : Form
    {
        MusiqueEntities musique;

        public Form1()
        {
            InitializeComponent();

            musique = new MusiqueEntities();
            Abonne_Load();
        }

        private void Abonne_Load()
        {
            var abonnes = (from a in musique.ABONNÉS
                           select a).ToList();

            foreach (ABONNÉS a in abonnes)
            {
                listBox1.Items.Add(a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nom.Text != "" && prenom.Text != "" && login.Text != "" && mdp.Text != "")
            {
                ABONNÉS a = new ABONNÉS();
                a.PRÉNOM_ABONNÉ = prenom.Text;
                a.NOM_ABONNÉ = nom.Text;
                a.LOGIN_ABONNÉ = login.Text;
                a.PASSWORD_ABONNÉ = mdp.Text;

                listBox1.Items.Add(a);
                musique.ABONNÉS.Add(a);
                musique.SaveChanges();
            }
        }
    }
}
