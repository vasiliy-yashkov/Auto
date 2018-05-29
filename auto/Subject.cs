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
    public partial class Subject : Form
    {
        public Subject ()
        {
            InitializeComponent();
        }

        private void pERSONBindingNavigatorSaveItem_Click ( object sender, EventArgs e )
        {
            this.Validate();
            this.pERSONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

        }

        private void Subject_Load ( object sender, EventArgs e )
        {
            // TODO: This line of code loads data into the 'autoDataSet.PERSON' table. You can move, or remove it, as needed.
            this.pERSONTableAdapter.Fill(this.autoDataSet.PERSON);

        }

        private void toolStripButton1_Click ( object sender, EventArgs e )
        {
            this.Validate();
            this.pERSONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

            this.pERSONTableAdapter.Fill(this.autoDataSet.PERSON);
        }

        private void pERSONDataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Пожалуйста, проверьте корректность введенных данных!",
                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}