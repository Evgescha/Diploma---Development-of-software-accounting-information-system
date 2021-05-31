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
    public partial class ReportByPC : Form
    {
        public ReportByPC()
        {
            InitializeComponent();
        }

        private void ReportByPC_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "SoftareAccountingDataSet.SoftwareAndComputer". При необходимости она может быть перемещена или удалена.
            this.SoftwareAndComputerTableAdapter.Fill(this.SoftareAccountingDataSet.SoftwareAndComputer);

            this.reportViewer1.RefreshReport();
        }

        private void ReportByPC_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }
    }
}
