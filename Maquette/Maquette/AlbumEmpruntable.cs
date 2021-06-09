using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquette
{
    public partial class AlbumEmpruntable : UserControl
    {
        ALBUMS album;
        Magasin magParent = null;
        Abonné aboParent = null;


        public AlbumEmpruntable(ALBUMS album, Magasin parent)
        {
            InitializeComponent();
            this.album = album;
            this.magParent = parent;
            ChargerElements();
        }

        public AlbumEmpruntable(ALBUMS album, Abonné parent)
        {
            InitializeComponent();
            this.album = album;
            this.aboParent = parent;
            ChargerElements();
        }

        #region IHM

        /// <summary>
        /// Click sur le bouton Voir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVoir_Click(object sender, EventArgs e)
        {
            AfficherDetails();
        }

        #endregion

        #region Logique

        /// <summary>
        /// Initialise l'affichage de l'emprunt
        /// </summary>
        private void ChargerElements()
        {
            lblTitre.Text = album.TITRE_ALBUM;
            if (album.POCHETTE != null)
            {
                pochette.Image = Image.FromStream(new MemoryStream(album.POCHETTE));
            }
        }

        /// <summary>
        /// Affiche les détails d'un album
        /// </summary>
        private void AfficherDetails()
        {
            DescriptionAlbum desc = new DescriptionAlbum(album);
            if (desc.ShowDialog() == DialogResult.OK)
            {
                EmprunterAlbum();
            }
        }

        private void EmprunterAlbum()
        {
            if (aboParent != null)
            {
                aboParent.EmprunterAlbum(album);
            } else
            {
                magParent.EmprunterAlbum(album);
            }
        }


        #endregion







        /// <summary>
        /// Méthode ci-dessous : US 1
        /// Méthode pour emprunter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /*
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                ALBUMS al = (ALBUMS)listBox2.SelectedItem;
                EMPRUNTER em = nouvelEmprunt(abonne, al);
                if (em != null)
                {
                    MessageBox.Show(em.ToString());
                }
                else
                {
                    MessageBox.Show("Album déjà pris");
                }
                afficherAlbums();
                afficherEmprunts();
                afficherSuggestions();
            }
        }*/
    }
}
