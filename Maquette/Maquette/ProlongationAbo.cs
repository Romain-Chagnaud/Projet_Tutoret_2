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
    public partial class ProlongationAbo : UserControl
    {
        public ABONNÉS abos;
        public EMPRUNTER emprunt;
        public ALBUMS al;
        public ProlongationAbo(EMPRUNTER emprunt)
        {
            InitializeComponent();
            this.abos = emprunt.ABONNÉS;
            this.emprunt = emprunt;
            this.al = emprunt.ALBUMS;
            Admin_Name.Text = abos.NOM_ABONNÉ.Trim();
            Admin_Prenom.Text = abos.PRÉNOM_ABONNÉ.Trim();
            TitreAlbum.Text = emprunt.ALBUMS.TITRE_ALBUM.Trim();
            ChargerElements();
        }

        /// <summary>
        /// Initialise l'affichage de l'emprunt
        /// </summary>
        private void ChargerElements()
        {
            ALBUMS album = Outil.GetAlbumSelonID(emprunt.CODE_ALBUM);
            TitreAlbum.Text = album.TITRE_ALBUM;
            if (album.POCHETTE != null)
            {
                pochette.Image = Image.FromStream(new MemoryStream(album.POCHETTE));
            }
        }


    }
}
