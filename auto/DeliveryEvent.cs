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
    public partial class DeliveryEvent : Form
    {
        private autoDataSetTableAdapters.DELIVERYTableAdapter deliveryAdapter;

        public DeliveryEvent ()
        {
            InitializeComponent();

            deliveryAdapter = new autoDataSetTableAdapters.DELIVERYTableAdapter();
            deliveryAdapter.ClearBeforeFill = true;
            deliveryAdapter.Fill(autoDataSet.DELIVERY);
        }

        private void DeliveryEvent_Load (object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'autoDataSet.V_DELIVERY_TABLE' table. You can move, or remove it, as needed.
                this.v_DELIVERY_TABLETableAdapter.Fill(this.autoDataSet.V_DELIVERY_TABLE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! Возможно " +
                    "присутствуют дублирующиеся значения, или попытка удаления использующейся записи. \n" + ex.Message,
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void v_DELIVERY_TABLEDataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Пожалуйста, проверьте корректность введенных данных!",
                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tsbSave_Click (object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.v_DELIVERY_TABLEBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.autoDataSet);
                DeliveryEvent_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! Возможно " +
                    "присутствуют дублирующиеся значения, или попытка удаления использующейся записи. \n" + ex.Message,
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbUpdate_Click (object sender, EventArgs e)
        {
            tsbSave_Click(sender, e);
        }

        private void tsbAdd_Click (object sender, EventArgs e)
        {
            AddDelivery addDelivery = new AddDelivery();
            addDelivery.ShowDialog();
            tsbSave_Click(sender, e);
        }

        private void tsbEdit_Click (object sender, EventArgs e)
        {
            if (v_DELIVERY_TABLEDataGridView.CurrentRow != null)
            {
                DataGridViewRow row = v_DELIVERY_TABLEDataGridView.CurrentRow;
                long deliveryID = (long)row.Cells[0].Value;
                long providerID = (long)row.Cells[1].Value;
                long autoID = (long)row.Cells[2].Value;
                AddDelivery addDelivery = new AddDelivery(deliveryID,
                    providerID,
                    autoID,
                    (DateTime)row.Cells[7].Value,
                    (Decimal)row.Cells[8].Value);
                addDelivery.Text = "Редактирование поставки автомобиля";
                addDelivery.ShowDialog();
                tsbSave_Click(sender, e);
            }
        }

        private void tsbDelete_Click (object sender, EventArgs e)
        {
            if (v_DELIVERY_TABLEDataGridView.CurrentRow != null)
            {
                try
                {
                    DataGridViewRow row = v_DELIVERY_TABLEDataGridView.CurrentRow;
                    deliveryAdapter.Delete((int)(long)row.Cells[0].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Невозможно удалить запись!\n" + ex.Message,
                    "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                tsbSave_Click(sender, e);
            }
        }
    }
}
