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
using System.IO;

namespace ProjectDB2
{
    public partial class Inbox : MaterialSkin.Controls.MaterialForm
    {
        string constr = "Data source= orcl; User Id=scott;Password=tiger;";
        OracleDataAdapter adapter;
        OracleDataAdapter adapter2;
        OracleDataAdapter adapter3;
        OracleCommandBuilder builder;
        DataSet ds;
        public Inbox()
        {
            InitializeComponent();
        }

        private void Inbox_Load(object sender, EventArgs e)
        {
            string pic;
            // string cmd = "select picture from user_account where user_id=:userr";
          OracleConnection  conn = new OracleConnection(constr);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select picture from user_account where user_id=:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("userr", Sign_In.idd);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            //              pictureBox1.Load(dr["picture"].ToString());

        
        }

        private void Inbox_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {
            // string n = materialTabSelector1.Select();
            //string n= materialTabControl1.SelectedTab.Name;
            //  MessageBox.Show("inbox");
            string cmd = "select subject, mail_from,MESSAGE from mailing WHERE mail_to=:reciever";
            adapter = new OracleDataAdapter(cmd, constr);
            adapter.SelectCommand.Parameters.Add("reciever", Sign_In.mail_to.ToString());
            ds = new DataSet();
            adapter.Fill(ds);
            string name = materialTabControl1.SelectedTab.Name;
            if (name == "tab_inbox")
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            string cmd2 = "select draft_mails,MAIL_TO from draft where user_id=:UserId";
            adapter2 = new OracleDataAdapter(cmd2, constr);
            adapter2.SelectCommand.Parameters.Add("UserId", Sign_In.idd);
            //  adapter2.SelectCommand.Parameters.Add("E_mailTo",Send_Mail.mail_to);

            DataSet ds1 = new DataSet();
            adapter2.Fill(ds1);
            if (name == "tab_draft")
            {
                dataGridView1.DataSource = ds1.Tables[0];
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

            Send_Mail send = new Send_Mail();
            send.Show();
            this.Hide();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            
        }
    }

    internal class int32
    {
    }
}
