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
        OracleConnection conn;
      //  string constr = "Data source= orcl; User Id=scott;Password=tiger;";
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
            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select picture from user_account where user_id=:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("userr", Sign_In.idd);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            pictureBox1.Load(dr["picture"].ToString());
            txt_to.Visible = false;
            txt_sub.Visible = false;
            txt_msg.Visible = false;
            lbl_msg.Visible = false;
            lbl_sub.Visible = false;
            lbl_to.Visible = false;
            lbl_msg.Visible = false;
            btn_send.Visible = false;
            


        }

        private void Inbox_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {
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
            string cmd2 = "select draft_mails,MAIL_TO,subject from draft where user_id=:UserId";
            adapter2 = new OracleDataAdapter(cmd2, constr);
            adapter2.SelectCommand.Parameters.Add("UserId", Sign_In.idd);
            DataSet ds1 = new DataSet();
            adapter2.Fill(ds1);
            if (name == "tab_draft")
            {
                dataGridView1.DataSource = ds1.Tables[0];
                txt_to.Visible = true;
                txt_sub.Visible = true;
                txt_msg.Visible = true;
                lbl_msg.Visible = true;
                lbl_sub.Visible = true;
                lbl_msg.Visible = true;
                lbl_to.Visible = true;
                btn_send.Visible = true;
            }

            //conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (e.RowIndex >= 0)
            //{
            //  //  int rowindex = e.RowIndex;
            //    DataGridViewRow row =this.dataGridView1.Rows[e.RowIndex];
            //    txt_sub.Text = row.Cells[0].Value.ToString();
            //}
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowindex];
            txt_to.Text = row.Cells[1].Value.ToString();
            txt_sub.Text = row.Cells[2].Value.ToString();
            txt_msg.Text = row.Cells[0].Value.ToString();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            int maxid, newid;
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "GET_MAILINGID";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd2.ExecuteNonQuery();

            try
            {
                maxid = Convert.ToInt32(cmd2.Parameters["id"].Value.ToString());
                newid = maxid + 1;

            }
            catch
            {
                newid = 1;
            }



            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT_MAIL_INFO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", newid);
            cmd.Parameters.Add("to", txt_to.Text);
            cmd.Parameters.Add("from", Sign_In.mail_to);
            cmd.Parameters.Add("sub", txt_sub.Text);
            cmd.Parameters.Add("id", Sign_In.idd);
            cmd.Parameters.Add("msg", txt_msg.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Sending");
            conn.Close();
            this.Close();
        }
    }

    //internal class int32
    //{
    //}
}
