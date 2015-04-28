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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OptionComboBox.SelectedIndex = 0;
        }

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
                            outputList.Add(new List<String>() { itemList[1], itemList[2], itemList[3], itemList[10], itemList[11], itemList[7], (float.Parse(itemList[10].Equals("") ? "0" : itemList[10]) + float.Parse(itemList[11].Equals("") ? "0" : itemList[11]) + float.Parse(itemList[7].Equals("") ? "0" : itemList[7])).ToString() });
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
    }
}
