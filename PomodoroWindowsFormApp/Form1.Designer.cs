namespace PomodoroWindowsFormApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnPomodoro = new System.Windows.Forms.Button();
            this.LblMinute = new System.Windows.Forms.Label();
            this.LblSecond = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnBreak = new System.Windows.Forms.Button();
            this.BtnLongBreak = new System.Windows.Forms.Button();
            this.LblMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblTimeIsOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPomodoro
            // 
            this.BtnPomodoro.BackColor = System.Drawing.Color.Transparent;
            this.BtnPomodoro.Location = new System.Drawing.Point(22, 378);
            this.BtnPomodoro.Name = "BtnPomodoro";
            this.BtnPomodoro.Size = new System.Drawing.Size(151, 31);
            this.BtnPomodoro.TabIndex = 0;
            this.BtnPomodoro.Text = "Pomodoro";
            this.BtnPomodoro.UseVisualStyleBackColor = false;
            this.BtnPomodoro.Click += new System.EventHandler(this.BtnPomodoro_Click);
            // 
            // LblMinute
            // 
            this.LblMinute.AutoSize = true;
            this.LblMinute.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMinute.Location = new System.Drawing.Point(189, 280);
            this.LblMinute.Name = "LblMinute";
            this.LblMinute.Size = new System.Drawing.Size(64, 46);
            this.LblMinute.TabIndex = 1;
            this.LblMinute.Text = "00";
            // 
            // LblSecond
            // 
            this.LblSecond.AutoSize = true;
            this.LblSecond.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSecond.Location = new System.Drawing.Point(263, 280);
            this.LblSecond.Name = "LblSecond";
            this.LblSecond.Size = new System.Drawing.Size(64, 46);
            this.LblSecond.TabIndex = 2;
            this.LblSecond.Text = "00";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTime.Location = new System.Drawing.Point(36, 280);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(141, 46);
            this.LblTime.TabIndex = 3;
            this.LblTime.Text = "Time : ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(188, 378);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(151, 31);
            this.BtnStop.TabIndex = 4;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnBreak
            // 
            this.BtnBreak.Location = new System.Drawing.Point(22, 435);
            this.BtnBreak.Name = "BtnBreak";
            this.BtnBreak.Size = new System.Drawing.Size(151, 31);
            this.BtnBreak.TabIndex = 5;
            this.BtnBreak.Text = "Break";
            this.BtnBreak.UseVisualStyleBackColor = true;
            this.BtnBreak.Click += new System.EventHandler(this.BtnBreak_Click);
            // 
            // BtnLongBreak
            // 
            this.BtnLongBreak.Location = new System.Drawing.Point(188, 435);
            this.BtnLongBreak.Name = "BtnLongBreak";
            this.BtnLongBreak.Size = new System.Drawing.Size(151, 31);
            this.BtnLongBreak.TabIndex = 6;
            this.BtnLongBreak.Text = "Long Break";
            this.BtnLongBreak.UseVisualStyleBackColor = true;
            this.BtnLongBreak.Click += new System.EventHandler(this.BtnLongBreak_Click);
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Location = new System.Drawing.Point(12, 9);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(31, 13);
            this.LblMessage.TabIndex = 7;
            this.LblMessage.Text = "Type";
            this.LblMessage.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::PomodoroWindowsFormApp.Properties.Resources.tomatotimer;
            this.pictureBox1.Location = new System.Drawing.Point(22, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(188, 378);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(151, 31);
            this.BtnStart.TabIndex = 9;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblTimeIsOver
            // 
            this.LblTimeIsOver.AutoSize = true;
            this.LblTimeIsOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTimeIsOver.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblTimeIsOver.Location = new System.Drawing.Point(44, 339);
            this.LblTimeIsOver.Name = "LblTimeIsOver";
            this.LblTimeIsOver.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.LblTimeIsOver.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblTimeIsOver.Size = new System.Drawing.Size(100, 25);
            this.LblTimeIsOver.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 487);
            this.Controls.Add(this.LblTimeIsOver);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.BtnLongBreak);
            this.Controls.Add(this.BtnBreak);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.LblSecond);
            this.Controls.Add(this.LblMinute);
            this.Controls.Add(this.BtnPomodoro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pomodoro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPomodoro;
        private System.Windows.Forms.Label LblMinute;
        private System.Windows.Forms.Label LblSecond;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnBreak;
        private System.Windows.Forms.Button BtnLongBreak;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblTimeIsOver;
    }
}

