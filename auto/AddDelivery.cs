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
    public partial class AddDelivery : Form
    {
        private autoDataSetTableAdapters.DELIVERYTableAdapter deliveryAdapter;
        private autoDataSetTableAdapters.AUTO_COUNTTableAdapter autoCount;

        private bool edit = false;
        private long deliveryID;
        private long providerID;
        private long autoID;
        private DateTime date;
        private Decimal price;

        public AddDelivery ()
        {
            InitializeComponent();

            deliveryAdapter = new autoDataSetTableAdapters.DELIVERYTableAdapter();
            deliveryAdapter.ClearBeforeFill = true;
            deliveryAdapter.Fill(autoDataSet.DELIVERY);
            
            autoCount = new autoDataSetTableAdapters.AUTO_COUNTTableAdapter();
            autoCount.ClearBeforeFill = true;
            autoCount.Fill(autoDataSet.AUTO_COUNT);
        }

        public AddDelivery (long deliveryID, long providerID, long autoID,
            DateTime date, Decimal price)
        {
            InitializeComponent();

            deliveryAdapter = new autoDataSetTableAdapters.DELIVERYTableAdapter();
            deliveryAdapter.ClearBeforeFill = true;
            deliveryAdapter.Fill(autoDataSet.DELIVERY);

            this.edit = true;
            this.deliveryID = deliveryID;
            this.providerID = providerID;
            this.autoID = autoID;
            this.date = date;
            this.price = price;
        }

        private void AddDelivery_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoDataSet.AUTO' table. You can move, or remove it, as needed.
            this.aUTOTableAdapter.Fill(this.autoDataSet.AUTO);
            // TODO: This line of code loads data into the 'autoDataSet.PROVIDER' table. You can move, or remove it, as needed.
            this.pROVIDERTableAdapter.Fill(this.autoDataSet.PROVIDER);

            if (edit)
            {
                cmbProvider.SelectedValue = providerID;
                cmbAuto.SelectedValue = autoID;
                dateTimePicker1.Value = date;
                txtPrice.Text = price.ToString();
            }
        }

        private void cmbOk_Click (object sender, EventArgs e)
        {
            if (!edit)
            {
                try
                {
                    if (String.IsNullOrEmpty(txtPrice.Text))
                    {
                        MessageBox.Show("Пожалуйста, заполните все поля!",
                        "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        deliveryAdapter.Insert((int)(long)cmbProvider.SelectedValue, (int)(long)cmbAuto.SelectedValue,
                            dateTimePicker1.Value, Decimal.Parse(txtPrice.Text));
                        object count = autoCount.GetAutoCount((int)(long)cmbAuto.SelectedValue);
                        if (count == null)
                        {
                            autoCount.Insert((int)(long)cmbAuto.SelectedValue, 1);
                        }
                        else
                        {
                            int cnt = (int)count;
                            autoCount.UpdateAutoCount(++cnt, (int)(long)cmbAuto.SelectedValue);
                        }
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! \n" + ex.Message,
                    "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    if (String.IsNullOrEmpty(txtPrice.Text))
                    {
                        MessageBox.Show("Пожалуйста, заполните все поля!",
                        "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        deliveryAdapter.Update((int)(long)cmbProvider.SelectedValue, (int)(long)cmbAuto.SelectedValue,
                        dateTimePicker1.Value, Decimal.Parse(txtPrice.Text),
                        (int)deliveryID);
                        this.Close();
                    }
                }
                catch (Exception /*ex*/)
                {
                    MessageBox.Show("Пожалуйста, проверьте корректность введенных данных!",
                    "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cmbCancel_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbProvider_SelectedIndexChanged (object sender, EventArgs e)
        {
            ComboBox cbo = (sender as ComboBox);
            if (cbo.SelectedIndex > -1)
            {
                this.aUTOTableAdapter.FillByMarkName(this.autoDataSet.AUTO, cbo.Text);
            }
        }

        private void cmbProvider_SelectedValueChanged (object sender, EventArgs e)
        {
            ComboBox cbo = (sender as ComboBox);
            if (cbo.SelectedValue != null)
            {
                this.aUTOTableAdapter.FillByMarkName(this.autoDataSet.AUTO, cbo.Text);
            }
        }

        private void txtPrice_KeyPress (object sender, KeyPressEventArgs e)
        {
            // запрет на ввод букв
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_TextChanged (object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (!String.IsNullOrEmpty(txtPrice.Text))
            {
                try
                {
                    decimal d = decimal.Parse(txtPrice.Text);
                    if (d == 0)
                    {
                        MessageBox.Show("Цена не может быть меньше или равна 0!",
                            "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPrice.Text = "";
                        return;
                    }
                    txtPrice.Text = d.ToString();
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
