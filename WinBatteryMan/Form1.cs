using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.ApplicationServices;
using Microsoft.WindowsAPICodePack.Shell;
using System.IO; 

namespace WinBatteryMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String currentLevel;
        private Boolean isStart = false;
        private DateTime beginTime;
        private void button_start_Click(object sender, EventArgs e)
        {
            if (isStart)
            {
                isStart = false;
                button_start.Text = "开始监控";
                listBox1.Items.Clear();
                label_status.Text = "";
                ShowSaveFileDialog();
            }
            else 
            {
                if (File.Exists("temp.txt"))
                {
                    File.Delete("temp.txt");
                }
                FileStream fs1 = new FileStream("temp.txt", FileMode.Create, FileAccess.Write);//创建文件
                fs1.Close();
                listBox1.Items.Clear();
                isStart = true;
                button_start.Text = "停止监控";
                beginTime = DateTime.Now;
                currentLevel = PowerManager.BatteryLifePercent.ToString();
                listBox1.Items.Add(beginTime.ToString() + " " + PowerManager.PowerSource.ToString()+" " + currentLevel + "%" + "  开始监控");
                label_status.Text = "监控中";
                addLog(DateTime.Now.ToString() + " " + PowerManager.PowerSource.ToString() + " " + currentLevel + "%" + "  开始监控");
            }
           
        }

        private void BatteryLifePercentChanged(object sender, EventArgs e)
        {
            progressBar_level.Value = PowerManager.BatteryLifePercent;
            label_level.Text = PowerManager.BatteryLifePercent.ToString() + "%";
            if (isStart && currentLevel != PowerManager.BatteryLifePercent.ToString())
            {
                currentLevel = PowerManager.BatteryLifePercent.ToString();
                TimeSpan ts = DateTime.Now.Subtract(beginTime).Duration();
                String spanTime = ts.Hours.ToString() + "小时" + ts.Minutes.ToString() + "分" + ts.Seconds.ToString() + "秒";
                listBox1.Items.Add(DateTime.Now.ToString() + " " + PowerManager.PowerSource.ToString() + " " + currentLevel + "%  " + spanTime);
                addLog(DateTime.Now.ToString() + " " + PowerManager.PowerSource.ToString() + " " + currentLevel + "%  " + spanTime);
            }
        }

        private void PowerSourceChanged(object sender, EventArgs e)
        {
            label_powersource.Text = PowerManager.PowerSource.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("temp.txt"))
            {
               // File.Delete("temp.txt");
                openLast();
            }
            PowerManager.BatteryLifePercentChanged += new EventHandler(BatteryLifePercentChanged);
            PowerManager.PowerSourceChanged += new EventHandler(PowerSourceChanged);
            label_powersource.Text = PowerManager.PowerSource.ToString();
            progressBar_level.Value = PowerManager.BatteryLifePercent;
            label_level.Text = PowerManager.BatteryLifePercent.ToString() + "%";
        }

        private void addLog(String log) 
        {
            StreamWriter sw = File.AppendText("temp.txt");

            sw.WriteLine(log);

            sw.Flush();

            sw.Close();
        }

        private void ShowSaveFileDialog()
        {

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.FileName = "WinBatteryMan";
            //设置文件类型   
            sfd.Filter = "log文件（*.txt）|*.txt";

            //设置默认文件类型显示顺序   
            sfd.FilterIndex = 1;

            //保存对话框是否记忆上次打开的目录   
            sfd.RestoreDirectory = true;

            //点了保存按钮进入   
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = sfd.FileName.ToString();     //获得文件路径 
                File.Copy("temp.txt", localFilePath, true);
                File.Delete("temp.txt");
                MessageBox.Show("保存成功!", "Notice");
            }
            else 
            {
                File.Copy("temp.txt", DateTime.Now.ToString("yyyyMMddHHmmss")+".txt", true);
                File.Delete("temp.txt");
            }
        }

        private void openLast() 
        {
            DialogResult dr;
            dr = MessageBox.Show("检测到有上次数据，是否打开？！", "提示", MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                StreamReader sr = new StreamReader("temp.txt", Encoding.UTF8);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
                sr.Close();
            }
        }
    }
}
