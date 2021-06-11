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
    public partial class PresentationAbonne : UserControl
    {
        private ABONNÉS abonnés;
        public PresentationAbonne(ABONNÉS abo)
        {
            InitializeComponent();
            this.abonnés = abo;
            lblNom.Text = abo.NOM_ABONNÉ;
            lblPrenom.Text = abo.PRÉNOM_ABONNÉ;
            abonnés = abo;
        }

        private void btnVoir_Click(object sender, EventArgs e)
        {
            AfficherDetail();         
        }

        private void AfficherDetail()
        {
            CompteUtilisateurPourAdmin ca = new CompteUtilisateurPourAdmin(abonnés);
            ca.ShowDialog();
        }
    }
}
