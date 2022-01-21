using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottery_numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] randomNumbers;
            randomNumbers = new int[50];

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(1, 49);
            }

            Control[] labels = new Control[] { label1, label2, label3, label4, label5, label6,label6, label7 };

            foreach(Control control in labels)
            {
                control.Text = random.Next(1, 49).ToString();
            }

            
        } 
        
    }
}