using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;


namespace DesktopDigitalClock
{
    public partial class Form1 : Form
    {
        // Digial elements sizes
        private static readonly int horizontalWidth = 40;
        private static readonly int horizontalHeight = 10;
        private static readonly int verticalWidth = 10;
        private static readonly int verticalHeight = 40;

        private static readonly Size SizeDigitalElementHorizontal = new Size(horizontalWidth, horizontalHeight);
        private static readonly Size SizeDigitalElementVertical = new Size(verticalWidth, verticalHeight);

        // Init digits
        int timerdigit1 = 0;
        int timerdigit2 = 0;
        int timerdigit3 = 0;
        int timerdigit4 = 0;
        int timerdigit5 = 0;
        int timerdigit6 = 0;

        string alarmTimeSet = string.Empty;

        static int R = 255;
        static int G = 0;
        static int B = 0;
        static Color ClockColor = Color.FromArgb(255, R, G, B);

        private static readonly bool[,] isOn =
        {
            { true,true,true,true,true,true,false },             //0
            { true,true,false,false,false,false,false },         //1
            { true,false,true,false,true,true,true },            //2
            { true,true,false,false,true,true,true },            //3
            { true,true,false,true,false,false,true },           //4
            { false,true,false,true,true,true,true },            //5
            { false,true,true,true,true,true,true },             //6
            { true,true,false,false,false,true,false },          //7
            { true,true,true,true,true,true,true },              //8
            { true,true,false,true,true,true,true}               //9
        };

        List<PictureBox> digt1 = Digit(0);
        List<PictureBox> digt2 = Digit(70);
        List<PictureBox> digt3 = Digit(170);
        List<PictureBox> digt4 = Digit(250);
        List<PictureBox> digt5 = Digit(350);
        List<PictureBox> digt6 = Digit(430);
        List<PictureBox> dots  = Dots(240);
        public Form1()
        {
            InitializeComponent();
            this.Width = 720;
            this.Height = 410;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BackGround();
            AddToDisplay(digt1);
            AddToDisplay(digt2);
            AddToDisplay(dots);
            AddToDisplay(digt3);
            AddToDisplay(digt4);
            AddToDisplay(digt5);
            AddToDisplay(digt6);
            ResetDigits();
            ColorRValue.Value = R;
            ColorGValue.Value = G;
            ColorBValue.Value = B;
            label1.Text = $"R = {R}";
            label2.Text = $"G = {G}";
            label3.Text = $"B = {B}";
            timer1.Start();
            groupBox1.Enabled = false;
        }

        private PictureBox BackGround()
        {
            PictureBox BackGround = new PictureBox();
            BackGround.BackColor = Color.Black;
            BackGround.BorderStyle = BorderStyle.None;
            BackGround.Size = new Size(600, 140);
            BackGround.Location = new Point(50, 50);

            this.Controls.Add(BackGround);
            BackGround.BringToFront();

            return BackGround;
        }

        private static PictureBox DigitalElements(int locationOffsetX, int locationOffsetY, Size size)
        {
            PictureBox line = new PictureBox();
            line.Size = size;
            Point location = new Point(610 - line.Size.Width - locationOffsetX, 50 + 10 + locationOffsetY);

            line.Location = location;
            line.BackColor = ClockColor;
            line.BorderStyle = BorderStyle.None;
            return line;
        }

        private static void SetDigtits(List<PictureBox> Pb, int value, bool[,] isON)
        {
            for (int i = 0; i < Pb.Count; i++)
            {
                if (!isON[value, i])
                {
                    Pb[i].BackColor = Color.Black;
                }
                else if (isON[value, i])
                {
                    Pb[i].BackColor = ClockColor;
                }
            }
        }

        private static List<PictureBox> Digit(int posX)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            pictureBoxes.Add(DigitalElements(15 + posX, 15, SizeDigitalElementVertical));                           //TopRight
            pictureBoxes.Add(DigitalElements(15 + posX, 25 + verticalHeight, SizeDigitalElementVertical));          //DownRigth
            pictureBoxes.Add(DigitalElements(65 + posX, 25 + verticalHeight, SizeDigitalElementVertical));          //DownLeft
            pictureBoxes.Add(DigitalElements(65 + posX, 15, SizeDigitalElementVertical));                           //TopLeft
            pictureBoxes.Add(DigitalElements(25 + posX, 25 + (2 * verticalHeight), SizeDigitalElementHorizontal));  //DownCenter        
            pictureBoxes.Add(DigitalElements(25 + posX, 5, SizeDigitalElementHorizontal));                          //TopCenter
            pictureBoxes.Add(DigitalElements(25 + posX, 15 + verticalHeight, SizeDigitalElementHorizontal));        //MiddleCenter
            return pictureBoxes;
        }

        private static List<PictureBox> Dots(int posX)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            PictureBox UpperDotR = new PictureBox();
            PictureBox LowerDotR = new PictureBox();
            PictureBox UpperDotL = new PictureBox();
            PictureBox LowerDotL = new PictureBox();
            Size dotSize = new Size(10, 10);
            pictureBoxes.Add(UpperDotR);
            pictureBoxes.Add(LowerDotR);
            pictureBoxes.Add(UpperDotL);
            pictureBoxes.Add(LowerDotL);
            pictureBoxes[0].Location = new Point(posX + 200, 105);
            pictureBoxes[1].Location = new Point(posX + 200, 125);
            pictureBoxes[2].Location = new Point(posX + 20, 105);
            pictureBoxes[3].Location = new Point(posX + 20, 125);

