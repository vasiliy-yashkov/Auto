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
    public partial class Client : Form
    {
        public Client ()
        {
            InitializeComponent();
        }

        private void cLIENTBindingNavigatorSaveItem_Click ( object sender, EventArgs e )
        {
            this.Validate();
            this.cLIENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

        }

        private void Client_Load ( object sender, EventArgs e )
        {
            // TODO: This line of code loads data into the 'autoDataSet.AUTO' table. You can move, or remove it, as needed.
            this.aUTOTableAdapter.Fill(this.autoDataSet.AUTO);
            // TODO: This line of code loads data into the 'autoDataSet.PERSON' table. You can move, or remove it, as needed.
            this.pERSONTableAdapter.Fill(this.autoDataSet.PERSON);
            // TODO: This line of code loads data into the 'autoDataSet.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.autoDataSet.CLIENT);

        }

        private void toolStripButton1_Click ( object sender, EventArgs e )
        {
            this.Validate();
            this.cLIENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

            this.cLIENTTableAdapter.Fill(this.autoDataSet.CLIENT);
        }

        private void updateComboboxes ()
        {
            foreach (DataGridViewRow row in cLIENTDataGridView.Rows)
            {
                if (row.Cells[2].Value != null)
                    ((DataGridViewComboBoxCell)row.Cells["PERSON"]).Value = row.Cells[1].Value;
                if (row.Cells[2].Value != null)
                    ((DataGridViewComboBoxCell)row.Cells["AUTO"]).Value = row.Cells[2].Value;
            }
        }

        private void cLIENTDataGridView_CellEndEdit ( object sender, DataGridViewCellEventArgs e )
        {
            Object obj = cLIENTDataGridView.Rows[e.RowIndex].Cells[1].Value;
            if (obj != null)
                cLIENTDataGridView.Rows[e.RowIndex].Cells[1].Value = obj;

            obj = cLIENTDataGridView.Rows[e.RowIndex].Cells[4].Value;
            if (obj != null)
                cLIENTDataGridView.Rows[e.RowIndex].Cells[2].Value = obj;
        }
    }
}
