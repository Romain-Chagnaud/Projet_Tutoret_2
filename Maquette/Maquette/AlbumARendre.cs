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
    public partial class AlbumARendre : UserControl
    {
        private EMPRUNTER emprunt;

        public AlbumARendre(EMPRUNTER emprunt)
        {
            InitializeComponent();
            this.emprunt = emprunt;
            ChargerElements();
        }

        private void ChargerElements()
        {
            ALBUMS album = Outil.getAlbumSelonID(emprunt.CODE_ALBUM);
            lblTitre.Text = album.TITRE_ALBUM;
            lblDate.Text = emprunt.DATE_RETOUR_ATTENDUE.ToString();
            if (album.POCHETTE != null)
            {
                pochette.Image = Image.FromStream(new MemoryStream(album.POCHETTE));
            }
        }
    }
}
