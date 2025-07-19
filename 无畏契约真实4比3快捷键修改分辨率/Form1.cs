using AntdUI;
using Lzhdim.Helper;
using System.Collections;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

namespace 无畏契约真实4比3快捷键修改分辨率
{

    public partial class Form1 : AntdUI.Window

    {

        public class User32API
        {
            private static Hashtable processWnd = null;
            public delegate bool WNDENUMPROC(IntPtr hwnd, uint lParam);

            static User32API()
            {
                if (processWnd == null)
                {
                    processWnd = new Hashtable();
                }
            }

            [DllImport("user32.dll", EntryPoint = "EnumWindows", SetLastError = true)]
            public static extern bool EnumWindows(WNDENUMPROC lpEnumFunc, uint lParam);

            [DllImport("user32.dll", EntryPoint = "GetParent", SetLastError = true)]
            public static extern IntPtr GetParent(IntPtr hWnd);

            [DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId")]
            public static extern uint GetWindowThreadProcessId(IntPtr hWnd, ref uint lpdwProcessId);

            [DllImport("user32.dll", EntryPoint = "IsWindow")]
            public static extern bool IsWindow(IntPtr hWnd);

            [DllImport("kernel32.dll", EntryPoint = "SetLastError")]
            public static extern void SetLastError(uint dwErrCode);

            public static IntPtr GetCurrentWindowHandle()
            {
                IntPtr ptrWnd = IntPtr.Zero;
                uint uiPid = (uint)Process.GetCurrentProcess().Id;  // 当前进程 ID
                object objWnd = processWnd[uiPid];

                if (objWnd != null)
                {
                    ptrWnd = (IntPtr)objWnd;
                    if (ptrWnd != IntPtr.Zero && IsWindow(ptrWnd))  // 从缓存中获取句柄
                    {
                        return ptrWnd;
                    }
                    else
                    {
                        ptrWnd = IntPtr.Zero;
                    }
                }

                bool bResult = EnumWindows(new WNDENUMPROC(EnumWindowsProc), uiPid);
                // 枚举窗口返回 false 并且没有错误号时表明获取成功
                if (!bResult && Marshal.GetLastWin32Error() == 0)
                {
                    objWnd = processWnd[uiPid];
                    if (objWnd != null)
                    {
                        ptrWnd = (IntPtr)objWnd;
                    }
                }

                return ptrWnd;
            }

            private static bool EnumWindowsProc(IntPtr hwnd, uint lParam)
            {
                uint uiPid = 0;

                if (GetParent(hwnd) == IntPtr.Zero)
                {
                    GetWindowThreadProcessId(hwnd, ref uiPid);
                    if (uiPid == lParam)    // 找到进程对应的主窗口句柄
                    {
                        processWnd[uiPid] = hwnd;   // 把句柄缓存起来
                        SetLastError(0);    // 设置无错误
                        return false;   // 返回 false 以终止枚举窗口
                    }
                }

                return true;
            }
        }



        int i = Screen.PrimaryScreen.Bounds.Width;
        int j = Screen.PrimaryScreen.Bounds.Height;

        #region 修改分辨率部分
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct DEVMODE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmDeviceName;
            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public short dmOrientation;
            public short dmPaperSize;
            public short dmPaperLength;
            public short dmPaperWidth;
            public short dmScale;
            public short dmCopies;
            public short dmDefaultSource;
            public short dmPrintQuality;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmFormName;
            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int ChangeDisplaySettings([In] ref DEVMODE lpDevMode, int dwFlags);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern bool EnumDisplaySettings(string lpszDeviceName, Int32 iModeNum, ref DEVMODE lpDevMode);
        void ChangeRes(int x = 0, int y = 0, int hz = 0)
        {

            DEVMODE DevM = new DEVMODE();
            DevM.dmSize = (short)Marshal.SizeOf(typeof(DEVMODE));
            bool mybool;
            mybool = EnumDisplaySettings(null, 0, ref DevM);
            DevM.dmPelsWidth = x;      //设置宽

            DevM.dmPelsHeight = y;       //设置高

            DevM.dmDisplayFrequency = hz;      //刷新频率

            DevM.dmBitsPerPel = 32;          //颜色象素

            long result = ChangeDisplaySettings(ref DevM, 0);
        }
        void FuYuan(int x = 0, int y = 0, int hz = 0)
        {
            DEVMODE DevM = new DEVMODE();
            DevM.dmSize = (short)Marshal.SizeOf(typeof(DEVMODE));
            bool mybool;
            mybool = EnumDisplaySettings(null, 0, ref DevM);
            DevM.dmPelsWidth = x;      //恢复宽
            DevM.dmPelsHeight = y;     //恢复高
            DevM.dmDisplayFrequency = hz;         //刷新频率
            DevM.dmBitsPerPel = 32;        //颜色象素
            long result = ChangeDisplaySettings(ref DevM, 0);
        }
        #endregion








