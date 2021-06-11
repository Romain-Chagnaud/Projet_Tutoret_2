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
    public partial class NonEmprunte : Form
    {
        List<ALBUMS> albums;
        int page = 0;
        int nbPage;

        public NonEmprunte()
        {
            InitializeComponent();
            albums = Outil.GetAlbumsNonEmpruntés();
            ActualiserPage();
            AfficherAlbums();
        }

        #region IHM

        /// <summary>
        /// Clic sur le bouton Page Précédente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreCon_Click(object sender, EventArgs e)
        {
            Decrementer();
        }

        /// <summary>
        /// Clic sur le bouton Page Suivante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuiCon_Click(object sender, EventArgs e)
        {
            Incrementer();
        }

        #endregion

        #region Logique

        /// <summary>
        /// Actualise le nombre de pages
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
        /// Affiche les albums de la page courante
        /// </summary>
        private void AfficherAlbums()
        {
            pnlNonEmp.Controls.Clear();
            for (int i = 3 * page; i < 3 * (page + 1); i++)
            {
                if (i < albums.Count)
                {
                    pnlNonEmp.Controls.Add(new AlbumNonEmprunte(albums[i]));
                }
            }
            lblPageReco.Text = page + 1 + "";
        }

        /// <summary>
        /// Incrémente la page
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
        /// Décrémente la page
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
