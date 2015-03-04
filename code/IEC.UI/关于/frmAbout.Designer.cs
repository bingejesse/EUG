namespace IEC.UI
{
    partial class frmAbout
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
            DevComponents.DotNetBar.Keyboard.VirtualKeyboardColorTable virtualKeyboardColorTable2 = new DevComponents.DotNetBar.Keyboard.VirtualKeyboardColorTable();
            DevComponents.DotNetBar.Keyboard.FlatStyleRenderer flatStyleRenderer2 = new DevComponents.DotNetBar.Keyboard.FlatStyleRenderer();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.ManagerPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.companyName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.adress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.telNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.serverUrl = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.remark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.confirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.managerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.virtualNumKeyboard = new DevComponents.DotNetBar.Keyboard.KeyboardControl();
            this.modeltype = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(170, 59);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(126, 32);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "管理员密码：";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(189, 106);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(107, 32);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "智能柜名：";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(170, 153);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(126, 32);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "所属公司名：";
            // 
            // ManagerPwd
            // 
            // 
            // 
            // 
            this.ManagerPwd.Border.Class = "TextBoxBorder";
            this.ManagerPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ManagerPwd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ManagerPwd.Location = new System.Drawing.Point(302, 59);
            this.ManagerPwd.Name = "ManagerPwd";
            this.ManagerPwd.PasswordChar = '*';
            this.ManagerPwd.PreventEnterBeep = true;
            this.ManagerPwd.Size = new System.Drawing.Size(284, 33);
            this.ManagerPwd.TabIndex = 3;
            this.ManagerPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cabinetCode_KeyPress);
            // 
            // name
            // 
            // 
            // 
            // 
            this.name.Border.Class = "TextBoxBorder";
            this.name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.name.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(302, 106);
            this.name.Name = "name";
            this.name.PreventEnterBeep = true;
            this.name.Size = new System.Drawing.Size(284, 33);
            this.name.TabIndex = 4;
            // 
            // companyName
            // 
            // 
            // 
            // 
            this.companyName.Border.Class = "TextBoxBorder";
            this.companyName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.companyName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.companyName.Location = new System.Drawing.Point(302, 153);
            this.companyName.Name = "companyName";
            this.companyName.PreventEnterBeep = true;
            this.companyName.Size = new System.Drawing.Size(284, 33);
            this.companyName.TabIndex = 5;
            // 
            // adress
            // 
            // 
            // 
            // 
            this.adress.Border.Class = "TextBoxBorder";
            this.adress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.adress.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adress.Location = new System.Drawing.Point(302, 200);
            this.adress.Name = "adress";
            this.adress.PreventEnterBeep = true;
            this.adress.Size = new System.Drawing.Size(284, 33);
            this.adress.TabIndex = 7;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.Location = new System.Drawing.Point(170, 200);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(126, 32);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "智能柜地址：";
            // 
            // telNum
            // 
            // 
            // 
            // 
            this.telNum.Border.Class = "TextBoxBorder";
            this.telNum.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.telNum.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.telNum.Location = new System.Drawing.Point(302, 247);
            this.telNum.MaxLength = 11;
            this.telNum.Name = "telNum";
            this.telNum.PreventEnterBeep = true;
            this.telNum.Size = new System.Drawing.Size(284, 33);
            this.telNum.TabIndex = 9;
            this.telNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telNum_KeyPress);
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.Location = new System.Drawing.Point(170, 247);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(126, 32);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "管理员电话：";
            // 
            // serverUrl
            // 
            // 
            // 
            // 
            this.serverUrl.Border.Class = "TextBoxBorder";
            this.serverUrl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.serverUrl.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.serverUrl.Location = new System.Drawing.Point(302, 294);
            this.serverUrl.Name = "serverUrl";
            this.serverUrl.PreventEnterBeep = true;
            this.serverUrl.Size = new System.Drawing.Size(284, 33);
            this.serverUrl.TabIndex = 11;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.Location = new System.Drawing.Point(178, 294);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(118, 32);
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "serverUrl：";
            // 
            // remark
            // 
            // 
            // 
            // 
            this.remark.Border.Class = "TextBoxBorder";
            this.remark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.remark.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remark.Location = new System.Drawing.Point(302, 388);
            this.remark.Name = "remark";
            this.remark.PreventEnterBeep = true;
            this.remark.Size = new System.Drawing.Size(284, 33);
            this.remark.TabIndex = 13;
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX7.Location = new System.Drawing.Point(228, 388);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(68, 32);
            this.labelX7.TabIndex = 12;
            this.labelX7.Text = "备注：";
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm.Location = new System.Drawing.Point(178, 446);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(118, 38);
            this.confirm.TabIndex = 14;
            this.confirm.Text = "确定";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Location = new System.Drawing.Point(414, 446);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(118, 38);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // managerName
            // 
            // 
            // 
            // 
            this.managerName.Border.Class = "TextBoxBorder";
            this.managerName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.managerName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.managerName.Location = new System.Drawing.Point(302, 12);
            this.managerName.Name = "managerName";
            this.managerName.PreventEnterBeep = true;
            this.managerName.Size = new System.Drawing.Size(284, 33);
            this.managerName.TabIndex = 17;
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX8.Location = new System.Drawing.Point(150, 12);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(146, 32);
            this.labelX8.TabIndex = 16;
            this.labelX8.Text = "管理员用户名：";
            // 
            // virtualNumKeyboard
            // 
            this.virtualNumKeyboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            virtualKeyboardColorTable2.BackgroundColor = System.Drawing.Color.Black;
            virtualKeyboardColorTable2.DarkKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            virtualKeyboardColorTable2.DownKeysColor = System.Drawing.Color.White;
            virtualKeyboardColorTable2.DownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            virtualKeyboardColorTable2.KeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            virtualKeyboardColorTable2.LightKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            virtualKeyboardColorTable2.PressedKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(161)))), ((int)(((byte)(81)))));
            virtualKeyboardColorTable2.TextColor = System.Drawing.Color.White;
            virtualKeyboardColorTable2.ToggleTextColor = System.Drawing.Color.Green;
            virtualKeyboardColorTable2.TopBarTextColor = System.Drawing.Color.White;
            this.virtualNumKeyboard.ColorTable = virtualKeyboardColorTable2;
            this.virtualNumKeyboard.IsTopBarVisible = false;
            this.virtualNumKeyboard.Location = new System.Drawing.Point(57, 500);
            this.virtualNumKeyboard.Name = "virtualNumKeyboard";
            flatStyleRenderer2.ColorTable = virtualKeyboardColorTable2;
            flatStyleRenderer2.ForceAntiAlias = false;
            this.virtualNumKeyboard.Renderer = flatStyleRenderer2;
            this.virtualNumKeyboard.Size = new System.Drawing.Size(672, 230);
            this.virtualNumKeyboard.TabIndex = 18;
            this.virtualNumKeyboard.Text = "keyboardControl1";
            // 
            // modeltype
            // 
            // 
            // 
            // 
            this.modeltype.Border.Class = "TextBoxBorder";
            this.modeltype.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.modeltype.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modeltype.Location = new System.Drawing.Point(302, 341);
            this.modeltype.Name = "modeltype";
            this.modeltype.PreventEnterBeep = true;
            this.modeltype.Size = new System.Drawing.Size(284, 33);
            this.modeltype.TabIndex = 20;
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX9.Location = new System.Drawing.Point(228, 341);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(68, 32);
            this.labelX9.TabIndex = 19;
            this.labelX9.Text = "型号：";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 742);
            this.Controls.Add(this.modeltype);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.virtualNumKeyboard);
            this.Controls.Add(this.managerName);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.remark);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.serverUrl);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.telNum);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.ManagerPwd);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "信息配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX ManagerPwd;
        private DevComponents.DotNetBar.Controls.TextBoxX name;
        private DevComponents.DotNetBar.Controls.TextBoxX companyName;
        private DevComponents.DotNetBar.Controls.TextBoxX adress;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX telNum;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX serverUrl;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX remark;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button cancel;
        private DevComponents.DotNetBar.Controls.TextBoxX managerName;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Keyboard.KeyboardControl virtualNumKeyboard;
        private DevComponents.DotNetBar.Controls.TextBoxX modeltype;
        private DevComponents.DotNetBar.LabelX labelX9;
    }
}