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
    public partial class DeliveryEvent : Form
    {
        public DeliveryEvent ()
        {
            InitializeComponent();
        }

        private void dELIVERYBindingNavigatorSaveItem_Click ( object sender, EventArgs e )
        {
            this.Validate();
            this.dELIVERYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

        }

        private void DeliveryEvent_Load ( object sender, EventArgs e )
        {
            // TODO: This line of code loads data into the 'autoDataSet.AUTO' table. You can move, or remove it, as needed.
            this.aUTOTableAdapter.Fill(this.autoDataSet.AUTO);
            // TODO: This line of code loads data into the 'autoDataSet.PROVIDER' table. You can move, or remove it, as needed.
            this.pROVIDERTableAdapter.Fill(this.autoDataSet.PROVIDER);
            // TODO: This line of code loads data into the 'autoDataSet.DELIVERY' table. You can move, or remove it, as needed.
            this.dELIVERYTableAdapter.Fill(this.autoDataSet.DELIVERY);

        }

        private void toolStripButton1_Click ( object sender, EventArgs e )
        {
            this.Validate();
            this.dELIVERYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

            this.dELIVERYTableAdapter.Fill(this.autoDataSet.DELIVERY);
        }

        private void updateComboboxes ()
        {
            foreach (DataGridViewRow row in dELIVERYDataGridView.Rows)
            {
                if (row.Cells[2].Value != null)
                    ((DataGridViewComboBoxCell)row.Cells["PROVIDER"]).Value = row.Cells[1].Value;
                if (row.Cells[2].Value != null)
                    ((DataGridViewComboBoxCell)row.Cells["AUTO"]).Value = row.Cells[2].Value;
            }
        }

        private void dELIVERYDataGridView_CellEndEdit ( object sender, DataGridViewCellEventArgs e )
        {
            Object obj = dELIVERYDataGridView.Rows[e.RowIndex].Cells[3].Value;
            if (obj != null)
                dELIVERYDataGridView.Rows[e.RowIndex].Cells[1].Value = obj;

            obj = dELIVERYDataGridView.Rows[e.RowIndex].Cells[4].Value;
            if (obj != null)
                dELIVERYDataGridView.Rows[e.RowIndex].Cells[2].Value = obj;
        }

        private void dELIVERYDataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Пожалуйста, проверьте корректность введенных данных!",
                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
