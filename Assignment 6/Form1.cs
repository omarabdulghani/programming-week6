using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[20];
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            

            string input = txtComparison.Text;
            int comparenumber = int.Parse(input);

         

            for (int i = 0; i < numbers.Length; i++)
            {
                
                
                if (numbers[i] >= comparenumber)
                {
                     
                    numbers[i] += 10;
                }
               
                else if (numbers[i] <= comparenumber)
                {
                    numbers[i] -= 5;
                }

                lblAfter.Text += "Element " + i + " = " + numbers[i] + "\n";
            }





            btnCompare.Enabled = false;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 501);
                lblBefore.Text += "Element " + i + " = " + numbers[i] + "\n";


            }
        }
    }
}