        // 声明INI文件的写操作函数 WritePrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        // 声明INI文件的读操作函数 GetPrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, System.Text.StringBuilder retVal, int size, string filePath);


        /// 写入INI的方法
        public void INIWrite(string section, string key, string value, string path)
        {
            // section=配置节点名称，key=键名，value=返回键值，path=路径
            WritePrivateProfileString(section, key, value, path);
        }

        //读取INI的方法
        public string INIRead(string section, string key, string path)
        {
            // 每次从ini中读取多少字节
            System.Text.StringBuilder temp = new System.Text.StringBuilder(255);

            // section=配置节点名称，key=键名，temp=上面，path=路径
            GetPrivateProfileString(section, key, "", temp, 255, path);
            return temp.ToString();

        }

        //删除一个INI文件
        public void INIDelete(string FilePath)
        {
            File.Delete(FilePath);
        }








        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;



        /// 创建一个定时器

        [DllImport("user32.dll")]
        private static extern int SetTimer(int hWnd, int nIDEvent, int uElapse, Action lpTimerFunc);


        /// 销毁定时器


        [DllImport("user32.dll")]
        private static extern int KillTimer(int hWnd, int nIDEvent);


        /// 确定在调用函数时某个键是向上还是向下，以及在上一次调用GetAsyncKeyState之后是否按下了该键。

        [DllImport("user32.dll")]
        private static extern Int16 GetAsyncKeyState(int keyCode);

        /// 将消息信息传递给指定的窗口过程。 回调钩子

        [DllImport("user32.dll")]
        private static extern int CallWindowProcA(Action lpPrevWndFunc, int hWnd, int Msg, int wParam, int lParam);


        /// 关闭打开的对象句柄。

        [DllImport("kernel32.dll")]
        private static extern int CloseHandle(int hObject);


        /// 创建一个线程以在调用进程的虚拟地址空间内执行。

        [DllImport("kernel32.dll")]
        private static extern int CreateThread(int lpThreadAttributes, int dwStackSize, Action lpStartAddress, int lpParameter, int dwCreationFlags, int lpThreadId);



        /// <summary>
        /// 热键信息
        /// </summary>
        public class Hotkey
        {
            public int Id { get; set; }

            public Action Action { get; set; }

            public int KeyCode { get; set; }

            public int FunKeyCode { get; set; }

            public int OtherKeyCode { get; set; }

            public byte KeyState { get; set; }

            public bool State { get; set; }

            public bool DirectTrigger { get; set; }
        }
        private static List<Hotkey> hotkeyList = null; //记录注册的热键信息
        private static Action _HotkeyAction = null;  //监视热键线程

        /// <summary>
        /// 注册热键
        /// </summary>
        ///action">响应事件</param>
        /// keyCode">键代码</param>
        /// funKeyCode">功能键代码  1 Alt  2 Ctrl  4 Shift  8 Win 若要两个或以上的状态键,则把它们的值相加.</param>
        ///  otherKeyCode">如果需要注册由两个普通键组合的热键,可设置一个其它键代码.</param>
        /// millisecondsTimeout">默认为10,监视热键的周期时间(建议5-200之间)</param>
        ///  DirectTrigger">默认为false:创建新的线程事件 true:直接调用事件等待返回</param>
        int hwnd;
        public static int RegisterHotkey(Action action, int keyCode, int funKeyCode = 0, int otherKeyCode = 0, int millisecondsTimeout = 10, bool DirectTrigger = false)
        {
            Hotkey hotkey = new Hotkey();

            if (keyCode <= 0)
                return 0;
            if (hotkeyList == null)
                hotkeyList = new List<Hotkey>();

            for (int i = 0; i < hotkeyList.Count; i++)
            {
                if (hotkeyList[i].KeyCode == keyCode && hotkeyList[i].FunKeyCode == funKeyCode && hotkeyList[i].OtherKeyCode == otherKeyCode)
                {
                    hotkeyList[i].Action = action;
                    hotkeyList[i].DirectTrigger = DirectTrigger;

                    if (hotkeyList[i].Id != 0)
                    {
                        return hotkeyList[i].Id;
                    }

                    hotkeyList[i].Id = i + 1000000;
                    return hotkeyList[i].Id;
                }
            }

            hotkey.Action = action;
            hotkey.KeyCode = keyCode;
            hotkey.FunKeyCode = funKeyCode;
            hotkey.OtherKeyCode = otherKeyCode;
            hotkey.DirectTrigger = DirectTrigger;
            hotkey.Id = hotkeyList.Count + 1000001;
            hotkeyList.Add(hotkey);

            if (hotkey.Id == 1000001)
            {
                _HotkeyAction = MonitorHotkeyThreads;

                int time = millisecondsTimeout == 0 ? 10 : millisecondsTimeout;

                // 创建定时器
                SetTimer((int)User32API.GetCurrentWindowHandle(), 1, time, _HotkeyAction);

            }

            return hotkey.Id;
        }

