namespace ProjectDB2
{
    partial class Inbox
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tab_inbox = new System.Windows.Forms.TabPage();
            this.tab_draft = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_send = new MaterialSkin.Controls.MaterialFlatButton();
            this.txt_sub = new System.Windows.Forms.TextBox();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.txt_msg = new System.Windows.Forms.RichTextBox();
            this.lbl_msg = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_sub = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_to = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sendmsg = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(1, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(798, 30);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tab_inbox);
            this.materialTabControl1.Controls.Add(this.tab_draft);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 6);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(747, 28);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tab_inbox
            // 
            this.tab_inbox.Location = new System.Drawing.Point(4, 22);
            this.tab_inbox.Name = "tab_inbox";
            this.tab_inbox.Padding = new System.Windows.Forms.Padding(3);
            this.tab_inbox.Size = new System.Drawing.Size(739, 2);
            this.tab_inbox.TabIndex = 0;
            this.tab_inbox.Text = "Inbox";
            this.tab_inbox.UseVisualStyleBackColor = true;
            // 
            // tab_draft
            // 
            this.tab_draft.Location = new System.Drawing.Point(4, 22);
            this.tab_draft.Name = "tab_draft";
            this.tab_draft.Padding = new System.Windows.Forms.Padding(3);
            this.tab_draft.Size = new System.Drawing.Size(739, 2);
            this.tab_draft.TabIndex = 1;
            this.tab_draft.Text = "Draft";
            this.tab_draft.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjectDB2.Properties.Resources.email;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_send);
            this.panel1.Controls.Add(this.txt_sub);
            this.panel1.Controls.Add(this.txt_to);
            this.panel1.Controls.Add(this.txt_msg);
            this.panel1.Controls.Add(this.lbl_msg);
            this.panel1.Controls.Add(this.lbl_sub);
            this.panel1.Controls.Add(this.lbl_to);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_sendmsg);
            this.panel1.Controls.Add(this.materialTabControl1);
            this.panel1.Location = new System.Drawing.Point(1, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 357);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_send
            // 
            this.btn_send.AutoSize = true;
            this.btn_send.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_send.Depth = 0;
            this.btn_send.Location = new System.Drawing.Point(497, 295);
            this.btn_send.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_send.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_send.Name = "btn_send";
            this.btn_send.Primary = false;
            this.btn_send.Size = new System.Drawing.Size(47, 36);
            this.btn_send.TabIndex = 11;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_sub
            // 
            this.txt_sub.Location = new System.Drawing.Point(137, 197);
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.Size = new System.Drawing.Size(333, 20);
            this.txt_sub.TabIndex = 10;
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(137, 162);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(333, 20);
            this.txt_to.TabIndex = 9;
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(137, 248);
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(333, 96);
            this.txt_msg.TabIndex = 8;
            this.txt_msg.Text = "";
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Depth = 0;
            this.lbl_msg.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_msg.Location = new System.Drawing.Point(11, 282);
            this.lbl_msg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(70, 19);
            this.lbl_msg.TabIndex = 7;
            this.lbl_msg.Text = "Message";
            // 
            // lbl_sub
            // 
            this.lbl_sub.AutoSize = true;
            this.lbl_sub.Depth = 0;
            this.lbl_sub.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_sub.Location = new System.Drawing.Point(3, 198);
            this.lbl_sub.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_sub.Name = "lbl_sub";
            this.lbl_sub.Size = new System.Drawing.Size(59, 19);
            this.lbl_sub.TabIndex = 6;
            this.lbl_sub.Text = "Subject";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Depth = 0;
            this.lbl_to.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_to.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_to.Location = new System.Drawing.Point(11, 163);
            this.lbl_to.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(27, 19);
            this.lbl_to.TabIndex = 5;
            this.lbl_to.Text = "To";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(672, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 144);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_sendmsg
            // 
            this.btn_sendmsg.AutoSize = true;
            this.btn_sendmsg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_sendmsg.Depth = 0;
            this.btn_sendmsg.Location = new System.Drawing.Point(637, 295);
            this.btn_sendmsg.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_sendmsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_sendmsg.Name = "btn_sendmsg";
            this.btn_sendmsg.Primary = false;
            this.btn_sendmsg.Size = new System.Drawing.Size(113, 36);
            this.btn_sendmsg.TabIndex = 3;
            this.btn_sendmsg.Text = "Send Message";
            this.btn_sendmsg.UseVisualStyleBackColor = true;
            this.btn_sendmsg.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "Inbox";
            this.Text = "Inbox";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inbox_FormClosed);
            this.Load += new System.EventHandler(this.Inbox_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tab_inbox;
        private System.Windows.Forms.TabPage tab_draft;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton btn_sendmsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_sub;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.RichTextBox txt_msg;
        private MaterialSkin.Controls.MaterialLabel lbl_msg;
        private MaterialSkin.Controls.MaterialLabel lbl_sub;
        private MaterialSkin.Controls.MaterialLabel lbl_to;
        private MaterialSkin.Controls.MaterialFlatButton btn_send;
    }
}