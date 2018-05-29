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
    public partial class SubjectInfo : Form
    {
        public SubjectInfo ()
        {
            InitializeComponent();
        }

        private void SubjectInfo_Load ( object sender, EventArgs e )
        {
            // TODO: This line of code loads data into the 'autoDataSet.PERSON' table. You can move, or remove it, as needed.
            this.pERSONTableAdapter.Fill(this.autoDataSet.PERSON);
            // TODO: This line of code loads data into the 'autoDataSet.PERSON_INFO' table. You can move, or remove it, as needed.
            this.pERSON_INFOTableAdapter.Fill(this.autoDataSet.PERSON_INFO);

            updateComboboxes();

        }

        private void pERSON_INFOBindingNavigatorSaveItem_Click ( object sender, EventArgs e )
        {
            this.Validate();
            this.pERSON_INFOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

        }

        private void toolStripButton1_Click ( object sender, EventArgs e )
        {
            this.Validate();
            this.pERSON_INFOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

            this.pERSON_INFOTableAdapter.Fill(this.autoDataSet.PERSON_INFO);

            updateComboboxes();
        }

        private void pERSON_INFODataGridView_CellEndEdit ( object sender, DataGridViewCellEventArgs e )
        {
            Object obj = pERSON_INFODataGridView.Rows[e.RowIndex].Cells[1].Value;
            if (obj != null)
                pERSON_INFODataGridView.Rows[e.RowIndex].Cells[4].Value = obj;
        }

        private void updateComboboxes ()
        {
            foreach (DataGridViewRow row in pERSON_INFODataGridView.Rows)
            {
                if (row.Cells[4].Value != null)
                    ((DataGridViewComboBoxCell)row.Cells["PERSON_FULL"]).Value = row.Cells[4].Value;
            }
        }

        private void pERSON_INFODataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Пожалуйста, проверьте корректность введенных данных!",
                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
