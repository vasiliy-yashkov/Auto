using FirebirdSql.Data.FirebirdClient;
using fyiReporting.RdlDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();

            // Тут можно изменить настройки и залогиниться под другой учетной записью, если надо
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            string appPath = Application.StartupPath;
            string user = "SYSDBA";
            string password = "masterkey";
            string dbPath = appPath + "\\db\\AUTO.FDB";
            string connString = "database=" + dbPath + ";data source=localhost;user=" + user + ";password=" + password;
            connectionStringsSection.ConnectionStrings["auto.Properties.Settings.auto_database"].ConnectionString = 
                connString;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

            FbConnection connection = new FbConnection(connString);
            try
            {
                connection.Open();
                connection.Close();
                connectionLabel.Text = "Статус: " + dbPath + "; Пользователь: " + user;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка соединения с базой данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connectionLabel.Text = "Статус: соединение не установлено";
            }          
        }

        private void exitToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            MessageBox.Show("ИС \"Автосалон\"\nВерсия 1.0\nИспользуемая БД: Firebird 2.5", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void MainForm_Load ( object sender, EventArgs e )
        {
            
        }

        private void statusToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            AutoStatus autoStatus = new AutoStatus();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(AutoStatus))
                    autoStatus = (AutoStatus) form;
            }
            autoStatus.MdiParent = this;
            autoStatus.Show();
        }

        private void payToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Pay pay = new Pay();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Pay))
                    pay = (Pay)form;
            }
            pay.MdiParent = this;
            pay.Show();
        }

        private void postToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Post post = new Post();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Post))
                    post = (Post)form;
            }
            post.MdiParent = this;
            post.Show();
        }

        private void subjectToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Subject subject = new Subject();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Subject))
                    subject = (Subject)form;
            }
            subject.MdiParent = this;
            subject.Show();
        }

        private void subjectInfoToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            SubjectInfo subjectInfo = new SubjectInfo();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(SubjectInfo))
                    subjectInfo = (SubjectInfo)form;
            }
            subjectInfo.MdiParent = this;
            subjectInfo.Show();
        }

        private void employeeToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Employee employee = new Employee();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Employee))
                    employee = (Employee)form;
            }
            employee.MdiParent = this;
            employee.Show();
        }

        private void modificationToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Modification modification = new Modification();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Modification))
                    modification = (Modification)form;
            }
            modification.MdiParent = this;
            modification.Show();
        }

        private void autoToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Auto auto = new Auto();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Auto))
                    auto = (Auto)form;
            }
            auto.MdiParent = this;
            auto.Show();
        }

        private void clientToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Client client = new Client();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Client))
                    client = (Client)form;
            }
            client.MdiParent = this;
            client.Show();
        }

        private void providerToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Provider provider = new Provider();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Provider))
                    provider = (Provider)form;
            }
            provider.MdiParent = this;
            provider.Show();
        }

        private void deleveryToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            DeliveryEvent deliveryForm = new DeliveryEvent();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(DeliveryEvent))
                    deliveryForm = (DeliveryEvent)form;
            }
            deliveryForm.MdiParent = this;
            deliveryForm.Show();
        }

        private void saleToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            SaleEventForm saleForm = new SaleEventForm();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(SaleEventForm))
                    saleForm = (SaleEventForm)form;
            }
            saleForm.MdiParent = this;
            saleForm.Show();
        }
        private void markToolStripMenuItem_Click (object sender, EventArgs e)
        {
            Mark markForm = new Mark();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Mark))
                    markForm = (Mark)form;
            }
            markForm.MdiParent = this;
            markForm.Show();
        }

        private void modelToolStripMenuItem_Click (object sender, EventArgs e)
        {
            Model modelForm = new Model();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Model))
                    modelForm = (Model)form;
            }
            modelForm.MdiParent = this;
            modelForm.Show();
        }

        private void engineToolStripMenuItem_Click (object sender, EventArgs e)
        {
            Engine engineForm = new Engine();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(Engine))
                    engineForm = (Engine)form;
            }
            engineForm.MdiParent = this;
            engineForm.Show();
        }

        private void deliveryReportToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FRDiliveryReport deliveryReport = new FRDiliveryReport();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(FRDiliveryReport))
                    deliveryReport = (FRDiliveryReport)form;
            }
            deliveryReport.MdiParent = this;
            deliveryReport.showReport();
        }

        private void saleReportToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FBSaleReport saleReport = new FBSaleReport();
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(FBSaleReport))
                    saleReport = (FBSaleReport)form;
            }
            saleReport.MdiParent = this;
            saleReport.showReport();
        }
    }
}
