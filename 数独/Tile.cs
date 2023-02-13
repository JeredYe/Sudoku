namespace 数独
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class Tile
    {
        public Button button = new Button();
        public int FilledNum;
        public int id;
        public int num;
        public bool status;
        public int x;
        public int y;

        public Tile(int num, int x, int y, bool status, int Width, int Height, EventHandler eventHandler)
        {
            this.num = num;
            this.button.Text = Convert.ToString(num);
            this.button.Tag = this;
            this.button.Click += eventHandler;
            this.x = x;
            this.y = y;
            this.button.Enabled = this.status = status;
            this.id = this.GetID();
            this.Resize(Width, Height);
        }

        private int GetID()
        {
            int num = 0;
            if ((this.x >= 0) && (this.x <= 2))
            {
                num++;
            }
            if ((this.x >= 3) && (this.x <= 5))
            {
                num += 2;
            }
            if ((this.x >= 6) && (this.x <= 8))
            {
                num += 3;
            }
            if ((this.y >= 3) && (this.y <= 5))
            {
                num += 3;
            }
            if ((this.y >= 6) && (this.y <= 8))
            {
                num += 6;
            }
            return num;
        }

        public void Initialize()
        {
            this.button.Text = "";
            this.button.Enabled = true;
            this.status = true;
        }

        public void Resize(int Width, int Height)
        {
            int num = ((this.x - 1) / 3) * 10;
            int num2 = ((this.y - 1) / 3) * 10;
            this.button.Left = ((Width / 500) + ((this.x - 1) * (Width / 11))) + num;
            this.button.Top = ((Height / 500) + ((this.y - 1) * ((Height / 0x5f) * 10))) + num2;
            this.button.Width = Width / 11;
            this.button.Height = Height / 10;
            this.button.Font = new Font("微软雅黑", (float) (this.button.Width / 3), FontStyle.Bold);
        }
    }
}

