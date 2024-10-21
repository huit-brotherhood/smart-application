using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Timer : UserControl
    {
        public int flag { get; set; }
        private int h, m, s, khac; // Biến khắc để đếm khắc

        public Timer()
        {
            InitializeComponent();
            flag = 0;
            h = m = s = khac = 0; // Khởi tạo giá trị ban đầu
            timer1.Interval = 1;
            timer1.Tick += Timer1_Tick1;
            btnPlay.Click += BtnPlay_Click;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (flag == 0) // Nếu chưa bắt đầu
            {
                flag = 1; // Chuyển sang trạng thái chạy
                timer1.Start(); // Bắt đầu timer
            }
            else if (flag == 1) // Nếu đang chạy
            {
                flag = 0; // Chuyển sang trạng thái dừng
                timer1.Stop(); // Dừng timer
            }
        }
        private void Timer1_Tick1(object sender, EventArgs e)
        {
            // Tăng số khắc
            khac += 1;

            // Nếu đạt 60 khắc, tăng giây
            if (khac == 999)
            {
                khac = 0; // Đặt lại số khắc về 0
                s += 1;  // Tăng giây lên 1

                // Kiểm tra nếu giây đạt 60 thì tăng phút
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }

                // Kiểm tra nếu phút đạt 60 thì tăng giờ
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
            }

            // Cập nhật hiển thị thời gian và số khắc
            lblTimer.Text = String.Format("{0:D2}:{1:D2}:{2:D2} - {3}", h, m, s, khac);
        }
    }



}
