using System;
namespace CoolantPostureController.UICtrls
{
    partial class PageViewDiagnose
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
            this.button33 = new ComCtrls.ImageButton(this.components);
            this.label_Diagnose = new System.Windows.Forms.Label();
            this.panel_Drv = new System.Windows.Forms.Panel();
            this.panel_IO = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button33
            // 
            this.button33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button33.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.button33.Location = new System.Drawing.Point(663, 326);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(99, 62);
            this.button33.TabIndex = 32;
            this.button33.Text = "返回";
            this.button33.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ExitButton_Click);
            // 
            // label_Diagnose
            // 
            this.label_Diagnose.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular);
            this.label_Diagnose.Location = new System.Drawing.Point(317, 4);
            this.label_Diagnose.Name = "label_Diagnose";
            this.label_Diagnose.Size = new System.Drawing.Size(169, 40);
            this.label_Diagnose.Text = "诊断";
            // 
            // panel_Drv
            // 
            this.panel_Drv.Location = new System.Drawing.Point(389, 36);
            this.panel_Drv.Name = "panel_Drv";
            this.panel_Drv.Size = new System.Drawing.Size(351, 371);
            // 
            // panel_IO
            // 
            this.panel_IO.Location = new System.Drawing.Point(12, 36);
            this.panel_IO.Name = "panel_IO";
            this.panel_IO.Size = new System.Drawing.Size(351, 371);
            // 
            // PageViewDiagnose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.button33);
            this.Controls.Add(this.panel_Drv);
            this.Controls.Add(this.panel_IO);
            this.Controls.Add(this.label_Diagnose);
            this.Name = "PageViewDiagnose";
            this.Size = new System.Drawing.Size(800, 410);
            this.Click += new System.EventHandler(this.PageViewDiagnose_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private ComCtrls.ImageButton button33;
        private System.Windows.Forms.Label label_Diagnose;
        private System.Windows.Forms.Panel panel_Drv;
        private System.Windows.Forms.Panel panel_IO;
    }
}
