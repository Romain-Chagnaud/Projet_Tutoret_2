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
            var albums = Outil.getALBUMSs();

            foreach (ALBUMS al in albums)
            {
                var emprunts = Outil.getEmpruntsSelonAlbum(al.CODE_ALBUM);

                if (emprunts.Count == 0)
                {
                    listBox4.Items.Add(al);
                }
                else
                {
                    int compteur = 0;
                    bool aEteEmprunte = false;

                    while (compteur < emprunts.Count && !aEteEmprunte)
                    {
                        EMPRUNTER emp = emprunts[compteur];
                        DateTime date = emp.DATE_EMPRUNT.AddYears(1);

                        if (date.CompareTo(DateTime.Now) > 0)
                        {
                            aEteEmprunte = true;
                        }
                        compteur++;
                    }

                    if (!aEteEmprunte)
                    {
                        listBox4.Items.Add(al);
                    }
                }
            }
        }
    }
}
