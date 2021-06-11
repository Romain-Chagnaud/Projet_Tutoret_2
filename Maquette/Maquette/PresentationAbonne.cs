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
        public PresentationAbonne(ABONNÉS abo)
        {
            InitializeComponent();
            lblNom.Text = abo.NOM_ABONNÉ;
            lblPrenom.Text = abo.PRÉNOM_ABONNÉ;
        }
    }
}
