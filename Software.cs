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
    public partial class Software : Form
    {
        public Software()
        {
            InitializeComponent();
        }

        private void Software_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void loadData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softareAccountingDataSet.Computer". При необходимости она может быть перемещена или удалена.
            this.computerTableAdapter.Fill(this.softareAccountingDataSet.Computer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softareAccountingDataSet.Type". При необходимости она может быть перемещена или удалена.
            this.typeTableAdapter.Fill(this.softareAccountingDataSet.Type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softareAccountingDataSet.Producer". При необходимости она может быть перемещена или удалена.
            this.producerTableAdapter.Fill(this.softareAccountingDataSet.Producer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softareAccountingDataSet.InstalledSoftare". При необходимости она может быть перемещена или удалена.
            this.installedSoftareTableAdapter.Fill(this.softareAccountingDataSet.InstalledSoftare);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softareAccountingDataSet.Software". При необходимости она может быть перемещена или удалена.
            this.softwareTableAdapter.Fill(this.softareAccountingDataSet.Software);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\nПродолжить сохранение?",
               "Подтвердите сохранение",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    softwareTableAdapter.Update(softareAccountingDataSet.Software);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\nПродолжить сохранение?",
               "Подтвердите сохранение",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    installedSoftareTableAdapter.Update(softareAccountingDataSet.InstalledSoftare);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Software_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }
    }
}
