﻿namespace Data_Access_with_LINQ
{
    partial class StudentInfoForm
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
            this.ILabel = new System.Windows.Forms.Label();
            this.IDDateLabel = new System.Windows.Forms.Label();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.StudentIDDataLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ILabel
            // 
            this.ILabel.Location = new System.Drawing.Point(95, 51);
            this.ILabel.Name = "ILabel";
            this.ILabel.Size = new System.Drawing.Size(168, 63);
            this.ILabel.TabIndex = 0;
            this.ILabel.Text = "ID";
            this.ILabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IDDateLabel
            // 
            this.IDDateLabel.BackColor = System.Drawing.Color.White;
            this.IDDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDDateLabel.Location = new System.Drawing.Point(283, 51);
            this.IDDateLabel.Name = "IDDateLabel";
            this.IDDateLabel.Size = new System.Drawing.Size(232, 63);
            this.IDDateLabel.TabIndex = 0;
            this.IDDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.Location = new System.Drawing.Point(89, 132);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(174, 63);
            this.StudentIDLabel.TabIndex = 0;
            this.StudentIDLabel.Text = "Student ID";
            this.StudentIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StudentIDDataLabel
            // 
            this.StudentIDDataLabel.BackColor = System.Drawing.Color.White;
            this.StudentIDDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StudentIDDataLabel.Location = new System.Drawing.Point(283, 132);
            this.StudentIDDataLabel.Name = "StudentIDDataLabel";
            this.StudentIDDataLabel.Size = new System.Drawing.Size(232, 63);
            this.StudentIDDataLabel.TabIndex = 0;
            this.StudentIDDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Location = new System.Drawing.Point(89, 213);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(174, 63);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Location = new System.Drawing.Point(89, 294);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(174, 63);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.White;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameDataLabel.Location = new System.Drawing.Point(283, 213);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(476, 63);
            this.FirstNameDataLabel.TabIndex = 0;
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.BackColor = System.Drawing.Color.White;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameDataLabel.Location = new System.Drawing.Point(283, 294);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(476, 63);
            this.LastNameDataLabel.TabIndex = 0;
            this.LastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 490);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(124, 59);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LastNameDataLabel);
            this.Controls.Add(this.FirstNameDataLabel);
            this.Controls.Add(this.StudentIDDataLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.IDDateLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.StudentIDLabel);
            this.Controls.Add(this.ILabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "StudentInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Info Form";
            this.Activated += new System.EventHandler(this.StudentInfoForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentInfoForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ILabel;
        private System.Windows.Forms.Label IDDateLabel;
        private System.Windows.Forms.Label StudentIDLabel;
        private System.Windows.Forms.Label StudentIDDataLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.Button BackButton;
    }
}