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
    public partial class Sous_Admin2cs : Form
    {

        List<ABONNÉS> retards;
        int pageRetard = 0;
        int nbPageRetard;

        public Sous_Admin2cs()
        {
            InitializeComponent();
            retards = GetRetardataires();
            ActualiserPage();

        }

        #region IHM

        /// <summary>
        /// Clique sur page précédédente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPreRe_Click(object sender, EventArgs e)
        {
            DecrementerPage();
        }

         /// <summary>
         /// Permet d'afficher les retardataire
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void Sous_Admin2cs_Load(object sender, EventArgs e)
        {
            ChargerRetard();
        }

        /// <summary>
        /// Clique sur page suivante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSuiRe_Click(object sender, EventArgs e)
        {
            IncrementerPage();
        }

        #endregion

        #region Logique

        /// <summary>
        /// Actualiser le nombre de pages
        /// </summary>
        private void ActualiserPage()
        {
            if (retards.Count % 2 != 0 || retards.Count==0)
            {
                nbPageRetard = retards.Count / 2;
            }
            else
            {
                nbPageRetard = (retards.Count / 2) - 1;
            }
        }
                
        /// <summary>
        /// Affiche les retardataires
        /// </summary>
        private void ChargerRetard()
        {
            pnlRetards.Controls.Clear();
            for (int i = 2 * pageRetard; i < 2 * (pageRetard + 1); i++)
            {
                if (i < retards.Count)
                {
                    pnlRetards.Controls.Add(new PresentationAbonne(retards[i]));
                }
            }
            lblPageRe.Text = pageRetard + 1 + "";
        }

        /// <summary>
        /// Permet de décrémenter la page 
        /// </summary>
        private void DecrementerPage()
        {
            if (pageRetard > 0)
            {
                pageRetard--;
            }
            else
            {
                pageRetard = nbPageRetard;
            }
            ChargerRetard();
        }

        /// <summary>
        /// Permet de d'incrémenter la page 
        /// </summary>
        private void IncrementerPage()
        {
            if (pageRetard < nbPageRetard)
            {
                pageRetard++;
            }
            else
            {
                pageRetard = 0;
            }
            ChargerRetard();
        }

        #endregion
    }
}
