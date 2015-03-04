using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IEC.UI
{
    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string oldpassword = txtoldPassWord.Text;
            string newpassword = txtnewPassWord.Text;
            string repeatpassword = txtrepeatPassWord.Text;
            if (oldpassword != "admini")
            {
                MessageBox.Show("旧密码错误");
                return;
            }
            if (newpassword != repeatpassword)
            {
                MessageBox.Show("密码不一致");
                return;
            }
            if (newpassword.Length < 7)
            {
                MessageBox.Show("密码长度必须大于6个字符");
                return;
            }
            if (newpassword == oldpassword)
            {
                MessageBox.Show("新旧密码不能一样");
                return;
            }
            else
            {
                MessageBox.Show("密码修改成功");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
