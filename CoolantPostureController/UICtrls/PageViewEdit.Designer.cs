namespace CoolantPostureController.UICtrls
{
    partial class PageViewEdit
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageButton_Set = new ComCtrls.ImageButton(this.components);
            this.imageButton_Dec = new ComCtrls.ImageButton(this.components);
            this.imageButton_Inc = new ComCtrls.ImageButton(this.components);
            this.label_Pos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_ToolNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_back = new ComCtrls.ImageButton(this.components);
            this.panel_body = new System.Windows.Forms.Panel();
            this.label_cap = new System.Windows.Forms.Label();
            this.imageButton_Pgback = new ComCtrls.ImageButton(this.components);
            this.imageButton_PgFore = new ComCtrls.ImageButton(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.imageButton_Set);
            this.panel1.Controls.Add(this.imageButton_Dec);
            this.panel1.Controls.Add(this.imageButton_Inc);
            this.panel1.Controls.Add(this.label_Pos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label_ToolNum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Location = new System.Drawing.Point(627, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 404);
            // 
            // imageButton_Set
            // 
            this.imageButton_Set.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton_Set.Checked = false;
            this.imageButton_Set.DNImg = null;
            this.imageButton_Set.DNImgDisable = null;
            this.imageButton_Set.DownColor = System.Drawing.SystemColors.Control;
            this.imageButton_Set.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.imageButton_Set.IMGContainer = null;
            this.imageButton_Set.Layout = ComCtrls.KTLayout.GlyphTop;
            this.imageButton_Set.Location = new System.Drawing.Point(8, 253);
            this.imageButton_Set.Name = "imageButton_Set";
            this.imageButton_Set.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.imageButton_Set.Size = new System.Drawing.Size(155, 62);
            this.imageButton_Set.TabIndex = 42;
            this.imageButton_Set.TabStop = false;
            this.imageButton_Set.Text = "设置";
            this.imageButton_Set.Toggle = false;
            this.imageButton_Set.TransParent = true;
            this.imageButton_Set.UpColor = System.Drawing.SystemColors.Control;
            this.imageButton_Set.UPImg = null;
            this.imageButton_Set.UPImgDisable = null;
            this.imageButton_Set.Click += new System.EventHandler(this.imageButton_Set_Click);
            // 
            // imageButton_Dec
            // 
            this.imageButton_Dec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton_Dec.Checked = false;
            this.imageButton_Dec.DNImg = null;
            this.imageButton_Dec.DNImgDisable = null;
            this.imageButton_Dec.DownColor = System.Drawing.SystemColors.Control;
            this.imageButton_Dec.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.imageButton_Dec.IMGContainer = null;
            this.imageButton_Dec.Layout = ComCtrls.KTLayout.GlyphTop;
            this.imageButton_Dec.Location = new System.Drawing.Point(8, 171); 
            this.imageButton_Dec.Name = "imageButton_Dec";
            this.imageButton_Dec.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.imageButton_Dec.Size = new System.Drawing.Size(75, 62);
            this.imageButton_Dec.TabIndex = 41;
            this.imageButton_Dec.TabStop = false;
            this.imageButton_Dec.Text = "手动-";
            this.imageButton_Dec.Toggle = false;
            this.imageButton_Dec.TransParent = true;
            this.imageButton_Dec.UpColor = System.Drawing.SystemColors.Control;
            this.imageButton_Dec.UPImg = null;
            this.imageButton_Dec.UPImgDisable = null;
            this.imageButton_Dec.Click += new System.EventHandler(this.imageButton_Dec_Click);
            // 
            // imageButton_Inc
            // 
            this.imageButton_Inc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton_Inc.Checked = false;
            this.imageButton_Inc.DNImg = null;
            this.imageButton_Inc.DNImgDisable = null;
            this.imageButton_Inc.DownColor = System.Drawing.SystemColors.Control;
            this.imageButton_Inc.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.imageButton_Inc.IMGContainer = null;
            this.imageButton_Inc.Layout = ComCtrls.KTLayout.GlyphTop;
            this.imageButton_Inc.Location = new System.Drawing.Point(88, 171);
            this.imageButton_Inc.Name = "imageButton_Inc";
            this.imageButton_Inc.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.imageButton_Inc.Size = new System.Drawing.Size(75, 62);
            this.imageButton_Inc.TabIndex = 40;
            this.imageButton_Inc.TabStop = false;
            this.imageButton_Inc.Text = "手动+";
            this.imageButton_Inc.Toggle = false;
            this.imageButton_Inc.TransParent = true;
            this.imageButton_Inc.UpColor = System.Drawing.SystemColors.Control;
            this.imageButton_Inc.UPImg = null;
            this.imageButton_Inc.UPImgDisable = null;
            this.imageButton_Inc.Click += new System.EventHandler(this.imageButton_Inc_Click);
            // 
            // label_Pos
            // 
            this.label_Pos.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular);
            this.label_Pos.Location = new System.Drawing.Point(89, 92);
            this.label_Pos.Name = "label_Pos";
            this.label_Pos.Size = new System.Drawing.Size(76, 20);
            this.label_Pos.Text = "360.5";
            this.label_Pos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.Text = "当前角度值";
            // 
            // label_ToolNum
            // 
            this.label_ToolNum.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular);
            this.label_ToolNum.Location = new System.Drawing.Point(88, 35);
            this.label_ToolNum.Name = "label_ToolNum";
            this.label_ToolNum.Size = new System.Drawing.Size(77, 20);
            this.label_ToolNum.Text = "#2";
            this.label_ToolNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.Text = "当前刀具号";
            // 
            // button_back
            // 
            this.button_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_back.Checked = false;
            this.button_back.DNImg = null;
            this.button_back.DNImgDisable = null;
            this.button_back.DownColor = System.Drawing.SystemColors.Control;
            this.button_back.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.button_back.IMGContainer = null;
            this.button_back.Layout = ComCtrls.KTLayout.GlyphTop;
            this.button_back.Location = new System.Drawing.Point(37, 339);
            this.button_back.Name = "button_back";
            this.button_back.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.button_back.Size = new System.Drawing.Size(99, 62);
            this.button_back.TabIndex = 33;
            this.button_back.TabStop = false;
            this.button_back.Text = "返回";
            this.button_back.Toggle = false;
            this.button_back.TransParent = true;
            this.button_back.UpColor = System.Drawing.SystemColors.Control;
            this.button_back.UPImg = null;
            this.button_back.UPImgDisable = null;
            // 
            // panel_body
            // 
            this.panel_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_body.Location = new System.Drawing.Point(3, 33);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(621, 374);
            // 
            // label_cap
            // 
            this.label_cap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cap.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular);
            this.label_cap.Location = new System.Drawing.Point(308, 3);
            this.label_cap.Name = "label_cap";
            this.label_cap.Size = new System.Drawing.Size(146, 35);
            this.label_cap.Text = "编 辑";
            // 
            // imageButton_Pgback
            // 
            this.imageButton_Pgback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.imageButton_Pgback.Checked = false;
            this.imageButton_Pgback.DNImg = null;
            this.imageButton_Pgback.DNImgDisable = null;
            this.imageButton_Pgback.DownColor = System.Drawing.SystemColors.Control;
            this.imageButton_Pgback.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.imageButton_Pgback.IMGContainer = null;
            this.imageButton_Pgback.Layout = ComCtrls.KTLayout.GlyphTop;
            this.imageButton_Pgback.Location = new System.Drawing.Point(0, 0);
            this.imageButton_Pgback.Name = "imageButton_Pgback";
            this.imageButton_Pgback.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.imageButton_Pgback.Size = new System.Drawing.Size(48, 36);
            this.imageButton_Pgback.TabIndex = 34;
            this.imageButton_Pgback.TabStop = false;
            this.imageButton_Pgback.Text = "<<";
            this.imageButton_Pgback.Toggle = false;
            this.imageButton_Pgback.TransParent = true;
            this.imageButton_Pgback.UpColor = System.Drawing.SystemColors.Control;
            this.imageButton_Pgback.UPImg = null;
            this.imageButton_Pgback.UPImgDisable = null;
            this.imageButton_Pgback.Click += new System.EventHandler(this.imageButton_Pgback_Click);
            // 
            // imageButton_PgFore
            // 
            this.imageButton_PgFore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton_PgFore.Checked = false;
            this.imageButton_PgFore.DNImg = null;
            this.imageButton_PgFore.DNImgDisable = null;
            this.imageButton_PgFore.DownColor = System.Drawing.SystemColors.Control;
            this.imageButton_PgFore.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.imageButton_PgFore.IMGContainer = null;
            this.imageButton_PgFore.Layout = ComCtrls.KTLayout.GlyphTop;
            this.imageButton_PgFore.Location = new System.Drawing.Point(577, 3);
            this.imageButton_PgFore.Name = "imageButton_PgFore";
            this.imageButton_PgFore.ShortcutKeys = System.Windows.Forms.Keys.None;
            this.imageButton_PgFore.Size = new System.Drawing.Size(48, 36);
            this.imageButton_PgFore.TabIndex = 35;
            this.imageButton_PgFore.TabStop = false;
            this.imageButton_PgFore.Text = ">>";
            this.imageButton_PgFore.Toggle = false;
            this.imageButton_PgFore.TransParent = true;
            this.imageButton_PgFore.UpColor = System.Drawing.SystemColors.Control;
            this.imageButton_PgFore.UPImg = null;
            this.imageButton_PgFore.UPImgDisable = null;
            this.imageButton_PgFore.Click += new System.EventHandler(this.imageButton_PgFore_Click);
            // 
            // PageViewEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.imageButton_PgFore);
            this.Controls.Add(this.imageButton_Pgback);
            this.Controls.Add(this.label_cap);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel1);
            this.Name = "PageViewEdit";
            this.Size = new System.Drawing.Size(800, 410);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_body;
        private ComCtrls.ImageButton button_back;
        private System.Windows.Forms.Label label_cap;
        private ComCtrls.ImageButton imageButton_Pgback;
        private ComCtrls.ImageButton imageButton_PgFore;
        private System.Windows.Forms.Label label1;
        private ComCtrls.ImageButton imageButton_Dec;
        private ComCtrls.ImageButton imageButton_Inc;
        private System.Windows.Forms.Label label_Pos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_ToolNum;
        private ComCtrls.ImageButton imageButton_Set;
    }
}
