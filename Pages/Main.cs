
using Microsoft.WindowsAPICodePack.Taskbar;
using StretchBreak.Pages;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace StretchBreak
{
    public partial class Main : Form
    {
        Timer t = new Timer();
        DateTime currentTime;
        DateTime x30MinsLater;
        string TimeToBreak = "0";
        TaskbarManager tbManager = TaskbarManager.Instance;
        int countSeconds = 0;
        int secondsLeft = 0;


        public void GetSettings()
        {
            TimeToBreak = StretchBreak.Default.timeToBreak.ToString();
            if (TimeToBreak == "")
            {
                TimeToBreak = "0";
            }
        }


        public Main()
        {
            InitializeComponent();
            GetSettings();
            lbl_time.BackColor = Color.Transparent;
            lbl_nextText.BackColor = Color.Transparent;
            lbl_nextTime.BackColor = Color.Transparent;
            lbl_versions.BackColor = Color.Transparent;
        }


        private void btn_Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Settings(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //timer interval
            t.Interval = 1000;  //in milliseconds
            t.Tick += new EventHandler(this.t_Tick);

            //start timer when form loads
            t.Start(); 
            lbl_time.Text = DateTime.Now.ToString("T");
            currentTime = DateTime.Now;
            int intValue = Int32.Parse(TimeToBreak);
            x30MinsLater = currentTime.AddMinutes(intValue);
            lbl_nextTime.Text = x30MinsLater.ToString("T") ;
            this.ShowInTaskbar = true;
            tbManager.SetProgressState(TaskbarProgressBarState.Normal);
            tbManager.SetProgressValue(0, intValue);

            //lbl_versions.Text = Application.ProductVersion;

        }

        //timer eventhandler
        private void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            if(x30MinsLater.ToString("T") == time)
            {
                Practice picture = new Practice();
                picture.Show();
                FlashWindows.FlashWindowEx(this);
                currentTime = DateTime.Now;
                int intValue = Convert.ToInt32(TimeToBreak);
                x30MinsLater = currentTime.AddMinutes(intValue);
                lbl_nextTime.Text = x30MinsLater.ToString("T");
                countSeconds = 0;
                secondsLeft = Int32.Parse(TimeToBreak) * 60;
                tbManager.SetProgressValue(countSeconds, secondsLeft);
            }

            //update label
            lbl_time.Text = time;
            countSeconds++;
            secondsLeft = Int32.Parse(TimeToBreak) * 60;
            tbManager.SetProgressValue(countSeconds, secondsLeft);
        }

    }
}
