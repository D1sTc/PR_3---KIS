using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBoxNumbersKeys.Clear();
            textBoxNumbersValues.Clear();
            textBoxNumbersExScreen.Clear();
        }

        private void Generation_Click(object sender, EventArgs e)
        {

        }

        private void Multiply_Click(object sender, EventArgs e)
        {

        }

        private void ClearMenu_Click(object sender, EventArgs e)
        {
            textBoxNumbersKeys.Clear();
            textBoxNumbersValues.Clear();
            textBoxNumbersExScreen.Clear();
        }

        private void AboutProgram_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void ApplicationGeneration_Click(object sender, EventArgs e)
        {
            Generation_Click(sender, e);
        }

        private void ApplicationMultiply_Click(object sender, EventArgs e)
        {
            Multiply_Click(sender, e);
        }
    }
}
