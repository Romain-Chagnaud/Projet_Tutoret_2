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
    public partial class Magasin : Form
    {

        List<ALBUMS> dispos;
        int pageDispo = 0;

        public Magasin(Abonné parent)
        {
            InitializeComponent();
            this.Owner = parent;
            InitialiserElements();
        }
        #region IHM

        private void lblEspace_Click(object sender, EventArgs e)
        {
            Quitter();
        }

        #endregion
        #region Logique

        private void Quitter()
        {
            this.Close();
        }

        #endregion

        private void InitialiserElements()
        {
            ActualiserListes();
            afficherAlbums();
        }

        private void ActualiserListes()
        {
            dispos = getALBUMSs().OrderBy(a => a.TITRE_ALBUM).Except(getIndisponibles()).ToList();
        }

        /// <summary>        
        /// Méthode ci-dessous : US 1
        /// Méthode pour afficher les albums non-empruntés
        /// </summary>
        private void afficherAlbums()
        {
            panelDispo.Controls.Clear();
            for (int i = 8 * pageDispo; i < 8 * (pageDispo + 1); i++)
            {
                if (i < dispos.Count)
                {
                    panelDispo.Controls.Add(new AlbumEmpruntable(dispos[i], this));
                }
            }
        }

        private void btnPreDis_Click(object sender, EventArgs e)
        {
            if (pageDispo > 0)
            {
                pageDispo--;
            }
            afficherAlbums();
        }

        private void btnSuiDis_Click(object sender, EventArgs e)
        {
            if (pageDispo < (dispos.Count / 8))
            {
                pageDispo++;
            }
            afficherAlbums();
        }

        public void EmprunterAlbum(ALBUMS album)
        {
            Abonné parent = (Abonné)Owner;
            parent.EmprunterAlbum(album);
            ActualiserListes();
            afficherAlbums();
        }
    }
}
