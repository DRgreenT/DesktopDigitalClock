using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopDigitalClock
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
            timer1 = new System.Windows.Forms.Timer(components);
            ColorRValue = new TrackBar();
            ColorGValue = new TrackBar();
            ColorBValue = new TrackBar();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            BtnResetStop = new Button();
            BtnStart = new Button();
            BtnStop = new Button();
            RadUhrzeit = new RadioButton();
            RadStopUhr = new RadioButton();
            groupBox1 = new GroupBox();
            ChkBAlarm = new CheckBox();
            UDHours = new NumericUpDown();
            UDMin = new NumericUpDown();
            UDSec = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)ColorRValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorGValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorBValue).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UDHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UDMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UDSec).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // ColorRValue
            // 
            ColorRValue.Location = new Point(50, 245);
            ColorRValue.Maximum = 255;
            ColorRValue.Name = "ColorRValue";
            ColorRValue.Size = new Size(400, 45);
            ColorRValue.TabIndex = 1;
            ColorRValue.Scroll += ColorRValue_Scroll;
            // 
            // ColorGValue
            // 
            ColorGValue.Location = new Point(50, 270);
            ColorGValue.Maximum = 255;
            ColorGValue.Name = "ColorGValue";
            ColorGValue.Size = new Size(400, 45);
            ColorGValue.TabIndex = 1;
            ColorGValue.Scroll += ColorGValue_Scroll;
            // 
            // ColorBValue
            // 
            ColorBValue.Location = new Point(50, 296);
            ColorBValue.Maximum = 255;
            ColorBValue.Name = "ColorBValue";
            ColorBValue.Size = new Size(400, 45);
            ColorBValue.TabIndex = 1;
            ColorBValue.Scroll += ColorBValue_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(456, 245);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "xxx";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(456, 296);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 0;
            label3.Text = "xxx";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(456, 270);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 0;
            label2.Text = "xxx";
            // 
            // BtnResetStop
            // 
            BtnResetStop.Location = new Point(87, 16);
            BtnResetStop.Name = "BtnResetStop";
            BtnResetStop.Size = new Size(75, 23);
            BtnResetStop.TabIndex = 3;
            BtnResetStop.Text = "Reset";
            BtnResetStop.UseVisualStyleBackColor = true;
            BtnResetStop.Click += BtnResetStop_Click;
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(6, 46);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(75, 23);
            BtnStart.TabIndex = 3;
            BtnStart.Text = "Start ";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // BtnStop
            // 
            BtnStop.Location = new Point(87, 45);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(75, 23);
            BtnStop.TabIndex = 3;
            BtnStop.Text = "Stop";
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += BtnStop_Click;
            // 
            // RadUhrzeit
            // 
            RadUhrzeit.AutoSize = true;
            RadUhrzeit.Checked = true;
            RadUhrzeit.Location = new Point(577, 271);
            RadUhrzeit.Name = "RadUhrzeit";
            RadUhrzeit.Size = new Size(62, 19);
            RadUhrzeit.TabIndex = 4;
            RadUhrzeit.TabStop = true;
            RadUhrzeit.Text = "Uhrzeit";
            RadUhrzeit.UseVisualStyleBackColor = true;
            RadUhrzeit.CheckedChanged += RadUhrzeit_CheckedChanged;
            // 
            // RadStopUhr
            // 
            RadStopUhr.AutoSize = true;
            RadStopUhr.Location = new Point(577, 246);
            RadStopUhr.Name = "RadStopUhr";
            RadStopUhr.Size = new Size(74, 19);
            RadStopUhr.TabIndex = 4;
            RadStopUhr.TabStop = true;
            RadStopUhr.Text = "Stoppuhr";
            RadStopUhr.UseVisualStyleBackColor = true;
            RadStopUhr.CheckedChanged += RadStopUhr_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnStart);
            groupBox1.Controls.Add(BtnStop);
            groupBox1.Controls.Add(BtnResetStop);
            groupBox1.Location = new Point(490, 321);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(176, 74);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // ChkBAlarm
            // 
            ChkBAlarm.AutoSize = true;
            ChkBAlarm.Location = new Point(60, 356);
            ChkBAlarm.Name = "ChkBAlarm";
            ChkBAlarm.Size = new Size(58, 19);
            ChkBAlarm.TabIndex = 6;
            ChkBAlarm.Text = "Alarm";
            ChkBAlarm.UseVisualStyleBackColor = true;
            ChkBAlarm.CheckedChanged += ChkBAlarm_CheckedChanged;
            // 
            // UDHours
            // 
            UDHours.Location = new Point(124, 355);
            UDHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            UDHours.Name = "UDHours";
            UDHours.Size = new Size(39, 23);
            UDHours.TabIndex = 7;
            // 
            // UDMin
            // 
            UDMin.Location = new Point(169, 355);
            UDMin.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            UDMin.Name = "UDMin";
            UDMin.Size = new Size(39, 23);
            UDMin.TabIndex = 7;
            // 
            // UDSec
            // 
            UDSec.Location = new Point(214, 355);
            UDSec.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            UDSec.Name = "UDSec";
            UDSec.Size = new Size(39, 23);
            UDSec.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 337);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 8;
            label4.Text = "HH";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 337);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 8;
            label5.Text = "MM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(214, 337);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 8;
            label6.Text = "SS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(276, 358);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 402);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(UDSec);
            Controls.Add(UDMin);
            Controls.Add(UDHours);
            Controls.Add(ChkBAlarm);
            Controls.Add(RadStopUhr);
            Controls.Add(RadUhrzeit);
            Controls.Add(ColorBValue);
            Controls.Add(ColorGValue);
            Controls.Add(ColorRValue);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "main";
            Text = "Digital clock and stop watch";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ColorRValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorGValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorBValue).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UDHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)UDMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)UDSec).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private TrackBar ColorRValue;
        private TrackBar ColorGValue;
        private TrackBar ColorBValue;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Button BtnResetStop;
        private Button BtnStart;
        private Button BtnStop;
        private RadioButton RadUhrzeit;
        private RadioButton RadStopUhr;
        private GroupBox groupBox1;
        private CheckBox ChkBAlarm;
        private NumericUpDown UDHours;
        private NumericUpDown UDMin;
        private NumericUpDown UDSec;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}