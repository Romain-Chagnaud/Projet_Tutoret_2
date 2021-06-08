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
    public partial class AdminIHM2 : Form
    {
        MusiqueEntities musique;
        public AdminIHM2(MusiqueEntities musique)
        {
            InitializeComponent();
            this.musique = musique;
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
    }
}
