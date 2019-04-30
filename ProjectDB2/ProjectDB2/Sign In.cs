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

namespace ProjectDB2
{
    public partial class Sign_In : MaterialSkin.Controls.MaterialForm
    {
        string constr = "Data source= orcl; User Id=scott;Password=tiger;";
        OracleConnection conn;
        public static string idd;
        public static string mail_to;
        public Sign_In()
        {
            InitializeComponent();
        }

        private void Sign_In_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(constr);
            conn.Open();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Inbox inboxform = new Inbox();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from user_account where E_MAIL=:mail and PASSWORD=:pass";
            cmd.Parameters.Add("mail", txt_mail.Text);
            mail_to = txt_mail.Text;
            cmd.Parameters.Add("pass", txt_password.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count = count + 1;
                idd = dr["user_id"].ToString();
            }
            if (count == 1)
            {

                this.Hide();
                inboxform.Show();
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Incorrect Mail or Password ");
            }
            dr.Close();
        }

        private void chkbox_show_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_show.Checked)
            {

                txt_password.UseSystemPasswordChar = false;

            }
            else
            {

                txt_password.UseSystemPasswordChar = true;
            }
        }
        private void Sign_In_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
