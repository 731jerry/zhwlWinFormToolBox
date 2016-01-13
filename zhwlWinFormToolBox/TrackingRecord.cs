﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zhwlWinFormToolBox
{
    public partial class TrackingRecord : Form
    {
        public Boolean isNewRecord = false;
        public String trackingNumber = "";
        public TrackingRecord()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Connection.Ins.ExecuteNonquery("insert into " +MainWindow.pre_Tracking_Number+ trackingNumber + "(time, status) values('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','振华物流（桐乡）');", null);
        }

        private void isRecevied_CheckedChanged(object sender, EventArgs e)
        {
            currentStatus.Enabled = !isRecevied.Checked;
            startLoc.Enabled = !isRecevied.Checked;
            endLoc.Enabled = !isRecevied.Checked;
            senderInfo.Enabled = !isRecevied.Checked;
        }

        private void TrackingRecord_Load(object sender, EventArgs e)
        {
            if (isNewRecord)
            {
                currentStatus.Text = "振华物流（桐乡）";
                startLoc.Text = "振华物流（桐乡）";
            }
        }
    }
}