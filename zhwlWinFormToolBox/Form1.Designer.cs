﻿namespace zhwlWinFormToolBox
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.inputInfoLabel = new System.Windows.Forms.Label();
            this.clearBtn1 = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.OptionComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CompanyComboBox = new System.Windows.Forms.ComboBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.CopyClipboardBtn = new System.Windows.Forms.Button();
            this.outputTB = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numberTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dzNumberTB = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableXTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableYTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.internalYTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.internalXTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fontSizeDiffTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.inlineDistenceYTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maxCountPerPageTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupbox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(5, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(6, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 593);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupbox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(983, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据筛选";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.inputInfoLabel);
            this.groupbox1.Controls.Add(this.clearBtn1);
            this.groupbox1.Controls.Add(this.confirmBtn);
            this.groupbox1.Controls.Add(this.inputTB);
            this.groupbox1.Controls.Add(this.OptionComboBox);
            this.groupbox1.Location = new System.Drawing.Point(8, 7);
            this.groupbox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupbox1.Size = new System.Drawing.Size(968, 276);
            this.groupbox1.TabIndex = 2;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "输入";
            // 
            // inputInfoLabel
            // 
            this.inputInfoLabel.AutoSize = true;
            this.inputInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.inputInfoLabel.Location = new System.Drawing.Point(155, 23);
            this.inputInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputInfoLabel.Name = "inputInfoLabel";
            this.inputInfoLabel.Size = new System.Drawing.Size(35, 12);
            this.inputInfoLabel.TabIndex = 7;
            this.inputInfoLabel.Text = "条件:";
            // 
            // clearBtn1
            // 
            this.clearBtn1.Location = new System.Drawing.Point(887, 19);
            this.clearBtn1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clearBtn1.Name = "clearBtn1";
            this.clearBtn1.Size = new System.Drawing.Size(76, 23);
            this.clearBtn1.TabIndex = 3;
            this.clearBtn1.Text = "清空";
            this.clearBtn1.UseVisualStyleBackColor = true;
            this.clearBtn1.Click += new System.EventHandler(this.clearBtn1_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(756, 19);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(100, 23);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "确认";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(6, 58);
            this.inputTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputTB.MaxLength = 327670000;
            this.inputTB.Multiline = true;
            this.inputTB.Name = "inputTB";
            this.inputTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTB.Size = new System.Drawing.Size(956, 212);
            this.inputTB.TabIndex = 1;
            // 
            // OptionComboBox
            // 
            this.OptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OptionComboBox.FormattingEnabled = true;
            this.OptionComboBox.Items.AddRange(new object[] {
            "发货",
            "回货"});
            this.OptionComboBox.Location = new System.Drawing.Point(6, 20);
            this.OptionComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OptionComboBox.Name = "OptionComboBox";
            this.OptionComboBox.Size = new System.Drawing.Size(120, 20);
            this.OptionComboBox.TabIndex = 0;
            this.OptionComboBox.SelectedIndexChanged += new System.EventHandler(this.OptionComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CompanyComboBox);
            this.groupBox2.Controls.Add(this.infoLabel);
            this.groupBox2.Controls.Add(this.CopyClipboardBtn);
            this.groupBox2.Controls.Add(this.outputTB);
            this.groupBox2.Location = new System.Drawing.Point(8, 288);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(968, 262);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出";
            // 
            // CompanyComboBox
            // 
            this.CompanyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompanyComboBox.FormattingEnabled = true;
            this.CompanyComboBox.Location = new System.Drawing.Point(710, 22);
            this.CompanyComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CompanyComboBox.Name = "CompanyComboBox";
            this.CompanyComboBox.Size = new System.Drawing.Size(120, 20);
            this.CompanyComboBox.TabIndex = 8;
            this.CompanyComboBox.SelectedIndexChanged += new System.EventHandler(this.CompanyComboBox_SelectedIndexChanged);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(6, 25);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(35, 12);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "结果:";
            // 
            // CopyClipboardBtn
            // 
            this.CopyClipboardBtn.Location = new System.Drawing.Point(863, 20);
            this.CopyClipboardBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CopyClipboardBtn.Name = "CopyClipboardBtn";
            this.CopyClipboardBtn.Size = new System.Drawing.Size(100, 23);
            this.CopyClipboardBtn.TabIndex = 4;
            this.CopyClipboardBtn.Text = "复制到粘贴板";
            this.CopyClipboardBtn.UseVisualStyleBackColor = true;
            this.CopyClipboardBtn.Click += new System.EventHandler(this.CopyClipboardBtn_Click);
            // 
            // outputTB
            // 
            this.outputTB.Location = new System.Drawing.Point(6, 56);
            this.outputTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.outputTB.MaxLength = 327670000;
            this.outputTB.Multiline = true;
            this.outputTB.Name = "outputTB";
            this.outputTB.ReadOnly = true;
            this.outputTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTB.Size = new System.Drawing.Size(956, 200);
            this.outputTB.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.maxCountPerPageTB);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.dzNumberTB);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.numberTB);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.addressTB);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.phoneTB);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.nameTB);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.printPreviewBT);
            this.tabPage2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(983, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "运单打印";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.panel1.Size = new System.Drawing.Size(1001, 613);
            this.panel1.TabIndex = 1;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewBT
            // 
            this.printPreviewBT.Location = new System.Drawing.Point(819, 493);
            this.printPreviewBT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.printPreviewBT.Name = "printPreviewBT";
            this.printPreviewBT.Size = new System.Drawing.Size(124, 42);
            this.printPreviewBT.TabIndex = 3;
            this.printPreviewBT.Text = "打印预览";
            this.printPreviewBT.UseVisualStyleBackColor = true;
            this.printPreviewBT.Click += new System.EventHandler(this.printPreviewBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "收货人:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(182, 76);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(290, 33);
            this.nameTB.TabIndex = 5;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(659, 76);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(238, 33);
            this.phoneTB.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "收货电话:";
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(182, 135);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(715, 33);
            this.addressTB.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "收货地址:";
            // 
            // numberTB
            // 
            this.numberTB.Location = new System.Drawing.Point(182, 198);
            this.numberTB.Name = "numberTB";
            this.numberTB.Size = new System.Drawing.Size(290, 33);
            this.numberTB.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "货物单号:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "运单数:";
            // 
            // dzNumberTB
            // 
            this.dzNumberTB.Location = new System.Drawing.Point(629, 498);
            this.dzNumberTB.Name = "dzNumberTB";
            this.dzNumberTB.Size = new System.Drawing.Size(90, 33);
            this.dzNumberTB.TabIndex = 13;
            this.dzNumberTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dzNumberTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fontSizeDiffTB);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.inlineDistenceYTB);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.internalYTB);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.internalXTB);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tableYTB);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tableXTB);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.groupBox3.Location = new System.Drawing.Point(75, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(822, 168);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "打印位置调整";
            // 
            // tableXTB
            // 
            this.tableXTB.Location = new System.Drawing.Point(116, 49);
            this.tableXTB.Name = "tableXTB";
            this.tableXTB.Size = new System.Drawing.Size(72, 27);
            this.tableXTB.TabIndex = 16;
            this.tableXTB.Text = "30";
            this.tableXTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tableXTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "整体左位移:";
            // 
            // tableYTB
            // 
            this.tableYTB.Location = new System.Drawing.Point(116, 107);
            this.tableYTB.Name = "tableYTB";
            this.tableYTB.Size = new System.Drawing.Size(72, 27);
            this.tableYTB.TabIndex = 18;
            this.tableYTB.Text = "50";
            this.tableYTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tableYTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "整体上位移:";
            // 
            // internalYTB
            // 
            this.internalYTB.Location = new System.Drawing.Point(407, 107);
            this.internalYTB.Name = "internalYTB";
            this.internalYTB.Size = new System.Drawing.Size(72, 27);
            this.internalYTB.TabIndex = 22;
            this.internalYTB.Text = "80";
            this.internalYTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.internalYTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "单个上位移:";
            // 
            // internalXTB
            // 
            this.internalXTB.Location = new System.Drawing.Point(407, 49);
            this.internalXTB.Name = "internalXTB";
            this.internalXTB.Size = new System.Drawing.Size(72, 27);
            this.internalXTB.TabIndex = 20;
            this.internalXTB.Text = "10";
            this.internalXTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.internalXTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "单个左位移:";
            // 
            // fontSizeDiffTB
            // 
            this.fontSizeDiffTB.Location = new System.Drawing.Point(705, 107);
            this.fontSizeDiffTB.Name = "fontSizeDiffTB";
            this.fontSizeDiffTB.Size = new System.Drawing.Size(72, 27);
            this.fontSizeDiffTB.TabIndex = 26;
            this.fontSizeDiffTB.Text = "0";
            this.fontSizeDiffTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fontSizeDiffTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(596, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "字体大小差值:";
            // 
            // inlineDistenceYTB
            // 
            this.inlineDistenceYTB.Location = new System.Drawing.Point(705, 49);
            this.inlineDistenceYTB.Name = "inlineDistenceYTB";
            this.inlineDistenceYTB.Size = new System.Drawing.Size(72, 27);
            this.inlineDistenceYTB.TabIndex = 24;
            this.inlineDistenceYTB.Text = "30";
            this.inlineDistenceYTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inlineDistenceYTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(626, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "内部行距:";
            // 
            // maxCountPerPageTB
            // 
            this.maxCountPerPageTB.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.maxCountPerPageTB.Location = new System.Drawing.Point(423, 501);
            this.maxCountPerPageTB.Name = "maxCountPerPageTB";
            this.maxCountPerPageTB.Size = new System.Drawing.Size(59, 27);
            this.maxCountPerPageTB.TabIndex = 16;
            this.maxCountPerPageTB.Text = "14";
            this.maxCountPerPageTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maxCountPerPageTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label12.Location = new System.Drawing.Point(284, 504);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "每张最大单子数量:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 613);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "振华物流工具箱";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Label inputInfoLabel;
        private System.Windows.Forms.Button clearBtn1;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.ComboBox OptionComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CompanyComboBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button CopyClipboardBtn;
        private System.Windows.Forms.TextBox outputTB;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button printPreviewBT;
        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dzNumberTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tableXTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fontSizeDiffTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inlineDistenceYTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox internalYTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox internalXTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tableYTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox maxCountPerPageTB;
        private System.Windows.Forms.Label label12;

    }
}

