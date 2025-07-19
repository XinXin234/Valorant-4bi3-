using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 无畏契约真实4比3快捷键修改分辨率
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AntdUI.Tabs.StyleLine styleLine1 = new AntdUI.Tabs.StyleLine();
            AntdUI.SegmentedItem segmentedItem1 = new AntdUI.SegmentedItem();
            AntdUI.SegmentedItem segmentedItem2 = new AntdUI.SegmentedItem();
            AntdUI.MenuItem menuItem1 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem2 = new AntdUI.MenuItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new AntdUI.Label();
            tabs1 = new AntdUI.Tabs();
            tabPage1 = new AntdUI.TabPage();
            collapse1 = new AntdUI.Collapse();
            collapseItem1 = new AntdUI.CollapseItem();
            原始分辨率y = new AntdUI.InputNumber();
            原始分辨率x = new AntdUI.InputNumber();
            label5 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            ysfblx = new AntdUI.Input();
            collapseItem2 = new AntdUI.CollapseItem();
            更改分辨率y = new AntdUI.InputNumber();
            更改分辨率x = new AntdUI.InputNumber();
            label3 = new AntdUI.Label();
            collapseItem3 = new AntdUI.CollapseItem();
            刷新率 = new AntdUI.InputNumber();
            label4 = new AntdUI.Label();
            collapseItem4 = new AntdUI.CollapseItem();
            label6 = new AntdUI.Label();
            tabPage2 = new AntdUI.TabPage();
            alert3 = new AntdUI.Alert();
            avatar2 = new AntdUI.Avatar();
            alert1 = new AntdUI.Alert();
            alert2 = new AntdUI.Alert();
            segmented1 = new AntdUI.Segmented();
            avatar1 = new AntdUI.Avatar();
            menu1 = new AntdUI.Menu();
            pageHeader1 = new AntdUI.PageHeader();
            pageHeader2 = new AntdUI.PageHeader();
            button1 = new AntdUI.Button();
            button2 = new AntdUI.Button();
            button3 = new AntdUI.Button();
            label7 = new AntdUI.Label();
            当前版本框 = new AntdUI.Label();
            最新版本 = new AntdUI.Label();
            label9 = new AntdUI.Label();
            tabs1.SuspendLayout();
            tabPage1.SuspendLayout();
            collapse1.SuspendLayout();
            collapseItem1.SuspendLayout();
            collapseItem2.SuspendLayout();
            collapseItem3.SuspendLayout();
            collapseItem4.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(-1, 0);
            label1.Name = "label1";
            label1.ShadowColor = Color.BlueViolet;
            label1.ShadowOffsetX = 10;
            label1.ShadowOffsetY = 10;
            label1.ShadowOpacity = 1F;
            label1.Size = new Size(97, 305);
            label1.TabIndex = 1;
            label1.Text = "";
            label1.MouseDown += Form1_MouseDown;
            // 
            // tabs1
            // 
            tabs1.BackgroundImageLayout = ImageLayout.None;
            tabs1.Controls.Add(tabPage1);
            tabs1.Controls.Add(tabPage2);
            tabs1.Location = new Point(95, 0);
            tabs1.Name = "tabs1";
            tabs1.Pages.Add(tabPage1);
            tabs1.Pages.Add(tabPage2);
            tabs1.Size = new Size(418, 305);
            tabs1.Style = styleLine1;
            tabs1.TabIndex = 4;
            tabs1.TabMenuVisible = false;
            tabs1.Text = "tabs1";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(collapse1);
            tabPage1.Location = new Point(3, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(412, 299);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "主页";
            // 
            // collapse1
            // 
            collapse1.BackColor = SystemColors.Control;
            collapse1.Items.Add(collapseItem1);
            collapse1.Items.Add(collapseItem2);
            collapse1.Items.Add(collapseItem3);
            collapse1.Items.Add(collapseItem4);
            collapse1.Location = new Point(0, 0);
            collapse1.Name = "collapse1";
            collapse1.Size = new Size(412, 296);
            collapse1.TabIndex = 0;
            collapse1.Text = "collapse1";
            collapse1.Unique = true;
            collapse1.MouseDown += Form1_MouseDown;
            // 
            // collapseItem1
            // 
            collapseItem1.BackgroundImageLayout = ImageLayout.None;
            collapseItem1.Controls.Add(原始分辨率y);
            collapseItem1.Controls.Add(原始分辨率x);
            collapseItem1.Controls.Add(label5);
            collapseItem1.Controls.Add(label2);
            collapseItem1.Controls.Add(ysfblx);
            collapseItem1.Expand = true;
            collapseItem1.Location = new Point(19, 59);
            collapseItem1.Name = "collapseItem1";
            collapseItem1.Size = new Size(374, 59);
            collapseItem1.TabIndex = 0;
            collapseItem1.Text = "原始分辨率";
            collapseItem1.Click += collapseItem1_Click;
            collapseItem1.MouseDown += Form1_MouseDown;
            // 
            // 原始分辨率y
            // 
            原始分辨率y.Location = new Point(205, 8);
            原始分辨率y.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            原始分辨率y.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            原始分辨率y.Name = "原始分辨率y";
            原始分辨率y.SelectionStart = 1;
            原始分辨率y.ShowControl = false;
            原始分辨率y.Size = new Size(69, 46);
            原始分辨率y.TabIndex = 10;
            原始分辨率y.Text = "0";
            原始分辨率y.TextAlign = HorizontalAlignment.Center;
            原始分辨率y.WheelModifyEnabled = false;
            // 
            // 原始分辨率x
            // 
            原始分辨率x.Location = new Point(105, 8);
            原始分辨率x.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            原始分辨率x.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            原始分辨率x.Name = "原始分辨率x";
            原始分辨率x.SelectionStart = 1;
            原始分辨率x.ShowControl = false;
            原始分辨率x.Size = new Size(69, 46);
            原始分辨率x.TabIndex = 9;
            原始分辨率x.Text = "0";
            原始分辨率x.TextAlign = HorizontalAlignment.Center;
            原始分辨率x.WheelModifyEnabled = false;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft YaHei UI", 17F);
            label5.Location = new Point(180, 13);
            label5.Name = "label5";
            label5.Size = new Size(19, 32);
            label5.TabIndex = 7;
            label5.Text = "x";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 0);
            label2.TabIndex = 0;
            // 
            // ysfblx
            // 
            ysfblx.Location = new Point(0, 0);
            ysfblx.Name = "ysfblx";
            ysfblx.Size = new Size(0, 0);
            ysfblx.TabIndex = 2;
            // 
            // collapseItem2
            // 
            collapseItem2.Controls.Add(更改分辨率y);
            collapseItem2.Controls.Add(更改分辨率x);
            collapseItem2.Controls.Add(label3);
            collapseItem2.Location = new Point(-374, -60);
            collapseItem2.Name = "collapseItem2";
            collapseItem2.Size = new Size(374, 60);
            collapseItem2.TabIndex = 1;
            collapseItem2.Text = "更改分辨率";
            collapseItem2.MouseDown += Form1_MouseDown;
            // 
            // 更改分辨率y
            // 
            更改分辨率y.Location = new Point(205, 6);
            更改分辨率y.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            更改分辨率y.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            更改分辨率y.Name = "更改分辨率y";
            更改分辨率y.SelectionStart = 1;
            更改分辨率y.ShowControl = false;
            更改分辨率y.Size = new Size(69, 46);
            更改分辨率y.TabIndex = 12;
            更改分辨率y.Text = "0";
            更改分辨率y.TextAlign = HorizontalAlignment.Center;
            更改分辨率y.WheelModifyEnabled = false;
            更改分辨率y.ValueChanged += 更改分辨率y_ValueChanged;
            // 
            // 更改分辨率x
            // 
            更改分辨率x.Location = new Point(105, 6);
            更改分辨率x.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            更改分辨率x.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            更改分辨率x.Name = "更改分辨率x";
            更改分辨率x.SelectionStart = 1;
            更改分辨率x.ShowControl = false;
            更改分辨率x.Size = new Size(69, 46);
            更改分辨率x.TabIndex = 11;
            更改分辨率x.Text = "0";
            更改分辨率x.TextAlign = HorizontalAlignment.Center;
            更改分辨率x.WheelModifyEnabled = false;
            更改分辨率x.ValueChanged += 更改分辨率x_ValueChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei UI", 17F);
            label3.Location = new Point(180, 12);
            label3.Name = "label3";
            label3.Size = new Size(19, 32);
            label3.TabIndex = 5;
            label3.Text = "x";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // collapseItem3
            // 
            collapseItem3.Controls.Add(刷新率);
            collapseItem3.Controls.Add(label4);
            collapseItem3.Location = new Point(-374, -60);
            collapseItem3.Name = "collapseItem3";
            collapseItem3.Size = new Size(374, 60);
            collapseItem3.TabIndex = 2;
            collapseItem3.Text = "刷新率";
            collapseItem3.MouseDown += Form1_MouseDown;
            // 
            // 刷新率
            // 
            刷新率.Location = new Point(132, 7);
            刷新率.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            刷新率.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            刷新率.Name = "刷新率";
            刷新率.SelectionStart = 1;
            刷新率.ShowControl = false;
            刷新率.Size = new Size(69, 46);
            刷新率.TabIndex = 11;
            刷新率.Text = "0";
            刷新率.TextAlign = HorizontalAlignment.Center;
            刷新率.WheelModifyEnabled = false;
            刷新率.ValueChanged += 刷新率_ValueChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei UI", 17F);
            label4.Location = new Point(197, 14);
            label4.Name = "label4";
            label4.Size = new Size(57, 32);
            label4.TabIndex = 5;
            label4.Text = "HZ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // collapseItem4
            // 
            collapseItem4.Controls.Add(label6);
            collapseItem4.Location = new Point(-374, -60);
            collapseItem4.Name = "collapseItem4";
            collapseItem4.Size = new Size(374, 60);
            collapseItem4.TabIndex = 3;
            collapseItem4.Text = "快捷键设置";
            // 
            // label6
            // 
            label6.Location = new Point(48, 4);
            label6.Name = "label6";
            label6.Size = new Size(278, 53);
            label6.TabIndex = 1;
            label6.Text = "暂无添加，F1修改 F2复原";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(alert3);
            tabPage2.Controls.Add(avatar2);
            tabPage2.Location = new Point(-412, -299);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(412, 299);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "关于";
            // 
            // alert3
            // 
            alert3.ForeColor = SystemColors.ControlText;
            alert3.Icon = AntdUI.TType.Info;
            alert3.Location = new Point(20, 122);
            alert3.Name = "alert3";
            alert3.Size = new Size(377, 169);
            alert3.TabIndex = 6;
            alert3.Text = "By:DJ鑫鑫\r\nBug提交邮箱：2963676214@qq.com";
            alert3.TextTitle = "作者";
            // 
            // avatar2
            // 
            avatar2.BackColor = SystemColors.ButtonHighlight;
            avatar2.ForeColor = SystemColors.ButtonHighlight;
            avatar2.Image = Properties.Resources.微信图片_2025_07_18_022150_789;
            avatar2.Location = new Point(160, 11);
            avatar2.Name = "avatar2";
            avatar2.OriginalBackColor = SystemColors.Control;
            avatar2.Radius = 64;
            avatar2.Size = new Size(100, 100);
            avatar2.TabIndex = 5;
            avatar2.Text = "a";
            // 
            // alert1
            // 
            alert1.Icon = AntdUI.TType.Warn;
            alert1.Location = new Point(19, 134);
            alert1.Name = "alert1";
            alert1.Size = new Size(100, 65);
            alert1.TabIndex = 3;
            alert1.Text = "务必输入符合你的刷新率否则出现任何问题无法帮助你";
            alert1.Visible = false;
            // 
            // alert2
            // 
            alert2.Icon = AntdUI.TType.Warn;
            alert2.Location = new Point(22, 228);
            alert2.Loop = true;
            alert2.LoopInfinite = false;
            alert2.LoopSpeed = 5;
            alert2.Name = "alert2";
            alert2.Size = new Size(375, 67);
            alert2.TabIndex = 3;
            alert2.Text = "务必所有都输入你可使用的数值，否则出现任何问题我将无法帮助你";
            alert2.TextTitle = "警告";
            alert2.Visible = false;
            // 
            // segmented1
            // 
            segmented1.IconAlign = AntdUI.TAlignMini.Left;
            segmentedItem1.Badge = null;
            segmentedItem1.BadgeAlign = AntdUI.TAlign.TR;
            segmentedItem1.BadgeBack = null;
            segmentedItem1.BadgeMode = false;
            segmentedItem1.BadgeOffsetX = 0;
            segmentedItem1.BadgeOffsetY = 0;
            segmentedItem1.BadgeSize = 0.6F;
            segmentedItem1.BadgeSvg = null;
            segmentedItem1.Icon = Properties.Resources.明亮模式;
            segmentedItem1.IconActive = Properties.Resources.明亮模式__1_;
            segmentedItem2.Badge = null;
            segmentedItem2.BadgeAlign = AntdUI.TAlign.TR;
            segmentedItem2.BadgeBack = null;
            segmentedItem2.BadgeMode = false;
            segmentedItem2.BadgeOffsetX = 0;
            segmentedItem2.BadgeOffsetY = 0;
            segmentedItem2.BadgeSize = 0.6F;
            segmentedItem2.BadgeSvg = null;
            segmentedItem2.Icon = Properties.Resources.切换_暗色模式__1_;
            segmentedItem2.IconActive = Properties.Resources.切换_暗色模式;
            segmented1.Items.Add(segmentedItem1);
            segmented1.Items.Add(segmentedItem2);
            segmented1.Location = new Point(6, 236);
            segmented1.Name = "segmented1";
            segmented1.OriginalBackColor = SystemColors.ButtonHighlight;
            segmented1.Radius = 16;
            segmented1.SelectIndex = 0;
            segmented1.Size = new Size(83, 23);
            segmented1.TabIndex = 8;
            segmented1.Text = "segmented1";
            segmented1.SelectIndexChanged += segmented1_SelectIndexChanged;
            // 
            // avatar1
            // 
            avatar1.BackColor = SystemColors.ButtonHighlight;
            avatar1.ForeColor = SystemColors.ButtonHighlight;
            avatar1.Image = Properties.Resources.微信图片_2025_07_18_022150_789;
            avatar1.Location = new Point(16, 12);
            avatar1.Name = "avatar1";
            avatar1.OriginalBackColor = SystemColors.ButtonHighlight;
            avatar1.Radius = 32;
            avatar1.Size = new Size(64, 64);
            avatar1.TabIndex = 7;
            avatar1.Text = "a";
            // 
            // menu1
            // 
            menu1.BackColor = SystemColors.ButtonHighlight;
            menu1.BackHover = Color.CadetBlue;
            menuItem1.Icon = Properties.Resources.主页;
            menuItem1.IconActive = Properties.Resources.主页__1_;
            menuItem1.ID = "0";
            menuItem1.Select = true;
            menuItem1.Text = "主页";
            menuItem2.Icon = Properties.Resources.关于;
            menuItem2.IconActive = Properties.Resources.关于__1_;
            menuItem2.ID = "1";
            menuItem2.Text = "关于";
            menu1.Items.Add(menuItem1);
            menu1.Items.Add(menuItem2);
            menu1.Location = new Point(4, 117);
            menu1.Name = "menu1";
            menu1.Size = new Size(90, 82);
            menu1.TabIndex = 6;
            menu1.Text = "menu1";
            menu1.SelectChanged += menu1_SelectChanged;
            // 
            // pageHeader1
            // 
            pageHeader1.Location = new Point(0, 0);
            pageHeader1.Name = "pageHeader1";
            pageHeader1.Size = new Size(0, 0);
            pageHeader1.TabIndex = 0;
            // 
            // pageHeader2
            // 
            pageHeader2.Location = new Point(34, 6);
            pageHeader2.Name = "pageHeader2";
            pageHeader2.Size = new Size(360, 35);
            pageHeader2.TabIndex = 1000;
            pageHeader2.Text = "";
            pageHeader2.Visible = false;
            // 
            // button1
            // 
            button1.Icon = Properties.Resources.退出;
            button1.IconHover = Properties.Resources.退出__1_;
            button1.Location = new Point(30, 265);
            button1.Name = "button1";
            button1.OriginalBackColor = SystemColors.ButtonHighlight;
            button1.Size = new Size(32, 34);
            button1.TabIndex = 9;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(0, 0);
            button2.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(0, 0);
            button3.TabIndex = 0;
            // 
            // label7
            // 
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 0);
            label7.TabIndex = 0;
            // 
            // 当前版本框
            // 
            当前版本框.Location = new Point(0, 0);
            当前版本框.Name = "当前版本框";
            当前版本框.Size = new Size(0, 0);
            当前版本框.TabIndex = 0;
            // 
            // 最新版本
            // 
            最新版本.Location = new Point(0, 0);
            最新版本.Name = "最新版本";
            最新版本.Size = new Size(0, 0);
            最新版本.TabIndex = 0;
            // 
            // label9
            // 
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 0);
            label9.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 306);
            Controls.Add(button1);
            Controls.Add(segmented1);
            Controls.Add(avatar1);
            Controls.Add(menu1);
            Controls.Add(tabs1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Resizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "无畏契约快捷4比3";
            Load += Form1_Load;
            tabs1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            collapse1.ResumeLayout(false);
            collapseItem1.ResumeLayout(false);
            collapseItem2.ResumeLayout(false);
            collapseItem3.ResumeLayout(false);
            collapseItem4.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Tabs tabs1;
        private AntdUI.TabPage tabPage1;
        private AntdUI.TabPage tabPage2;
        private AntdUI.Alert alert1;
        private AntdUI.Alert alert2;
        private AntdUI.Avatar avatar2;
        private AntdUI.Alert alert3;
        private AntdUI.Segmented segmented1;
        private AntdUI.Avatar avatar1;
        private AntdUI.Menu menu1;
        private AntdUI.PageHeader pageHeader1;
        private AntdUI.PageHeader pageHeader2;
        private AntdUI.Collapse collapse1;
        private AntdUI.CollapseItem collapseItem1;
        private AntdUI.Label label5;
        private AntdUI.Input ysbblxx;
        private AntdUI.Label label2;
        private AntdUI.Input ysfblx;
        private AntdUI.CollapseItem collapseItem2;
        private AntdUI.Label label3;
        private AntdUI.CollapseItem collapseItem3;
        private AntdUI.Label label4;
        private AntdUI.CollapseItem collapseItem4;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Button button3;
        private AntdUI.InputNumber 原始分辨率x;
        private AntdUI.InputNumber 原始分辨率y;
        private AntdUI.InputNumber 更改分辨率y;
        private AntdUI.InputNumber 更改分辨率x;
        private AntdUI.InputNumber 刷新率;
        private AntdUI.Label label7;
        private AntdUI.Label 当前版本框;
        private AntdUI.Label 最新版本;
        private AntdUI.Label label9;
        private AntdUI.Label label6;
    }
}
