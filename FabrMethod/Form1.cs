using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FabrMethLib;

namespace FabrMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FactCargo Factory;
        Cargo Cargo;

        private void button1_Click(object sender, EventArgs e)
        {
            Cargo = Factory.CreateCargo();
            MessageBox.Show(Cargo.Size);
        }    

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            Factory = new FactBig();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            Factory = new FactMid();
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            Factory = new FactLow();
        }
    }
}
