using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteLogFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void displayLog(string m)
        {
            string msg =  DateTime.Now.ToString("[yyyy/MM/dd hh:mm:ss.fff]") + m;
            //listBox1.Items.Add(m); //가장 최근에 추가한게 가장아래로감
            listBox1.Items.Insert(0, m); //가장 최근에 추가한게 가장위로감
        }

        private void button1_log_Click(object sender, EventArgs e)
        {
            displayLog(textBox1.Text);
            WriteLog.writeFileLog(textBox1.Text);
        }
    }
}
