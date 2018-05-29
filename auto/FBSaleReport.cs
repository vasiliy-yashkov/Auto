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
    public partial class FBSaleReport : Form
    {
        public FBSaleReport ()
        {
            InitializeComponent();
        }

        public void showReport ()
        {
            report1.Show();
        }
    }
}
