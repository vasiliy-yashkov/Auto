﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto
{
    public partial class SubjectInfo : Form
    {
        public SubjectInfo ()
        {
            InitializeComponent();
        }

        private void SubjectInfo_Load (object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'autoDataSet.PERSON' table. You can move, or remove it, as needed.
                this.pERSONTableAdapter.Fill(this.autoDataSet.PERSON);
                // TODO: This line of code loads data into the 'autoDataSet.PERSON_INFO' table. You can move, or remove it, as needed.
                this.pERSON_INFOTableAdapter.Fill(this.autoDataSet.PERSON_INFO);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! Возможно " +
                    "присутствуют дублирующиеся значения, или попытка удаления использующейся записи. \n" + ex.Message,
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            updateComboboxes();

        }

        private void pERSON_INFOBindingNavigatorSaveItem_Click (object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pERSON_INFOBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.autoDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! Возможно " +
                    "присутствуют дублирующиеся значения, или попытка удаления использующейся записи. \n" + ex.Message,
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click (object sender, EventArgs e)
        {
            this.Validate();
            this.pERSON_INFOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

            this.pERSON_INFOTableAdapter.Fill(this.autoDataSet.PERSON_INFO);

            updateComboboxes();
        }

        private void pERSON_INFODataGridView_CellEndEdit (object sender, DataGridViewCellEventArgs e)
        {
            Object obj = pERSON_INFODataGridView.Rows[e.RowIndex].Cells[1].Value;
            if (obj != null)
                pERSON_INFODataGridView.Rows[e.RowIndex].Cells[4].Value = obj;
            if (e.ColumnIndex == 2)
            {
                Object value = pERSON_INFODataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value != null && !String.IsNullOrEmpty(value.ToString()))
                {
                    try
                    {
                        string number = value.ToString();
                        string result = "";
                        bool usePlus = false;
                        if (number[0] == '+')
                            usePlus = true;
                        var pattern = new Regex(@"[^\d]");
                        result = pattern.Replace(number, string.Empty);
                        result = result.Trim();
                        if (usePlus && result.Length > 11)
                        {
                            result = "+" + result.Substring(0, 11);
                        }
                        else if (usePlus && result.Length <= 11)
                        {
                            result = "+" + result;
                        }
                        else if (result.Length > 11)
                        {
                            result = result.Substring(0, 11);
                        }
                        if (String.IsNullOrEmpty(result))
                        {
                            MessageBox.Show("Неверный номер телефона!",
                                    "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            pERSON_INFODataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;

                            return;
                        }
                        pERSON_INFODataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = result;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Неверный номер телефона!",
                                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //pERSONDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                        return;
                    }
                }
            }
        }

        private void updateComboboxes ()
        {
            foreach (DataGridViewRow row in pERSON_INFODataGridView.Rows)
            {
                if (row.Cells[4].Value != null)
                    ((DataGridViewComboBoxCell)row.Cells["PERSON_FULL"]).Value = row.Cells[4].Value;
            }
        }

        private void pERSON_INFODataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Пожалуйста, проверьте корректность введенных данных! \n" + e.Exception.Message,
                "Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
