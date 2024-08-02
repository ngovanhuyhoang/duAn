using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA1_formLogin
{
    public partial class CountDown : Form
    {
        private System.Windows.Forms.Timer countdownTimer; // Explicitly use System.Windows.Forms.Timer
        private int remainingTime;
        public bool IsConfirmed { get; private set; }
        public CountDown()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            remainingTime = 5; // 60 seconds
            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000; // 1 second intervals
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();
            UpdateTimerLabel();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            UpdateTimerLabel();

            if (remainingTime <= 0)
            {
                countdownTimer.Stop();
                MessageBox.Show("Thời gian thanh toán đã hết. Vui lòng ấn thanh toán lại.");
                this.Close();
            }
        }

        private void UpdateTimerLabel()
        {
            lbl_Timer.Text = $" {remainingTime} s";
        }

        private void CountDown_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsConfirmed = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsConfirmed = false;
            this.Close();
        }
    }
}
