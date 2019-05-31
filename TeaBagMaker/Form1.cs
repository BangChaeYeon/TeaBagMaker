using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        String[] teaList = { "홍차", "녹차", "루이보스차", "국화차" };
        String select = "";
        int time = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < teaList.Length; i++)
            {
                this.teaComboBox.Items.Add(teaList[i]);
            }

            if(select.Equals(""))
            {
                this.teaComboBox.SelectedIndex = 0;
            }
        }

        private void CountDownBtn_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void TeaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            select = teaComboBox.Text;
            switch (select)
            {
                case "홍차":
                    time = 120;
                    break;
                case "녹차":
                    time = 180;
                    break;
                case "루이보스차":
                    time = 300;
                    break;
                case "국화차":
                    time = 120;
                    break;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int min, sec;

            if (time == 0)
            {
                this.timer1.Enabled = false;
                MessageBox.Show("티백을 건지세요!", "종료",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.teaComboBox.Focus();
            }
            else
            {
                time--;
                min = time / 60;
                sec = time % 60;
                timeTxt.Text = "남은 시간: " + min + ":" + sec;
            }
        }
    }
}
