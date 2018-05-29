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
    public partial class Employee : Form
    {
        public Employee ()
        {
            InitializeComponent();

            updateComboboxes();
        }

        private void eMPLOYEEBindingNavigatorSaveItem_Click ( object sender, EventArgs e )
        {
            try
            {
                this.Validate();
                this.eMPLOYEEBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.autoDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! Возможно, " +
                    "одна есть дубликаты записей",
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Employee_Load ( object sender, EventArgs e )
        {
            // TODO: This line of code loads data into the 'autoDataSet.POST' table. You can move, or remove it, as needed.
            this.pOSTTableAdapter.Fill(this.autoDataSet.POST);
            // TODO: This line of code loads data into the 'autoDataSet.PERSON' table. You can move, or remove it, as needed.
            this.pERSONTableAdapter.Fill(this.autoDataSet.PERSON);
            // TODO: This line of code loads data into the 'autoDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.autoDataSet.EMPLOYEE);

            updateComboboxes();

        }

        private void toolStripButton1_Click ( object sender, EventArgs e )
        {
            this.Validate();
            this.eMPLOYEEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

            this.eMPLOYEETableAdapter.Fill(this.autoDataSet.EMPLOYEE);
        }

        private void updateComboboxes ()
        {
            foreach (DataGridViewRow row in eMPLOYEEDataGridView.Rows)
            {
                if (row.Cells[2].Value != null)
                    ((DataGridViewComboBoxCell)row.Cells["PERSON_FULL"]).Value = row.Cells[1].Value;
                if (row.Cells[2].Value != null)
                    ((DataGridViewComboBoxCell)row.Cells["POST"]).Value = row.Cells[6].Value;
            }
        }

        private void eMPLOYEEDataGridView_CellEndEdit ( object sender, DataGridViewCellEventArgs e )
        {
            Object obj = eMPLOYEEDataGridView.Rows[e.RowIndex].Cells[2].Value;
            if (obj != null)
                eMPLOYEEDataGridView.Rows[e.RowIndex].Cells[1].Value = obj;

            obj = eMPLOYEEDataGridView.Rows[e.RowIndex].Cells[3].Value;
            if (obj != null)
                eMPLOYEEDataGridView.Rows[e.RowIndex].Cells[6].Value = obj;
        }

        private void eMPLOYEEDataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Пожалуйста, проверьте корректность введенных данных!",
                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
