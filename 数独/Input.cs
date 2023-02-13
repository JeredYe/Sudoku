namespace 数独
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class Input : Form
    {
        public Button button1;
        public Button button10;
        public Button button2;
        public Button button3;
        public Button button4;
        public Button button5;
        public Button button6;
        public Button button7;
        public Button button8;
        public Button button9;
        private IContainer components;
        public string Return = "";

        public Input()
        {
            this.InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void Click(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            this.Return = button.Text;
            base.Close();
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
            this.button2 = new Button();
            this.button3 = new Button();
            this.button4 = new Button();
            this.button5 = new Button();
            this.button6 = new Button();
            this.button7 = new Button();
            this.button8 = new Button();
            this.button9 = new Button();
            this.button10 = new Button();
            base.SuspendLayout();
            this.button1.Font = new Font("微软雅黑", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.button1.Location = new Point(12, 0x13);
            this.button1.Name = "button1";
            this.button1.Size = new Size(60, 0x37);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button2.Font = new Font("微软雅黑", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.button2.Location = new Point(0x4e, 0x13);
            this.button2.Name = "button2";
            this.button2.Size = new Size(60, 0x37);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button3.Font = new Font("微软雅黑", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.button3.Location = new Point(0x90, 0x13);
            this.button3.Name = "button3";
            this.button3.Size = new Size(60, 0x37);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button4.Font = new Font("微软雅黑", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.button4.Location = new Point(210, 0x13);
            this.button4.Name = "button4";
            this.button4.Size = new Size(60, 0x37);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button5.Font = new Font("微软雅黑", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.button5.Location = new Point(0x114, 0x13);
            this.button5.Name = "button5";
            this.button5.Size = new Size(60, 0x37);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button6.Font = new Font("微软雅黑", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.button6.Location = new Point(0x156, 0x13);
            this.button6.Name = "button6";
            this.button6.Size = new Size(60, 0x37);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button7.Font = new Font("微软雅黑", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.button7.Location = new Point(0x198, 0x13);
            this.button7.Name = "button7";
            this.button7.Size = new Size(60, 0x37);
            this.button7.TabIndex = 5;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button8.Font = new Font("微软雅黑", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.button8.Location = new Point(0x1da, 0x13);
            this.button8.Name = "button8";
            this.button8.Size = new Size(60, 0x37);
            this.button8.TabIndex = 4;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button9.Font = new Font("微软雅黑", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.button9.Location = new Point(540, 0x13);
            this.button9.Name = "button9";
            this.button9.Size = new Size(60, 0x37);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button10.Font = new Font("微软雅黑", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.button10.Location = new Point(0x25e, 0x13);
            this.button10.Name = "button10";
            this.button10.Size = new Size(60, 0x37);
            this.button10.TabIndex = 8;
            this.button10.Text = "X";
            this.button10.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(11f, 25f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x2a3, 0x57);
            base.Controls.Add(this.button9);
            base.Controls.Add(this.button10);
            base.Controls.Add(this.button5);
            base.Controls.Add(this.button6);
            base.Controls.Add(this.button7);
            base.Controls.Add(this.button8);
            base.Controls.Add(this.button4);
            base.Controls.Add(this.button3);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            this.Font = new Font("微软雅黑", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(6);
            base.Name = "Input";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "输入";
            base.Load += new EventHandler(this.输入_Load);
            base.ResumeLayout(false);
        }

        private void 输入_Load(object sender, EventArgs e)
        {
            this.button1.Click += new EventHandler(this.Click);
            this.button2.Click += new EventHandler(this.Click);
            this.button9.Click += new EventHandler(this.Click);
            this.button3.Click += new EventHandler(this.Click);
            this.button7.Click += new EventHandler(this.Click);
            this.button6.Click += new EventHandler(this.Click);
            this.button5.Click += new EventHandler(this.Click);
            this.button4.Click += new EventHandler(this.Click);
            this.button8.Click += new EventHandler(this.Click);
            this.button10.Click += new EventHandler(this.Click);
        }
    }
}

