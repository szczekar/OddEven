using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOddEvenNumber
{
    public partial class OddEvenNumber : Form
    {
        public OddEvenNumber()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clickButton_Click(object sender, EventArgs e)
        {
                // MessageBox.Show("Klik!");
                //this.clickButton.Text = "Kliknięty!";


            int inputUserNumber = Convert.ToInt32(inputNumber.Text);

            if (inputUserNumber % 2 == 0)
            {
                MessageBox.Show("Number " + inputUserNumber + " is even !");
            }
            else
            {
                MessageBox.Show("Number " + inputUserNumber + " is odd !");
            }
            
            
        }
    }
}
