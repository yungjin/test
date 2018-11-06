namespace schubert
{
    partial class Form2
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
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnWeightPlus = new System.Windows.Forms.Button();
            this.btnWeightMinus = new System.Windows.Forms.Button();
            this.btnSpeedPlus = new System.Windows.Forms.Button();
            this.btnSpeedMinus = new System.Windows.Forms.Button();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblWeightChange = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSpeedChange = new System.Windows.Forms.Label();
            this.lblStatusChange = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblModeChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btnUp.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUp.ForeColor = System.Drawing.Color.Blue;
            this.btnUp.Location = new System.Drawing.Point(27, 28);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(55, 55);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDown.ForeColor = System.Drawing.Color.Blue;
            this.btnDown.Location = new System.Drawing.Point(27, 94);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(55, 55);
            this.btnDown.TabIndex = 1;
            this.btnDown.Text = "▼";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLeft.ForeColor = System.Drawing.Color.Blue;
            this.btnLeft.Location = new System.Drawing.Point(98, 28);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(55, 55);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "◀";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRight.ForeColor = System.Drawing.Color.Blue;
            this.btnRight.Location = new System.Drawing.Point(98, 94);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(55, 55);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "▶";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStop.Location = new System.Drawing.Point(354, 167);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(104, 145);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblStatus.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStatus.Location = new System.Drawing.Point(171, 28);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 19);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "동작 : ";
            // 
            // btnWeightPlus
            // 
            this.btnWeightPlus.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWeightPlus.Location = new System.Drawing.Point(27, 167);
            this.btnWeightPlus.Name = "btnWeightPlus";
            this.btnWeightPlus.Size = new System.Drawing.Size(55, 55);
            this.btnWeightPlus.TabIndex = 6;
            this.btnWeightPlus.Text = "+";
            this.btnWeightPlus.UseVisualStyleBackColor = true;
            this.btnWeightPlus.Click += new System.EventHandler(this.btnWeightPlus_Click);
            // 
            // btnWeightMinus
            // 
            this.btnWeightMinus.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWeightMinus.Location = new System.Drawing.Point(98, 167);
            this.btnWeightMinus.Name = "btnWeightMinus";
            this.btnWeightMinus.Size = new System.Drawing.Size(55, 55);
            this.btnWeightMinus.TabIndex = 7;
            this.btnWeightMinus.Text = "-";
            this.btnWeightMinus.UseVisualStyleBackColor = true;
            this.btnWeightMinus.Click += new System.EventHandler(this.btnWeightMinus_Click);
            // 
            // btnSpeedPlus
            // 
            this.btnSpeedPlus.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSpeedPlus.Location = new System.Drawing.Point(27, 242);
            this.btnSpeedPlus.Name = "btnSpeedPlus";
            this.btnSpeedPlus.Size = new System.Drawing.Size(55, 55);
            this.btnSpeedPlus.TabIndex = 8;
            this.btnSpeedPlus.Text = "+";
            this.btnSpeedPlus.UseVisualStyleBackColor = true;
            this.btnSpeedPlus.Click += new System.EventHandler(this.btnSpeedPlus_Click);
            // 
            // btnSpeedMinus
            // 
            this.btnSpeedMinus.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSpeedMinus.Location = new System.Drawing.Point(98, 242);
            this.btnSpeedMinus.Name = "btnSpeedMinus";
            this.btnSpeedMinus.Size = new System.Drawing.Size(55, 55);
            this.btnSpeedMinus.TabIndex = 9;
            this.btnSpeedMinus.Text = "-";
            this.btnSpeedMinus.UseVisualStyleBackColor = true;
            this.btnSpeedMinus.Click += new System.EventHandler(this.btnSpeedMinus_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblWeight.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWeight.Location = new System.Drawing.Point(171, 167);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(65, 19);
            this.lblWeight.TabIndex = 11;
            this.lblWeight.Text = "중량 : ";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSpeed.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSpeed.Location = new System.Drawing.Point(171, 243);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(65, 19);
            this.lblSpeed.TabIndex = 13;
            this.lblSpeed.Text = "속도 : ";
            // 
            // lblWeightChange
            // 
            this.lblWeightChange.AutoSize = true;
            this.lblWeightChange.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblWeightChange.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWeightChange.Location = new System.Drawing.Point(228, 167);
            this.lblWeightChange.Name = "lblWeightChange";
            this.lblWeightChange.Size = new System.Drawing.Size(38, 19);
            this.lblWeightChange.TabIndex = 14;
            this.lblWeightChange.Text = "1.2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(261, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "t";
            // 
            // lblSpeedChange
            // 
            this.lblSpeedChange.AutoSize = true;
            this.lblSpeedChange.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSpeedChange.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSpeedChange.Location = new System.Drawing.Point(228, 243);
            this.lblSpeedChange.Name = "lblSpeedChange";
            this.lblSpeedChange.Size = new System.Drawing.Size(38, 19);
            this.lblSpeedChange.TabIndex = 16;
            this.lblSpeedChange.Text = "1.0";
            // 
            // lblStatusChange
            // 
            this.lblStatusChange.AutoSize = true;
            this.lblStatusChange.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblStatusChange.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStatusChange.Location = new System.Drawing.Point(228, 28);
            this.lblStatusChange.Name = "lblStatusChange";
            this.lblStatusChange.Size = new System.Drawing.Size(49, 19);
            this.lblStatusChange.TabIndex = 17;
            this.lblStatusChange.Text = "정지";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "-------------------------------------------------------";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.Location = new System.Drawing.Point(354, 16);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 145);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAuto.Location = new System.Drawing.Point(27, 341);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(55, 55);
            this.btnAuto.TabIndex = 21;
            this.btnAuto.Text = "자동";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnManual
            // 
            this.btnManual.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnManual.Location = new System.Drawing.Point(27, 402);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(55, 55);
            this.btnManual.TabIndex = 23;
            this.btnManual.Text = "수동";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "-------------------------------------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "-------------------------------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "-------------------------------------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 12);
            this.label5.TabIndex = 27;
            this.label5.Text = "-------------------------------------------------------";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMode.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMode.Location = new System.Drawing.Point(23, 315);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(103, 19);
            this.lblMode.TabIndex = 28;
            this.lblMode.Text = "현재 모드 :";
            // 
            // lblModeChange
            // 
            this.lblModeChange.AutoSize = true;
            this.lblModeChange.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblModeChange.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblModeChange.Location = new System.Drawing.Point(123, 315);
            this.lblModeChange.Name = "lblModeChange";
            this.lblModeChange.Size = new System.Drawing.Size(49, 19);
            this.lblModeChange.TabIndex = 29;
            this.lblModeChange.Text = "자동";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 521);
            this.Controls.Add(this.lblModeChange);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStatusChange);
            this.Controls.Add(this.lblSpeedChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblWeightChange);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.btnSpeedMinus);
            this.Controls.Add(this.btnSpeedPlus);
            this.Controls.Add(this.btnWeightMinus);
            this.Controls.Add(this.btnWeightPlus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnWeightPlus;
        private System.Windows.Forms.Button btnWeightMinus;
        private System.Windows.Forms.Button btnSpeedPlus;
        private System.Windows.Forms.Button btnSpeedMinus;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblWeightChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSpeedChange;
        private System.Windows.Forms.Label lblStatusChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblModeChange;
    }
}