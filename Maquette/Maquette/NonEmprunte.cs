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
    public partial class NonEmprunte : Form
    {
        public NonEmprunte()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var albums = Outil.getAlbumsNonEmpruntés();
            foreach(ALBUMS a in albums)
            {
                listBox4.Items.Add(a);
            }
        }
    }
}
