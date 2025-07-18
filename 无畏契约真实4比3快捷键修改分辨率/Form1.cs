using AntdUI;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace 无畏契约真实4比3快捷键修改分辨率
{
    public partial class Form1 : AntdUI.Window

    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;


        public Form1()
        {
            this.MouseDown += Form1_MouseDown; // 绑定鼠标按下事件
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitter1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ysfbly_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            }
        }

        private void menu1_SelectChanged(object sender, MenuSelectEventArgs e)
        {
            if (e.Value.ToString() == "主页")
            {
                tabs1.SelectedIndex = 0;
            }
            else if (e.Value.ToString() == "关于")
            {
                tabs1.SelectedIndex = 1;
            }


        }

        private void segmented1_SelectIndexChanged(object sender, IntEventArgs e)
        {
            if (e.Value == 0)
            {
                AntdUI.Config.IsLight = true;
                Refresh();
            }
            else if (e.Value == 1)
            {
                                AntdUI.Config.IsLight = false;
                Refresh();
            }
        }
    }



}

