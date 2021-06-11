using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquette
{
    public partial class PresentationAbonne : UserControl
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeft,
        int nTop,
        int nRight,
        int nBottom,
        int nWidthEllipse,
        int nHeightEllipse
        );

        ABONNÉS abo;
        public PresentationAbonne(ABONNÉS abo)
        {
            InitializeComponent();
            this.abo = abo;
            lblNom.Text = abo.NOM_ABONNÉ;
            lblPrenom.Text = abo.PRÉNOM_ABONNÉ;

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));

        }
    }
}
