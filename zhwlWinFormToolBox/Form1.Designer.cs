namespace zhwlWinFormToolBox
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
            this.groupbox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.inputInfoLabel);
            this.groupbox1.Controls.Add(this.clearBtn1);
            this.groupbox1.Controls.Add(this.confirmBtn);
            this.groupbox1.Controls.Add(this.inputTB);
            this.groupbox1.Controls.Add(this.OptionComboBox);
            this.groupbox1.Location = new System.Drawing.Point(12, 12);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(968, 276);
            this.groupbox1.TabIndex = 0;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "输入";
            // 
            // inputInfoLabel
            // 
            this.inputInfoLabel.AutoSize = true;
            this.inputInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.inputInfoLabel.Location = new System.Drawing.Point(155, 23);
            this.inputInfoLabel.Name = "inputInfoLabel";
            this.inputInfoLabel.Size = new System.Drawing.Size(35, 12);
            this.inputInfoLabel.TabIndex = 7;
            this.inputInfoLabel.Text = "条件:";
            // 
            // clearBtn1
            // 
            this.clearBtn1.Location = new System.Drawing.Point(887, 18);
            this.clearBtn1.Name = "clearBtn1";
            this.clearBtn1.Size = new System.Drawing.Size(75, 23);
            this.clearBtn1.TabIndex = 3;
            this.clearBtn1.Text = "清空";
            this.clearBtn1.UseVisualStyleBackColor = true;
            this.clearBtn1.Click += new System.EventHandler(this.clearBtn1_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(756, 18);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(99, 23);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "确认";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(6, 58);
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
            this.OptionComboBox.Name = "OptionComboBox";
            this.OptionComboBox.Size = new System.Drawing.Size(121, 20);
            this.OptionComboBox.TabIndex = 0;
            this.OptionComboBox.SelectedIndexChanged += new System.EventHandler(this.OptionComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CompanyComboBox);
            this.groupBox2.Controls.Add(this.infoLabel);
            this.groupBox2.Controls.Add(this.CopyClipboardBtn);
            this.groupBox2.Controls.Add(this.outputTB);
            this.groupBox2.Location = new System.Drawing.Point(12, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(968, 262);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出";
            // 
            // CompanyComboBox
            // 
            this.CompanyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompanyComboBox.FormattingEnabled = true;
            this.CompanyComboBox.Location = new System.Drawing.Point(710, 22);
            this.CompanyComboBox.Name = "CompanyComboBox";
            this.CompanyComboBox.Size = new System.Drawing.Size(121, 20);
            this.CompanyComboBox.TabIndex = 8;
            this.CompanyComboBox.SelectedIndexChanged += new System.EventHandler(this.CompanyComboBox_SelectedIndexChanged);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(6, 25);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(35, 12);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "结果:";
            // 
            // CopyClipboardBtn
            // 
            this.CopyClipboardBtn.Location = new System.Drawing.Point(863, 20);
            this.CopyClipboardBtn.Name = "CopyClipboardBtn";
            this.CopyClipboardBtn.Size = new System.Drawing.Size(99, 23);
            this.CopyClipboardBtn.TabIndex = 4;
            this.CopyClipboardBtn.Text = "复制到粘贴板";
            this.CopyClipboardBtn.UseVisualStyleBackColor = true;
            this.CopyClipboardBtn.Click += new System.EventHandler(this.CopyClipboardBtn_Click);
            // 
            // outputTB
            // 
            this.outputTB.Location = new System.Drawing.Point(6, 56);
            this.outputTB.MaxLength = 327670000;
            this.outputTB.Multiline = true;
            this.outputTB.Name = "outputTB";
            this.outputTB.ReadOnly = true;
            this.outputTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTB.Size = new System.Drawing.Size(956, 200);
            this.outputTB.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 568);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "振华物流工具箱";
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Button clearBtn1;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.ComboBox OptionComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CopyClipboardBtn;
        private System.Windows.Forms.TextBox outputTB;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label inputInfoLabel;
        private System.Windows.Forms.ComboBox CompanyComboBox;
    }
}

