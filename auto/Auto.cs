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
    public partial class Auto : Form
    {
        public Auto ()
        {
            InitializeComponent();
        }

        private void aUTOBindingNavigatorSaveItem_Click (object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.aUTOBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.autoDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! Возможно " +
                    "присутствуют дублирующиеся значения, или попытка удаления использующейся записи. \n" + ex.Message,
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

        private void Auto_Load (object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'autoDataSet.V_AUTO' table. You can move, or remove it, as needed.
                this.v_AUTOTableAdapter.Fill(this.autoDataSet.V_AUTO);
                // TODO: This line of code loads data into the 'autoDataSet.MARK' table. You can move, or remove it, as needed.
                this.mARKTableAdapter.Fill(this.autoDataSet.MARK);
                // TODO: This line of code loads data into the 'autoDataSet.ENGINE' table. You can move, or remove it, as needed.
                this.eNGINETableAdapter.Fill(this.autoDataSet.ENGINE);
                // TODO: This line of code loads data into the 'autoDataSet.MODIFICATION' table. You can move, or remove it, as needed.
                this.mODIFICATIONTableAdapter.Fill(this.autoDataSet.MODIFICATION);
                // TODO: This line of code loads data into the 'autoDataSet.MODEL' table. You can move, or remove it, as needed.
                this.mODELTableAdapter.Fill(this.autoDataSet.MODEL);
                // TODO: This line of code loads data into the 'autoDataSet.AUTO' table. You can move, or remove it, as needed.
                this.aUTOTableAdapter.Fill(this.autoDataSet.AUTO);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! Возможно " +
                    "присутствуют дублирующиеся значения, или попытка удаления использующейся записи. \n" + ex.Message,
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //updateComboboxes();
        }

        private void updateComboboxes ()
        {
            /*            foreach (DataGridViewRow row in aUTODataGridView.Rows)
                        {
                            if (row.Cells[3].Value != null)
                                ((DataGridViewComboBoxCell)row.Cells["MODEL"]).Value = row.Cells[1].Value;
                            if (row.Cells[3].Value != null)
                                ((DataGridViewComboBoxCell)row.Cells["MOD"]).Value = row.Cells[4].Value;
                            if (row.Cells[3].Value != null)
                                ((DataGridViewComboBoxCell)row.Cells["ENGINE"]).Value = row.Cells[6].Value;
                            if (row.Cells[3].Value != null)
                                ((DataGridViewComboBoxCell)row.Cells["STATUS"]).Value = row.Cells[9].Value;
                            if (row.Cells[3].Value != null)
                            {
                                DataGridViewComboBoxCell cell = ((DataGridViewComboBoxCell)row.Cells["MODEL"]);
                                BindingSource bs = cell.DataSource as BindingSource;              
                                autoDataSet.MODELRow modelRow = (bs.Current as DataRowView).Row as autoDataSet.MODELRow;

                                DataGridViewComboBoxCell markCell = ((DataGridViewComboBoxCell)row.Cells["Mark"]);
                                BindingSource markBs = markCell.DataSource as BindingSource;

                                //autoDataSet.MODELRow modelRow = (bs.Current as DataRowView).Row as autoDataSet.MODELRow;
                                ((DataGridViewComboBoxCell)row.Cells["MARK"]).Value = mODELTableAdapter.GetMarkID((long)((DataGridViewComboBoxCell)row.Cells["MODEL"]).Value);

                            }
                        }*/
        }

        private void toolStripButton1_Click (object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.aUTOBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.autoDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! Возможно " +
                    "присутствуют дублирующиеся значения, или попытка удаления использующейся записи. \n" + ex.Message,
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Auto_Load(sender, e);
        }

        private void aUTODataGridView_CellEndEdit (object sender, DataGridViewCellEventArgs e)
        {
            /*            Object obj = aUTODataGridView.Rows[e.RowIndex].Cells[3].Value;
                        if (obj != null)
                            aUTODataGridView.Rows[e.RowIndex].Cells[1].Value = obj;
                        obj = aUTODataGridView.Rows[e.RowIndex].Cells[5].Value;
                        if (obj != null)
                            aUTODataGridView.Rows[e.RowIndex].Cells[4].Value = obj;
                        obj = aUTODataGridView.Rows[e.RowIndex].Cells[7].Value;
                        if (obj != null)
                            aUTODataGridView.Rows[e.RowIndex].Cells[6].Value = obj;
                        obj = aUTODataGridView.Rows[e.RowIndex].Cells[10].Value;
                        if (obj != null)
                            aUTODataGridView.Rows[e.RowIndex].Cells[9].Value = obj;       
                        obj = aUTODataGridView.Rows[e.RowIndex].Cells[2].Value;
                        if (obj != null)
                        {
                            DataGridViewComboBoxCell cell = ((DataGridViewComboBoxCell)aUTODataGridView.Rows[e.RowIndex].Cells["MODEL"]);
                            BindingSource bs = cell.DataSource as BindingSource;
                            bs.Filter = "MARK_ID = " + obj;
                            //mODELTableAdapter.FillByMarkID(this.autoDataSet.MODEL, (int)((long)obj));
                            //aUTODataGridView.Rows[e.RowIndex].Cells[9].Value = obj;
                        } */
        }

        private void aUTODataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void aUTODataGridView_DataBindingComplete (object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset)
                updateComboboxes();
        }

        private void tsbAdd_Click (object sender, EventArgs e)
        {
            AddAuto addAuto = new AddAuto();
            addAuto.ShowDialog();
            aUTOBindingNavigatorSaveItem_Click(sender, e);
            toolStripButton1_Click(sender, e);
        }

        private void tsbEdit_Click (object sender, EventArgs e)
        {
            if (v_AUTODataGridView.CurrentRow != null)
            {
                DataGridViewRow row = v_AUTODataGridView.CurrentRow;
                long mark = (long)mODELTableAdapter.GetMarkID((long)row.Cells[1].Value);
                AddAuto addAuto = new AddAuto((long)row.Cells[0].Value,
                    row.Cells[7].Value.ToString(),
                    (long)row.Cells[2].Value,
                    mark,
                    (long)row.Cells[1].Value,
                    (long)row.Cells[3].Value,
                    row.Cells[14].Value.ToString());
                addAuto.Text = "Редактирование автомобиля";
                addAuto.ShowDialog();
                aUTOBindingNavigatorSaveItem_Click(sender, e);
                toolStripButton1_Click(sender, e);
            }
        }

        private void tsbDelete_Click (object sender, EventArgs e)
        {
            if (v_AUTODataGridView.CurrentRow != null)
            {
                try
                {
                    DataGridViewRow row = v_AUTODataGridView.CurrentRow;
                    aUTOTableAdapter.Delete((int)(long)row.Cells[0].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Невозможно удалить запись!\n" + ex.Message,
                    "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                aUTOBindingNavigatorSaveItem_Click(sender, e);
                toolStripButton1_Click(sender, e);
            }
        }
    }
}
