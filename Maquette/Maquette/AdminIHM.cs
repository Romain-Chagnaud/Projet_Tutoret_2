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
    public partial class AdminIHM : Form
    {
        MusiqueEntities musique;

        public AdminIHM(MusiqueEntities musique)
        {
            InitializeComponent();
            this.musique = musique;
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
            AdminIHM2 add = new AdminIHM2(musique);
            add.Show();
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            AdminIHM add = new AdminIHM(musique);
            add.Show();
            this.Close();
        }

        private void AdminIHM_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var abonnes = Outil.getABONNÉSs();

            foreach (ABONNÉS a in abonnes)
            {
                listBox1.Items.Add(a);
            }
        }
    }

    }