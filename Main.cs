using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_accounting
{
    public partial class Main : Form
    {
        public static Main main;
        public Main()
        {
            InitializeComponent();
            main = this;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Computer().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Software().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new ComputerGuide().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SoftwareGuide().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ReportByPC().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new ReportBySoftware().Show();
            this.Hide();
        }
    }
}