        /// <summary>
        /// 监视注册热键的线程
        /// </summary>
        public static void MonitorHotkeyThreads()
        {
            Action tempAction = null;
            int tempId = 0;

            Int16[] cacheKeyState = new Int16[256];

            for (int i = 0; i < 255; i++)
            {
                cacheKeyState[i] = 251;
                cacheKeyState[i] = GetAsyncKeyState(i);
            }

            for (int i = 0; i < hotkeyList.Count; i++)
            {
                if (hotkeyList[i].Id != 0)
                {
                    int k = hotkeyList[i].KeyCode;
                    k = cacheKeyState[k];

                    if (k == 0)  //0表示无状态
                    {
                        if (hotkeyList[i].KeyState == 1)
                        {
                            hotkeyList[i].KeyState = 2;
                        }
                        else
                        {
                            hotkeyList[i].KeyState = 0;
                        }
                        continue;
                    }
                    if (k < 0)  //-32767,按下状态
                    {
                        if (hotkeyList[i].KeyState == 0)
                        {
                            hotkeyList[i].KeyState = 1;
                        }
                        if (hotkeyList[i].KeyCode < 0)
                        {
                            continue;
                        }
                    }

                    // 判断激活热键
                    if (hotkeyList[i].KeyState > 0 && hotkeyList[i].KeyState != 88)
                    {
                        hotkeyList[i].KeyState = 88;

                        int funNum = cacheKeyState[18] < 0 ? 1 : 0;
                        funNum += cacheKeyState[17] < 0 ? 2 : 0;
                        funNum += cacheKeyState[16] < 0 ? 4 : 0;
                        funNum += cacheKeyState[91] < 0 ? 8 : 0;

                        if (hotkeyList[i].FunKeyCode == funNum)
                        {
                            if (hotkeyList[i].OtherKeyCode != 0)
                            {
                                k = hotkeyList[i].OtherKeyCode;
                                if (cacheKeyState[k] >= 0)
                                {
                                    continue;
                                }
                            }

                            tempAction = hotkeyList[i].Action;
                            tempId = hotkeyList[i].Id;

                            if (hotkeyList[i].DirectTrigger)
                            {
                                CallWindowProcA(tempAction, tempId, 0, 0, 0);
                            }
                            else
                            {
                                CloseHandle(CreateThread(0, 0, tempAction, tempId, 0, 0));
                            }
                        }
                    }

                }
            }
        }




        /// <summary>
        /// 撤销监视热键
        /// </summary>
        /// 撤消的热键标识(注册时的返回值) ,如果留空则撤消全部热键</param>
        /// <returns></returns>
        public static bool UndoMonitorHotkey(int id)
        {
            if (hotkeyList != null && hotkeyList.Count > 0)
            {
                for (int i = 0; i < hotkeyList.Count; i++)
                {
                    if (id == 0)
                    {
                        hotkeyList[i].Id = 0;
                    }
                    else
                    {
                        if (id == hotkeyList[i].Id)
                        {
                            hotkeyList[i].Id = 0;
                            return true;
                        }
                    }
                }
            }
            return id == 0;
        }

