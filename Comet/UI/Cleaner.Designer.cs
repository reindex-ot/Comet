﻿namespace Comet.UI
{
    partial class Cleaner
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
            this.LblIntro = new System.Windows.Forms.Label();
            this.LblClnUp = new System.Windows.Forms.Label();
            this.PrgClean = new System.Windows.Forms.ProgressBar();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblClean = new System.Windows.Forms.Label();
            this.LblHandler = new System.Windows.Forms.Label();
            this.PtbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblIntro
            // 
            this.LblIntro.Location = new System.Drawing.Point(48, 11);
            this.LblIntro.Name = "LblIntro";
            this.LblIntro.Size = new System.Drawing.Size(276, 41);
            this.LblIntro.TabIndex = 0;
            this.LblIntro.Text = "ドライブ内にある不要なファイルを整理しています。";
            // 
            // LblClnUp
            // 
            this.LblClnUp.AutoSize = true;
            this.LblClnUp.Location = new System.Drawing.Point(8, 63);
            this.LblClnUp.Name = "LblClnUp";
            this.LblClnUp.Size = new System.Drawing.Size(120, 12);
            this.LblClnUp.TabIndex = 1;
            this.LblClnUp.Text = "ドライブをクリーンアップ中";
            // 
            // PrgClean
            // 
            this.PrgClean.Location = new System.Drawing.Point(11, 78);
            this.PrgClean.Name = "PrgClean";
            this.PrgClean.Size = new System.Drawing.Size(227, 13);
            this.PrgClean.TabIndex = 2;
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnCancel.Location = new System.Drawing.Point(249, 70);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "キャンセル";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblClean
            // 
            this.LblClean.AutoSize = true;
            this.LblClean.Location = new System.Drawing.Point(8, 96);
            this.LblClean.Name = "LblClean";
            this.LblClean.Size = new System.Drawing.Size(78, 12);
            this.LblClean.TabIndex = 4;
            this.LblClean.Text = "クリーンアップ中:";
            // 
            // LblHandler
            // 
            this.LblHandler.AutoSize = true;
            this.LblHandler.Location = new System.Drawing.Point(63, 96);
            this.LblHandler.Name = "LblHandler";
            this.LblHandler.Size = new System.Drawing.Size(0, 12);
            this.LblHandler.TabIndex = 5;
            // 
            // PtbLogo
            // 
            this.PtbLogo.Location = new System.Drawing.Point(11, 11);
            this.PtbLogo.Name = "PtbLogo";
            this.PtbLogo.Size = new System.Drawing.Size(32, 32);
            this.PtbLogo.TabIndex = 6;
            this.PtbLogo.TabStop = false;
            // 
            // Cleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(335, 114);
            this.Controls.Add(this.PtbLogo);
            this.Controls.Add(this.LblHandler);
            this.Controls.Add(this.LblClean);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.PrgClean);
            this.Controls.Add(this.LblClnUp);
            this.Controls.Add(this.LblIntro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cleaner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Managed Disk Cleanup";
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblIntro;
        private System.Windows.Forms.Label LblClnUp;
        private System.Windows.Forms.ProgressBar PrgClean;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblClean;
        private System.Windows.Forms.Label LblHandler;
        private System.Windows.Forms.PictureBox PtbLogo;
    }
}