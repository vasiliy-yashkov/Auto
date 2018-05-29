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
    public partial class Provider : Form
    {
        public Provider ()
        {
            InitializeComponent();
        }

        private void pROVIDERBindingNavigatorSaveItem_Click ( object sender, EventArgs e )
        {
            this.Validate();
            this.pROVIDERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

        }

        private void Provider_Load ( object sender, EventArgs e )
        {
            // TODO: This line of code loads data into the 'autoDataSet.PROVIDER' table. You can move, or remove it, as needed.
            this.pROVIDERTableAdapter.Fill(this.autoDataSet.PROVIDER);

        }

        private void toolStripButton1_Click ( object sender, EventArgs e )
        {
            this.Validate();
            this.pROVIDERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

            this.pROVIDERTableAdapter.Fill(this.autoDataSet.PROVIDER);
        }

        private void pROVIDERDataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Пожалуйста, проверьте корректность введенных данных!",
                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
