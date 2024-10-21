using System;
using System.Windows.Forms;
using CustomConnection; // Thêm nếu cần thiết

namespace OnKT_PhatTrienThongMinh
{
    public partial class Form1 : Form
    {
        DbContext db = new DbContext();
        TimeSpan timeLeft; // Thời gian còn lại

        public Form1()
        {
            InitializeComponent();

            timer1 = new Timer();
            timer1.Interval = 1000; // Timer tick mỗi 1 giây
            timer1.Tick += Timer1_Tick; // Xử lý khi Timer tick

            textBox1.Text = "00:05:00"; // Đặt thời gian ban đầu (ví dụ 5 phút)

            button1.Click += Button1_Click; // Sự kiện click cho nút bắt đầu
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Lấy thời gian từ textBox (dạng HH:mm:ss) và chuyển đổi thành TimeSpan
            if (TimeSpan.TryParse(textBox1.Text, out timeLeft))
            {
                // Bắt đầu timer
                timer1.Start();
                button1.Enabled = false; // Vô hiệu hóa nút bắt đầu để không bắt đầu lại khi đang countdown
            }
            else
            {
                MessageBox.Show("Thời gian nhập không hợp lệ. Vui lòng nhập lại (HH:mm:ss).");
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Giảm thời gian
            if (timeLeft.TotalSeconds > 0)
            {
                timeLeft = timeLeft.Add(TimeSpan.FromSeconds(-1)); // Trừ 1 giây mỗi tick
                textBox1.Text = timeLeft.ToString(@"hh\:mm\:ss"); // Cập nhật textBox
            }
            else
            {
                timer1.Stop(); // Dừng timer khi hết thời gian
                MessageBox.Show("Hết giờ!");
                button1.Enabled = true; // Kích hoạt lại nút bắt đầu
            }
        }
    }
}
