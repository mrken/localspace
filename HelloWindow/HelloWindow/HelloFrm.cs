using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWindow
{
    public partial class HelloFrm : Form
    {
        public HelloFrm()
        {
            InitializeComponent();
        }

        private void HelloFrm_Load(object sender, EventArgs e)
        {
            this.Text = "可输入的窗体";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string result;
            result = txtName.Text+"同学，";
            result += "已完成作业";
            lb1Show.Text = result;
            label3.Text = "肿么有介摸二逼的交作业方式?!";
        }
    }
}
