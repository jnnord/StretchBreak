using System;
using System.Windows.Forms;

namespace StretchBreak.Pages
{
    public partial class Settings : Form
    {
        public void GetSettings()
        {
            txt_minuts.Text = StretchBreak.Default.timeToBreak.ToString();
            txt_seconds.Text = StretchBreak.Default.breakTime.ToString();
            if (txt_minuts.Text == "")
            {
                txt_minuts.Text = "0";
            }
            if(txt_seconds.Text == "")
            {
                txt_seconds.Text = "0";
            }
        }

        public void SetSettings()
        {
            StretchBreak.Default.timeToBreak = txt_minuts.Text;
            StretchBreak.Default.breakTime = txt_seconds.Text;
        }
        public Settings()
        {
            InitializeComponent();
            GetSettings();
        }

        private void btn_Save(object sender, EventArgs e)
        {
            SetSettings();
            StretchBreak.Default.Save();
            this.Close();
        }

        private void btn_Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
