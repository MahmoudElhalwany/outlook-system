using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace outlook_system
{
    public partial class signin : Form
    {
        static string conString = "Data source=orcl;User Id=scott; Password=tiger;";
        public signin()
        {
            InitializeComponent();
            OracleConnection c = new OracleConnection(conString);
          
           
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            mainMenu main = new mainMenu();
            main.Closed += (s, args) => this.Close();
            main.Show();
        }
    }
}
