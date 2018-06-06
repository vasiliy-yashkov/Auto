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
    public partial class Engine : Form
    {
        public Engine ()
        {
            InitializeComponent();

        }

        private void eNGINEBindingNavigatorSaveItem_Click (object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.eNGINEBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.autoDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! Возможно " +
                    "присутствуют дублирующиеся значения, или попытка удаления использующейся записи. \n" + ex.Message,
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Engine_Load (object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'autoDataSet.ENGINE' table. You can move, or remove it, as needed.
                this.eNGINETableAdapter.Fill(this.autoDataSet.ENGINE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! Возможно " +
                    "присутствуют дублирующиеся значения, или попытка удаления использующейся записи. \n" + ex.Message,
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click (object sender, EventArgs e)
        {
            this.Validate();
            this.eNGINEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

            Engine_Load(sender, e);
        }

        private void eNGINEDataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Пожалуйста, проверьте корректность введенных данных!",
                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void eNGINEDataGridView_CellEndEdit (object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) {
                Object value = eNGINEDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value != null && !String.IsNullOrEmpty(value.ToString()))
                {
                    try
                    {
                        decimal d = decimal.Parse(value.ToString());
                        if (d == 0 || d < 0)
                        {
                            MessageBox.Show("Цена не может быть равной 0!",
                                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            eNGINEDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "1";
                            return;
                        }
                        eNGINEDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = d.ToString();
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
    }
}
