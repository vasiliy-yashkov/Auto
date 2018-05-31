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
    public partial class AddNewPerson : Form
    {
        private autoDataSetTableAdapters.PERSONTableAdapter personAdapter;
        private long personID;
        private autoDataSetTableAdapters.PERSON_INFOTableAdapter personInfoAdapter;

        public AddNewPerson ()
        {
            InitializeComponent();

            autoDataSet = new autoDataSet();

            personAdapter = new autoDataSetTableAdapters.PERSONTableAdapter();
            personAdapter.ClearBeforeFill = true;
            personAdapter.Fill(this.autoDataSet.PERSON);

            personInfoAdapter = new autoDataSetTableAdapters.PERSON_INFOTableAdapter();
            personInfoAdapter.ClearBeforeFill = true;
            personInfoAdapter.Fill(this.autoDataSet.PERSON_INFO);
        }

        public long PersonID
        {
            get
            {
                return personID;
            }
        }

        private void btnOk_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) ||
                String.IsNullOrEmpty(txtLastName.Text) ||
                String.IsNullOrEmpty(txtMiddleName.Text) ||
                String.IsNullOrEmpty(txtPassportSerial.Text) ||
                String.IsNullOrEmpty(txtPassportNumber.Text) ||
                String.IsNullOrEmpty(txtGov.Text) ||
                String.IsNullOrEmpty(txtPhone.Text) ||
                String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!",
                "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int serial;
            int number;

            if (!int.TryParse(txtPassportSerial.Text, out serial) || !int.TryParse(txtPassportNumber.Text, out number))
            {
                MessageBox.Show("Пожалуйста, введите корректные серию и номер паспорта!",
                "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                personAdapter.Insert(txtName.Text,
                    txtLastName.Text,
                    txtMiddleName.Text,
                    bdDate.Value,
                    number,
                    serial,
                    releaseDate.Value,
                    txtGov.Text);
                personID = (long)personAdapter.GetPersonIDByPSN(serial, number);
                personInfoAdapter.Insert(txtPhone.Text, txtAddress.Text, (int)PersonID);

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! " +
                    "Заполните все поля, или пользователь с уникальными данными уже существует. \n" + ex.Message,
                "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click (object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
