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
    public partial class AutoStatus : Form
    {
        public AutoStatus ()
        {
            InitializeComponent();
        }

        private void sTATUSBindingNavigatorSaveItem_Click ( object sender, EventArgs e )
        {
            this.Validate();
            this.sTATUSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

        }

        private void AutoStatus_Load ( object sender, EventArgs e )
        {
            // TODO: This line of code loads data into the 'autoDataSet.STATUS' table. You can move, or remove it, as needed.
            this.sTATUSTableAdapter.Fill(this.autoDataSet.STATUS);

        }

        private void toolStripButton1_Click ( object sender, EventArgs e )
        {
            this.Validate();
            this.sTATUSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

            this.sTATUSTableAdapter.Fill(this.autoDataSet.STATUS);
        }

        private void sTATUSDataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Пожалуйста, проверьте корректность введенных данных!",
                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}