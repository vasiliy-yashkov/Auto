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
    }
}
