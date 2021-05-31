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
    public partial class SoftwareGuide : Form
    {
        public SoftwareGuide()
        {
            InitializeComponent();
        }

        private void SoftwareGuide_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void loadData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softareAccountingDataSet.Software". При необходимости она может быть перемещена или удалена.
            this.softwareTableAdapter.Fill(this.softareAccountingDataSet.Software);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softareAccountingDataSet.Type". При необходимости она может быть перемещена или удалена.
            this.typeTableAdapter.Fill(this.softareAccountingDataSet.Type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softareAccountingDataSet.Producer". При необходимости она может быть перемещена или удалена.
            this.producerTableAdapter.Fill(this.softareAccountingDataSet.Producer);
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void SoftwareGuide_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\nПродолжить сохранение?",
   "Подтвердите сохранение",
   MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    producerTableAdapter.Update(softareAccountingDataSet.Producer);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\nПродолжить сохранение?",
   "Подтвердите сохранение",
   MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    typeTableAdapter.Update(softareAccountingDataSet.Type);
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
                    softwareTableAdapter.Update(softareAccountingDataSet.Software);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
