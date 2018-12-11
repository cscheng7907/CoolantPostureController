namespace CoolantPostureController
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.label_Conio = new System.Windows.Forms.Label();
            this.label_ConDrv = new System.Windows.Forms.Label();
            this.label_company = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label_ErrNo = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Caption = new System.Windows.Forms.Label();
            this.panel_body = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(701, 422);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(72, 20);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "退出";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_Title.Controls.Add(this.label_Conio);
            this.panel_Title.Controls.Add(this.label_ConDrv);
            this.panel_Title.Controls.Add(this.label_company);
            this.panel_Title.Controls.Add(this.pictureBox_logo);
            this.panel_Title.Controls.Add(this.label_ErrNo);
            this.panel_Title.Controls.Add(this.label_Time);
            this.panel_Title.Controls.Add(this.label_Date);
            this.panel_Title.Controls.Add(this.label_Caption);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(800, 70);
            this.panel_Title.DoubleClick += new System.EventHandler(this.panel_Title_DoubleClick);
            this.panel_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Head_MouseMove);
            this.panel_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Head_MouseDown);
            this.panel_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Head_MouseUp);
            // 
            // label_Conio
            // 
            this.label_Conio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Conio.BackColor = System.Drawing.Color.GreenYellow;
            this.label_Conio.Location = new System.Drawing.Point(653, 39);
            this.label_Conio.Name = "label_Conio";
            this.label_Conio.Size = new System.Drawing.Size(2, 25);
            this.label_Conio.Text = ".";
            // 
            // label_ConDrv
            // 
            this.label_ConDrv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ConDrv.BackColor = System.Drawing.Color.GreenYellow;
            this.label_ConDrv.Location = new System.Drawing.Point(653, 8);
            this.label_ConDrv.Name = "label_ConDrv";
            this.label_ConDrv.Size = new System.Drawing.Size(2, 25);
            this.label_ConDrv.Text = ".";
            // 
            // label_company
            // 
            this.label_company.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular);
            this.label_company.ForeColor = System.Drawing.Color.White;
            this.label_company.Location = new System.Drawing.Point(318, 30);
            this.label_company.Name = "label_company";
            this.label_company.Size = new System.Drawing.Size(198, 19);
            this.label_company.Text = "上海历炎自动化";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(70, 70);
            // 
            // label_ErrNo
            // 
            this.label_ErrNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ErrNo.BackColor = System.Drawing.Color.Red;
            this.label_ErrNo.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Regular);
            this.label_ErrNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label_ErrNo.Location = new System.Drawing.Point(604, 12);
            this.label_ErrNo.Name = "label_ErrNo";
            this.label_ErrNo.Size = new System.Drawing.Size(34, 48);
            this.label_ErrNo.Text = "5";
            this.label_ErrNo.Visible = false;
            // 
            // label_Time
            // 
            this.label_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Time.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label_Time.ForeColor = System.Drawing.Color.White;
            this.label_Time.Location = new System.Drawing.Point(662, 39);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(133, 20);
            this.label_Time.Text = "12 : 11 : 18";
            // 
            // label_Date
            // 
            this.label_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Date.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label_Date.ForeColor = System.Drawing.Color.White;
            this.label_Date.Location = new System.Drawing.Point(662, 11);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(133, 20);
            this.label_Date.Text = "2015-02-12";
            // 
            // label_Caption
            // 
            this.label_Caption.BackColor = System.Drawing.Color.RoyalBlue;
            this.label_Caption.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label_Caption.ForeColor = System.Drawing.Color.White;
            this.label_Caption.Location = new System.Drawing.Point(87, 21);
            this.label_Caption.Name = "label_Caption";
            this.label_Caption.Size = new System.Drawing.Size(251, 38);
            this.label_Caption.Text = "切削液控制系统 | ";
            // 
            // panel_body
            // 
            this.panel_body.Location = new System.Drawing.Point(346, 275);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(427, 191);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.panel_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_Title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Caption;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_ErrNo;
        private System.Windows.Forms.Label label_company;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_Conio;
        private System.Windows.Forms.Label label_ConDrv;
    }
}

