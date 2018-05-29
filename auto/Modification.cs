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
    public partial class Modification : Form
    {
        public Modification ()
        {
            InitializeComponent();
        }

        private void mODIFICATIONBindingNavigatorSaveItem_Click ( object sender, EventArgs e )
        {
            this.Validate();
            this.mODIFICATIONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

        }

        private void Modification_Load ( object sender, EventArgs e )
        {
            // TODO: This line of code loads data into the 'autoDataSet.MODIFICATION' table. You can move, or remove it, as needed.
            this.mODIFICATIONTableAdapter.Fill(this.autoDataSet.MODIFICATION);

        }

        private void toolStripButton1_Click ( object sender, EventArgs e )
        {
            this.Validate();
            this.mODIFICATIONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

            this.mODIFICATIONTableAdapter.Fill(this.autoDataSet.MODIFICATION);
        }

        private void mODIFICATIONDataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Пожалуйста, проверьте корректность введенных данных!",
                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
