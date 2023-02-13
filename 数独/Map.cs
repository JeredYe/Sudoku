namespace 数独
{
    using System;
    using System.Windows.Forms;

    public class Map
    {
        private int[] Chart = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public int[,] Matrix = new int[9, 9];
        private Random random = new Random();
        private bool SAVED;
        private int[] Selected = new int[9];

        public Map()
        {
            this.Matrix = new int[9, 9];
            this.Selected = new int[9];
            this.GenerateMap();
        }

        private void Debug_Output()
        {
            string mapString = this.GetMapString();
            for (int i = 0; i < 9; i++)
            {
                mapString = mapString + Convert.ToString((int) (i + 1));
            }
            mapString = mapString + "\n";
            for (int j = 0; j < 9; j++)
            {
                mapString = mapString + Convert.ToString(this.Selected[j]);
            }
            MessageBox.Show(mapString + "\n");
        }

        private void DFS(int Line, int X)
        {
            if (!this.SAVED)
            {
                if (Line == 9)
                {
                    this.SAVED = true;
                }
                else
                {
                    int[] numArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    int num = this.random.Next(5, 10);
                    for (int i = 0; i < num; i++)
                    {
                        int index = this.random.Next(9);
                        int num4 = this.random.Next(9);
                        int num5 = numArray[index];
                        numArray[index] = numArray[num4];
                        numArray[num4] = num5;
                    }
                    for (int j = X; j < 9; j++)
                    {
                        bool flag = true;
                        int num7 = 0;
                        while (num7 < 9)
                        {
                            if (numArray[num7] != 0)
                            {
                                if (this.Selected[numArray[num7] - 1] == 9)
                                {
                                    goto Label_00B2;
                                }
                                if (this.Judge(X, Line, numArray[num7]))
                                {
                                    flag = false;
                                    break;
                                }
                            }
                            numArray[num7] = 0;
                        Label_00B2:
                            num7++;
                        }
                        if (flag)
                        {
                            return;
                        }
                        this.Matrix[Line, X] = this.Chart[numArray[num7] - 1];
                        numArray[num7] = 0;
                        this.Selected[num7]++;
                        if (X == 8)
                        {
                            this.DFS(Line + 1, 0);
                        }
                        else
                        {
                            this.DFS(Line, X + 1);
                        }
                        if (this.SAVED)
                        {
                            return;
                        }
                        this.Selected[num7]--;
                        this.Matrix[Line, X] = 0;
                        j--;
                    }
                }
            }
        }

        public void GenerateMap()
        {
            int[] numArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int num = 0;
            while (num < 9)
            {
                int index = this.random.Next(numArray.Length);
                if (numArray[index] != 0)
                {
                    this.Matrix[0, num++] = numArray[index];
                    this.Selected[numArray[index] - 1]++;
                    numArray[index] = 0;
                }
            }
            this.DFS(1, 0);
        }

        private int GetID(int x, int y)
        {
            int num = 0;
            if ((x >= 0) && (x <= 2))
            {
                num++;
            }
            if ((x >= 3) && (x <= 5))
            {
                num += 2;
            }
            if ((x >= 6) && (x <= 8))
            {
                num += 3;
            }
            if ((y >= 3) && (y <= 5))
            {
                num += 3;
            }
            if ((y >= 6) && (y <= 8))
            {
                num += 6;
            }
            return num;
        }

        public string GetMapString()
        {
            string str = "";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    str = str + Convert.ToString(this.Matrix[i, j]);
                }
                str = str + "\n";
            }
            return (str + "\n");
        }

        public bool Judge(int x, int y, int num)
        {
            if (!this.JudgeHorizonal(y, num))
            {
                return false;
            }
            if (!this.JudgeVertical(x, num))
            {
                return false;
            }
            int iD = this.GetID(x, y);
            int num3 = 0;
            int num4 = 0;
            switch (iD)
            {
                case 1:
                    num3 = 0;
                    num4 = 0;
                    break;

                case 2:
                    num3 = 3;
                    num4 = 0;
                    break;

                case 3:
                    num3 = 6;
                    num4 = 0;
                    break;

                case 4:
                    num3 = 0;
                    num4 = 3;
                    break;

                case 5:
                    num3 = 3;
                    num4 = 3;
                    break;

                case 6:
                    num3 = 6;
                    num4 = 3;
                    break;

                case 7:
                    num3 = 0;
                    num4 = 6;
                    break;

                case 8:
                    num3 = 3;
                    num4 = 6;
                    break;

                case 9:
                    num3 = 6;
                    num4 = 6;
                    break;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (this.Matrix[num4 + i, num3 + j] == num)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool JudgeHorizonal(int y, int num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (this.Matrix[y, i] == num)
                {
                    return false;
                }
            }
            return true;
        }

        private bool JudgeVertical(int x, int num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (this.Matrix[i, x] == num)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

