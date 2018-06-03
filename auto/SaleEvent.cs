using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto
{
    public partial class SaleEvent : Form
    {
        public SaleEvent ()
        {
            InitializeComponent();

            updateComboboxes();
        }

        private void sALEBindingNavigatorSaveItem_Click (object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.sALEBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.autoDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! Возможно " +
                    "присутствуют дублирующиеся значения, или попытка удаления использующейся записи. \n" + ex.Message,
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataGridViewRow row in sALEDataGridView.Rows)
            {
                Object obj = row.Cells[2].Value;
                if (obj != null)
                    this.tableAdapterManager.AUTOTableAdapter.UpdateQueryNotAvailable(Int32.Parse(obj.ToString()));
            }

            updateComboboxes();

        }

        private void SaleEvent_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoDataSet.PAY' table. You can move, or remove it, as needed.
            this.pAYTableAdapter.Fill(this.autoDataSet.PAY);
            // TODO: This line of code loads data into the 'autoDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.autoDataSet.EMPLOYEE);
            // TODO: This line of code loads data into the 'autoDataSet.AUTO' table. You can move, or remove it, as needed.
            this.aUTOTableAdapter.FillByStock(this.autoDataSet.AUTO);
            // TODO: This line of code loads data into the 'autoDataSet.PERSON' table. You can move, or remove it, as needed.
            this.pERSONTableAdapter.Fill(this.autoDataSet.PERSON);
            // TODO: This line of code loads data into the 'autoDataSet.SALE' table. You can move, or remove it, as needed.
            this.sALETableAdapter.Fill(this.autoDataSet.SALE);

        }

        private void toolStripButton1_Click (object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.sALEBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.autoDataSet);

                this.sALETableAdapter.Fill(this.autoDataSet.SALE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! Возможно " +
                    "присутствуют дублирующиеся значения, или попытка удаления использующейся записи. \n" + ex.Message,
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            updateComboboxes();
        }

        private void updateComboboxes ()
        {
            foreach (DataGridViewRow row in sALEDataGridView.Rows)
            {
                if (row.Cells[2].Value != null)
                    ((DataGridViewComboBoxCell)row.Cells["PERSON"]).Value = row.Cells[1].Value;
                if (row.Cells[2].Value != null)
                    ((DataGridViewComboBoxCell)row.Cells["AUTO"]).Value = row.Cells[2].Value;
                if (row.Cells[2].Value != null)
                    ((DataGridViewComboBoxCell)row.Cells["EMPLOYEE"]).Value = row.Cells[3].Value;
                if (row.Cells[2].Value != null)
                    ((DataGridViewComboBoxCell)row.Cells["PAY"]).Value = row.Cells[4].Value;
            }
        }

        private void sALEDataGridView_CellEndEdit (object sender, DataGridViewCellEventArgs e)
        {
            Object obj = sALEDataGridView.Rows[e.RowIndex].Cells[5].Value;
            if (obj != null)
                sALEDataGridView.Rows[e.RowIndex].Cells[1].Value = obj;

            obj = sALEDataGridView.Rows[e.RowIndex].Cells[6].Value;
            if (obj != null)
                sALEDataGridView.Rows[e.RowIndex].Cells[2].Value = obj;

            obj = sALEDataGridView.Rows[e.RowIndex].Cells[7].Value;
            if (obj != null)
                sALEDataGridView.Rows[e.RowIndex].Cells[3].Value = obj;

            obj = sALEDataGridView.Rows[e.RowIndex].Cells[8].Value;
            if (obj != null)
                sALEDataGridView.Rows[e.RowIndex].Cells[4].Value = obj;
        }

        private void sALEDataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Пожалуйста, проверьте корректность введенных данных!",
                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
