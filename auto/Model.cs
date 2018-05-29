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
            this.Validate();
            this.mODELBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

        }

        private void Model_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoDataSet.MARK' table. You can move, or remove it, as needed.
            this.mARKTableAdapter.Fill(this.autoDataSet.MARK);
            // TODO: This line of code loads data into the 'autoDataSet.MODEL' table. You can move, or remove it, as needed.
            this.mODELTableAdapter.Fill(this.autoDataSet.MODEL);

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
