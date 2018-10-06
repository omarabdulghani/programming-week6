using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            int[] dice = new int[6];
            const int MAX_COUNT = 6000;

           

                for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = 0;
                lbldice.Text = "";
            }

            Random rnd = new Random();

            for (int n = 0; n < MAX_COUNT; n++ )
            {
                int value = rnd.Next(1, 7);
                dice[value - 1] = dice[value - 1] + 1;

            }

            for (int i = 0; i < dice.Length; i++)
            {
                lbldice.Text += "\nNumber of throws of value " + " " + (i+1) + " = " + dice[i];
            }

            
            
        }
    }
}
