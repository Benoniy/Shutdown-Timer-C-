namespace Shutdown_Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButtonS = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonL = new System.Windows.Forms.RadioButton();
            this.radioButtonR = new System.Windows.Forms.RadioButton();
            this.radioButtonAlarm = new System.Windows.Forms.RadioButton();
            this.radioButtonCount = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelHours = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSecsUp_BIG = new System.Windows.Forms.Button();
            this.buttonSecsUp = new System.Windows.Forms.Button();
            this.buttonSecsDown = new System.Windows.Forms.Button();
            this.buttonSecsDown_BIG = new System.Windows.Forms.Button();
            this.buttonMinsUp_BIG = new System.Windows.Forms.Button();
            this.buttonMinsUp = new System.Windows.Forms.Button();
            this.buttonMinsDown = new System.Windows.Forms.Button();
            this.buttonMinsDown_BIG = new System.Windows.Forms.Button();
            this.buttonHoursUp_BIG = new System.Windows.Forms.Button();
            this.buttonHoursUp = new System.Windows.Forms.Button();
            this.buttonHoursDown = new System.Windows.Forms.Button();
            this.buttonHoursDown_BIG = new System.Windows.Forms.Button();
            this.labelColon2 = new System.Windows.Forms.Label();
            this.labelColon1 = new System.Windows.Forms.Label();
            this.labelMins = new System.Windows.Forms.Label();
            this.labelSecs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonS
            // 
            this.radioButtonS.AutoSize = true;
            this.radioButtonS.Checked = true;
            this.radioButtonS.Location = new System.Drawing.Point(11, 26);
            this.radioButtonS.Name = "radioButtonS";
            this.radioButtonS.Size = new System.Drawing.Size(73, 17);
            this.radioButtonS.TabIndex = 0;
            this.radioButtonS.TabStop = true;
            this.radioButtonS.Text = "Shutdown";
            this.radioButtonS.UseVisualStyleBackColor = true;
            this.radioButtonS.CheckedChanged += new System.EventHandler(this.radioButtonMode_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonL);
            this.groupBox1.Controls.Add(this.radioButtonR);
            this.groupBox1.Controls.Add(this.radioButtonS);
            this.groupBox1.Location = new System.Drawing.Point(146, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mode:";
            // 
            // radioButtonL
            // 
            this.radioButtonL.AutoSize = true;
            this.radioButtonL.Location = new System.Drawing.Point(11, 62);
            this.radioButtonL.Name = "radioButtonL";
            this.radioButtonL.Size = new System.Drawing.Size(60, 17);
            this.radioButtonL.TabIndex = 0;
            this.radioButtonL.Text = "Log Off";
            this.radioButtonL.UseVisualStyleBackColor = true;
            this.radioButtonL.CheckedChanged += new System.EventHandler(this.radioButtonMode_CheckedChanged);
            // 
            // radioButtonR
            // 
            this.radioButtonR.AutoSize = true;
            this.radioButtonR.Location = new System.Drawing.Point(11, 44);
            this.radioButtonR.Name = "radioButtonR";
            this.radioButtonR.Size = new System.Drawing.Size(59, 17);
            this.radioButtonR.TabIndex = 0;
            this.radioButtonR.Text = "Restart";
            this.radioButtonR.UseVisualStyleBackColor = true;
            this.radioButtonR.CheckedChanged += new System.EventHandler(this.radioButtonMode_CheckedChanged);
            // 
            // radioButtonAlarm
            // 
            this.radioButtonAlarm.AutoSize = true;
            this.radioButtonAlarm.Location = new System.Drawing.Point(11, 41);
            this.radioButtonAlarm.Name = "radioButtonAlarm";
            this.radioButtonAlarm.Size = new System.Drawing.Size(51, 17);
            this.radioButtonAlarm.TabIndex = 0;
            this.radioButtonAlarm.Text = "Alarm";
            this.radioButtonAlarm.UseVisualStyleBackColor = true;
            this.radioButtonAlarm.CheckedChanged += new System.EventHandler(this.radioButtonAlarm_CheckedChanged);
            // 
            // radioButtonCount
            // 
            this.radioButtonCount.AutoSize = true;
            this.radioButtonCount.Checked = true;
            this.radioButtonCount.Location = new System.Drawing.Point(11, 24);
            this.radioButtonCount.Name = "radioButtonCount";
            this.radioButtonCount.Size = new System.Drawing.Size(79, 17);
            this.radioButtonCount.TabIndex = 0;
            this.radioButtonCount.TabStop = true;
            this.radioButtonCount.Text = "Countdown";
            this.radioButtonCount.UseVisualStyleBackColor = true;
            this.radioButtonCount.CheckedChanged += new System.EventHandler(this.radioButtonAlarm_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.radioButtonAlarm);
            this.groupBox2.Controls.Add(this.radioButtonCount);
            this.groupBox2.Location = new System.Drawing.Point(21, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(95, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Timer Mode:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(279, 170);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(64, 20);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.BackColor = System.Drawing.Color.Transparent;
            this.labelHours.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold);
            this.labelHours.Location = new System.Drawing.Point(-7, 5);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(137, 106);
            this.labelHours.TabIndex = 3;
            this.labelHours.Text = "00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSecsUp_BIG);
            this.groupBox3.Controls.Add(this.buttonSecsUp);
            this.groupBox3.Controls.Add(this.buttonSecsDown);
            this.groupBox3.Controls.Add(this.buttonSecsDown_BIG);
            this.groupBox3.Controls.Add(this.buttonMinsUp_BIG);
            this.groupBox3.Controls.Add(this.buttonMinsUp);
            this.groupBox3.Controls.Add(this.buttonMinsDown);
            this.groupBox3.Controls.Add(this.buttonMinsDown_BIG);
            this.groupBox3.Controls.Add(this.buttonHoursUp_BIG);
            this.groupBox3.Controls.Add(this.buttonHoursUp);
            this.groupBox3.Controls.Add(this.buttonHoursDown);
            this.groupBox3.Controls.Add(this.buttonHoursDown_BIG);
            this.groupBox3.Controls.Add(this.labelColon2);
            this.groupBox3.Controls.Add(this.labelColon1);
            this.groupBox3.Controls.Add(this.labelMins);
            this.groupBox3.Controls.Add(this.labelSecs);
            this.groupBox3.Controls.Add(this.labelHours);
            this.groupBox3.Location = new System.Drawing.Point(10, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 119);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // buttonSecsUp_BIG
            // 
            this.buttonSecsUp_BIG.Location = new System.Drawing.Point(258, 11);
            this.buttonSecsUp_BIG.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSecsUp_BIG.Name = "buttonSecsUp_BIG";
            this.buttonSecsUp_BIG.Size = new System.Drawing.Size(42, 19);
            this.buttonSecsUp_BIG.TabIndex = 18;
            this.buttonSecsUp_BIG.Text = "▲";
            this.buttonSecsUp_BIG.UseVisualStyleBackColor = true;
            this.buttonSecsUp_BIG.Click += new System.EventHandler(this.valueChange);
            // 
            // buttonSecsUp
            // 
            this.buttonSecsUp.Location = new System.Drawing.Point(304, 11);
            this.buttonSecsUp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSecsUp.Name = "buttonSecsUp";
            this.buttonSecsUp.Size = new System.Drawing.Size(42, 19);
            this.buttonSecsUp.TabIndex = 17;
            this.buttonSecsUp.Text = "▲";
            this.buttonSecsUp.UseVisualStyleBackColor = true;
            this.buttonSecsUp.Click += new System.EventHandler(this.valueChange);
            // 
            // buttonSecsDown
            // 
            this.buttonSecsDown.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSecsDown.Location = new System.Drawing.Point(304, 97);
            this.buttonSecsDown.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSecsDown.Name = "buttonSecsDown";
            this.buttonSecsDown.Size = new System.Drawing.Size(42, 19);
            this.buttonSecsDown.TabIndex = 16;
            this.buttonSecsDown.Text = "▼";
            this.buttonSecsDown.UseVisualStyleBackColor = true;
            this.buttonSecsDown.Click += new System.EventHandler(this.valueChange);
            // 
            // buttonSecsDown_BIG
            // 
            this.buttonSecsDown_BIG.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSecsDown_BIG.Location = new System.Drawing.Point(258, 97);
            this.buttonSecsDown_BIG.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSecsDown_BIG.Name = "buttonSecsDown_BIG";
            this.buttonSecsDown_BIG.Size = new System.Drawing.Size(42, 19);
            this.buttonSecsDown_BIG.TabIndex = 15;
            this.buttonSecsDown_BIG.Text = "▼";
            this.buttonSecsDown_BIG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSecsDown_BIG.UseVisualStyleBackColor = true;
            this.buttonSecsDown_BIG.Click += new System.EventHandler(this.valueChange);
            // 
            // buttonMinsUp_BIG
            // 
            this.buttonMinsUp_BIG.Location = new System.Drawing.Point(136, 11);
            this.buttonMinsUp_BIG.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMinsUp_BIG.Name = "buttonMinsUp_BIG";
            this.buttonMinsUp_BIG.Size = new System.Drawing.Size(42, 19);
            this.buttonMinsUp_BIG.TabIndex = 14;
            this.buttonMinsUp_BIG.Text = "▲";
            this.buttonMinsUp_BIG.UseVisualStyleBackColor = true;
            this.buttonMinsUp_BIG.Click += new System.EventHandler(this.valueChange);
            // 
            // buttonMinsUp
            // 
            this.buttonMinsUp.Location = new System.Drawing.Point(182, 11);
            this.buttonMinsUp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMinsUp.Name = "buttonMinsUp";
            this.buttonMinsUp.Size = new System.Drawing.Size(42, 19);
            this.buttonMinsUp.TabIndex = 13;
            this.buttonMinsUp.Text = "▲";
            this.buttonMinsUp.UseVisualStyleBackColor = true;
            this.buttonMinsUp.Click += new System.EventHandler(this.valueChange);
            // 
            // buttonMinsDown
            // 
            this.buttonMinsDown.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinsDown.Location = new System.Drawing.Point(182, 97);
            this.buttonMinsDown.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMinsDown.Name = "buttonMinsDown";
            this.buttonMinsDown.Size = new System.Drawing.Size(42, 19);
            this.buttonMinsDown.TabIndex = 12;
            this.buttonMinsDown.Text = "▼";
            this.buttonMinsDown.UseVisualStyleBackColor = true;
            this.buttonMinsDown.Click += new System.EventHandler(this.valueChange);
            // 
            // buttonMinsDown_BIG
            // 
            this.buttonMinsDown_BIG.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinsDown_BIG.Location = new System.Drawing.Point(136, 97);
            this.buttonMinsDown_BIG.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMinsDown_BIG.Name = "buttonMinsDown_BIG";
            this.buttonMinsDown_BIG.Size = new System.Drawing.Size(42, 19);
            this.buttonMinsDown_BIG.TabIndex = 11;
            this.buttonMinsDown_BIG.Text = "▼";
            this.buttonMinsDown_BIG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinsDown_BIG.UseVisualStyleBackColor = true;
            this.buttonMinsDown_BIG.Click += new System.EventHandler(this.valueChange);
            // 
            // buttonHoursUp_BIG
            // 
            this.buttonHoursUp_BIG.Location = new System.Drawing.Point(13, 11);
            this.buttonHoursUp_BIG.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHoursUp_BIG.Name = "buttonHoursUp_BIG";
            this.buttonHoursUp_BIG.Size = new System.Drawing.Size(42, 19);
            this.buttonHoursUp_BIG.TabIndex = 10;
            this.buttonHoursUp_BIG.Text = "▲";
            this.buttonHoursUp_BIG.UseVisualStyleBackColor = true;
            this.buttonHoursUp_BIG.Click += new System.EventHandler(this.valueChange);
            // 
            // buttonHoursUp
            // 
            this.buttonHoursUp.Location = new System.Drawing.Point(59, 11);
            this.buttonHoursUp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHoursUp.Name = "buttonHoursUp";
            this.buttonHoursUp.Size = new System.Drawing.Size(42, 19);
            this.buttonHoursUp.TabIndex = 9;
            this.buttonHoursUp.Text = "▲";
            this.buttonHoursUp.UseVisualStyleBackColor = true;
            this.buttonHoursUp.Click += new System.EventHandler(this.valueChange);
            // 
            // buttonHoursDown
            // 
            this.buttonHoursDown.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHoursDown.Location = new System.Drawing.Point(59, 97);
            this.buttonHoursDown.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHoursDown.Name = "buttonHoursDown";
            this.buttonHoursDown.Size = new System.Drawing.Size(42, 19);
            this.buttonHoursDown.TabIndex = 8;
            this.buttonHoursDown.Text = "▼";
            this.buttonHoursDown.UseVisualStyleBackColor = true;
            this.buttonHoursDown.Click += new System.EventHandler(this.valueChange);
            // 
            // buttonHoursDown_BIG
            // 
            this.buttonHoursDown_BIG.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHoursDown_BIG.Location = new System.Drawing.Point(13, 97);
            this.buttonHoursDown_BIG.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHoursDown_BIG.Name = "buttonHoursDown_BIG";
            this.buttonHoursDown_BIG.Size = new System.Drawing.Size(42, 19);
            this.buttonHoursDown_BIG.TabIndex = 7;
            this.buttonHoursDown_BIG.Text = "▼";
            this.buttonHoursDown_BIG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHoursDown_BIG.UseVisualStyleBackColor = true;
            this.buttonHoursDown_BIG.Click += new System.EventHandler(this.valueChange);
            // 
            // labelColon2
            // 
            this.labelColon2.BackColor = System.Drawing.Color.Transparent;
            this.labelColon2.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.labelColon2.Location = new System.Drawing.Point(228, 19);
            this.labelColon2.Margin = new System.Windows.Forms.Padding(0);
            this.labelColon2.Name = "labelColon2";
            this.labelColon2.Size = new System.Drawing.Size(31, 69);
            this.labelColon2.TabIndex = 5;
            this.labelColon2.Text = ":";
            this.labelColon2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelColon1
            // 
            this.labelColon1.BackColor = System.Drawing.Color.Transparent;
            this.labelColon1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.labelColon1.Location = new System.Drawing.Point(105, 17);
            this.labelColon1.Margin = new System.Windows.Forms.Padding(0);
            this.labelColon1.Name = "labelColon1";
            this.labelColon1.Size = new System.Drawing.Size(31, 69);
            this.labelColon1.TabIndex = 5;
            this.labelColon1.Text = ":";
            this.labelColon1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMins
            // 
            this.labelMins.AutoSize = true;
            this.labelMins.BackColor = System.Drawing.Color.Transparent;
            this.labelMins.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold);
            this.labelMins.Location = new System.Drawing.Point(116, 5);
            this.labelMins.Name = "labelMins";
            this.labelMins.Size = new System.Drawing.Size(137, 106);
            this.labelMins.TabIndex = 3;
            this.labelMins.Text = "00";
            // 
            // labelSecs
            // 
            this.labelSecs.AutoSize = true;
            this.labelSecs.BackColor = System.Drawing.Color.Transparent;
            this.labelSecs.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold);
            this.labelSecs.Location = new System.Drawing.Point(238, 5);
            this.labelSecs.Name = "labelSecs";
            this.labelSecs.Size = new System.Drawing.Size(137, 106);
            this.labelSecs.TabIndex = 3;
            this.labelSecs.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Minutes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Seconds";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 231);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 270);
            this.MinimumSize = new System.Drawing.Size(400, 270);
            this.Name = "Form1";
            this.Text = "Shutdown Timer";
            this.TransparencyKey = System.Drawing.Color.DarkOrange;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonL;
        private System.Windows.Forms.RadioButton radioButtonR;
        private System.Windows.Forms.RadioButton radioButtonAlarm;
        private System.Windows.Forms.RadioButton radioButtonCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSecs;
        private System.Windows.Forms.Label labelColon2;
        private System.Windows.Forms.Label labelColon1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMins;
        private System.Windows.Forms.Button buttonSecsUp_BIG;
        private System.Windows.Forms.Button buttonSecsUp;
        private System.Windows.Forms.Button buttonSecsDown;
        private System.Windows.Forms.Button buttonSecsDown_BIG;
        private System.Windows.Forms.Button buttonMinsUp_BIG;
        private System.Windows.Forms.Button buttonMinsUp;
        private System.Windows.Forms.Button buttonMinsDown;
        private System.Windows.Forms.Button buttonMinsDown_BIG;
        private System.Windows.Forms.Button buttonHoursUp_BIG;
        private System.Windows.Forms.Button buttonHoursUp;
        private System.Windows.Forms.Button buttonHoursDown;
        private System.Windows.Forms.Button buttonHoursDown_BIG;
    }
}


