﻿using System;
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
    public partial class Pay : Form
    {
        public Pay ()
        {
            InitializeComponent();
        }

        private void pAYBindingNavigatorSaveItem_Click (object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pAYBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.autoDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! Возможно " +
                    "присутствуют дублирующиеся значения, или попытка удаления использующейся записи. \n" + ex.Message,
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pay_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoDataSet.PAY' table. You can move, or remove it, as needed.
            this.pAYTableAdapter.Fill(this.autoDataSet.PAY);

        }

        private void toolStripButton1_Click (object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pAYBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.autoDataSet);

                this.pAYTableAdapter.Fill(this.autoDataSet.PAY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! Возможно " +
                    "присутствуют дублирующиеся значения, или попытка удаления использующейся записи. \n" + ex.Message,
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pAYDataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Пожалуйста, проверьте корректность введенных данных!",
                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
