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
    public partial class Prologation : Form
    {
        public Prologation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var emprunts = Outil.getProlongés();
            foreach (EMPRUNTER em in emprunts)
            {
                listBox1.Items.Add(em);
            }
        }
    }
}
