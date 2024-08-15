using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001216316_PhanNgocBaoVinh_Buoi1.Controller
{
    class HandleBaiTap1
    {
        //private Thread trd;
        public HandleBaiTap1()
        {

        }
        int count = 0;
        ProgressBar pbShort;
        ProgressBar pbLong;
        Button[][] aBtn;
        string[][] board_caro;
        Boolean flag = false;
        public void load_board(Control.ControlCollection controls, int n)
        {
            aBtn = new Button[n][];
            board_caro = new string[n][];
            for (int i = 0; i < n; i++)
            {
                aBtn[i] = new Button[n];
                board_caro[i] = new string[n];
            }

            controls.Clear();
            new Thread(() =>
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        int row = i;
                        int col = j;
                        aBtn[i][j] = new Button();
                        aBtn[i][j].Size = new System.Drawing.Size(30, 30);
                        aBtn[i][j].Click += (sender,e)=> Button_Click(row,col);
                        aBtn[i][j].Text = "";
                        count++;
                      
                        controls.Owner.Invoke(new Action(() =>
                        {
                            controls.Add(aBtn[i][j]);
                            pbShort.Value = count;
                            pbLong.Value = count;
                        }));
                        Thread.Sleep(100);
                    }
                }
                Thread.Sleep(1000);
            }).Start();
        }

        private void Button_Click(int i, int j)
        {
            if (aBtn[i][j] != null && aBtn[i][j].Text == String.Empty)
            {
                if (!flag)
                {
                    aBtn[i][j].Text = "O";
                    flag = true;
                }
                else
                {
                    aBtn[i][j].Text = "X";
                    flag = false;
                }
            }
            else
            {
                // MessageBox.Show("A");
            }        
        }

        public void Generate_ProgressBar(ProgressBar b1, ProgressBar b2)
        {
            pbShort = b1;
            pbLong = b2;
        }
    }
}
