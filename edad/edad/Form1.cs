using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            string edad = txtedad.Text;

            int edadd = int.Parse(edad);


            if (edadd >= 18){

                lblmaymen.Text = " Mayor de edad ";
                lblmaymen.Visible = true;

            }else{

                lblmaymen.Text = " Menor de edad  ";
                lblmaymen.Visible = true;
            }
        }
    }
}
