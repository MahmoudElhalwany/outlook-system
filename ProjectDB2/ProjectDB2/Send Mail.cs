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
    public partial class Send_Mail : MaterialSkin.Controls.MaterialForm
    {
        string constr = "Data source= orcl; User Id=scott;Password=tiger;";
        OracleConnection conn;
        public static string mail_to;
        //  public static string mail_from;
        public static int flag = 0;
        public static string msg;
        public Send_Mail()
        {
            InitializeComponent();
        }

        private void Send_Mail_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(constr);
            conn.Open();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
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
            mail_to = txt_to.Text;
            cmd.Parameters.Add("from", Sign_In.mail_to);
            cmd.Parameters.Add("sub", txt_sub.Text);
            cmd.Parameters.Add("id", Sign_In.idd);
            cmd.Parameters.Add("msg", txt_msg.Text);
            mail_to = txt_to.Text;
            //mail_from = txt_from.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Sending");
            conn.Close();
            this.Close();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into draft values (:id,:drafted_mail,:mailTo)";
            cmd.Parameters.Add("id", Sign_In.idd);
            cmd.Parameters.Add("drafted_mail", txt_msg.Text);
            cmd.Parameters.Add("mailTo", txt_to.Text);
            int n = cmd.ExecuteNonQuery();
            if (n != -1)
            {
               
                MessageBox.Show("added to draft");
                this.Close();
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Send_Mail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            txt_msg.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_msg.Undo();

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_msg.Redo();

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_msg.Cut();

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_msg.Copy();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_msg.Paste();

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_msg.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files (*.png)*.png|All Files ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(ofd.FileName);   
            }
        }
    }
    }

