﻿
namespace Week08_TQC5OX
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSelectBall = new System.Windows.Forms.Button();
            this.btnSelectCar = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.lblNext);
            this.mainPanel.Controls.Add(this.btnSelectCar);
            this.mainPanel.Controls.Add(this.btnSelectBall);
            this.mainPanel.Location = new System.Drawing.Point(-3, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(804, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btnSelectBall
            // 
            this.btnSelectBall.Location = new System.Drawing.Point(119, 12);
            this.btnSelectBall.Name = "btnSelectBall";
            this.btnSelectBall.Size = new System.Drawing.Size(98, 74);
            this.btnSelectBall.TabIndex = 0;
            this.btnSelectBall.Text = "&BALL";
            this.btnSelectBall.UseVisualStyleBackColor = true;
            this.btnSelectBall.Click += new System.EventHandler(this.btnSelectBall_Click);
            // 
            // btnSelectCar
            // 
            this.btnSelectCar.Location = new System.Drawing.Point(15, 12);
            this.btnSelectCar.Name = "btnSelectCar";
            this.btnSelectCar.Size = new System.Drawing.Size(98, 74);
            this.btnSelectCar.TabIndex = 1;
            this.btnSelectCar.Text = "&CAR";
            this.btnSelectCar.UseVisualStyleBackColor = true;
            this.btnSelectCar.Click += new System.EventHandler(this.btnSelectCar_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(223, 12);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(89, 17);
            this.lblNext.TabIndex = 2;
            this.lblNext.Text = "Coming next:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnSelectCar;
        private System.Windows.Forms.Button btnSelectBall;
    }
}

