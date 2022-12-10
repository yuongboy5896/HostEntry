using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HostEntry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string listip = this.Domainlist.Text;
            string[] Domainlist = System.Text.RegularExpressions.Regex.Split(listip, @"\r?\n|\r");
            var Outlist = new List<string>();
            foreach (string s in Domainlist)
            {
                Outlist.Add(s + ":");
                IPHostEntry host = Dns.GetHostEntry(s);
                foreach (var va in host.AddressList)
                {
                    Console.WriteLine(va.ToString());
                    Outlist.Add(va.ToString());
                }
                
            }
            System.IO.File.WriteAllLines(this.tBoutDir.Text, Outlist);
            MessageBox.Show("导出","完成！！");
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            //选择文件夹路径
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            //提示信息
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.tBoutDir.Text = dialog.SelectedPath+ @"\\Host-IP.txt";
            }

        }
    }
}
