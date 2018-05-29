using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto
{
    public partial class SaleEventForm : Form
    {
        private autoDataSetTableAdapters.SALETableAdapter saleAdapter;
        private autoDataSetTableAdapters.MARKTableAdapter markAdapter;
        private autoDataSetTableAdapters.MODELTableAdapter modelAdapter;
        private autoDataSetTableAdapters.STATUSTableAdapter statusAdapter;

        private int modelID;
        private int engineID;
        private int modID;
        private int autoID;

        public SaleEventForm ()
        {
            InitializeComponent();

            saleAdapter = new autoDataSetTableAdapters.SALETableAdapter();
            saleAdapter.ClearBeforeFill = true;

            markAdapter = new autoDataSetTableAdapters.MARKTableAdapter();
            markAdapter.ClearBeforeFill = true;

            modelAdapter = new autoDataSetTableAdapters.MODELTableAdapter();
            modelAdapter.ClearBeforeFill = true;

            statusAdapter = new autoDataSetTableAdapters.STATUSTableAdapter();
            statusAdapter.ClearBeforeFill = true;

            //this.dateTimePicker1.ShowUpDown = true;

            string filepath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "reports\\BuySale.rdl");
            //this.rdlViewer1.SourceFile = new Uri(filepath);
            //this.rdlViewer1.Rebuild();
        }

        private void SaleEventForm_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoDataSet.MODIFICATION' table. You can move, or remove it, as needed.
            this.mODIFICATIONTableAdapter.Fill(this.autoDataSet.MODIFICATION);
            // TODO: This line of code loads data into the 'autoDataSet.ENGINE' table. You can move, or remove it, as needed.
            this.eNGINETableAdapter.Fill(this.autoDataSet.ENGINE);
            // TODO: This line of code loads data into the 'autoDataSet.MODEL' table. You can move, or remove it, as needed.
            this.mODELTableAdapter.Fill(this.autoDataSet.MODEL);
            // TODO: This line of code loads data into the 'autoDataSet.MARK' table. You can move, or remove it, as needed.
            this.mARKTableAdapter.Fill(this.autoDataSet.MARK);
            // TODO: This line of code loads data into the 'autoDataSet.PAY' table. You can move, or remove it, as needed.
            this.pAYTableAdapter.Fill(this.autoDataSet.PAY);
            // TODO: This line of code loads data into the 'autoDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.autoDataSet.EMPLOYEE);
            // TODO: This line of code loads data into the 'autoDataSet.AUTO' table. You can move, or remove it, as needed.
            this.aUTOTableAdapter.FillByStock(this.autoDataSet.AUTO);
            // TODO: This line of code loads data into the 'autoDataSet.PERSON' table. You can move, or remove it, as needed.
            this.pERSONTableAdapter.Fill(this.autoDataSet.PERSON);
            // TODO: This line of code loads data into the 'autoDataSet.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.autoDataSet.CLIENT);

            saleAdapter.Fill(this.autoDataSet.SALE);
            markAdapter.Fill(this.autoDataSet.MARK);
            modelAdapter.Fill(this.autoDataSet.MODEL);
            statusAdapter.Fill(this.autoDataSet.STATUS);

            this.Validate();

            this.pAYTableAdapter.Update(this.autoDataSet);
            this.eMPLOYEETableAdapter.Update(this.autoDataSet);
            this.aUTOTableAdapter.Update(this.autoDataSet);
            this.pERSONTableAdapter.Update(this.autoDataSet);
            this.cLIENTTableAdapter.Update(this.autoDataSet);

            this.pAYBindingSource.EndEdit();
            this.eMPLOYEEBindingSource.EndEdit();
            this.aUTOBindingSource.EndEdit();
            this.pERSONBindingSource.EndEdit();
            this.cLIENTBindingSource.EndEdit();

            this.autoDataSet.AUTO.AcceptChanges();
        }

        private void btnApply_Click (object sender, EventArgs e)
        {
            if (dateTimePicker1.Value == null)
            {
                MessageBox.Show("Пожалуйста, укажите дату продажи автомобиля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cmbPerson.SelectedValue == null)
            {
                MessageBox.Show("Пожалуйста, укажите клиента", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cmbEmployee.SelectedValue == null)
            {
                MessageBox.Show("Пожалуйста, укажите сотрудника, осуществляющего продажу автомобиля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (String.IsNullOrEmpty(tbPrice.Text))
            {
                MessageBox.Show("Пожалуйста, укажите цену", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cmbPay.SelectedValue == null)
            {
                MessageBox.Show("Пожалуйста, укажите способ оплаты", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Decimal.Parse(tbPrice.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, укажите корректную цену продажи", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                saleAdapter.InsertQuery(dateTimePicker1.Value,
                    Int32.Parse(cmbPerson.SelectedValue.ToString()),
                    Int32.Parse(cmbEmployee.SelectedValue.ToString()),
                    autoID,
                    Decimal.Parse(tbPrice.Text),
                    Int32.Parse(cmbPay.SelectedValue.ToString())
                    );

                auto.autoDataSet.EMPLOYEERow employeeRow = ((cmbEmployee.SelectedItem as DataRowView).Row as auto.autoDataSet.EMPLOYEERow);
                DateTime empBD = employeeRow.PERSONRow.PERSON_BIRTHDAY;
                int empPS = employeeRow.PERSONRow.PERSON_PASSPORT_SERIAL;
                int empPN = employeeRow.PERSONRow.PERSON_PASSPORT_SERIAL;
                DateTime empPD = employeeRow.PERSONRow.PERSON_P_DATE;
                string empPP = employeeRow.PERSONRow.PERSON_P_PLACE;

                auto.autoDataSet.PERSONRow client = ((cmbPerson.SelectedItem as DataRowView).Row as auto.autoDataSet.PERSONRow);
                DateTime cliBD = client.PERSON_BIRTHDAY;
                int cliPS = client.PERSON_PASSPORT_SERIAL;
                int cliPN = client.PERSON_PASSPORT_NUMBER;
                DateTime cliPD = client.PERSON_P_DATE;
                string cliPP = client.PERSON_P_PLACE;

                FastReport.TextObject repEmpBD = report1.FindObject("repTxtEBD") as FastReport.TextObject;
                repEmpBD.Text = empBD.ToShortDateString();

                FastReport.TextObject repEmpPS = report1.FindObject("repTxtEPS") as FastReport.TextObject;
                repEmpPS.Text = empPS.ToString();

                FastReport.TextObject repEmpPN = report1.FindObject("repTxtEPN") as FastReport.TextObject;
                repEmpPN.Text = empPN.ToString();

                FastReport.TextObject repEmpPD = report1.FindObject("repTxtEPD") as FastReport.TextObject;
                repEmpPD.Text = empPD.ToShortDateString();

                FastReport.TextObject repEmpPP = report1.FindObject("repTxtEPP") as FastReport.TextObject;
                repEmpPP.Text = empPP;

                FastReport.TextObject repCliBD = report1.FindObject("repTxtCBD") as FastReport.TextObject;
                repCliBD.Text = cliBD.ToShortDateString();

                FastReport.TextObject repCliPS = report1.FindObject("repTxtCPS") as FastReport.TextObject;
                repCliPS.Text = cliPS.ToString();

                FastReport.TextObject repCliPN = report1.FindObject("repTxtCPN") as FastReport.TextObject;
                repCliPN.Text = cliPN.ToString();

                FastReport.TextObject repCliPD = report1.FindObject("repTxtCPD") as FastReport.TextObject;
                repCliPD.Text = cliPD.ToShortDateString();

                FastReport.TextObject repCliPP = report1.FindObject("repTxtCPP") as FastReport.TextObject;
                repCliPP.Text = cliPP;

                autoDataSet.AUTODataTable table = aUTOTableAdapter.GetDataByAutoID(autoID); 
                auto.autoDataSet.AUTORow aObj = table.Rows[0] as autoDataSet.AUTORow;
                autoDataSet.MODELDataTable mdlTable = modelAdapter.GetDataByModelID(Int32.Parse(aObj.MODEL_ID.ToString()));
                string modelFull = (mdlTable.Rows[0] as auto.autoDataSet.MODELRow).MODEL_FULL.ToString();

                MessageBox.Show("Продажа успешно оформлена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                String file = File.ReadAllText("reports\\BuySale2.rdl");

                file = file.Replace("REP_DATE", dateTimePicker1.Value.ToShortDateString());
                FastReport.TextObject text = report1.FindObject("repTxtDate") as FastReport.TextObject;
                text.Text = dateTimePicker1.Value.ToShortDateString();

                auto.autoDataSet.PERSONRow obj = ((cmbPerson.SelectedItem as DataRowView).Row as auto.autoDataSet.PERSONRow);
                file = file.Replace("REP_PERSON", obj.PERSON_FULL.ToString());

                auto.autoDataSet.EMPLOYEERow emp = ((cmbEmployee.SelectedItem as DataRowView).Row as auto.autoDataSet.EMPLOYEERow);
                FastReport.TextObject employee = report1.FindObject("repTxtEmployee") as FastReport.TextObject;
                if (emp.EMPLOYEE_FULL.ToString().IndexOf(',') > 0)
                    employee.Text = emp.EMPLOYEE_FULL.ToString().Substring(0, emp.EMPLOYEE_FULL.ToString().IndexOf(','));
                else
                    employee.Text = emp.EMPLOYEE_FULL.ToString();

                FastReport.TextObject person = report1.FindObject("repTxtPerson") as FastReport.TextObject;
                person.Text = obj.PERSON_FULL.ToString();

                file = file.Replace("REP_MODEL", modelFull);

                FastReport.TextObject model = report1.FindObject("repTxtModel") as FastReport.TextObject;
                model.Text = modelFull;

                auto.autoDataSet.AUTORow obj2 = aObj;
                FastReport.TextObject all = report1.FindObject("repTxtAll") as FastReport.TextObject;
                all.Text = obj2.AUTO_FULL;
                
                file = file.Replace("REP_COLOR", obj2.AUTO_COLOR.ToString());

                FastReport.TextObject color = report1.FindObject("repTxtColor") as FastReport.TextObject;
                color.Text = obj2.AUTO_COLOR.ToString();

                file = file.Replace("REP_VIN", obj2.AUTO_VIN.ToString());

                FastReport.TextObject vin = report1.FindObject("repTxtVin") as FastReport.TextObject;
                vin.Text = obj2.AUTO_VIN.ToString();

                FastReport.TextObject vin2 = report1.FindObject("repTxtVin2") as FastReport.TextObject;
                vin2.Text = obj2.AUTO_VIN.ToString();

                file = file.Replace("REP_PRICE", tbPrice.Text + " руб.");

                FastReport.TextObject sum = report1.FindObject("repTxtSum") as FastReport.TextObject;
                sum.Text = tbPrice.Text + " руб.";

                FastReport.TextObject sum2 = report1.FindObject("repTxtSum2") as FastReport.TextObject;
                sum2.Text = txtCatalogPrice.Text + " руб.";

                FastReport.TextObject priceMethod = report1.FindObject("repTxtPriceMethod") as FastReport.TextObject;
                auto.autoDataSet.PAYRow payRow = ((cmbPay.SelectedItem as DataRowView).Row as auto.autoDataSet.PAYRow);
                priceMethod.Text = payRow.PAY_NAME;

                File.WriteAllText("reports\\BuySale2_tmp.rdl", file);

                string filepath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "reports\\BuySale2_tmp.rdl");
                //this.rdlViewer1.SourceFile = new Uri(filepath);
                //this.rdlViewer1.Rebuild();

                this.aUTOTableAdapter.UpdateQueryNotAvailable(autoID);
                SaleEventForm_Load(sender, e);

                report1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка оформления продажи. \n" + ex.Message, "Ошибка обработки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOK_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMark_SelectedIndexChanged (object sender, EventArgs e)
        {
            ComboBox cbo = (sender as ComboBox);
            if (cbo.SelectedIndex > -1)
            {
                Int32 mark_ID = (Int32)(((System.Data.DataRowView)(cbo.SelectedItem)).Row as autoDataSet.MARKRow).MARK_ID;

                mODELBindingSource.Filter = string.Format("MARK_ID={0}", mark_ID);
                getAutoInfo();
            }            
        }

        private void cmbModel_SelectedIndexChanged (object sender, EventArgs e)
        {
            ComboBox cbo = (sender as ComboBox);
            if (cbo.SelectedIndex > -1)
            {
                Int32 modelID = (Int32)(((System.Data.DataRowView)(cbo.SelectedItem)).Row as autoDataSet.MODELRow).MODEL_ID;

                aUTOBindingSource.Filter = string.Format("MODEL_ID={0}", modelID);

                object eObj = aUTOTableAdapter.getEngineID(modelID);
                if (eObj != null)
                {
                    Int32 engineID = (Int32)(long)eObj;
                    eNGINEBindingSource.Filter = string.Format("ENGINE_ID={0}", engineID);
                }
                else
                {
                    eNGINEBindingSource.Filter = string.Format("ENGINE_ID={0}", Int32.MaxValue);
                }
                object mObj = aUTOTableAdapter.getModID(modelID);
                if (mObj != null)
                {
                    Int32 modificationID = (Int32)(long)mObj;
                    mODIFICATIONBindingSource.Filter = string.Format("MODIFICATION_ID={0}", modificationID);                    
                }
                else
                {
                    mODIFICATIONBindingSource.Filter = string.Format("MODIFICATION_ID={0}", Int32.MaxValue);
                }
                getAutoInfo();
            }            
        }

        private void cmbMark_SelectedValueChanged (object sender, EventArgs e)
        {
            ComboBox cbo = (sender as ComboBox);
            if (cbo.SelectedValue != null)
            {
                Int32 mark_ID = (Int32)(((System.Data.DataRowView)(cbo.SelectedItem)).Row as autoDataSet.MARKRow).MARK_ID;

                mODELBindingSource.Filter = string.Format("MARK_ID={0}", mark_ID);
                getAutoInfo();
            }            
        }

        private void cmbModel_SelectedValueChanged (object sender, EventArgs e)
        {
            ComboBox cbo = (sender as ComboBox);
            if (cbo.SelectedValue != null)
            {
                Int32 modelID = (Int32)(((System.Data.DataRowView)(cbo.SelectedItem)).Row as autoDataSet.MODELRow).MODEL_ID;

                aUTOBindingSource.Filter = string.Format("MODEL_ID={0}", modelID);

                object eObj = aUTOTableAdapter.getEngineID(modelID);
                if (eObj != null)
                {
                    Int32 engineID = (Int32)(long)eObj;
                    eNGINEBindingSource.Filter = string.Format("ENGINE_ID={0}", engineID);
                }
                else
                {
                    eNGINEBindingSource.Filter = string.Format("ENGINE_ID={0}", Int32.MaxValue);
                }
                object mObj = aUTOTableAdapter.getModID(modelID);
                if (mObj != null)
                {
                    Int32 modificationID = (Int32)(long)mObj;
                    mODIFICATIONBindingSource.Filter = string.Format("MODIFICATION_ID={0}", modificationID);
                }
                else
                {
                    mODIFICATIONBindingSource.Filter = string.Format("MODIFICATION_ID={0}", Int32.MaxValue);
                }
                getAutoInfo();
            }            
        }

        private void getAutoInfo()
        {      
            if (cmbModel.SelectedValue != null)
            {
                modelID = (Int32)(((System.Data.DataRowView)(cmbModel.SelectedItem)).Row as autoDataSet.MODELRow).MODEL_ID;
            }
            else
            {
                tbPrice.Text = txtCatalogPrice.Text = String.Empty;
                txtStatus.Text = String.Empty;
                txtStatus.BackColor = Color.White;
                btnApply.Enabled = false;
                return;
            }
            if (cmbEngine.SelectedValue != null)
            {
                engineID = (Int32)(((System.Data.DataRowView)(cmbEngine.SelectedItem)).Row as autoDataSet.ENGINERow).ENGINE_ID;
            }
            else
            {
                tbPrice.Text = txtCatalogPrice.Text = String.Empty;
                txtStatus.Text = String.Empty;
                txtStatus.BackColor = Color.White;
                btnApply.Enabled = false;
                return;
            }
            if (cmbMod.SelectedValue != null)
            {
                modID = (Int32)(((System.Data.DataRowView)(cmbMod.SelectedItem)).Row as autoDataSet.MODIFICATIONRow).MODIFICATION_ID;
            }
            else
            {
                tbPrice.Text = txtCatalogPrice.Text = String.Empty;
                txtStatus.Text = String.Empty;
                txtStatus.BackColor = Color.White;
                btnApply.Enabled = false;
                return;
            }
            autoID = (int)(long)aUTOTableAdapter.getAutoID(modelID, modID, engineID);

            autoDataSet.AUTODataTable table = aUTOTableAdapter.GetDataByAutoID(autoID);
            autoDataSet.AUTORow row = table.Rows[0] as autoDataSet.AUTORow;

            int statusID = (int)(long)row.STATUS_ID;

            autoDataSet.STATUSDataTable statusTable = statusAdapter.GetDataByStatusID(statusID);
            autoDataSet.STATUSRow statusRow = statusTable.Rows[0] as autoDataSet.STATUSRow;
            string status = statusRow.STATUS_NAME;
            if (!status.ToLower().Equals("в наличии"))
            {
                txtStatus.Text = status;
                txtStatus.BackColor = Color.Red;
                btnApply.Enabled = false;
                return;
            }
            else
            {
                txtStatus.Text = status;
                txtStatus.BackColor = Color.Green;
            }

            tbPrice.Text = txtCatalogPrice.Text = row.AUTO_PRICE.ToString();
            btnApply.Enabled = true;
        }
    }
}
