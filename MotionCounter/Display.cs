using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotionCounter
{
    public partial class Display : Form
    {
        private Form1 ParentForm { set; get; }
        public Display()
        {
            InitializeComponent();
        }
        public Display(Form1 pform) : this()
        {
            ParentForm = pform;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.button1.Hide();
        }

        private void ExitFullScreen(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27: //Esc键值
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                    this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                    this.button1.Show();
                    break;
                default:

                    break;
            }
        }

        private void Display_Closed(object sender, EventArgs e)
        {
            ParentForm.Display = null;
        }

        public void DataInit(DataModel data)
        {
            this.labNowName.Text = data.CurrentName;
            this.labNowValue.Text = data.CurrentValue.ToString();

            this.labDiscript.Text = "";
            foreach (var obj in data.Descript)
            {
                this.labDiscript.Text += obj.Key + "：" + obj.Value + "\r\n";
            }
        }
    }
}
