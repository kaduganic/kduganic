using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kduganic
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            float polumjer = 0;
            float povrsina = 0;
            float opseg = 0;

            float.TryParse(txtPolumjer.Text, out polumjer);

            izracun(polumjer);

            if (chkSpremi.Checked == true) lstRezultati.Items.Add(polumjer);
            

        }

        private void izracun(float polumjer)
        {
            float povrsina = 0;
            float opseg = 0;
            if (polumjer > 0)
            {
                povrsina = polumjer * polumjer * (float)Math.PI;
                opseg = 2 * polumjer * (float)Math.PI;

                txtPovrsina.Text = povrsina.ToString();
                txtOpseg.Text = opseg.ToString();
            }
        }

        private void lstRezultati_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            float polumjer = 0;

            float.TryParse(lstRezultati.SelectedItem.ToString(), out polumjer);
            txtPolumjer.Text = polumjer.ToString();

            izracun(polumjer);
        }

      
    }
}
