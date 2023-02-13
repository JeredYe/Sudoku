namespace 数独
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class Game : Form
    {
        private Button button1;
        private IContainer components;
        private DateTime dateTime = new DateTime(0L);
        public int Difficulty = 50;
        private Map map = new Map();
        private Random random = new Random(DateTime.Now.Second);
        private Tile[,] Tiles = new Tile[9, 9];
        private Timer timer1;
        public bool Tips = true;
        private Label x1;
        private Label x2;
        private Label y1;
        private Label y2;

        public Game()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (this.Tiles[i - 1, j - 1].status)
                    {
                        Button button = this.Tiles[i - 1, j - 1].button;
                        if (button.Text == Convert.ToString(this.Tiles[i - 1, j - 1].num))
                        {
                            button.BackColor = button.ForeColor = Color.LightBlue;
                        }
                        else
                        {
                            flag = false;
                            this.dateTime.Add(TimeSpan.FromSeconds((double) this.Difficulty));
                        }
                    }
                }
            }
            if (!flag)
            {
                MessageBox.Show("您尚未完全正确", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("恭喜您已通关！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                for (int k = 1; k <= 9; k++)
                {
                    for (int m = 1; m <= 9; m++)
                    {
                        this.Tiles[k - 1, m - 1].button.Enabled = false;
                    }
                }
            }
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            Tile tag = (Tile) button.Tag;
            Input input = new Input();
            if (this.Tips)
            {
                int num = this.map.Matrix[tag.y - 1, tag.x - 1];
                this.map.Matrix[tag.y - 1, tag.x - 1] = 0;
                if (this.map.Judge(tag.x - 1, tag.y - 1, 1))
                {
                    input.button1.Enabled = true;
                }
                else
                {
                    input.button1.Enabled = false;
                }
                if (this.map.Judge(tag.x - 1, tag.y - 1, 2))
                {
                    input.button2.Enabled = true;
                }
                else
                {
                    input.button2.Enabled = false;
                }
                if (this.map.Judge(tag.x - 1, tag.y - 1, 3))
                {
                    input.button3.Enabled = true;
                }
                else
                {
                    input.button3.Enabled = false;
                }
                if (this.map.Judge(tag.x - 1, tag.y - 1, 4))
                {
                    input.button4.Enabled = true;
                }
                else
                {
                    input.button4.Enabled = false;
                }
                if (this.map.Judge(tag.x - 1, tag.y - 1, 5))
                {
                    input.button5.Enabled = true;
                }
                else
                {
                    input.button5.Enabled = false;
                }
                if (this.map.Judge(tag.x - 1, tag.y - 1, 6))
                {
                    input.button6.Enabled = true;
                }
                else
                {
                    input.button6.Enabled = false;
                }
                if (this.map.Judge(tag.x - 1, tag.y - 1, 7))
                {
                    input.button7.Enabled = true;
                }
                else
                {
                    input.button7.Enabled = false;
                }
                if (this.map.Judge(tag.x - 1, tag.y - 1, 8))
                {
                    input.button8.Enabled = true;
                }
                else
                {
                    input.button8.Enabled = false;
                }
                if (this.map.Judge(tag.x - 1, tag.y - 1, 9))
                {
                    input.button9.Enabled = true;
                }
                else
                {
                    input.button9.Enabled = false;
                }
                this.map.Matrix[tag.y - 1, tag.x - 1] = num;
            }
            input.ShowDialog();
            if (input.Return != "")
            {
                button.Text = (input.Return == "X") ? "" : input.Return;
            }
            if (input.Return == "X")
            {
                this.map.Matrix[tag.y - 1, tag.x - 1] = 0;
            }
            else if (input.Return != "")
            {
                this.map.Matrix[tag.y - 1, tag.x - 1] = Convert.ToInt32(input.Return);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Game_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    this.Tiles[i - 1, k - 1] = new Tile(this.map.Matrix[i - 1, k - 1], k, i, false, base.Width, base.Height, new EventHandler(this.ClickEvent));
                    base.Controls.Add(this.Tiles[i - 1, k - 1].button);
                    this.Tiles[i - 1, k - 1].button.BringToFront();
                }
            }
            int num = (this.Difficulty * 5) / 7;
            for (int j = 0; j < num; j++)
            {
                int num5 = this.random.Next(9);
                int num6 = this.random.Next(9);
                if (this.map.Matrix[num6, num5] == 0)
                {
                    j--;
                }
                else
                {
                    this.map.Matrix[num6, num5] = 0;
                    this.Tiles[num6, num5].Initialize();
                }
            }
            this.Render();
        }

        private void Game_Resize(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    this.Tiles[i - 1, j - 1].Resize(base.Width, base.Height);
                }
            }
            this.button1.Left = (base.Width - (this.button1.Width * 2)) + 50;
            this.button1.Top = (base.Height - (this.button1.Height * 2)) + 20;
            this.Render();
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Game));
            this.button1 = new Button();
            this.timer1 = new Timer(this.components);
            this.y1 = new Label();
            this.y2 = new Label();
            this.x1 = new Label();
            this.x2 = new Label();
            base.SuspendLayout();
            this.button1.Font = new Font("微软雅黑", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.button1.Location = new Point(0x2b7, 0x24c);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x4d, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.timer1.Interval = 0x3e8;
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            this.y1.AutoSize = true;
            this.y1.Location = new Point(-93, 0xc6);
            this.y1.Name = "y1";
            this.y1.Size = new Size(0xf65, 12);
            this.y1.TabIndex = 1;
            //this.y1.Text = manager.GetString("y1.Text");
            this.y2.AutoSize = true;
            this.y2.Location = new Point(-102, 0x176);
            this.y2.Name = "y2";
            this.y2.Size = new Size(0xf65, 12);
            this.y2.TabIndex = 2;
            //this.y2.Text = manager.GetString("y2.Text");
            this.x1.AutoSize = true;
            this.x1.Location = new Point(0xdb, 9);
            this.x1.Name = "x1";
            this.x1.Size = new Size(11, 0x960);
            this.x1.TabIndex = 3;
            //this.x1.Text = manager.GetString("x1.Text");
            this.x2.AutoSize = true;
            this.x2.Location = new Point(460, -271);
            this.x2.Name = "x2";
            this.x2.Size = new Size(11, 0x960);
            this.x2.TabIndex = 4;
            //this.x2.Text = manager.GetString("x2.Text");
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x310, 670);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.y2);
            base.Controls.Add(this.x1);
            base.Controls.Add(this.y1);
            base.Controls.Add(this.x2);
            base.Name = "Game";
            this.Text = "Game";
            base.Load += new EventHandler(this.Game_Load);
            base.Resize += new EventHandler(this.Game_Resize);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Render()
        {
            this.y1.Top = this.Tiles[2, 0].button.Top + this.Tiles[2, 0].button.Height;
            this.y2.Top = this.Tiles[5, 0].button.Top + this.Tiles[5, 0].button.Height;
            this.x1.Left = this.Tiles[0, 2].button.Left + this.Tiles[0, 2].button.Width;
            this.x2.Left = this.Tiles[0, 5].button.Left + this.Tiles[0, 5].button.Width;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.dateTime.AddSeconds(1.0);
            this.Text = "用时" + this.dateTime.Minute.ToString() + ":" + this.dateTime.Second.ToString();
        }
    }
}

