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

        public AlbumEmpruntable(ALBUMS album)
        {
            InitializeComponent();
            this.album = album;
            ChargerElements();
        }

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
