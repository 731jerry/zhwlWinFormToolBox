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

        public TrackingRecord()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            int result = Connection.Ins.ExecuteNonquery("insert into " + MainWindow.pre_Tracking_Number + trackingNumber
                + "(time, currentstatus, startLoc, endLoc, senderinfo) values('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + currentStatus.Text + "'" + ",'" + startLoc.Text + "','" + endLoc.Text + "','" + senderInfo.Text + "');", null);
            if (result == 1)
            {
                MessageBox.Show("成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("失败，请重试！");
            }
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
            if (isNewTN) // 激活新单号
            {
                startLoc.Text = "振华物流（桐乡）";
                currentStatus.Text = "振华物流（桐乡）已收件";
                isRecevied.Enabled = false;
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
                    startLoc.Enabled = false;
                    startLocLabel.Enabled = false;

                    endLoc.Enabled = false;
                    endLocLabel.Enabled = false;
                    senderInfo.Enabled = false;
                    senderInfoLabel.Enabled = false;
                }
            }
        }
    }
}
