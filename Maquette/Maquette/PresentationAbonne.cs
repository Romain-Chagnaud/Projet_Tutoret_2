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
        ABONNÉS abo;

        public PresentationAbonne(ABONNÉS abo)
        {
            InitializeComponent();
            this.abo = abo;
            lblNom.Text = abo.NOM_ABONNÉ;
            lblPrenom.Text = abo.PRÉNOM_ABONNÉ;
        }

        private void btnVoir_Click(object sender, EventArgs e)
        {
            AfficherDetail();         
        }

        private void AfficherDetail()
        {
            CompteUtilisateurPourAdmin ca = new CompteUtilisateurPourAdmin(abo);
            ca.ShowDialog();
        }
    }
}
