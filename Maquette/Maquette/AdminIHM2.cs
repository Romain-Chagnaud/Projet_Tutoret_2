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
    public partial class AdminIHM2 : Form
    {
        public AdminIHM2()
        {
            InitializeComponent();
        }

        #region IHM

        /// <summary>
        /// Clic sur bouton Pas Emprunté
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPasEmp_Click(object sender, EventArgs e)
        {
            AfficherNonEmprunt();
        }

        /// <summary>
        /// Clic sur le bouton Top 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTop_Click(object sender, EventArgs e)
        {
            AfficherTop();
        }

        /// <summary>
        /// Clic sur le label Abonné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblAbo_Click(object sender, EventArgs e)
        {
            AfficherPremiereFenetre();
        }

        /// <summary>
        /// Clic sur le bouton casier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCasier_Click(object sender, EventArgs e)
        {
            AfficherCasier();
        }



        #endregion

        #region Logique

        /// <summary>
        /// Affiche la fenêtre des albums non empruntés
        /// </summary>
        private static void AfficherNonEmprunt()
        {
            NonEmprunte ne = new NonEmprunte();
            ne.Show();
        }

        /// <summary>
        /// Affiche la fenêtre du top 10 des albums
        /// </summary>
        private static void AfficherTop()
        {
            TopAlbum ta = new TopAlbum();
            ta.Show();
        }

        /// <summary>
        /// Affiche la fenêtre principale de gestion des abonnés
        /// </summary>
        private void AfficherPremiereFenetre()
        {
            AdminIHM add = new AdminIHM();
            add.Show();
            this.Close();
        }

        /// <summary>
        /// Affiche la fenêtre des albums empruntés selon leur casier
        /// </summary>
        private void AfficherCasier()
        {
            Casier casier = new Casier();
            casier.Show();
        }

        #endregion

    }
}
