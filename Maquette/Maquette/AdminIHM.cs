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
    public partial class AdminIHM : Form
    {

        public AdminIHM()
        {
            InitializeComponent();
        }
        #region IHM

        /// <summary>
        /// Clic sur le bouton des abonnés fantômes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFantome_Click(object sender, EventArgs e)
        {
            AfficherFantomes();
        }

        /// <summary>
        /// Clic sur le bouton des abonnés retardataires
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRetard_Click(object sender, EventArgs e)
        {
            AfficherRetardataires();
        }

        /// <summary>
        /// Clic sur le bouton des albums prolongés
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnProlo_Click(object sender, EventArgs e)
        {
            AfficherProlongations();
        }

        /// <summary>
        /// Clic sur le label Album
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblAlbum_Click(object sender, EventArgs e)
        {
            AfficherDeuxiemeFenetre();
        }

        /// <summary>
        /// Clic sur le bouton Liste des Abonnés
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbo_Click(object sender, EventArgs e)
        {
            AfficherAbonnes();
        }



        #endregion

        #region Logique

        /// <summary>
        /// Affiche la fenêtre principale des albums
        /// </summary>
        private void AfficherDeuxiemeFenetre()
        {
            AdminIHM2 ad = new AdminIHM2();
            ad.Show();
            this.Close();
        }

        /// <summary>
        /// Affiche la fenêtre des prolongations
        /// </summary>
        private void AfficherProlongations()
        {
            Prologation pl = new Prologation();
            pl.Show();
        }

        /// <summary>
        /// Affiche la fenêtre qui liste tout les abonnés
        /// </summary>
        private static void AfficherAbonnes()
        {
            ListeAbonnes liste = new ListeAbonnes();
            liste.Show();
        }

        /// <summary>
        /// Lance la fenêtre des abonnés fantômes
        /// </summary>
        private static void AfficherFantomes()
        {
            Sous_Admin ad = new Sous_Admin();
            ad.Show();
        }

        /// <summary>
        /// Affiche la fenêtre des retardataires
        /// </summary>
        private static void AfficherRetardataires()
        {
            Sous_Admin2cs ad = new Sous_Admin2cs();
            ad.Show();
        }

        #endregion














    }

}