        public static string getPageInfo(String url)
        {
            WebResponse wr_result = null;
            StringBuilder txthtml = new StringBuilder();
            try
            {
                WebRequest wr_req = WebRequest.Create(url);
                wr_result = wr_req.GetResponse();
                Stream ReceiveStream = wr_result.GetResponseStream();
                //Encoding encode = System.Text.Encoding.GetEncoding("gb2312");
                //Encoding encode = Encoding.Unicode;
                Encoding encode = Encoding.UTF8;
                StreamReader sr = new StreamReader(ReceiveStream, encode);
                if (true)
                {
                    Char[] read = new Char[256];
                    int count = sr.Read(read, 0, 256);
                    while (count > 0)
                    {
                        String str = new String(read, 0, count);
                        txthtml.Append(str);
                        count = sr.Read(read, 0, 256);
                    }
                }
            }
            catch (Exception)
            {
                txthtml.Append("err");
            }
            finally
            {
                if (wr_result != null)
                {
                    wr_result.Close();
                }
            }
            return txthtml.ToString();
        }


        Form form;

        private AntdUI.Window window;
        string inipath;
        int pmx, pmy, zpmx, zpmy;
        int ggx, ggy, ysx, ysy = 0;
        public Form1()
        {
            window = this;
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\XinXin\\");
            inipath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\XinXin\\4b3Config.ini";
            this.pmx = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.pmy = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;






            int id = RegisterHotkey(() => 开始修改分辨率(), 112);
            int id1 = RegisterHotkey(() => 恢复原始分辨率(), 113);






            float dpi = AntdUI.Config.Dpi;
            AntdUI.Config.SetDpi(dpi);
            AntdUI.Config.ShowInWindowByMessage = true;
            this.MouseDown += Form1_MouseDown; // 绑定鼠标按下事件

            InitializeComponent();
            读取配置项();
            Update();

        }

        string 当前版本 = "1.0";
        string 最新版本a;


        public bool Update()
        {

            最新版本a = getPageInfo("http://115.190.108.98/4b3/bb.txt");
            if (当前版本 != 最新版本a)
            {
                MessageBox.Show("检测到新版本，请前往官网下载最新版本");

                System.Diagnostics.Process.Start("explorer.exe", getPageInfo("http://115.190.108.98/4b3/xzdz.txt"));

                Environment.Exit(0);

            }

            AntdUI.Modal.open(new AntdUI.Modal.Config(window, "公告", getPageInfo("http://115.190.108.98/4b3/gg.txt"))
            {
                Icon = TType.Info,
                //内边距
                Padding = new Size(24, 20),

            });
            return true;

        }

        public void 开始修改分辨率()
        {


            ChangeRes((int)更改分辨率x.Value, (int)更改分辨率y.Value, (int)刷新率.Value);
            Thread.Sleep(1000);
            this.ggx = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.ggy = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            if (ggx == (int)更改分辨率x.Value && ggy == (int)更改分辨率y.Value)
            {
                AntdUI.Message.success(window, "修改成功", autoClose: 3);
                SoundHelper.PlayResourceSound(Properties.Resources.修改成功);
            }
            else
            {
                AntdUI.Message.success(window, "修改失败", autoClose: 3);
                SoundHelper.PlayResourceSound(Properties.Resources.修改失败);
            }

        }
        public void 恢复原始分辨率()
        {
            FuYuan((int)原始分辨率x.Value, (int)原始分辨率y.Value, (int)刷新率.Value);
            Thread.Sleep(1000);
            this.ysx = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.ysy = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            if (ysx == (int)原始分辨率x.Value && ysy == (int)原始分辨率y.Value)
            {
                AntdUI.Message.success(window, "恢复成功", autoClose: 3);
                SoundHelper.PlayResourceSound(Properties.Resources.恢复成功);
            }
            else
            {
                AntdUI.Message.success(window, "恢复失败", autoClose: 3);
                SoundHelper.PlayResourceSound(Properties.Resources.恢复失败);
            }
        }
        public void 读取配置项()
        {
            if (INIRead("Config", "ladMode", inipath) == "Light")
            {
                segmented1.SelectIndex = 0;
                浅色模式();
                segmented1.OriginalBackColor = SystemColors.ButtonHighlight; //分割栏背景切换暗色
                segmented1.BackColor = Color.FromArgb(191, 191, 191);
                Refresh(); //刷新界面

            }
            else if (INIRead("Config", "ladMode", inipath) == "Dark")
            {
                segmented1.SelectIndex = 1;
                深色模式();
                segmented1.OriginalBackColor = Color.FromArgb(52, 63, 86); //分割栏背景切换暗色
                segmented1.BackColor = Color.FromArgb(65, 79, 108);
                Refresh(); //刷新界面
            }



            if (INIRead("Config", "ysfblx", inipath) == "")
            {
                原始分辨率x.Value = pmx;

                INIWrite("Config", "ysfblx", pmx.ToString(), inipath);


            }
            else
            {
                原始分辨率x.Value = int.Parse(INIRead("Config", "ysfblx", inipath));
            }
            if (INIRead("Config", "ysfbly", inipath) == "")
            {
                原始分辨率y.Value = pmy;
                INIWrite("Config", "ysfbly", pmy.ToString(), inipath);
            }
            else
            {
                原始分辨率y.Value = int.Parse(INIRead("Config", "ysfbly", inipath));
            }

            if (INIRead("Config", "ggfblx", inipath) != "")
            {
                更改分辨率x.Value = int.Parse(INIRead("Config", "ggfblx", inipath));

            }
            if (INIRead("Config", "ggfbly", inipath) != "")
            {
                更改分辨率y.Value = int.Parse(INIRead("Config", "ggfbly", inipath));

            }
            if (INIRead("Config", "sxl", inipath) != "")
            {

                刷新率.Value = int.Parse(INIRead("Config", "sxl", inipath));

            }


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
                浅色模式();

            }
            else if (e.Value == 1)
            {

                深色模式();

            }
        }



