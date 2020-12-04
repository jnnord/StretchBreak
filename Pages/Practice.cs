using System;
using System.Windows.Forms;

namespace StretchBreak.Pages
{

    public partial class Practice : Form
    {
        private delegate void CloseFormCallback();
        private Timer tmr = new Timer();
        int counter = 1000;
        string intValue = StretchBreak.Default.breakTime.ToString();
        int timeLeft = 0;

        public Practice()
        {
            InitializeComponent();

            tmr.Interval = counter;
            tmr.Enabled = true;
            tmr.Start();
            tmr.Tick += t_Tick;
            timeLeft = Int32.Parse(intValue);
            TimeSpan time = TimeSpan.FromSeconds(timeLeft);
            lblCountDown.Text = time.ToString(@"hh\:mm\:ss");
            Focus();
            FlashWindows.FlashWindowEx(this);
        }

        private void Practice_Load(object sender, EventArgs e)
        {
            BringToFront();
            Activate();
        }

        private void t_Tick(object sender, EventArgs e)
        {            
            timeLeft--;
            if (timeLeft == 0)
            {
                tmr.Stop();
                CloseForm();
            }
            TimeSpan time = TimeSpan.FromSeconds(timeLeft);
            lblCountDown.Text = time.ToString(@"hh\:mm\:ss");
        }

        private void CloseForm()
        {
            if (InvokeRequired)
            {
                var d = new CloseFormCallback(CloseForm);
                Invoke(d, default);
            }
            else
            {
                Close();
            }
        }
    }
}
