namespace CoolantPostureController
{
    partial class Terminal
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
            this.button_Read = new System.Windows.Forms.Button();
            this.textBox_Idx = new System.Windows.Forms.TextBox();
            this.textBox_Val = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_Init = new System.Windows.Forms.Button();
            this.button_Locate = new System.Windows.Forms.Button();
            this.textBox_pos = new System.Windows.Forms.TextBox();
            this.button_Home = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label_Pos = new System.Windows.Forms.Label();
            this.button_pos = new System.Windows.Forms.Button();
            this.checkBox_homed = new System.Windows.Forms.CheckBox();
            this.checkBox_inpos = new System.Windows.Forms.CheckBox();
            this.checkBox_err = new System.Windows.Forms.CheckBox();
            this.checkBox_en = new System.Windows.Forms.CheckBox();
            this.label_TN = new System.Windows.Forms.Label();
            this.checkBox_Ready = new System.Windows.Forms.CheckBox();
            this.checkBox_Inc = new System.Windows.Forms.CheckBox();
            this.checkBox_Dec = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_ot0 = new System.Windows.Forms.CheckBox();
            this.checkBox_ot1 = new System.Windows.Forms.CheckBox();
            this.checkBox_ot2 = new System.Windows.Forms.CheckBox();
            this.checkBox_ot3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Read
            // 
            this.button_Read.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.button_Read.Location = new System.Drawing.Point(336, 51);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(72, 26);
            this.button_Read.TabIndex = 0;
            this.button_Read.Text = "读取";
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // textBox_Idx
            // 
            this.textBox_Idx.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.textBox_Idx.Location = new System.Drawing.Point(44, 62);
            this.textBox_Idx.Name = "textBox_Idx";
            this.textBox_Idx.Size = new System.Drawing.Size(100, 29);
            this.textBox_Idx.TabIndex = 1;
            this.textBox_Idx.Text = "0";
            // 
            // textBox_Val
            // 
            this.textBox_Val.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.textBox_Val.Location = new System.Drawing.Point(187, 62);
            this.textBox_Val.Name = "textBox_Val";
            this.textBox_Val.Size = new System.Drawing.Size(100, 29);
            this.textBox_Val.TabIndex = 2;
            this.textBox_Val.Text = "0";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "参数号:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(187, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "值:";
            // 
            // button_Send
            // 
            this.button_Send.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.button_Send.Location = new System.Drawing.Point(336, 91);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(72, 26);
            this.button_Send.TabIndex = 6;
            this.button_Send.Text = "写入";
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_Init
            // 
            this.button_Init.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.button_Init.Location = new System.Drawing.Point(336, 129);
            this.button_Init.Name = "button_Init";
            this.button_Init.Size = new System.Drawing.Size(92, 26);
            this.button_Init.TabIndex = 7;
            this.button_Init.Text = "批量初始化";
            this.button_Init.Click += new System.EventHandler(this.button_Init_Click);
            // 
            // button_Locate
            // 
            this.button_Locate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.button_Locate.Location = new System.Drawing.Point(453, 91);
            this.button_Locate.Name = "button_Locate";
            this.button_Locate.Size = new System.Drawing.Size(60, 20);
            this.button_Locate.TabIndex = 10;
            this.button_Locate.Text = "GOTO";
            this.button_Locate.Click += new System.EventHandler(this.button_Locate_Click);
            // 
            // textBox_pos
            // 
            this.textBox_pos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.textBox_pos.Location = new System.Drawing.Point(453, 51);
            this.textBox_pos.Name = "textBox_pos";
            this.textBox_pos.Size = new System.Drawing.Size(85, 26);
            this.textBox_pos.TabIndex = 11;
            this.textBox_pos.Text = "0";
            // 
            // button_Home
            // 
            this.button_Home.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.button_Home.Location = new System.Drawing.Point(453, 129);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(60, 20);
            this.button_Home.TabIndex = 12;
            this.button_Home.Text = "回零";
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.button_Stop.Location = new System.Drawing.Point(536, 91);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(51, 20);
            this.button_Stop.TabIndex = 13;
            this.button_Stop.Text = "暂停";
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.button_Reset.Location = new System.Drawing.Point(536, 129);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(51, 20);
            this.button_Reset.TabIndex = 14;
            this.button_Reset.Text = "复位";
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // label_Pos
            // 
            this.label_Pos.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label_Pos.Location = new System.Drawing.Point(592, 56);
            this.label_Pos.Name = "label_Pos";
            this.label_Pos.Size = new System.Drawing.Size(81, 20);
            this.label_Pos.Text = "0.0";
            // 
            // button_pos
            // 
            this.button_pos.Location = new System.Drawing.Point(554, 28);
            this.button_pos.Name = "button_pos";
            this.button_pos.Size = new System.Drawing.Size(25, 20);
            this.button_pos.TabIndex = 16;
            this.button_pos.Text = "^";
            this.button_pos.Click += new System.EventHandler(this.button_pos_Click);
            // 
            // checkBox_homed
            // 
            this.checkBox_homed.Location = new System.Drawing.Point(602, 91);
            this.checkBox_homed.Name = "checkBox_homed";
            this.checkBox_homed.Size = new System.Drawing.Size(63, 20);
            this.checkBox_homed.TabIndex = 24;
            this.checkBox_homed.Text = "回零";
            // 
            // checkBox_inpos
            // 
            this.checkBox_inpos.Location = new System.Drawing.Point(602, 109);
            this.checkBox_inpos.Name = "checkBox_inpos";
            this.checkBox_inpos.Size = new System.Drawing.Size(63, 20);
            this.checkBox_inpos.TabIndex = 25;
            this.checkBox_inpos.Text = "到位";
            // 
            // checkBox_err
            // 
            this.checkBox_err.Location = new System.Drawing.Point(602, 128);
            this.checkBox_err.Name = "checkBox_err";
            this.checkBox_err.Size = new System.Drawing.Size(63, 20);
            this.checkBox_err.TabIndex = 26;
            this.checkBox_err.Text = "报错";
            // 
            // checkBox_en
            // 
            this.checkBox_en.Location = new System.Drawing.Point(602, 145);
            this.checkBox_en.Name = "checkBox_en";
            this.checkBox_en.Size = new System.Drawing.Size(63, 20);
            this.checkBox_en.TabIndex = 27;
            this.checkBox_en.Text = "能使";
            // 
            // label_TN
            // 
            this.label_TN.Location = new System.Drawing.Point(584, 201);
            this.label_TN.Name = "label_TN";
            this.label_TN.Size = new System.Drawing.Size(33, 20);
            this.label_TN.Text = "0";
            // 
            // checkBox_Ready
            // 
            this.checkBox_Ready.Location = new System.Drawing.Point(542, 229);
            this.checkBox_Ready.Name = "checkBox_Ready";
            this.checkBox_Ready.Size = new System.Drawing.Size(75, 20);
            this.checkBox_Ready.TabIndex = 32;
            this.checkBox_Ready.Text = "就绪";
            // 
            // checkBox_Inc
            // 
            this.checkBox_Inc.Location = new System.Drawing.Point(542, 248);
            this.checkBox_Inc.Name = "checkBox_Inc";
            this.checkBox_Inc.Size = new System.Drawing.Size(100, 20);
            this.checkBox_Inc.TabIndex = 33;
            this.checkBox_Inc.Text = "Inc";
            // 
            // checkBox_Dec
            // 
            this.checkBox_Dec.Location = new System.Drawing.Point(542, 267);
            this.checkBox_Dec.Name = "checkBox_Dec";
            this.checkBox_Dec.Size = new System.Drawing.Size(100, 20);
            this.checkBox_Dec.TabIndex = 34;
            this.checkBox_Dec.Text = "Dec";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(536, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.Text = "刀号";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(618, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.Text = "输出";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(545, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.Text = "角度";
            // 
            // checkBox_ot0
            // 
            this.checkBox_ot0.Location = new System.Drawing.Point(618, 229);
            this.checkBox_ot0.Name = "checkBox_ot0";
            this.checkBox_ot0.Size = new System.Drawing.Size(100, 20);
            this.checkBox_ot0.TabIndex = 40;
            this.checkBox_ot0.Tag = "0";
            this.checkBox_ot0.Text = "output0";
            this.checkBox_ot0.CheckStateChanged += new System.EventHandler(this.checkBox_ot0_CheckStateChanged);
            // 
            // checkBox_ot1
            // 
            this.checkBox_ot1.Location = new System.Drawing.Point(618, 248);
            this.checkBox_ot1.Name = "checkBox_ot1";
            this.checkBox_ot1.Size = new System.Drawing.Size(100, 20);
            this.checkBox_ot1.TabIndex = 41;
            this.checkBox_ot1.Tag = "1";
            this.checkBox_ot1.Text = "output1";
            this.checkBox_ot1.CheckStateChanged += new System.EventHandler(this.checkBox_ot0_CheckStateChanged);
            // 
            // checkBox_ot2
            // 
            this.checkBox_ot2.Location = new System.Drawing.Point(618, 267);
            this.checkBox_ot2.Name = "checkBox_ot2";
            this.checkBox_ot2.Size = new System.Drawing.Size(100, 20);
            this.checkBox_ot2.TabIndex = 42;
            this.checkBox_ot2.Tag = "2";
            this.checkBox_ot2.Text = "output2";
            this.checkBox_ot2.CheckStateChanged += new System.EventHandler(this.checkBox_ot0_CheckStateChanged);
            // 
            // checkBox_ot3
            // 
            this.checkBox_ot3.Location = new System.Drawing.Point(618, 284);
            this.checkBox_ot3.Name = "checkBox_ot3";
            this.checkBox_ot3.Size = new System.Drawing.Size(100, 20);
            this.checkBox_ot3.TabIndex = 43;
            this.checkBox_ot3.Tag = "3";
            this.checkBox_ot3.Text = "output3";
            this.checkBox_ot3.CheckStateChanged += new System.EventHandler(this.checkBox_ot0_CheckStateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 51;
            this.button1.Text = "返回";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_ot3);
            this.Controls.Add(this.checkBox_ot2);
            this.Controls.Add(this.checkBox_ot1);
            this.Controls.Add(this.checkBox_ot0);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_Dec);
            this.Controls.Add(this.checkBox_Inc);
            this.Controls.Add(this.checkBox_Ready);
            this.Controls.Add(this.label_TN);
            this.Controls.Add(this.checkBox_en);
            this.Controls.Add(this.checkBox_err);
            this.Controls.Add(this.checkBox_inpos);
            this.Controls.Add(this.checkBox_homed);
            this.Controls.Add(this.button_pos);
            this.Controls.Add(this.label_Pos);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Home);
            this.Controls.Add(this.textBox_pos);
            this.Controls.Add(this.button_Locate);
            this.Controls.Add(this.button_Init);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Val);
            this.Controls.Add(this.textBox_Idx);
            this.Controls.Add(this.button_Read);
            this.Controls.Add(this.label4);
            this.Name = "Terminal";
            this.Size = new System.Drawing.Size(800, 400);
            this.Click += new System.EventHandler(this.Terminal_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.TextBox textBox_Idx;
        private System.Windows.Forms.TextBox textBox_Val;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_Init;
        private System.Windows.Forms.Button button_Locate;
        private System.Windows.Forms.TextBox textBox_pos;
        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label_Pos;
        private System.Windows.Forms.Button button_pos;
        private System.Windows.Forms.CheckBox checkBox_homed;
        private System.Windows.Forms.CheckBox checkBox_inpos;
        private System.Windows.Forms.CheckBox checkBox_err;
        private System.Windows.Forms.CheckBox checkBox_en;
        private System.Windows.Forms.Label label_TN;
        private System.Windows.Forms.CheckBox checkBox_Ready;
        private System.Windows.Forms.CheckBox checkBox_Inc;
        private System.Windows.Forms.CheckBox checkBox_Dec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_ot0;
        private System.Windows.Forms.CheckBox checkBox_ot1;
        private System.Windows.Forms.CheckBox checkBox_ot2;
        private System.Windows.Forms.CheckBox checkBox_ot3;
        private System.Windows.Forms.Button button1;
    }
}
