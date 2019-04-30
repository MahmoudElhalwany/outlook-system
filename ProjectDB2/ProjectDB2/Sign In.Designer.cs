namespace ProjectDB2
{
    partial class Sign_In
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkbox_show = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_siginin = new MaterialSkin.Controls.MaterialFlatButton();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjectDB2.Properties.Resources.signin;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_mail);
            this.panel1.Controls.Add(this.chkbox_show);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.btn_siginin);
            this.panel1.Location = new System.Drawing.Point(-1, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 444);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chkbox_show
            // 
            this.chkbox_show.AutoSize = true;
            this.chkbox_show.Depth = 0;
            this.chkbox_show.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkbox_show.Location = new System.Drawing.Point(295, 203);
            this.chkbox_show.Margin = new System.Windows.Forms.Padding(0);
            this.chkbox_show.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkbox_show.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkbox_show.Name = "chkbox_show";
            this.chkbox_show.Ripple = true;
            this.chkbox_show.Size = new System.Drawing.Size(128, 30);
            this.chkbox_show.TabIndex = 3;
            this.chkbox_show.Text = "Show Password";
            this.chkbox_show.UseVisualStyleBackColor = true;
            this.chkbox_show.CheckedChanged += new System.EventHandler(this.chkbox_show_CheckedChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(73, 151);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Password";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(73, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "E_Mail";
            // 
            // btn_siginin
            // 
            this.btn_siginin.AutoSize = true;
            this.btn_siginin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_siginin.Depth = 0;
            this.btn_siginin.Location = new System.Drawing.Point(242, 295);
            this.btn_siginin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_siginin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_siginin.Name = "btn_siginin";
            this.btn_siginin.Primary = false;
            this.btn_siginin.Size = new System.Drawing.Size(60, 36);
            this.btn_siginin.TabIndex = 0;
            this.btn_siginin.Text = "Sign In";
            this.btn_siginin.UseVisualStyleBackColor = true;
            this.btn_siginin.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(184, 79);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(239, 20);
            this.txt_mail.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(184, 152);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(239, 20);
            this.txt_password.TabIndex = 5;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // Sign_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 509);
            this.Controls.Add(this.panel1);
            this.Name = "Sign_In";
            this.Text = "Sign_In";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sign_In_FormClosed);
            this.Load += new System.EventHandler(this.Sign_In_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCheckBox chkbox_show;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton btn_siginin;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_mail;
    }
}