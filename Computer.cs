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
    public partial class Computer : Form
    {
        public Computer()
        {
            InitializeComponent();
        }

        private void Computer_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void loadData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softareAccountingDataSet.Processor". При необходимости она может быть перемещена или удалена.
            this.processorTableAdapter.Fill(this.softareAccountingDataSet.Processor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softareAccountingDataSet.HDD". При необходимости она может быть перемещена или удалена.
            this.hDDTableAdapter.Fill(this.softareAccountingDataSet.HDD);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softareAccountingDataSet.Videocard". При необходимости она может быть перемещена или удалена.
            this.videocardTableAdapter.Fill(this.softareAccountingDataSet.Videocard);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softareAccountingDataSet.Software". При необходимости она может быть перемещена или удалена.
            this.softwareTableAdapter.Fill(this.softareAccountingDataSet.Software);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softareAccountingDataSet.InstalledSoftare". При необходимости она может быть перемещена или удалена.
            this.installedSoftareTableAdapter.Fill(this.softareAccountingDataSet.InstalledSoftare);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softareAccountingDataSet.Computer". При необходимости она может быть перемещена или удалена.
            this.computerTableAdapter.Fill(this.softareAccountingDataSet.Computer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softareAccountingDataSet.InstalledSoftare". При необходимости она может быть перемещена или удалена.
            this.installedSoftareTableAdapter.Fill(this.softareAccountingDataSet.InstalledSoftare);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softareAccountingDataSet.Computer". При необходимости она может быть перемещена или удалена.
            this.computerTableAdapter.Fill(this.softareAccountingDataSet.Computer);
        }

        private void Computer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
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
                    computerTableAdapter.Update(softareAccountingDataSet.Computer);
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
    }
}
