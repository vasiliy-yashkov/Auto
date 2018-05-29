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
    public partial class Post : Form
    {
        public Post ()
        {
            InitializeComponent();
        }

        private void pOSTBindingNavigatorSaveItem_Click ( object sender, EventArgs e )
        {
            this.Validate();
            this.pOSTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

        }

        private void Post_Load ( object sender, EventArgs e )
        {
            // TODO: This line of code loads data into the 'autoDataSet.POST' table. You can move, or remove it, as needed.
            this.pOSTTableAdapter.Fill(this.autoDataSet.POST);

        }

        private void toolStripButton1_Click ( object sender, EventArgs e )
        {
            this.Validate();
            this.pOSTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

            this.pOSTTableAdapter.Fill(this.autoDataSet.POST);
        }

        private void pOSTDataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Пожалуйста, проверьте корректность введенных данных!",
                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
