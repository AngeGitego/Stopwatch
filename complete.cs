using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Stopwatch
{
    /// <summary>
    /// Represents the main form for the Stopwatch application.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Tracks the hours elapsed.
        /// </summary>
        private int hours = 0;

        /// <summary>
        /// Tracks the minutes elapsed.
        /// </summary>
        private int minutes = 0;

        /// <summary>
        /// Tracks the seconds elapsed.
        /// </summary>
        private int seconds = 0;

        /// <summary>
        /// Indicates whether the stopwatch is paused.
        /// </summary>
        private bool isPaused = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates the time display every second if the stopwatch is not paused.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the btnStart control.
        /// Starts the stopwatch and ensures it is not paused.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            isPaused = false;  // Ensure it's not paused
        }

        /// <summary>
        /// Handles the Click event of the btnPause control.
        /// Pauses the stopwatch.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void btnPause_Click(object sender, EventArgs e)
        {
            isPaused = true;  // Pause the timer
        }

        /// <summary>
        /// Handles the Click event of the btnResume control.
        /// Resumes the stopwatch from the last paused state.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void btnResume_Click(object sender, EventArgs e)
        {
            isPaused = false;  // Resume the timer
        }

        /// <summary>
        /// Handles the Click event of the btnReset control.
        /// Stops and resets the stopwatch to 00:00:00.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();     // Stop the timer
            isPaused = false;  // Unpause if paused
            hours = 0;
            minutes = 0;
            seconds = 0;
            label1.Text = "00:00:00";  // Reset label1 to 00:00:00
        }

        /// <summary>
        /// Handles the Click event of the btnStop control.
        /// Stops the stopwatch completely, keeping the last recorded time displayed.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();  // Stop the timer
        }
    }
}
