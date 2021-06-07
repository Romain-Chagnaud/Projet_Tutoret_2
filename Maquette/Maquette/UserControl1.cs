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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        #region Paramètres
        private int annee;

        [Category("Param")]
        public int MyAnnee
        {
            get { return annee; }
            set { annee = value; anneeLbl.Text = value + ""; }
        }

        private string titre;

        [Category("Param")]
        public string MyTitre
        {
            get { return titre; }
            set { titre = value; nomLbl.Text = value; }
        }

        private Image image;

        [Category("Param")]
        public Image MyImage
        {
            get { return image; }
            set { image = value; pictureBox1.Image = value; }
        }

        #endregion
    }
}
