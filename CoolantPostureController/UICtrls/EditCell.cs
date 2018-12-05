using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CoolantPostureController.UICtrls
{
    public partial class EditCell : UserControl
    {
        public EditCell()
        {
            InitializeComponent();


        }

        private bool _checked = false;
        public bool Checked
        {
            get { return _checked; }
            set
            {
                if (_checked != value)
                {
                    _checked = value;
                    DoRefresh();
                }
            }
        }

        private void DoRefresh()
        {
            this.BackColor = (Checked) ?
                System.Drawing.Color.Gray :
                System.Drawing.Color.LightGray;

            this.label_Num.ForeColor = (Checked) ?
                System.Drawing.Color.White :
                System.Drawing.Color.Black;

            label_Num.Text = "#" + KeyNum.ToString();
            label_Val.Text = KeyValue.ToString("0.0");
        }

        private void EditCell_Click(object sender, EventArgs e)
        {

        }

        private int _keynum = -1;
        public int KeyNum
        {
            get { return _keynum; }
            set
            {
                if (_keynum != value)
                {
                    _keynum = value;
                    DoRefresh();
                }
            }
        }

        private double _keyVal = -1;
        public double KeyValue
        {
            get { return _keyVal; }
            set
            {
                if (_keyVal != value)
                {
                    _keyVal = value;
                    DoRefresh();
                }
            }
        }


    }
}
