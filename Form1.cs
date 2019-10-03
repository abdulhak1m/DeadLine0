using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int move = 0, moveX = 0, moveY = 0;
            panel1.MouseDown += (s, e) => { move = 1; moveX = e.X; moveY = e.Y; };
            panel1.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY); };
            panel1.MouseUp += (s, e) => { move = 0; };
        }

        void Button1_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        async void Button_Click(object sender, System.EventArgs e)
        {
            // начальный цвет 70,130,180
            //желаемый цвет 135,206,250

            //for (byte r = 70, g = 130, b = 180; r <= 135 & g <= 206 & b <= 250; r += 6, g += 7, b += 7, await Task.Delay(100))
            //{
            //    label1.ForeColor = Color.FromArgb(r, g, b);
            //}

            //await Task.Delay(2000);

            //for(byte r = 135, g = 206, b = 250; r >= 70 & g >= 130 & b >= 180; r-=6, g-=7, b -= 7, await Task.Delay(100))
            //{
            //    label1.ForeColor = Color.FromArgb(r, g, b);
            //}

            //label1.ForeColor = Color.FromArgb(70, 130, 180);

            char[] chars = "Джамиля улыбнись! Посмотри сколько людей тебя любят! Не время грустить, время веселиться!".ToCharArray();
            foreach(char ch in chars)
            {
                await Task.Delay(80);
                label1.Text += ch.ToString();
            }
        }
    }
}
