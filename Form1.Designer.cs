namespace Stopwatch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            button5 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Gill Sans Ultra Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(96, 120);
            button1.Name = "button1";
            button1.Size = new Size(140, 48);
            button1.TabIndex = 0;
            button1.Text = "PAUSE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnPause_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.Font = new Font("Gill Sans Ultra Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(496, 120);
            button2.Name = "button2";
            button2.Size = new Size(112, 42);
            button2.TabIndex = 1;
            button2.Text = "STOP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnStop_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSpringGreen;
            button3.Font = new Font("Gill Sans Ultra Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(96, 257);
            button3.Name = "button3";
            button3.Size = new Size(140, 46);
            button3.TabIndex = 2;
            button3.Text = "RESUME";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnResume_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Magenta;
            button4.Font = new Font("Gill Sans Ultra Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(496, 257);
            button4.Name = "button4";
            button4.Size = new Size(112, 46);
            button4.TabIndex = 3;
            button4.Text = "RESET";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnReset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 23);
            label1.Name = "label1";
            label1.Size = new Size(177, 44);
            label1.TabIndex = 4;
            label1.Text = "00:00:00";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Font = new Font("Gill Sans Ultra Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(294, 174);
            button5.Name = "button5";
            button5.Size = new Size(153, 68);
            button5.TabIndex = 5;
            button5.Text = "START";
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnStart_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button5;
        private System.Windows.Forms.Timer timer1;
    }
}
