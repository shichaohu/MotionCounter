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
    public partial class Form1 : Form
    {
        public Display Display { set; get; }
        public DataModel Data { set; get; }
        public Form1()
        {
            InitializeComponent();
            Data = new DataModel() { Descript = new Dictionary<string, int>(), CurrentName = "仰卧起坐", CurrentValue = 0 };
            btnSave.Enabled = false;
            combObject.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "初始化")
            {
                if (Display == null)
                {
                    Display = new Display(this);
                }
                Display.Show();

                button1.Text = "计数";

                btnSave.Enabled = true;
                combObject.Enabled = true;
            }
            else
            {
                this.Data.CurrentValue++;

                Display.DataInit(Data);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Data.Descript.Keys.Contains(Data.CurrentName))
            {
                Data.Descript[Data.CurrentName] += Data.CurrentValue;
            }
            else
            {
                Data.Descript.Add(Data.CurrentName, Data.CurrentValue);
            }
            Data.CurrentValue = 0;

            //if (this.Display != null)
                Display.DataInit(Data);
        }

        private void combObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
            Data.CurrentName = combObject.Text;
        }
    }
}
