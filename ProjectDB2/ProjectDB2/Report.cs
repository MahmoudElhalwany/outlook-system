using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace ProjectDB2
{
    public partial class Report : MaterialSkin.Controls.MaterialForm
    {
        CrystalReport4 CR;
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport4();
            CR.SetParameterValue(0,Sign_In.mail_to);
           crystalReportViewer1.ReportSource = CR;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
