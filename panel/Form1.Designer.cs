﻿
namespace panel
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
            this.roundPanel1 = new panel.RoundPanel();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.Fill_Type = panel.FillType.FillRoundedRectangle;
            this.roundPanel1.Fill_X = 20;
            this.roundPanel1.Fill_Y = 20;
            this.roundPanel1.FillColor = System.Drawing.Color.Blue;
            this.roundPanel1.FillLineColor = System.Drawing.Color.Blue;
            this.roundPanel1.FillLineWidth = 10F;
            this.roundPanel1.FillRadius = 10;
            this.roundPanel1.Location = new System.Drawing.Point(105, 32);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(580, 407);
            this.roundPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 501);
            this.Controls.Add(this.roundPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundPanel roundPanel1;
    }
}

