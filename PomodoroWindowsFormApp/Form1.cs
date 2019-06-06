using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PomodoroWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SoundPlayer SPNotification = new SoundPlayer(@"C:\Users\MyAsus\Documents\GitHub\PomodoroWindowsFormApp\PomodoroWindowsFormApp\Sound\NotiSound.wav");
        void BtnColorReset()
        {
            BtnLongBreak.BackColor = Color.Transparent;
            BtnBreak.BackColor = Color.Transparent;
            BtnPomodoro.BackColor = Color.Transparent;
            BtnStop.BackColor = Color.Transparent;
            BtnStart.BackColor = Color.Transparent;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
         

            LblMessage.Visible = false;
            BtnStart.Visible = false;
            timer1.Interval = 1000;
            LblMinute.Text = "00";
            LblSecond.Text = "00";
            BtnColorReset();
            

        }

        private void BtnPomodoro_Click(object sender, EventArgs e)
        {
            LblMessage.Text = "0";
            LblMinute.Text = "24";
           LblSecond.Text = "59";
            Second = 60;
        
            timer1.Start();
            BtnColorReset();
            BtnPomodoro.BackColor = Color.LightSeaGreen;
            LblTimeIsOver.Visible = false;
        }

        private void BtnBreak_Click(object sender, EventArgs e)
        {
            LblMessage.Text = "1";
            LblMinute.Text = "4";
            LblSecond.Text = "59";
            Second = 60;
            BtnColorReset();
            BtnBreak.BackColor = Color.LightSeaGreen;
            timer1.Start();
            LblTimeIsOver.Visible = false;
        }

        private void BtnLongBreak_Click(object sender, EventArgs e)
        {
            LblMessage.Text = "2";
            LblMinute.Text = "14";
         //  LblSecond.Text = "59";
            BtnColorReset();
            BtnLongBreak.BackColor = Color.LightSeaGreen;
            Second = 60;
            timer1.Start();
            LblTimeIsOver.Visible = false;
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
      
            timer1.Stop();
            BtnColorReset();

            BtnStop.Visible = false;
            BtnStart.Visible = true;
            BtnStart.BackColor = Color.LightSeaGreen;
     
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int message = Convert.ToInt32(LblMessage.Text);
            BtnStop.Visible = true;
            BtnStop.BackColor = Color.LightSeaGreen;
            BtnStart.Visible = false;
            BtnColorReset();
     
            timer1.Start();
            if (message==0)
            {
                BtnPomodoro.BackColor = Color.LightSeaGreen;
            }
            else if (message == 1)
            {
                BtnBreak.BackColor = Color.LightSeaGreen;
            }
            else if (message == 2)
            {
                BtnLongBreak.BackColor = Color.LightSeaGreen;
            }
        }

        int PomodoroMinute = 24; int Second = 60; int BreakMinute = 4; int LongbreakMinute = 14;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Message 0 = PomodoroTime,Message 1 = BreakTime,Message 2 = BreakTime
            int message = Convert.ToInt32(LblMessage.Text); //Timer Tipi için


            if (Second == 0)
            {
                Second = 59;
                if (message == 0)
                {
                    PomodoroMinute--;
                    LblMinute.Text = PomodoroMinute.ToString();
                    LblTimeIsOver.Text = "Pomodoro Time Is Over...";
                }
                else if (message == 1)
                {
                    BreakMinute--;
                    LblMinute.Text = BreakMinute.ToString();
                    LblTimeIsOver.Text = "Break Time Is Over...";
                }
                else if (message == 2)
                {
                    LongbreakMinute--;
                    LblMinute.Text = LongbreakMinute.ToString();
                    LblTimeIsOver.Text = "Long Break Time Is Over...";
                }

                LblSecond.Text = Second.ToString();
            }
            else
            {
                Second--;
                LblSecond.Text = Second.ToString();
            }
            if (Second == 0)
            {
                if (PomodoroMinute == 0 || BreakMinute == 0 || LongbreakMinute == 0)
                {
                    timer1.Stop();
                    LblMinute.Text = "00";
                    LblSecond.Text = "00";
                    SPNotification.Play();
                    LblTimeIsOver.Visible = true;
                    PomodoroMinute = 24;
                    BreakMinute = 5;
                    LongbreakMinute = 15;
                   
                }


            }


        }

    }
}
