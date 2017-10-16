namespace MotionCounter
{
    partial class Display
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.labNowName = new System.Windows.Forms.Label();
            this.labNowValue = new System.Windows.Forms.Label();
            this.labDiscript = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::MotionCounter.Properties.Resources.全屏;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1735, 750);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExitFullScreen);
            // 
            // labNowName
            // 
            this.labNowName.AutoSize = true;
            this.labNowName.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNowName.Location = new System.Drawing.Point(31, 388);
            this.labNowName.Name = "labNowName";
            this.labNowName.Size = new System.Drawing.Size(185, 34);
            this.labNowName.TabIndex = 1;
            this.labNowName.Text = "当前项目：";
            // 
            // labNowValue
            // 
            this.labNowValue.AutoSize = true;
            this.labNowValue.Font = new System.Drawing.Font("宋体", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNowValue.Location = new System.Drawing.Point(357, 362);
            this.labNowValue.Name = "labNowValue";
            this.labNowValue.Size = new System.Drawing.Size(77, 84);
            this.labNowValue.TabIndex = 2;
            this.labNowValue.Text = "0";
            // 
            // labDiscript
            // 
            this.labDiscript.AutoSize = true;
            this.labDiscript.Font = new System.Drawing.Font("宋体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDiscript.Location = new System.Drawing.Point(359, 59);
            this.labDiscript.Name = "labDiscript";
            this.labDiscript.Size = new System.Drawing.Size(96, 67);
            this.labDiscript.TabIndex = 3;
            this.labDiscript.Text = "无";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(65, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "已完成：";
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1772, 786);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labDiscript);
            this.Controls.Add(this.labNowValue);
            this.Controls.Add(this.labNowName);
            this.Controls.Add(this.button1);
            this.Name = "Display";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "运动数据展示端";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Display_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labNowName;
        private System.Windows.Forms.Label labNowValue;
        private System.Windows.Forms.Label labDiscript;
        private System.Windows.Forms.Label label1;
    }
}