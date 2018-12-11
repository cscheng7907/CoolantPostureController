namespace CoolantPostureController.UICtrls
{
    partial class PageViewMAC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageViewMAC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ToolNum = new System.Windows.Forms.Label();
            this.label_Pos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imageLabel_Edit = new ComCtrls.ImageLabel();
            this.imageLabel_Diagnose = new ComCtrls.ImageLabel();
            this.imageLabel_Reset = new ComCtrls.ImageButton(this.components);
            this.imageLabel_Home = new ComCtrls.ImageButton(this.components);
            this.imageLabel_Start = new ComCtrls.ImageButton(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(168, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 39);
            this.label1.Text = "刀具号";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(168, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 41);
            this.label2.Text = "角度值";
            // 
            // label_ToolNum
            // 
            this.label_ToolNum.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold);
            this.label_ToolNum.Location = new System.Drawing.Point(286, 60);
            this.label_ToolNum.Name = "label_ToolNum";
            this.label_ToolNum.Size = new System.Drawing.Size(335, 102);
            this.label_ToolNum.Text = "# 6";
            this.label_ToolNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_Pos
            // 
            this.label_Pos.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold);
            this.label_Pos.Location = new System.Drawing.Point(286, 173);
            this.label_Pos.Name = "label_Pos";
            this.label_Pos.Size = new System.Drawing.Size(335, 107);
            this.label_Pos.Text = "360.5°";
            this.label_Pos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(61, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            // 
            // imageLabel_Edit
            // 
            this.imageLabel_Edit.BackImg = null;
            this.imageLabel_Edit.Checked = false;
            this.imageLabel_Edit.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular);
            this.imageLabel_Edit.IMGContainer = null;
            this.imageLabel_Edit.ImgDisable = null;
            this.imageLabel_Edit.Layout = ComCtrls.KTLayout.GlyphTop;
            this.imageLabel_Edit.Location = new System.Drawing.Point(133, 315);
            this.imageLabel_Edit.Name = "imageLabel_Edit";
            this.imageLabel_Edit.Size = new System.Drawing.Size(120, 60);
            this.imageLabel_Edit.TabIndex = 6;
            this.imageLabel_Edit.TabStop = false;
            this.imageLabel_Edit.Tag = "0";
            this.imageLabel_Edit.Text = "编辑";
            this.imageLabel_Edit.TextX = -1F;
            this.imageLabel_Edit.TextY = -1F;
            this.imageLabel_Edit.TransParent = true;
            this.imageLabel_Edit.Click += new System.EventHandler(this.imageLabel_Click);
            this.imageLabel_Edit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageLabel_MouseUp);
            // 
            // imageLabel_Diagnose
            // 
            this.imageLabel_Diagnose.BackImg = null;
            this.imageLabel_Diagnose.Checked = false;
            this.imageLabel_Diagnose.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular);
            this.imageLabel_Diagnose.IMGContainer = null;
            this.imageLabel_Diagnose.ImgDisable = null;
            this.imageLabel_Diagnose.Layout = ComCtrls.KTLayout.GlyphTop;
            this.imageLabel_Diagnose.Location = new System.Drawing.Point(362, 315);
            this.imageLabel_Diagnose.Name = "imageLabel_Diagnose";
            this.imageLabel_Diagnose.Size = new System.Drawing.Size(120, 60);
            this.imageLabel_Diagnose.TabIndex = 13;
            this.imageLabel_Diagnose.TabStop = false;
            this.imageLabel_Diagnose.Tag = "1";
            this.imageLabel_Diagnose.Text = "诊断";
            this.imageLabel_Diagnose.TextX = -1F;
            this.imageLabel_Diagnose.TextY = -1F;
            this.imageLabel_Diagnose.TransParent = true;
            this.imageLabel_Diagnose.Click += new System.EventHandler(this.imageLabel_Click);
            this.imageLabel_Diagnose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageLabel_MouseUp);
            // 
            // imageLabel_Reset
            // 
            this.imageLabel_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageLabel_Reset.Checked = false;
            this.imageLabel_Reset.DNImg = null;
            this.imageLabel_Reset.DNImgDisable = null;
            this.imageLabel_Reset.DownColor = System.Drawing.Color.Silver;
            this.imageLabel_Reset.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular);
            this.imageLabel_Reset.IMGContainer = null;
            this.imageLabel_Reset.Layout = ComCtrls.KTLayout.GlyphTop;
            this.imageLabel_Reset.Location = new System.Drawing.Point(20, 307);
            this.imageLabel_Reset.Name = "imageLabel_Reset";
            this.imageLabel_Reset.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.imageLabel_Reset.Size = new System.Drawing.Size(120, 60);
            this.imageLabel_Reset.TabIndex = 14;
            this.imageLabel_Reset.TabStop = false;
            this.imageLabel_Reset.Text = "复位";
            this.imageLabel_Reset.Toggle = false;
            this.imageLabel_Reset.TransParent = true;
            this.imageLabel_Reset.UpColor = System.Drawing.Color.Silver;
            this.imageLabel_Reset.UPImg = null;
            this.imageLabel_Reset.UPImgDisable = null;
            this.imageLabel_Reset.Click += new System.EventHandler(this.imageLabel_Reset_Click);
            // 
            // imageLabel_Home
            // 
            this.imageLabel_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageLabel_Home.Checked = false;
            this.imageLabel_Home.DNImg = null;
            this.imageLabel_Home.DNImgDisable = null;
            this.imageLabel_Home.DownColor = System.Drawing.Color.Silver;
            this.imageLabel_Home.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular);
            this.imageLabel_Home.IMGContainer = null;
            this.imageLabel_Home.Layout = ComCtrls.KTLayout.GlyphTop;
            this.imageLabel_Home.Location = new System.Drawing.Point(652, 206);
            this.imageLabel_Home.Name = "imageLabel_Home";
            this.imageLabel_Home.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.imageLabel_Home.Size = new System.Drawing.Size(120, 60);
            this.imageLabel_Home.TabIndex = 15;
            this.imageLabel_Home.TabStop = false;
            this.imageLabel_Home.Text = "回零";
            this.imageLabel_Home.Toggle = false;
            this.imageLabel_Home.TransParent = true;
            this.imageLabel_Home.UpColor = System.Drawing.Color.Silver;
            this.imageLabel_Home.UPImg = null;
            this.imageLabel_Home.UPImgDisable = null;
            this.imageLabel_Home.Click += new System.EventHandler(this.imageLabel_Home_Click);
            // 
            // imageLabel_Start
            // 
            this.imageLabel_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageLabel_Start.Checked = false;
            this.imageLabel_Start.DNImg = null;
            this.imageLabel_Start.DNImgDisable = null;
            this.imageLabel_Start.DownColor = System.Drawing.Color.Silver;
            this.imageLabel_Start.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular);
            this.imageLabel_Start.IMGContainer = null;
            this.imageLabel_Start.Layout = ComCtrls.KTLayout.GlyphTop;
            this.imageLabel_Start.Location = new System.Drawing.Point(652, 97);
            this.imageLabel_Start.Name = "imageLabel_Start";
            this.imageLabel_Start.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.imageLabel_Start.Size = new System.Drawing.Size(120, 60);
            this.imageLabel_Start.TabIndex = 16;
            this.imageLabel_Start.TabStop = false;
            this.imageLabel_Start.Text = "启动|暂停";
            this.imageLabel_Start.Toggle = false;
            this.imageLabel_Start.TransParent = true;
            this.imageLabel_Start.UpColor = System.Drawing.Color.Silver;
            this.imageLabel_Start.UPImg = null;
            this.imageLabel_Start.UPImgDisable = null;
            this.imageLabel_Start.Click += new System.EventHandler(this.imageLabel_Start_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(627, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 474);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.imageLabel_Reset);
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 464);
            // 
            // PageViewMAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.imageLabel_Start);
            this.Controls.Add(this.imageLabel_Home);
            this.Controls.Add(this.imageLabel_Diagnose);
            this.Controls.Add(this.imageLabel_Edit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Pos);
            this.Controls.Add(this.label_ToolNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular);
            this.Name = "PageViewMAC";
            this.Size = new System.Drawing.Size(800, 480);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_ToolNum;
        private System.Windows.Forms.Label label_Pos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComCtrls.ImageLabel imageLabel_Edit;
        private ComCtrls.ImageLabel imageLabel_Diagnose;
        private ComCtrls.ImageButton imageLabel_Reset;
        private ComCtrls.ImageButton imageLabel_Home;
        private ComCtrls.ImageButton imageLabel_Start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
