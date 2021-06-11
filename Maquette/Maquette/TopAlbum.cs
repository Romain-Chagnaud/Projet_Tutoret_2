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
    public partial class TopAlbum : Form
    {

        List<ALBUMS> albums;
        List<int> count;
        int page = 0;
        int nbPage;

        public TopAlbum()
        {
            InitializeComponent();
            albums = Outil.getTop10Albums();
            count = Outil.getTop10Count();
            ActualiserPage();
            AfficherAlbums();
        }


        #region IHM
        /// <summary>
        /// Clique sur page précédente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPreEmp_Click(object sender, EventArgs e)
        {
            Decrementer();
        }

        /// <summary>
        /// Clique sur page suivante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSuiEmp_Click(object sender, EventArgs e)
        {
            Incrementer();
        }
        #endregion

        #region Logique
        /// <summary>
        /// Permet d'afficher les albums
        /// </summary>
        private void AfficherAlbums()
        {
            pnlElemEmprunt.Controls.Clear();
            for (int i = 3 * page; i < 3 * (page + 1); i++)
            {
                if (i < albums.Count && i >= 0)
                {
                    pnlElemEmprunt.Controls.Add(new AlbumClassement(albums[i], count[i]));
                }
            }
            lblPageEmp.Text = page + 1 + "";
        }


        /// <summary>
        /// Actualiser le nombre de pages 
        /// </summary>
        private void ActualiserPage()
        {
            if (albums.Count % 4 != 0)
            {
                nbPage = albums.Count / 4;
            }
            else
            {
                nbPage = (albums.Count / 4) - 1;
            }
        }


        /// <summary>
        /// Permet d'incrémenter la page 
        /// </summary>
        private void Incrementer()
        {
            if (page < nbPage)
            {
                page++;
            }
            else
            {
                page = 0;
            }
            AfficherAlbums();
        }


        /// <summary>
        /// Permet de décrémenter la page 
        /// </summary>
        private void Decrementer()
        {
            if (page > 0)
            {
                page--;
            }
            else
            {
                page = nbPage;
            }
            AfficherAlbums();
        }
        #endregion



    }
}