using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zodiaco.signozodiaco;

namespace zodiaco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zodiacoSoapClient signo = new zodiacoSoapClient();
            if (cmbmes.Text == null && txtdia.Text == string.Empty)
            {
                MessageBox.Show("Debes eleccionar un dia y mes");
            }
            else
            {
                try
                {
                    MessageBox.Show(signo.signo(int.Parse(txtdia.Text), cmbmes.SelectedIndex));

                }
                catch (FormatException ex)
                {

                    MessageBox.Show("Debes ingresar una fecha correcta");
                }

            }

        }

        private void cmbmes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
