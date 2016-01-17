using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Threading;
using System.Collections;

using com.google.zxing;
using ByteMatrix = com.google.zxing.common.ByteMatrix;

namespace zhwlWinFormToolBox
{
    public partial class MainWindow : Form
    {
        public static String pre_Tracking_Number = "TN_";
        public static String Tracking_Link = "http://www.zhhwl.com/query/tracking.php?tn=";
        public MainWindow()
        {
            InitializeComponent();
            OptionComboBox.SelectedIndex = 0;
        }

        Dictionary<String, String> DriversDic = new Dictionary<string, string>();

        private void MainWindow_Load(object sender, EventArgs e)
        {
            sendSMSComboBox.SelectedIndex = 0;
            DriversDic.Add("杨金宝", "15905833881");
            DriversDic.Add("张自锋", "18637531188");
            DriversDic.Add("杨进强", "13693752496");
            driverComboBox.Items.AddRange(DriversDic.Keys.ToArray());
            driverComboBox.SelectedIndex = -1;

            //SetContentTextOptionA();

            setTimeDateTimePicker.Value = DateTime.Now.AddHours(1);
            getSMSAccountInfo();
        }

        // 判断是否是数字
        public bool IsNumeric(String str)
        {
            String pattern = @"^[-]?\d+[.]?\d*$";
            return Regex.IsMatch(str, pattern);
        }

        // 判断是否是整数
        public bool IsIntegerByRegex(String str)
        {
            String pattern = @"^\d*$";
            return Regex.IsMatch(str, pattern);
        }

        public bool isInteger(String number)
        {
            try
            {
                double b = Convert.ToDouble(number);
                return b % 10 == 0;
            }
            catch
            {
                return false;
            }
        }

        #region 数据筛选

        List<List<String>> inputList = new List<List<String>>();
        List<List<String>> outputList = new List<List<String>>();

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            outputTB.Clear();
            inputList.Clear();
            outputList.Clear();
            CompanyComboBox.Items.Clear();

            if (inputTB.Text.Equals(""))
            {
                return;
            }

            String tempString;
            //String temps = inputTB.Text.Substring(inputTB.Text.Length - 2, 2);
            if (inputTB.Text.Substring(inputTB.Text.Length - 2, 2).Equals("\r\n"))
            {
                tempString = inputTB.Text.Substring(0, inputTB.Text.Length - 2);
            }
            else
            {
                tempString = inputTB.Text;
            }
            List<String> temp = new List<string>();

            temp = tempString.Split('\r').ToList();
            foreach (String item in temp)
            {
                inputList.Add(item.Split('\t').ToList());
            }

            temp.Clear();

            if (OptionComboBox.SelectedIndex == 0)
            { // 发货
                if (inputList[0].Count == 10)
                {
                    foreach (List<String> itemList in inputList)
                    {
                        outputList.Add(new List<String>() { itemList[3], itemList[4], "", "", "", itemList[7] });
                    }
                    outputTB.Text = printList(outputList);
                }
                else
                {
                    MessageBox.Show("输入的数据格式错误,请检查", "错误");
                }
            }
            else
            { // 回货
                if (inputList[0].Count == 12)
                {
                    foreach (List<String> itemList in inputList)
                    {
                        if (itemList[10].Equals("") && itemList[11].Equals("") && itemList[7].Equals(""))
                        {
                        }
                        else
                        {
                            outputList.Add(new List<String>() { itemList[1], itemList[2], itemList[3], itemList[10], itemList[11], itemList[7], (float.Parse(itemList[10].Trim().Equals("") ? "0" : itemList[10]) + float.Parse(itemList[11].Trim().Equals("") ? "0" : itemList[11]) + float.Parse(itemList[7].Trim().Equals("") ? "0" : itemList[7])).ToString() });
                            AddToCombBox(itemList[1], CompanyComboBox);
                        }
                    }
                    //System.Globalization.CultureInfo strokCi = new System.Globalization.CultureInfo("zh-cn");
                    //System.Threading.Thread.CurrentThread.CurrentCulture = strokCi;
                    //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(0x00020804);
                    //outputList.Sort(StringComparer.Create(new CultureInfo(0x00020804), true));

                    //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("zh-CN");
                    //Array stringArray = Array.CreateInstance(typeof(String), outputList.Count);
                    //stringArray = outputList.ToArray();
                    //Array.Sort(stringArray);
                    //outputList.Sort();
                    //PrintIndexAndValues(stringArray);

                    //System.Globalization.CultureInfo strokCi = new System.Globalization.CultureInfo(0x00000c04);
                    //System.Threading.Thread.CurrentThread.CurrentCulture = strokCi; ;
                    //outputList.Sort();

                    outputTB.Text = printList(outputList);
                }
                else
                {
                    MessageBox.Show("输入的数据格式错误,请检查", "错误");
                }
            }
        }

