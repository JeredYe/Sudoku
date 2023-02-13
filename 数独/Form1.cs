namespace 数独
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class Form1 : Form
    {
        private Button button1;
        private CheckBox checkBox1;
        private IContainer components;
        private Label label1;
        private TrackBar trackBar1;

        public Form1()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Game { 
                Difficulty = this.trackBar1.Value,
                Tips = this.checkBox1.Checked
            }.Show();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.button1 = new Button();
            this.trackBar1 = new TrackBar();
            this.label1 = new Label();
            this.checkBox1 = new CheckBox();
            this.trackBar1.BeginInit();
            base.SuspendLayout();
            this.button1.Font = new Font("微软雅黑", 21.75f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.button1.Location = new Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x127, 0x4a);
            this.button1.TabIndex = 0;
            this.button1.Text = "新的数独";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.trackBar1.Location = new Point(12, 0x81);
            this.trackBar1.Maximum = 80;
            this.trackBar1.Minimum = 30;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new Size(0x127, 0x2d);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 0x37;
            this.trackBar1.Scroll += new EventHandler(this.trackBar1_Scroll);
            this.label1.AutoSize = true;
            this.label1.Font = new Font("微软雅黑", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.label1.Location = new Point(12, 0x62);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x9f, 0x1c);
            this.label1.TabIndex = 2;
            this.label1.Text = "难度选择：中等";
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = CheckState.Checked;
            this.checkBox1.Font = new Font("微软雅黑", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.checkBox1.Location = new Point(0xea, 0x5e);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(0x49, 0x20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "提示";
            this.checkBox1.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x13c, 0xb1);
            base.Controls.Add(this.checkBox1);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.trackBar1);
            base.Controls.Add(this.button1);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Form1";
            this.Text = "数独 By DHU Jered.";
            this.trackBar1.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (this.trackBar1.Value <= 40)
            {
                this.label1.Text = "难度选择：极易";
            }
            else if (this.trackBar1.Value <= 50)
            {
                this.label1.Text = "难度选择：简单";
            }
            else if (this.trackBar1.Value <= 60)
            {
                this.label1.Text = "难度选择：中等";
            }
            else if (this.trackBar1.Value < 70)
            {
                this.label1.Text = "难度选择：稍难";
            }
            else
            {
                this.label1.Text = "难度选择：极难";
            }
            if (this.trackBar1.Value > 70)
            {
                this.checkBox1.Checked = false;
            }
            else
            {
                this.checkBox1.Checked = true;
            }
        }
    }
}

