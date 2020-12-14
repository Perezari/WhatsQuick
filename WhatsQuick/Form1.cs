using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WhatsQuick
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WaBtn_Click(object sender, EventArgs e)
        {
            string Kidomet = comboBox1.Text.Substring(1);
            string MyProcess = "https://wa.me/972" + Kidomet + textBox1.Text + "?text=" + richTextBox1.Text;
            Process.Start(MyProcess);  
        }
    }
}
