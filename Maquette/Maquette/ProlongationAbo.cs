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
        readonly ALBUMS al;
        readonly EMPRUNTER em;
        public ProlongationAbo(EMPRUNTER emprunt)
        {
            InitializeComponent();
            al = emprunt.ALBUMS;
            em = emprunt;
            ChargerElements(emprunt.ABONNÉS, emprunt.ALBUMS);
        }

        #region Logique

        /// <summary>
        /// Initialise l'affichage de l'emprunt
        /// </summary>
        private void ChargerElements(ABONNÉS abos, ALBUMS album)
        {
            Admin_Name.Text = abos.NOM_ABONNÉ.Trim();
            Admin_Prenom.Text = abos.PRÉNOM_ABONNÉ.Trim();
            lblDateA.Text = em.DATE_RETOUR_ATTENDUE.ToString();
            lblDateE.Text = em.DATE_EMPRUNT.ToString();
            TitreAlbum.Text = album.TITRE_ALBUM.Trim();
            if (album.POCHETTE != null)
            {
                pochette.Image = Image.FromStream(new MemoryStream(album.POCHETTE));
            }
        }

        #endregion

        private void btnDescription_Click(object sender, EventArgs e)
        {
            DescriptionAlbum da = new DescriptionAlbum(al);
            da.ShowDialog();
        }
    }
}
