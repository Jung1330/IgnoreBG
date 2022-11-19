using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace IgnoreBG
{
    /* Eğer Şifreyi Değiştirmek istiyosan Form1 deki Mavi yazılı Şeyi değiştir(PasswordCheck.Text) */
    public partial class Form1 : Form
    {

        #region Transparant+Blurlu Arkaplan
        [DllImport("gdi32")]
        private static extern IntPtr CreateEllipticRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);
        [DllImport("dwmapi")]
        private static extern int DwmEnableBlurBehindWindow(IntPtr hWnd, ref DwmBlurbehind pBlurBehind);
        public struct DwmBlurbehind
        {
            public int DwFlags;
            public bool FEnable;
            public IntPtr HRgnBlur;
            public bool FTransitionOnMaximized;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.DimGray), new Rectangle(0, 0, Width, Height));
        }
#endregion

        #region ALT+F4 engeli
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }

            base.OnFormClosing(e);
        }
        #endregion

        #region Çağırımlar
        public int Hiding = 0;

        string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
        string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        #region Her şey Burda
        private void button1_Click(object sender, EventArgs e)
        {


            if (PasswordCheck.Text == PasswordTextbox.Text)
            {
                TestLabel.Text = "Başarılı";
                Hiding = 0;
                SuccessTimer.Start();
                Success.Visible = true;
                WrongTimer.Stop();
                Hideme.Visible = false;
                Tray.Start();
            }
            else if (PasswordCheck.Text != PasswordTextbox.Text)
            {
                TestLabel.Text = "Hatalı";
                WrongTimer.Start();
                Hiding = 1;
                Ignore.Visible = true;
            }


        }

        #endregion

        #region Hata Kısımları

        private void SuccessTimer_Tick(object sender, EventArgs e)
        {     
            this.WindowState = FormWindowState.Minimized;
            Console.WriteLine("Hala Çalşıom Succress");
        }
        private void WrongTimer_Tick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Console.WriteLine("Hala Çalşıom Wrong");
        }

        #endregion

        #region Form1 Load/Resize/KeyPress
        private void Form1_Resize(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                Hideme.Visible = true;
            }
            else
            {
                Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var hr = CreateEllipticRgn(0, 0, Width, Height);
            var dbb = new DwmBlurbehind { FEnable = true, DwFlags = 1, HRgnBlur = hr, FTransitionOnMaximized = false };
            DwmEnableBlurBehindWindow(Handle, ref dbb);


            panel1.Location = new Point( this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                panel1.Visible = true;
            }
        }

        #endregion

        #region Tray
        private void Hideme_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Success.Visible = false;
            Ignore.Visible = false;
            SuccessTimer.Stop();
            WrongTimer.Stop();
            PasswordTextbox.Text = "";
            Tray.Stop();
            this.Show();
            this.WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region Location
        private void Protector_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        #endregion

    }
}
