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
    public partial class AddAuto : Form
    {
        private autoDataSetTableAdapters.AUTOTableAdapter autoAdapter;
        private bool edit = false;
        private long autoID;
        //private string color;
        //private long modID;
        private long markID;
        private long modelID;
        private long engineID;
        //private string vin;
        //private decimal price;

        public AddAuto ()
        {
            InitializeComponent();
            autoAdapter = new autoDataSetTableAdapters.AUTOTableAdapter();
            autoAdapter.ClearBeforeFill = true;
            autoAdapter.Fill(this.autoDataSet.AUTO);
        }

        public AddAuto (long autoID, string color, long modID,
            long markID, long modelID, long engineID, string vin)
        {
            InitializeComponent();
            autoAdapter = new autoDataSetTableAdapters.AUTOTableAdapter();
            autoAdapter.ClearBeforeFill = true;
            autoAdapter.Fill(this.autoDataSet.AUTO);

            edit = true;
            this.autoID = autoID;
            txtColor.Text = color;
            txtVIN.Text = vin;
            this.markID = markID;
            this.modelID = modelID;
            this.engineID = engineID;
        }

        private void AddAuto_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoDataSet.ENGINE' table. You can move, or remove it, as needed.
            this.eNGINETableAdapter.Fill(this.autoDataSet.ENGINE);
            // TODO: This line of code loads data into the 'autoDataSet.MODIFICATION' table. You can move, or remove it, as needed.
            this.mODIFICATIONTableAdapter.Fill(this.autoDataSet.MODIFICATION);
            // TODO: This line of code loads data into the 'autoDataSet.MODEL' table. You can move, or remove it, as needed.
            this.mODELTableAdapter.Fill(this.autoDataSet.MODEL);
            // TODO: This line of code loads data into the 'autoDataSet.MODEL' table. You can move, or remove it, as needed.
            this.mODELTableAdapter.Fill(this.autoDataSet.MODEL);
            // TODO: This line of code loads data into the 'autoDataSet.MARK' table. You can move, or remove it, as needed.
            this.mARKTableAdapter.Fill(this.autoDataSet.MARK);

            if (edit)
            {
                cmbMark.SelectedValue = markID;
                cmbModel.SelectedValue = modelID;
                cmbEngine.SelectedValue = engineID;
            }
        }

        private void btnOK_Click (object sender, EventArgs e)
        {
            if (!edit)
            {
                try
                {
                    if (String.IsNullOrEmpty(txtColor.Text))
                    {
                        MessageBox.Show("Пожалуйста, заполните все поля!",
                        "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    autoAdapter.Insert(txtColor.Text, (int)(long)cmbMod.SelectedValue, txtVIN.Text,
                        (int)(long)cmbModel.SelectedValue, (int)(long)cmbEngine.SelectedValue);
                    this.Close();
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
                    if (String.IsNullOrEmpty(txtColor.Text))
                    {
                        MessageBox.Show("Пожалуйста, заполните все поля!",
                        "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    autoAdapter.Update(txtColor.Text, (int)(long)cmbMod.SelectedValue,
                    txtVIN.Text, (int)(long)cmbModel.SelectedValue, (int)(long)cmbEngine.SelectedValue,
                    (int)autoID);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! \n" + ex.Message,
                    "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cmbMark_SelectedIndexChanged (object sender, EventArgs e)
        {
            ComboBox cbo = (sender as ComboBox);
            if (cbo.SelectedIndex > -1)
            {
                Int32 mark_ID = (Int32)(((System.Data.DataRowView)(cbo.SelectedItem)).Row as autoDataSet.MARKRow).MARK_ID;

                //(cmbModel.DataSource as autoDataSet.MODELDataTable).DefaultView.RowFilter = string.Format("MARK_ID={0}", mark_ID);
                mODELBindingSource.Filter = string.Format("MARK_ID={0}", mark_ID);
            }
        }

        private void cmbMark_SelectedValueChanged (object sender, EventArgs e)
        {
            ComboBox cbo = (sender as ComboBox);
            if (cbo.SelectedValue != null)
            {
                Int32 mark_ID = (Int32)(((System.Data.DataRowView)(cbo.SelectedItem)).Row as autoDataSet.MARKRow).MARK_ID;

                //(cmbModel.DataSource as autoDataSet.MODELDataTable).DefaultView.RowFilter = string.Format("MARK_ID={0}", mark_ID);
                mODELBindingSource.Filter = string.Format("MARK_ID={0}", mark_ID);
            }
        }

        private void txtVIN_TextChanged (object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text.Length != 17)
                tb.BackColor = Color.Red;
            else
                tb.BackColor = Color.White;
        }
    }
}
