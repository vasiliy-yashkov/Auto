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
    public partial class Model : Form
    {
        public Model ()
        {
            InitializeComponent();
        }

        private void mODELBindingNavigatorSaveItem_Click (object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.mODELBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.autoDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! Возможно " +
                    "присутствуют дублирующиеся значения, или попытка удаления использующейся записи. \n" + ex.Message,
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Model_Load (object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'autoDataSet.MARK' table. You can move, or remove it, as needed.
                this.mARKTableAdapter.Fill(this.autoDataSet.MARK);
                // TODO: This line of code loads data into the 'autoDataSet.MODEL' table. You can move, or remove it, as needed.
                this.mODELTableAdapter.Fill(this.autoDataSet.MODEL);
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
            foreach (DataGridViewRow row in mODELDataGridView.Rows)
            {
                if (row.Cells[2].Value != null)
                    ((DataGridViewComboBoxCell)row.Cells["MARK"]).Value = row.Cells[1].Value;
            }
        }

        private void mODELDataGridView_CellEndEdit (object sender, DataGridViewCellEventArgs e)
        {
            Object obj = mODELDataGridView.Rows[e.RowIndex].Cells[2].Value;
            if (obj != null)
                mODELDataGridView.Rows[e.RowIndex].Cells[1].Value = obj;
            if (e.ColumnIndex == 4)
            {
                Object value = mODELDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value != null && !String.IsNullOrEmpty(value.ToString()))
                {
                    try
                    {
                        decimal d = decimal.Parse(value.ToString());
                        if (d == 0 || d < 0)
                        {
                            MessageBox.Show("Цена не может быть равной 0!",
                                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            mODELDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                            return;
                        }
                        mODELDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = d.ToString();
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void toolStripButton1_Click (object sender, EventArgs e)
        {
            this.Validate();
            this.mODELBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

            Model_Load(sender, e);
        }

        private void mODELDataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Пожалуйста, проверьте корректность введенных данных!",
                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