        private void AddToCombBox(String item, ComboBox cb)
        {
            if (!cb.Items.Contains(item))
            {
                cb.Items.Add(item);
            }
        }

        private String printList(List<List<String>> inputStringList)
        {
            String outputString = "";
            foreach (List<String> itemList in inputStringList)
            {
                foreach (String item in itemList)
                {
                    outputString += item + "\t";
                }
                outputString.Trim();
                outputString += "\r\n";
            }
            outputString.Trim();
            return outputString;
        }

        private String printList(List<List<String>> inputStringList, String filter)
        {
            String outputString = "";
            foreach (List<String> itemList in inputStringList)
            {
                if (itemList[0].Equals(filter))
                {
                    foreach (String item in itemList)
                    {
                        outputString += item + "\t";
                    }
                    outputString.Trim();
                    outputString += "\r\n";
                }
            }
            outputString.Trim();
            return outputString;
        }

        private void clearBtn1_Click(object sender, EventArgs e)
        {
            inputTB.Clear();
        }

        private void OptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OptionComboBox.SelectedIndex == 0)
            {
                inputTB.Clear();
                inputInfoLabel.Text = "条件: 总共10列, 从\"日期\"到\"联系电话\"";
            }
            else
            {
                inputTB.Clear();
                inputInfoLabel.Text = "条件: 总共12列, 从\"到货日期\"到\"送费\"";
            }
        }

        private void CopyClipboardBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(outputTB.Text);
            infoLabel.Text = "已复制到粘贴板!";
        }

        private void CompanyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputTB.Clear();
            outputTB.Text = printList(outputList, CompanyComboBox.Text);
        }
        private void numberInputOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length >= 0)) return;   //处理负数
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }
        }
        #endregion

        #region 运单打印

        private void printPreviewBT_Click(object sender, EventArgs e)
        {
            if (dzNumberTB.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入需要打印的运单数量", "提示");
            }
            else
            {
                SetPrintPreview();
            }
        }

        private void SetPrintPreview()
        {
            //this.printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", this.printDocument1.DefaultPageSettings.PaperSize.Width, pageHeight);
            //pageHeight = this.printDocument1.DefaultPageSettings.PaperSize.Height;

            //注意指定其Document(获取或设置要预览的文档)属性
            this.printPreviewDialog1.Document = this.printDocument1;
            //ShowDialog方法：将窗体显示为模式对话框，并将当前活动窗口设置为它的所有者
            //this.printPreviewDialog1.WindowState = FormWindowState.Maximized;
            this.printPreviewDialog1.ClientSize = new Size(600, 800);
            this.printPreviewDialog1.ShowDialog();
        }

        int pageCount;
        int maxCountPerPage;
        String DestinationTBString;
        String nameTBString;
        String countTBString;
        String numberTBString;
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            pageCount = 0;
            maxCountPerPage = int.Parse(maxCountPerPageTB.Text);
            DestinationTBString = DestinationTB.Text;
            nameTBString = nameTB.Text;
            countTBString = countTB.Text;
            numberTBString = numberTB.Text;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int from = int.Parse(fromCount.Text.Trim()) - 1;
            int DzCount = int.Parse(dzNumberTB.Text.Trim()) + from;
            int pageWidth = this.printDocument1.DefaultPageSettings.PaperSize.Width;
            int pageHeight = this.printDocument1.DefaultPageSettings.PaperSize.Height;


            int tableX = int.Parse(tableXTB.Text);
            int tableY = int.Parse(tableYTB.Text);
            int internalX = int.Parse(internalXTB.Text); // 内部
            int internalY = int.Parse(internalYTB.Text); ;
            int inlineDistenceX = int.Parse(inlineDistenceXTB.Text); // 内部列距
            int inlineDistenceY = int.Parse(inlineDistenceYTB.Text); // 内部行距
            int fontSizeDiff = int.Parse(fontSizeDiffTB.Text); // 字体大小

            for (int i = 0; i < (DzCount - pageCount * maxCountPerPage); i++)
            {
                if ((i < from) && pageCount < 1)
                {
                    DestinationTBString = "";
                    nameTBString = "";
                    countTBString = "";
                    numberTBString = "";
                }
                else
                {
                    DestinationTBString = DestinationTB.Text;
                    nameTBString = nameTB.Text;
                    countTBString = countTB.Text;
                    numberTBString = numberTB.Text;
                }

                if (i % 2 == 0)
                {
                    //SizeF fontSize;
                    //fontSize = e.Graphics.MeasureString(nameTB.Text, nameTB.Font);//桐 乡 市 瑞 递 曼 尔 工 贸 有 限 公 司
                    e.Graphics.DrawString(DestinationTBString, new Font(DestinationTB.Font.Name, DestinationTB.Font.Size + fontSizeDiff), new SolidBrush(Color.Black), internalX + tableX + 0, internalY * i + tableY + 0);
                    e.Graphics.DrawString(nameTBString, new Font(nameTB.Font.Name, nameTB.Font.Size + fontSizeDiff), new SolidBrush(Color.Black), internalX + tableX + pageWidth / 4 + inlineDistenceX, internalY * i + tableY + 0);
                    e.Graphics.DrawString(countTBString, new Font(countTB.Font.Name, countTB.Font.Size + fontSizeDiff), new SolidBrush(Color.Black), internalX + tableX + 0, internalY * i + tableY + inlineDistenceY);
                    e.Graphics.DrawString(numberTBString, new Font(numberTB.Font.Name, numberTB.Font.Size + fontSizeDiff), new SolidBrush(Color.Black), internalX + tableX + pageWidth / 4 + inlineDistenceX, internalY * i + tableY + inlineDistenceY);
                }
                else
                {
                    e.Graphics.DrawString(DestinationTBString, new Font(DestinationTB.Font.Name, DestinationTB.Font.Size + fontSizeDiff), new SolidBrush(Color.Black), internalX + tableX + pageWidth / 2, internalY * (i - 1) + tableY + 0);
                    e.Graphics.DrawString(nameTBString, new Font(nameTB.Font.Name, nameTB.Font.Size + fontSizeDiff), new SolidBrush(Color.Black), internalX + tableX + (pageWidth / 4) * 3 + inlineDistenceX, internalY * (i - 1) + tableY + 0);
                    e.Graphics.DrawString(countTBString, new Font(countTB.Font.Name, countTB.Font.Size + fontSizeDiff), new SolidBrush(Color.Black), internalX + tableX + pageWidth / 2, internalY * (i - 1) + tableY + inlineDistenceY);
                    e.Graphics.DrawString(numberTBString, new Font(numberTB.Font.Name, numberTB.Font.Size + fontSizeDiff), new SolidBrush(Color.Black), internalX + tableX + (pageWidth / 4) * 3 + inlineDistenceX, internalY * (i - 1) + tableY + inlineDistenceY);
                }
            }

            pageCount++;
            float countFloat = (float)DzCount / (float)maxCountPerPage;
            if (pageCount < ((IsIntegerByRegex(countFloat.ToString()) ? countFloat : (int)(DzCount / maxCountPerPage) + 1)))
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }


        private void countTB_TextChanged(object sender, EventArgs e)
        {
            dzNumberTB.Text = countTB.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            DestinationTB.Clear();
            nameTB.Clear();
            countTB.Clear();
            numberTB.Clear();
        }

        #endregion

        #region 发送短信

        String uid = "GxDPNEIGtn9C";
        String pas = "5pggh3c5";

        private String getStringBySMSAPI(String url, String byteString)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(byteString);
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(new Uri(url));
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ContentLength = byteArray.Length;
            Stream newStream = webRequest.GetRequestStream();
            newStream.Write(byteArray, 0, byteArray.Length);
            newStream.Close();
            HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
            StreamReader php = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            return php.ReadToEnd();
        }

        private void getSMSAccountInfo()
        {
            Thread t = new Thread(new ParameterizedThreadStart(getSMSAccountInfoThreading));
            t.Start();
            t.DisableComObjectEagerCleanup();
        }

        private void getSMSAccountInfoThreading(Object obj)
        {
            setSMSAccountInfo();
        }

        delegate void setAccountInfoThreadDelegate();
        private void setSMSAccountInfo()
        {
            try
            {
                JSONObject json = JSONConvert.DeserializeObject(getStringBySMSAPI(
                    "http://api.weimi.cc/2/account/balance.html",
                    "uid=" + uid + "&pas=" + pas + "&type=json"));
                if (accountInfo.InvokeRequired)
                {
                    setAccountInfoThreadDelegate saitd = new setAccountInfoThreadDelegate(setSMSAccountInfo);
                    this.Invoke(saitd, new object[] { });
                }
                else
                {
                    accountInfo.Text = "账户余额(短信): " + (json["sms-left"]).ToString() + "/" + (json["sms-total"]).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "获取SMS账户信息错误!");
            }
        }

        delegate void setReciptNumberThreadDelegate();
        private void clearReciptNumer()
        {
            if (ReciptTextBox.InvokeRequired)
            {
                setReciptNumberThreadDelegate srnt = new setReciptNumberThreadDelegate(clearReciptNumer);
                this.Invoke(srnt, new object[] { });
            }
            else
            {
                ReciptTextBox.Clear();
            }
        }

        String mobileNumbers = "";
        String cidNumber = "";
        Boolean isEnabledDrivers = false;
        String DriverName, DriverNumer, ContactNumber;
        private void sendMsgButton_Click(object sender, EventArgs e)
        {
            //if (driverComboBox.Enabled)
            if (sendSMSComboBox.SelectedIndex == 1)
            {
                isEnabledDrivers = true;
                //DriverName = driverComboBox.Text;
                //DriverNumer = driverTextBox.Text;
                ContactNumber = contactTextbox.Text;
            }
            Thread t = new Thread(new ParameterizedThreadStart(sendSMSThreading));
            t.Start();
            t.DisableComObjectEagerCleanup();
        }

        private void sendSMSThreading(Object obj)
        {
            sendSMS();
        }

        private void sendSMS()
        {
            try
            {
                if (!verifyMobileNumbers())
                {
                    MessageBox.Show("输入的短信号码错误，请重新验证！", "提示");
                }
                else
                {
                    String addtionInfo = "";
                    String apiString = "mob=" + mobileNumbers + "&cid=" + cidNumber + "&uid=" + uid + "&pas=" + pas + "&type=json";
                    if (setTimeCheckBox.Checked)
                    {
                        //yyyy-MM-dd HH:mm:ss
                        apiString += "&timing=" + setTimeDateTimePicker.Value.ToString(setTimeDateTimePicker.CustomFormat);
                        addtionInfo = "定时(将于" + setTimeDateTimePicker.Value.ToString(setTimeDateTimePicker.CustomFormat) + "发送)";
                    }
                    if (isEnabledDrivers)
                    {
                        apiString += "&p1=" + ContactNumber;
                    }
                    JSONObject json = JSONConvert.DeserializeObject(getStringBySMSAPI(
                        "http://api.weimi.cc/2/sms/send.html",
                        apiString));

                    if (int.Parse((json["code"]).ToString()) == 0)
                    {
                        clearReciptNumer();
                        MessageBox.Show(addtionInfo + "短信" + mobileNumbers + "发送成功!", "提示");
                    }
                    else
                    {
                        MessageBox.Show("短信" + mobileNumbers + "发送失败:(code:" + (json["code"]).ToString() + ")" + (json["msg"]).ToString(), "提示");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "发送SMS错误!");
            }
        }

        private Boolean verifyMobileNumbers()
        {
            mobileNumbers = ReciptTextBox.Text;
            mobileNumbers = mobileNumbers.Replace(" ", "");
            mobileNumbers = mobileNumbers.Replace("，", ",");
            mobileNumbers = mobileNumbers.Replace("\r\n", ",");
            mobileNumbers = mobileNumbers.Replace(",,", ",");
            char[] charsToTrim = { '，', ',', ' ' };
            mobileNumbers = mobileNumbers.TrimEnd(charsToTrim);
            String[] mobileArray = mobileNumbers.Split(',');
            List<String> mobileNewList = new List<String>();
            foreach (String mobile in mobileArray)
            {
                if ((mobile.Length == 11) && IsNumeric(mobile))
                {
                    mobileNewList.Add(mobile);
                }
            }
            if (mobileNewList.Count > 0)
            {
                mobileNumbers = String.Join(",", mobileNewList);
                mobileNumbers = mobileNumbers.Trim();
                return true;
            }
            else { return false; }
        }

        private void sendSMSComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sendSMSComboBox.SelectedIndex)
            {
                default:
                    break;
                case 0: // 提货
                    cidNumber = "ZZCFFVQGk6HA";
                    //driverTextBox.Enabled = false;
                    //driverComboBox.SelectedIndex = -1;
                    //driverComboBox.Enabled = false;
                    contactTextbox.Enabled = false;
                    contactTextbox.Text = "";
                    SetContentTextOptionA();
                    break;
                case 1: // 派送
                    cidNumber = "IvgDeQ7fXG8F";
                    //driverTextBox.Enabled = true;
                    //driverComboBox.SelectedIndex = 0;
                    //driverComboBox.Enabled = true;
                    contactTextbox.Enabled = true;
                    contactTextbox.Text = "0573-88131799";
                    SetContentTextOptionB();
                    break;
            }
        }

        private void SetContentTextOptionA()
        {
            //ContentTextBox.Text = "【桐乡振华物流】您的货物已经到达振华物流，您还未来领取，请尽快携带您的身份证或者驾驶证前来领取。地址:环城东路183号(振东物流园区右转第一家)。详情请电话:13586404085。网址:http://www.zhhwl.com/。谢谢您的支持！";
            ContentTextBox.Text = "【桐乡振华物流】您的货物已经到达振华物流，您还未来领取，请尽快携带您的身份证或者驾驶证前来领取。从接到通知当日起，至次日12点前没有来取货者，我们将收取相应的仓储费，每日叠加。地址:环城东路183号(振东物流园区右转第一家)。详情请电话:13586404085。网址:http://www.zhhwl.com/。谢谢您的支持！";
        }

        private void SetContentTextOptionB()
        {
            // ContentTextBox.Text = "【桐乡振华物流】您好，我们是浙江省桐乡市振华物流，您从我司派出的货今日已到当地派货点，当地派货点电话:" + contactTextbox.Text + "。请保持您的手机通话顺畅，方便工作人员联系。详情请电话:13586404085。网址:http://www.zhhwl.com/。谢谢您的支持！";
            ContentTextBox.Text = "【桐乡振华物流】您好，我们是浙江省桐乡市振华物流，您从我司派出的货今日已到当地派货点，当地派货点电话:" + contactTextbox.Text + "。请保持您的手机通话顺畅，方便工作人员联系。详情请电话:13586404085。网址:http://www.zhhwl.com/。谢谢您的支持！";
        }
        private void driverTextBox_TextChanged(object sender, EventArgs e)
        {
            SetContentTextOptionB();
        }
        private void contactTextbox_TextChanged(object sender, EventArgs e)
        {
            SetContentTextOptionB();
        }

        private void setTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            setTimeDateTimePicker.Enabled = setTimeCheckBox.Checked;
        }

        private void fillAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.fillAccountLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.weimi.cc/sms.html");
        }

        private void checkSentLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.checkSentLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.weimi.cc/admin/");
        }

        private void driverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (driverComboBox.SelectedIndex == -1)
            {
                driverTextBox.Text = "";
                //SetContentTextOptionB();
            }
            else
            {
                String outValue;
                DriversDic.TryGetValue(driverComboBox.Text, out outValue);
                driverTextBox.Text = outValue;
                SetContentTextOptionA();
            }
        }

        #endregion

        private void searchButton_Click(object sender, EventArgs e)
        {
            String query = TrackingNumber.Text;
            String queryTable = pre_Tracking_Number + TrackingNumber.Text;
            if (IsNumeric(query))
            {
                if (checkIfExistsTN(queryTable) < 1) // table不存在
                {
                    if (MessageBox.Show("这个是新运单，是否需要激活新运单？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        // 创建新表
                        int returnId = Connection.Ins.ExecuteNonquery(
                                                     "CREATE TABLE IF NOT EXISTS `" + queryTable + "` ("
                                                     + @"`id` int(10) NOT NULL AUTO_INCREMENT,"
                                                     + @" `time` datetime DEFAULT NULL,"
                                                     + @"`currentstatus` varchar(255) DEFAULT NULL,"
                                                     + @"`startLoc` varchar(255) DEFAULT NULL,"
                                                     + @"`endLoc` varchar(255) DEFAULT NULL,"
                                                     + @"`senderinfo` varchar(255) DEFAULT NULL,"
                                                     + @" PRIMARY KEY (`id`)"
                                                     + @") ENGINE=InnoDB DEFAULT CHARSET=utf8;"
                                                     , null);

                        if (returnId == 0) //新建表成功
                        {
                            // 激活新单号
                            TrackingRecord tr = new TrackingRecord();
                            tr.isNewTN = true;
                            tr.trackingNumber = query;
                            tr.Text = "激活新单号:" + query;
                            tr.ShowDialog();

                            searchButton.PerformClick();
                        }
                    }
                    else {
                        return;
                    }
                }

                generate_qrcode(Tracking_Link + TrackingNumber.Text, Properties.Resources.logo.ToBitmap(), 300, QRcodeImage);
                //generate_barcode(TrackingNumber.Text, 363, 150, BarcodeImage);//363,150

                // 查询
               // DataTable result = Connection.Ins.ExcuteDataTable("SELECT id AS '序列', time AS '时间', currentstatus AS '当前状态' FROM " + queryTable + " ORDER BY id DESC", null);
                DataTable result = Connection.Ins.ExcuteDataTable("SELECT id AS '序列', time AS '时间', currentstatus AS '当前状态' FROM " + queryTable + " ORDER BY time DESC", null);
                QueryDataGridView.DataSource = result;

                QueryDataGridView.Columns[0].Visible = false;
                QueryDataGridView.Columns[1].Width = 110;

                DataTable senderResult = Connection.Ins.ExcuteDataTable("SELECT endLoc, senderinfo FROM " + queryTable + " WHERE id = 1", null);
                endLoc.Text = senderResult.Rows[0][0].ToString();
                senderInfo.Text = senderResult.Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("单号输入错误，需要输入11位数字");
            }
        }

        #region 二维码生成
        private void generate_qrcode(String queryString, Image logoImage, int size, PictureBox targetPictureBox)
        {
            try
            {
                //构造二维码写码器
                MultiFormatWriter mutiWriter = new com.google.zxing.MultiFormatWriter();
                Hashtable hint = new Hashtable();
                hint.Add(EncodeHintType.CHARACTER_SET, "UTF-8");
                hint.Add(EncodeHintType.ERROR_CORRECTION, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel.H);
                //生成二维码
                ByteMatrix bm = mutiWriter.encode(queryString, com.google.zxing.BarcodeFormat.QR_CODE, size, size, hint);
                Bitmap img = bm.ToBitmap();

                //要插入到二维码中的图片
                Image middlImg = logoImage;
                //获取二维码实际尺寸（去掉二维码两边空白后的实际尺寸）
                System.Drawing.Size realSize = mutiWriter.GetEncodeSize(TrackingNumber.Text, com.google.zxing.BarcodeFormat.QR_CODE, 300, 300);
                //计算插入图片的大小和位置
                int middleImgW = Math.Min((int)(realSize.Width / 3.5), middlImg.Width);
                int middleImgH = Math.Min((int)(realSize.Height / 3.5), middlImg.Height);
                int middleImgL = (img.Width - middleImgW) / 2;
                int middleImgT = (img.Height - middleImgH) / 2;

                //将img转换成bmp格式，否则后面无法创建 Graphics对象
                Bitmap bmpimg = new Bitmap(img.Width, img.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                using (Graphics g = Graphics.FromImage(bmpimg))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    g.DrawImage(img, 0, 0);
                }

                //在二维码中插入图片
                System.Drawing.Graphics MyGraphic = System.Drawing.Graphics.FromImage(bmpimg);
                //白底
                MyGraphic.FillRectangle(Brushes.White, middleImgL, middleImgT, middleImgW, middleImgH);
                MyGraphic.DrawImage(middlImg, middleImgL, middleImgT, middleImgW, middleImgH);

                targetPictureBox.Image = bmpimg;

                //自动保存图片到当前目录
                //string filename = System.Environment.CurrentDirectory + "\\QR" + DateTime.Now.Ticks.ToString() + ".jpg";
                //bmpimg.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                //lbshow.Text = "图片已保存到：" + filename;
            }
            catch (Exception ee)
            { MessageBox.Show(ee.Message); }
        }
        private void generate_barcode(String queryString, int width, int height, PictureBox targetPictureBox)
        {
            Regex rg = new Regex("^[0-9]{11}$");
            if (!rg.IsMatch(queryString))
            {
                // MessageBox.Show("本例子采用EAN_13编码，需要输入13位数字");
                MessageBox.Show("本例子采用EAN_11编码，需要输入11位数字");
                return;
            }

            try
            {
                MultiFormatWriter mutiWriter = new com.google.zxing.MultiFormatWriter();
                ByteMatrix bm = mutiWriter.encode(queryString, com.google.zxing.BarcodeFormat.EAN_13, 363, 150);
                Bitmap img = bm.ToBitmap();
                targetPictureBox.Image = img;

                //自动保存图片到当前目录
                //string filename = System.Environment.CurrentDirectory + "\\EAN_13" + DateTime.Now.Ticks.ToString() + ".jpg";
                //img.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ee)
            { MessageBox.Show(ee.Message); }
        }
        #endregion

        private void AddQueryButton_Click(object sender, EventArgs e)
        {
            String query = TrackingNumber.Text;
            // 插入新纪录
            TrackingRecord tr = new TrackingRecord();
            tr.isNewTN = false;
            tr.trackingNumber = query;
            tr.Text = "为单号" + query + "添加新纪录";
            tr.ShowDialog();

            searchButton.PerformClick();
        }

        private int checkIfExistsTN(String table)
        {
            //SELECT COUNT( * ) FROM information_schema.TABLES WHERE table_name = 'tn_99999'
            DataTable result = Connection.Ins.ExcuteDataTable("SELECT COUNT( * ) FROM information_schema.TABLES WHERE table_name = '" + table + "'", null);
            return Convert.ToInt32(result.Rows[0][0]);
        }

        public static String ConnStr = @"server=121.42.154.95; user id=zhhwl; password=zhhwl; database=zhhwl.com;Charset=utf8;";


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkIfExistsTN(pre_Tracking_Number + TrackingNumber.Text).ToString());
        }

        private void clearQuery_Click(object sender, EventArgs e)
        {
            TrackingNumber.Clear();
            QRcodeImage.Image = null;
            QueryDataGridView.DataSource = null;
            TrackingNumber.Focus();
            endLoc.Clear();
            senderInfo.Clear();
        }

        private void TrackingNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton.PerformClick();
            }
        }

        private void ModifyQueryButton_Click(object sender, EventArgs e)
        {
            String queryTable = pre_Tracking_Number + TrackingNumber.Text;
            try
            {
                Connection.Ins.ExecuteNonquery("UPDATE " + queryTable + " SET endLoc = '" + endLoc.Text + "', senderinfo = '" + senderInfo.Text + "' WHERE id = 1;", null);
                MessageBox.Show("更新发货人信息成功！");
                isNeedModifySenderInfo.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "失败，请重试！");
            }
        }

        private void isNeedModifySenderInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (!TrackingNumber.Text.Trim().Equals("") && QRcodeImage.Image != null)
            {
                endLoc.ReadOnly = !isNeedModifySenderInfo.Checked;
                senderInfo.ReadOnly = !isNeedModifySenderInfo.Checked;
                ModifyQueryButton.Enabled = isNeedModifySenderInfo.Checked;
            }
            else
            {
                MessageBox.Show("请先查询单号！");
            }
        }

        private void QueryDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditRecord();
        }

        private void QueryDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (QueryDataGridView.Rows[e.RowIndex].Selected == false)
                    {
                        QueryDataGridView.ClearSelection();
                        QueryDataGridView.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (QueryDataGridView.SelectedRows.Count == 1)
                    {
                        QueryDataGridView.CurrentCell = QueryDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    QueryResultContextMenuStrip.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        // 编辑记录
        private void EditRecord() {
            String idString = QueryDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            if (!idString.Trim().Equals("1"))
            {
                String query = TrackingNumber.Text;
                // 插入新纪录
                TrackingRecord tr = new TrackingRecord();
                tr.isNewTN = false;
                tr.isModify = true;
                tr.trackingNumber = query;
                tr.TN_id = idString;
                tr.Text = "修改单号为" + query + "的记录";
                tr.currentStatusString = QueryDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                if (tr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    searchButton.PerformClick();
                }
            }
            else {
                MessageBox.Show("初始记录不能编辑！", "提示");
            }
        }

        private void ToolStripMenuItemEdit_Click(object sender, EventArgs e)
        { // 编辑记录
            EditRecord();
        }

        private void ToolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(QueryDataGridView.GetClipboardContent());
            MessageBox.Show("已经成功复制到粘贴板", "成功！");
        }

        private void ToolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            String idString = QueryDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            if (!idString.Trim().Equals("1"))
            {
                String queryTable = pre_Tracking_Number + TrackingNumber.Text;
                if (MessageBox.Show("是否确认删除这条记录", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        Connection.Ins.ExecuteNonquery("DELETE FROM " + queryTable + " WHERE id = " + idString, null);
                        MessageBox.Show("删除记录成功！", "成功！");
                        searchButton.PerformClick();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "错误！");
                    }
                }
            }
            else
            {
                MessageBox.Show("初始记录不能删除！", "提示");
            }
        }

        // 双击事件
        private void QueryDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditRecord();
        }
    }
}
