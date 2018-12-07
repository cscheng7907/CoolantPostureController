namespace CoolantPostureController.UICtrls
{
    partial class EditCell
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
            this.label_Num = new System.Windows.Forms.Label();
            this.label_Val = new ComCtrls.ImageLabel();
            this.SuspendLayout();
            // 
            // label_Num
            // 
            this.label_Num.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Num.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label_Num.Location = new System.Drawing.Point(0, 5);
            this.label_Num.Name = "label_Num";
            this.label_Num.Size = new System.Drawing.Size(55, 21);
            this.label_Num.Text = "#18";
            // 
            // label_Val
            // 
            this.label_Val.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Val.BackColor = System.Drawing.Color.White;
            this.label_Val.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular);
            this.label_Val.Location = new System.Drawing.Point(49, 4);
            this.label_Val.Name = "label_Val";
            this.label_Val.Size = new System.Drawing.Size(102, 27);
            this.label_Val.Text = "231.2";
            this.label_Val.Click += new System.EventHandler(this.EditCell_Click);
            // this.label_Val.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EditCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.label_Val);
            this.Controls.Add(this.label_Num);
            this.Name = "EditCell";
            this.Size = new System.Drawing.Size(156, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Num;
        private ComCtrls.ImageLabel label_Val;
    }
}
