using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblMessage.Visible = false;
            timer1.Interval = 500;
            LblMinute.Text = "25";
            LblSecond.Text = "00";

        }

        private void BtnPomodoro_Click(object sender, EventArgs e)
        {
            LblMessage.Text = "0";
            LblMinute.Text = "24";
            LblSecond.Text = "59";
            Second = 60;
            timer1.Start();
        }

        private void BtnBreak_Click(object sender, EventArgs e)
        {
            LblMessage.Text = "1";
            LblMinute.Text = "4";
            LblSecond.Text = "59";
            Second = 60;
            timer1.Start();
        }

        private void BtnLongBreak_Click(object sender, EventArgs e)
        {
            LblMessage.Text = "2";
            LblMinute.Text = "14";
            LblSecond.Text = "59";

            Second = 60;
            timer1.Start();
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
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
                }
                else if (message == 1)
                {
                    BreakMinute--;
                    LblMinute.Text = BreakMinute.ToString();
                }
                else if (message == 2)
                {
                    LongbreakMinute--;
                    LblMinute.Text = LongbreakMinute.ToString();
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

                    MessageBox.Show("Süre Doldu");
                }


            }


        }

    }
}
