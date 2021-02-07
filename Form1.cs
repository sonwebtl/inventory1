using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlykho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int startRun = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startRun += 10;
            Progressbar.Value = startRun;
            if ( Progressbar.Value == 100)
            {
                timer1.Stop();
                Progressbar.Value = 0;
                this.Hide();
                CategoryManage cat = new CategoryManage();
                cat.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
