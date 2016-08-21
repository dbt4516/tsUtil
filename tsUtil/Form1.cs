using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TsUtil {
    public partial class Form1 : Form {


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool AddClipboardFormatListener(IntPtr hwnd);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool RemoveClipboardFormatListener(IntPtr hwnd);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);


        private static int WM_CLIPBOARDUPDATE = 0x031D;
        private static int ns;



        public Form1() {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None; 


            CheckForIllegalCrossThreadCalls = false;
            AddClipboardFormatListener(this.Handle);
            //RegisterHotKey(this.Handle, this.GetType().GetHashCode(), 0x0008, (int)'T');
            hide();

        }

        public static DateTime unixTimeStampToDateTime(double unixTimeStamp) {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static long getDateTime(String time) {
            var now = DateTime.Now;
            int y = now.Year, M = now.Month, d = now.Day, h = now.Hour, m = now.Minute;
            int s = 0;
            if (time.Contains(".")) {
                var ss = time.Substring(time.LastIndexOf(".") + 1);
                time = time.Substring(0, time.LastIndexOf("."));
                if (ss.Length == 1) {
                    ss += "0";
                }
                s = int.Parse(ss);
            }
            if (time.Length >= 2) {
                var t = time.Substring(time.Length - 2, 2);
                m = int.Parse(t);
            }
            if (time.Length >= 4) {
                var t = time.Substring(time.Length - 4, 2);
                h = int.Parse(t);
            }
            if (time.Length >= 6) {
                var t = time.Substring(time.Length - 6, 2);
                d = int.Parse(t);
            }
            if (time.Length >= 8) {
                var t = time.Substring(time.Length - 8, 2);
                M = int.Parse(t);
            }
            if (time.Length >= 12) {
                var t = time.Substring(time.Length - 12, 4);
                y = int.Parse(t);
            }

            //Time zone convertion is confusing. Always need to add a time zone offset despite the DateTimeKind setting.
            var dt = new DateTime(y, M, d, h, m, s, 0, System.DateTimeKind.Local);
            var tz = TimeZone.CurrentTimeZone.GetUtcOffset(dt); 
            var start = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).AddHours(tz.Hours);
            
            return (dt.Ticks - start.Ticks) / 1000 / 1000 / 10;
        }

        protected override void DefWndProc(ref Message m) {
            if (m.Msg == WM_CLIPBOARDUPDATE) {
                var text = Clipboard.GetText().Trim();
                if (text.Length == 13) {
                    text = text.Substring(0, 10);
                }
                try {
                    if (text.Length == 10 ) {
                        var time = unixTimeStampToDateTime(double.Parse(text));
                        var s = time.ToString("yyyy-MM-dd HH:mm:ss");
                        var now = DateTime.Now;
                        if (time.Year >= now.Year - 10 && time.Year <= now.Year + 10) {
                            tb.Text = s;
                            var p=System.Windows.Forms.Cursor.Position;
                            show();
                            hide();
                        }
                    }
                } catch (Exception e) {

                }
            } else {
                base.DefWndProc(ref m);
            }
        }

        public void hide() {
            System.Threading.Timer timer = null;
            int nsI=DateTime.Now.Second;
            Form1.ns = nsI;
            timer = new System.Threading.Timer((obj) => {
                if (nsI == Form1.ns) { 
                slideRight();
                }
                timer.Dispose();
            },null, 3000, System.Threading.Timeout.Infinite);
        }

        public void show() {
            var p = System.Windows.Forms.Cursor.Position;
            var res = Screen.PrimaryScreen.Bounds;
            var nX = p.X - 50 > (res.Width - 120) ? res.Width - 120 : p.X - 50;
            nX = nX < 10 ? 10 : nX;
            var nY = (p.Y - 50) < 10 ? 10 : p.Y-50;
            //Console.WriteLine(nX + " " + nY);
            Location = new Point(nX, nY);
            
        }

        public void slideRight() {
            if (tb.Focused)
                return; 
            Location = new Point(0, -27);
        }

        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
            //if (m.Msg == 0x0312)
            //    MessageBox.Show("Hotkey pressed");
        }

       


        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void tb_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(tb.Text)) {
                tb.SelectAll();
            }
        }

        private void enterKeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                try {
                    var ts = getDateTime(tb.Text).ToString().Trim();
                    if (ts.Length == 10) {
                        Clipboard.SetText(ts);
                    }
                } catch (Exception exc) {

                }

            }
        }

        private void enterForm(object sender, EventArgs e) {
            tb.Text = "entered";
        }

        private void clickTray(object sender, MouseEventArgs e) {
            if (Location.Y == -27) { 
            show();
            Activate();
            tb.Focus();
            } else {
                slideRight();
            }
        }

        private void lostFocus(object sender, EventArgs e) { 
            //hide();
        }

        private void exit(object sender, EventArgs e) {
            RemoveClipboardFormatListener(this.Handle);
            Application.Exit();
        }

        private void poweredByQOSSToolStripMenuItem_Click(object sender, EventArgs e) {

        }
 
        
       
    }
}
