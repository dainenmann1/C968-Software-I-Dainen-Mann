using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Software_I_Dainen_Mann
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPartScreen newPart = new AddPartScreen();
            newPart.Show();

        }

        private void PartDelete_Click(object sender, EventArgs e)
        {

        }

        private void ExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