        private void 浅色模式()
        {
            AntdUI.Config.IsLight = true; //antdui浅色模式
            label1.BackColor = SystemColors.ButtonHighlight;//左侧背景切换暗色
            avatar1.OriginalBackColor = SystemColors.ButtonHighlight;
            avatar2.OriginalBackColor = SystemColors.ButtonHighlight;//头像背景切换暗色
            menu1.BackColor = SystemColors.ButtonHighlight;//菜单栏背景切换暗色\
            segmented1.OriginalBackColor = SystemColors.ButtonHighlight; //分割栏背景切换暗色
            segmented1.BackColor = Color.FromArgb(191, 191, 191);
            //segmented1.Radius = 16;
            collapse1.BackColor = SystemColors.Control;
            tabs1.BackColor = SystemColors.Control;
            button1.OriginalBackColor = SystemColors.ButtonHighlight;
            Refresh(); //刷新界面




            AntdUI.Message.success(window, "切换成功", autoClose: 3);
            INIWrite("Config", "ladMode", "Light", inipath);



        }

        private void 深色模式()
        {
            AntdUI.Config.IsDark = true;//antdui深色模式
            label1.BackColor = Color.FromArgb(52, 63, 86);//左侧背景切换暗色
            avatar1.OriginalBackColor = Color.FromArgb(52, 63, 86);   //头像背景切换暗色
            avatar2.OriginalBackColor = Color.FromArgb(17, 26, 44);
            menu1.BackColor = Color.FromArgb(52, 63, 86);//菜单栏背景切换暗色\
            segmented1.OriginalBackColor = Color.FromArgb(52, 63, 86); //分割栏背景切换暗色
            segmented1.BackColor = Color.FromArgb(65, 79, 108);
            //segmented1.Radius = 16;

            collapse1.BackColor = Color.FromArgb(17, 26, 44);
            tabs1.BackColor = Color.FromArgb(17, 26, 44);
            button1.OriginalBackColor = Color.FromArgb(52, 63, 86);
            button1.BackColor = Color.FromArgb(65, 79, 108);
            Refresh(); //刷新界面
            AntdUI.Message.success(window, "切换成功", autoClose: 3);
            INIWrite("Config", "ladMode", "Dark", inipath);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AntdUI.Modal.open(new AntdUI.Modal.Config(window, "提示", "你确定要关闭吗?")
            {
                Icon = TType.Info,
                //内边距
                Padding = new Size(24, 20),
                OnOk = config =>
                {
                    //模拟耗时操作
                    Thread.Sleep(2000);
                    AntdUI.Message.info(window, config.OkText, autoClose: 1);
                    Environment.Exit(0);
                    return true;



                },
            });
            //
        }

        private void 更改分辨率x_ValueChanged(object sender, DecimalEventArgs e)
        {
            INIWrite("Config", "ggfblx", 更改分辨率x.Value.ToString(), inipath);
        }

        private void 更改分辨率y_ValueChanged(object sender, DecimalEventArgs e)
        {
            INIWrite("Config", "ggfbly", 更改分辨率y.Value.ToString(), inipath);
        }
        private void 刷新率_ValueChanged(object sender, DecimalEventArgs e)
        {
            INIWrite("Config", "sxl", 刷新率.Value.ToString(), inipath);
        }

        private void collapseItem1_Click(object sender, EventArgs e)
        {

        }
    }



}

