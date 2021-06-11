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
    public partial class AdminIHM2 : Form
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

        public AdminIHM2()
        {
            InitializeComponent();

            toolStrip1.Cursor = Cursors.Hand;

            this.flowLayoutPanel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel1.Width, flowLayoutPanel1.Height, 10, 10));

        }


         

        private void button1_Click(object sender, EventArgs e)
        {
            NonEmprunte ne = new NonEmprunte();
            ne.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TopAlbum ta = new TopAlbum();
            ta.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            AdminIHM add = new AdminIHM();
            add.Show();
            this.Close();
        }        

        private void btnCasier_Click(object sender, EventArgs e)
        {
            AfficherCasier();
        }

        private void AfficherCasier()
        {
            Casier casier = new Casier();
            casier.Show();
        }
    }
}
