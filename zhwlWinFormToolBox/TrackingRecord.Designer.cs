namespace zhwlWinFormToolBox
{
    partial class TrackingRecord
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
            this.currentStatus = new System.Windows.Forms.TextBox();
            this.startLoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endLoc = new System.Windows.Forms.TextBox();
            this.senderInfo = new System.Windows.Forms.TextBox();
            this.isRecevied = new System.Windows.Forms.CheckBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentStatus
            // 
            this.currentStatus.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currentStatus.Location = new System.Drawing.Point(102, 12);
            this.currentStatus.Name = "currentStatus";
            this.currentStatus.Size = new System.Drawing.Size(226, 27);
            this.currentStatus.TabIndex = 0;
            // 
            // startLoc
            // 
            this.startLoc.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startLoc.Location = new System.Drawing.Point(102, 45);
            this.startLoc.Name = "startLoc";
            this.startLoc.Size = new System.Drawing.Size(226, 27);
            this.startLoc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "当前状态";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "始发站";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "目的地";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "发货人信息";
            // 
            // endLoc
            // 
            this.endLoc.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endLoc.Location = new System.Drawing.Point(102, 78);
            this.endLoc.Multiline = true;
            this.endLoc.Name = "endLoc";
            this.endLoc.Size = new System.Drawing.Size(226, 55);
            this.endLoc.TabIndex = 6;
            // 
            // senderInfo
            // 
            this.senderInfo.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.senderInfo.Location = new System.Drawing.Point(102, 139);
            this.senderInfo.Multiline = true;
            this.senderInfo.Name = "senderInfo";
            this.senderInfo.Size = new System.Drawing.Size(226, 55);
            this.senderInfo.TabIndex = 7;
            // 
            // isRecevied
            // 
            this.isRecevied.AutoSize = true;
            this.isRecevied.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.isRecevied.Location = new System.Drawing.Point(16, 219);
            this.isRecevied.Name = "isRecevied";
            this.isRecevied.Size = new System.Drawing.Size(75, 21);
            this.isRecevied.TabIndex = 8;
            this.isRecevied.Text = "已送达？";
            this.isRecevied.UseVisualStyleBackColor = true;
            this.isRecevied.CheckedChanged += new System.EventHandler(this.isRecevied_CheckedChanged);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submit.Location = new System.Drawing.Point(228, 217);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(100, 23);
            this.submit.TabIndex = 9;
            this.submit.Text = "提交";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // TrackingRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 254);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.isRecevied);
            this.Controls.Add(this.senderInfo);
            this.Controls.Add(this.endLoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startLoc);
            this.Controls.Add(this.currentStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TrackingRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackingRecord";
            this.Load += new System.EventHandler(this.TrackingRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currentStatus;
        private System.Windows.Forms.TextBox startLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox endLoc;
        private System.Windows.Forms.TextBox senderInfo;
        private System.Windows.Forms.CheckBox isRecevied;
        private System.Windows.Forms.Button submit;
    }
}