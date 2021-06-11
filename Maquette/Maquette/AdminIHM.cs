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
    public partial class AdminIHM : Form
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

        public AdminIHM()
        {
            InitializeComponent();

            toolStrip1.Cursor = Cursors.Hand;

            this.button1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));
            this.groupBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, groupBox1.Width, groupBox1.Height, 10, 10));
            this.groupBox2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, groupBox2.Width, groupBox2.Height, 10, 10));
            this.groupBox3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, groupBox3.Width, groupBox3.Height, 10, 10));
        }


        private void Btn_Fantome_Click(object sender, EventArgs e)
        {
            Sous_Admin ad = new Sous_Admin();
            ad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sous_Admin2cs ad = new Sous_Admin2cs();
            ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prologation pl = new Prologation();
            pl.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            AdminIHM2 add = new AdminIHM2();
            add.Show();
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            AdminIHM add = new AdminIHM();
            add.Show();
            this.Close();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            ListeAbonnes liste = new ListeAbonnes();
            liste.Show();
        }
    }

    }