using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDB2
{
    public partial class Reports : MaterialSkin.Controls.MaterialForm
    {       CrystalReport2 cr;
            CrystalReport3 cr2;
        public Reports()
        {
           
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
           cr=new CrystalReport2();
            cr2=new CrystalReport3();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr;
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr2;
        }
    }
}
