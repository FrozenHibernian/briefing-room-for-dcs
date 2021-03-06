﻿namespace BriefingRoom4DCSWorld.Forms
{
    partial class AboutForm
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
            this.AboutTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.AboutTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutTableLayoutPanel
            // 
            this.AboutTableLayoutPanel.ColumnCount = 2;
            this.AboutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AboutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.AboutTableLayoutPanel.Controls.Add(this.InfoRichTextBox, 0, 1);
            this.AboutTableLayoutPanel.Controls.Add(this.TitleLabel, 0, 0);
            this.AboutTableLayoutPanel.Controls.Add(this.CloseButton, 1, 2);
            this.AboutTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.AboutTableLayoutPanel.Name = "AboutTableLayoutPanel";
            this.AboutTableLayoutPanel.RowCount = 3;
            this.AboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.AboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.AboutTableLayoutPanel.Size = new System.Drawing.Size(496, 345);
            this.AboutTableLayoutPanel.TabIndex = 0;
            // 
            // InfoRichTextBox
            // 
            this.InfoRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutTableLayoutPanel.SetColumnSpan(this.InfoRichTextBox, 2);
            this.InfoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoRichTextBox.Location = new System.Drawing.Point(9, 49);
            this.InfoRichTextBox.Margin = new System.Windows.Forms.Padding(9);
            this.InfoRichTextBox.Name = "InfoRichTextBox";
            this.InfoRichTextBox.ReadOnly = true;
            this.InfoRichTextBox.Size = new System.Drawing.Size(478, 247);
            this.InfoRichTextBox.TabIndex = 4;
            this.InfoRichTextBox.Text = "";
            this.InfoRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.IntoRichTextBox_LinkClicked);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.AboutTableLayoutPanel.SetColumnSpan(this.TitleLabel, 2);
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 3);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(490, 34);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "BriefingRoom for DCS World";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseButton.Location = new System.Drawing.Point(335, 308);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(158, 34);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "&Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 345);
            this.Controls.Add(this.AboutTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.AboutTableLayoutPanel.ResumeLayout(false);
            this.AboutTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AboutTableLayoutPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.RichTextBox InfoRichTextBox;
    }
}