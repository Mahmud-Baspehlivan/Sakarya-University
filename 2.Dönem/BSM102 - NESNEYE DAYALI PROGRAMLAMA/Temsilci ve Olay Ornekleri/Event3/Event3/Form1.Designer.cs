﻿namespace Event3
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
            this.tekKullanimlikButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tekKullanimlikButton
            // 
            this.tekKullanimlikButton.Location = new System.Drawing.Point(52, 57);
            this.tekKullanimlikButton.Name = "tekKullanimlikButton";
            this.tekKullanimlikButton.Size = new System.Drawing.Size(173, 23);
            this.tekKullanimlikButton.TabIndex = 0;
            this.tekKullanimlikButton.Text = "Tek Kullanımlık Button";
            this.tekKullanimlikButton.UseVisualStyleBackColor = true;
            this.tekKullanimlikButton.Click += new System.EventHandler(this.tekKullanimlikButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 137);
            this.Controls.Add(this.tekKullanimlikButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tekKullanimlikButton;
    }
}

