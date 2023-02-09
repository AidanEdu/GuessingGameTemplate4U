using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class ResultScreen : UserControl
    {
        public ResultScreen()
        {
            InitializeComponent();

            for (int i = 0; i < Form1.guess.Count; i++)
            {
                orginalOrderLabel.Text += $"{Convert.ToString(Form1.guess[i])} ";
                
            }

            Form1.guess.Sort();

            for (int i = 0; i < Form1.guess.Count; i++)
            {
                sortedOrderLabel.Text += $"{Convert.ToString(Form1.guess[i])} ";
            }

            guessCountLabel.Text = $"Number of Guesses: {Form1.guessCount}"; 
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
