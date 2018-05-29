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
    public partial class Mark : Form
    {
        public Mark ()
        {
            InitializeComponent();
        }

        private void mARKBindingNavigatorSaveItem_Click (object sender, EventArgs e)
        {
            this.Validate();
            this.mARKBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

        }

        private void Mark_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoDataSet.MARK' table. You can move, or remove it, as needed.
            this.mARKTableAdapter.Fill(this.autoDataSet.MARK);

        }

        private void mARKDataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Пожалуйста, проверьте корректность введенных данных!",
                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
