using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2806
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double b = 0;
            double a = 0;
            double total = 0;

            b = double.Parse(txtBase.Text);
            a = double.Parse(txtAltura.Text);
            total = (b * a) / 2;

            lblValor.Text = total.ToString();
        }
    }
}
