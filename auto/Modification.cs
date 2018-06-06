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
    public partial class Modification : Form
    {
        public Modification ()
        {
            InitializeComponent();
        }

        private void mODIFICATIONBindingNavigatorSaveItem_Click (object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.mODIFICATIONBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.autoDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! Возможно " +
                    "присутствуют дублирующиеся значения, или попытка удаления использующейся записи. \n" + ex.Message,
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Modification_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoDataSet.MODIFICATION' table. You can move, or remove it, as needed.
            this.mODIFICATIONTableAdapter.Fill(this.autoDataSet.MODIFICATION);

        }

        private void toolStripButton1_Click (object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.mODIFICATIONBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.autoDataSet);

                this.mODIFICATIONTableAdapter.Fill(this.autoDataSet.MODIFICATION);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! Возможно " +
                    "присутствуют дублирующиеся значения, или попытка удаления использующейся записи. \n" + ex.Message,
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mODIFICATIONDataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Пожалуйста, проверьте корректность введенных данных!",
                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void mODIFICATIONDataGridView_CellEndEdit (object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Object value = mODIFICATIONDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value != null && !String.IsNullOrEmpty(value.ToString()))
                {
                    try
                    {
                        decimal d = decimal.Parse(value.ToString());
                        if (d == 0 || d < 0)
                        {
                            MessageBox.Show("Цена не может быть равной 0!",
                                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            mODIFICATIONDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                            return;
                        }
                        mODIFICATIONDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = d.ToString();
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
    }
}