            foreach (PictureBox pb in pictureBoxes)
            {
                pb.BackColor = ClockColor;
                pb.Size = new Size(10, 10);
            }
            return pictureBoxes;
        }

        void AddToDisplay(List<PictureBox> pictureBoxes)
        {
            foreach (PictureBox pb in pictureBoxes)
            {
                this.Controls.Add(pb);
                pb.BringToFront();
            }
        }

        void ResetDigits()
        {
            SetDigtits(digt1, 0, isOn);
            SetDigtits(digt2, 0, isOn);
            SetDigtits(digt3, 0, isOn);
            SetDigtits(digt4, 0, isOn);
            SetDigtits(digt5, 0, isOn);
            SetDigtits(digt6, 0, isOn);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox pb in dots)
            {
                pb.BackColor = ClockColor;
            }

            if (RadUhrzeit.Checked)
            {
                ResetDigits();
                DateTime dateTime = DateTime.Now;
                string timeString = dateTime.ToString("HH:mm:ss");
                timerdigit1 = int.Parse(timeString[7].ToString());
                timerdigit2 = int.Parse(timeString[6].ToString());
                timerdigit3 = int.Parse(timeString[4].ToString());
                timerdigit4 = int.Parse(timeString[3].ToString());
                timerdigit5 = int.Parse(timeString[1].ToString());
                timerdigit6 = int.Parse(timeString[0].ToString());

                if (timeString == alarmTimeSet)
                {
                    MessageBox.Show("Alarm time!!!");
                    ChkBAlarm.Checked = false;
                    UDHours.Value = 0;
                    UDMin.Value = 0;
                    UDSec.Value = 0;
                }
            }
            if (RadStopUhr.Checked)
            {
                ResetDigits();
                timerdigit1++;
                if (timerdigit1 > 9)
                {
                    timerdigit1 = 0;
                    timerdigit2++;
                }
                if (timerdigit2 > 5)
                {
                    timerdigit2 = 0;
                    timerdigit3++;
                }
                if (timerdigit3 > 9)
                {
                    timerdigit3 = 0;
                    timerdigit4++;
                }
                if (timerdigit4 > 6)
                {
                    timerdigit4 = 0;
                    timerdigit5++;
                }
                if (timerdigit5 > 9 && timerdigit6 < 2)
                {
                    timerdigit5 = 0;
                    timerdigit6++;
                }
                if (timerdigit3 > 4 && timerdigit4 > 1)
                {
                    timerdigit5 = 0;
                    timerdigit6 = 0;
                }
            }
            SetDigtits(digt1, timerdigit1, isOn);
            SetDigtits(digt2, timerdigit2, isOn);
            SetDigtits(digt3, timerdigit3, isOn);
            SetDigtits(digt4, timerdigit4, isOn);
            SetDigtits(digt5, timerdigit5, isOn);
            SetDigtits(digt6, timerdigit6, isOn);
        }
        private void ColorRValue_Scroll(object sender, EventArgs e)
        {
            R = ColorRValue.Value;
            label1.Text = $"R = {ColorRValue.Value}";
            ClockColor = Color.FromArgb(255, R, G, B);
        }

        private void ColorGValue_Scroll(object sender, EventArgs e)
        {
            G = ColorGValue.Value;
            label2.Text = $"G = {ColorGValue.Value}";
            ClockColor = Color.FromArgb(255, R, G, B);
        }

        private void ColorBValue_Scroll(object sender, EventArgs e)
        {
            B = ColorBValue.Value;
            label3.Text = $"B = {ColorBValue.Value}";
            ClockColor = Color.FromArgb(255, R, G, B);
        }

        private void BtnStart_Click(object sender, EventArgs e) => timer1.Start();  
        private void BtnStop_Click(object sender, EventArgs e) => timer1.Stop(); 
        private void BtnResetStop_Click(object sender, EventArgs e)
        {
            SetDigitsToZero();
            timer1.Stop();
        }

        private void RadStopUhr_CheckedChanged(object sender, EventArgs e)
        {
            SetDigitsToZero();
            timer1.Stop();
            if (!RadStopUhr.Checked) groupBox1.Enabled = false;
            else groupBox1.Enabled = true;
        }

        private void SetDigitsToZero()
        {
            timerdigit1 = 0;
            timerdigit2 = 0;
            timerdigit3 = 0;
            timerdigit4 = 0;
            timerdigit5 = 0;
            timerdigit6 = 0;
            ResetDigits();
        }

        private void RadUhrzeit_CheckedChanged(object sender, EventArgs e)
        {
            SetDigitsToZero();
            timer1.Start();
        }
        private void ChkBAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBAlarm.Checked == true && UDHours.Value == 0 && UDMin.Value == 0 && UDSec.Value == 0 )
            {
                MessageBox.Show(" No time set");
                ChkBAlarm.Checked = false;
            }
            else if (ChkBAlarm.Checked == true && (UDHours.Value != 0 || UDMin.Value != 0 || UDSec.Value != 0))
            {               
                string h = $"{((int)UDHours.Value)}";
                if (h.Length < 2) h = "0" + h; 
                string m = $"{((int)UDMin.Value)}";
                if (m.Length < 2) m = "0" + m;
                string s = $"{((int)UDSec.Value)}";
                if (s.Length < 2) s = "0" + s;

                alarmTimeSet = $"{h}:{m}:{s}";
                label7.Text = "Alarm time set: " + alarmTimeSet;
            }
        }
    }
}