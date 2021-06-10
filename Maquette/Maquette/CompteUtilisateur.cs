﻿using System;
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
                if (nouveauMDP.Text == confirmedMDP.Text)
                {
                    String mdp=changerMDP(nouveauMDP.Text, abonné);
                    if (mdp == null)
                    {
                        MessageBox.Show("Nouveau mot de passe trop long.");
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

        }
    }
}