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
    public partial class Sign_Up : MaterialSkin.Controls.MaterialForm
    {
        OracleDataAdapter adapter;
        DataSet ds;
        OracleCommandBuilder builder;
        string constr = "Data source= orcl; User Id=scott;Password=tiger;";
        OracleConnection conn;
       public string filename;
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(constr);
            conn.Open();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files (*.png)*.png|All Files ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            int maxid, newid;
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "GETMAXID";
            cmd2.CommandType = CommandType.StoredProcedure;
            NewMethod(cmd2);
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
            cmd.CommandText = " insert into USER_ACCOUNT values(:id,:mail,:firstname,:lastname,:password,:gender,:day,:month,:year,:picture)";
            cmd.Parameters.Add("id", newid);
            cmd.Parameters.Add("mail", txt_mail.Text);
            cmd.Parameters.Add("firstname", txt_firstname.Text);
            cmd.Parameters.Add("lastname", txt_lastname.Text);
            cmd.Parameters.Add("password", txt_password.Text);
            if (radio_female.Checked)
            {
                cmd.Parameters.Add("gender", radio_female.Text);
            }
            else
            {
                cmd.Parameters.Add("gender", radio_male.Text);

            }
            cmd.Parameters.Add("day", comb_day.GetItemText(comb_day.SelectedItem));
            cmd.Parameters.Add("month", comb_month.SelectedItem.ToString());
            cmd.Parameters.Add("year", comb_year.GetItemText(comb_year.SelectedItem));
            string n = filename;
            cmd.Parameters.Add("picture", n);
            var flag = cmd.ExecuteNonQuery();
            if (flag != -1)
            {
                MessageBox.Show("Added Successfully");
            }

            conn.Close();
        }

        private static void NewMethod(OracleCommand cmd2)
        {
            cmd2.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_show.Checked)
            {

                txt_password.UseSystemPasswordChar = false;

            }
            else
            {

                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void Sign_Up_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            string cmd = "select * from User_account where E_MAIL=:txt_mail";
            adapter = new OracleDataAdapter(cmd, constr);
            adapter.SelectCommand.Parameters.Add("txt_mail", txt_mail.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

    
    }
}

