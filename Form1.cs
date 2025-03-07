
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        private int hours = 0;
        private int minutes = 0;
        private int seconds = 0;
        private bool isPaused = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Timer Tick Event to update time every second
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                seconds++;
                if (seconds >= 60)
                {
                    seconds = 0;
                    minutes++;
                }
                if (minutes >= 60)
                {
                    minutes = 0;
                    hours++;
                }
                label1.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            }
        }

        // Start Button Click Event
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            isPaused = false;  // Ensure it's not paused
        }

        // Pause Button Click Event
        private void btnPause_Click(object sender, EventArgs e)
        {
            isPaused = true;  // Pause the timer
        }

        // Resume Button Click Event
        private void btnResume_Click(object sender, EventArgs e)
        {
            isPaused = false;  // Resume the timer
        }

        // Reset Button Click Event
        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();     // Stop the timer
            isPaused = false;  // Unpause if paused
            hours = 0;
            minutes = 0;
            seconds = 0;
            label1.Text = "00:00:00";  // Reset label1 to 00:00:00
        }

        // Stop Button Click Event
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();  // Stop the timer
        }
    }
}
