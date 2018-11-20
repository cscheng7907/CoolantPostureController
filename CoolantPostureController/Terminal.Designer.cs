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
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.button_Init);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Val);
            this.Controls.Add(this.textBox_Idx);
            this.Controls.Add(this.button_Read);
            this.Name = "Terminal";
            this.Size = new System.Drawing.Size(604, 195);
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
    }
}
