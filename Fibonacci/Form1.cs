using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        long Fib(int n)
        {
            int num1 = 0;
            int num2 = 1;
            int num3 = 2;

            if (n == num2)
            {
                return num1;
            }
            else if (n == num3)
            {
                return num2;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text);
            txtValue.Text = Fib(num).ToString();
        }
    }
}
