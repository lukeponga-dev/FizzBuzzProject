using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzzProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i= 1 ; i < 100; i++)
            {
                //  dividable by 15 - FizzBuzz
                if (i % 3 == 0 && i % 5 == 0)
                {
                    ListOutput.Items.Add("FizzBuzz");
                }
                // dividable by 5 - Buzz
                else if (i % 5 == 0)
                {
                    ListOutput.Items.Add("Buzz");
                }
                // dividable by 3 - Fizz
                else if (i % 3 == 0)
                {
                    ListOutput.Items.Add("Fizz");
                }
                //  List Numbers itself
                else
                {
                    ListOutput.Items.Add(i);
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } 
}