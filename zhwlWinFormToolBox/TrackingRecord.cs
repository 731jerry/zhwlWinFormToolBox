using System;
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
        public Boolean isNewTN = false;
        public String trackingNumber = "";

        public Boolean isModify = false;
        public String TN_id = "";
        public String currentStatusString = "";

        public TrackingRecord()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (!isModify)
            {
                try
                {
                    Connection.Ins.ExecuteNonquery("INSERT INTO " + MainWindow.pre_Tracking_Number + trackingNumber
                        + "(time, currentstatus, startLoc, endLoc, senderinfo) VALUES('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" +currentStatus0.Text + currentStatus.Text + "'" + ",'" + startLoc.Text + "','" + endLoc.Text + "','" + senderInfo.Text + "');", null);

                    MessageBox.Show("成功！");
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "失败，请重试！");
                }
            }
            else
            {
                try
                {
                    Connection.Ins.ExecuteNonquery("UPDATE " + MainWindow.pre_Tracking_Number + trackingNumber
                        + " SET currentstatus = '" + currentStatus0.Text + currentStatus.Text + "', time = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id = " + TN_id + ";", null);
                    MessageBox.Show("成功！");
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "失败，请重试！");
                }
            }
        }

        private void TrackingRecord_Load(object sender, EventArgs e)
        {
            if (isNewTN) // 激活新单号
            {
                startLoc.Text = "振华物流（桐乡）";
                currentStatus.Text = "振华物流（桐乡）已收件";
            }
            else
            {
                if (!isModify)
                { // 添加新纪录
                    startLoc.Enabled = false;
                    startLocLabel.Enabled = false;

                    endLoc.Enabled = false;
                    endLocLabel.Enabled = false;
                    senderInfo.Enabled = false;
                    senderInfoLabel.Enabled = false;
                }
                else
                { // 修改记录
                    currentStatus.Text = currentStatusString;
                    startLoc.Enabled = false;
                    startLocLabel.Enabled = false;

                    endLoc.Enabled = false;
                    endLocLabel.Enabled = false;
                    senderInfo.Enabled = false;
                    senderInfoLabel.Enabled = false;
                }
            }
        }

        private void TrackingRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isNewTN)
            {
                submit.PerformClick();
            }
        }
    }
}
