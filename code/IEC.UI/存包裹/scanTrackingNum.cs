﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Keyboard;

namespace IEC.UI
{
    public partial class scanTrackingNum : UserControl
    {
        public scanTrackingNum()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            virtualNumKeyboard.Keyboard = KeyboardInstance.CreateNumericKeyboard();
            virtualNumKeyboard.Renderer = new vKeyboardRenderer();
            virtualNumKeyboard.Invalidate();
        }
        public event EventHandler scanTNEvent;
        public void inputFocus()
        {
            trackingNum.Clear();
            trackingNum.Focus();
        }
        public string getTrackingNum()
        {
            return trackingNum.Text;
        }

        public void errorMessage(string str)
        {
            errMsg.Text = str;
        }
        private void confirmScanTN_Click(object sender, EventArgs e)
        {
            if (scanTNEvent != null)
            {
                scanTNEvent(this, e);
            }
        }

        private void trackingNum_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (trackingNum.Text!=""&&scanTNEvent != null)
                {
                    ((TextBox)(sender)).SelectAll();
                    scanTNEvent(this, e);
                }
            }
        }

    }
}
