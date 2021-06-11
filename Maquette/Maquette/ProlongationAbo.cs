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

        public ProlongationAbo(EMPRUNTER emprunt)
        {
            InitializeComponent();
            ChargerElements(emprunt.ABONNÉS, emprunt.ALBUMS);
        }

        /// <summary>
        /// Initialise l'affichage de l'emprunt
        /// </summary>
        private void ChargerElements(ABONNÉS abos, ALBUMS album)
        {
            Admin_Name.Text = abos.NOM_ABONNÉ.Trim();
            Admin_Prenom.Text = abos.PRÉNOM_ABONNÉ.Trim();

            TitreAlbum.Text = album.TITRE_ALBUM.Trim();
            if (album.POCHETTE != null)
            {
                pochette.Image = Image.FromStream(new MemoryStream(album.POCHETTE));
            }
        }


    }
}
