namespace ButtonRanAway
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
            this.customButtonPushMe = new ButtonRanAway.CustomButton();
            this.SuspendLayout();
            // 
            // customButtonPushMe
            // 
            this.customButtonPushMe.BackColor = System.Drawing.Color.DodgerBlue;
            this.customButtonPushMe.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.customButtonPushMe.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.customButtonPushMe.BorderRadius = 40;
            this.customButtonPushMe.BorderSize = 15;
            this.customButtonPushMe.FlatAppearance.BorderSize = 0;
            this.customButtonPushMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtonPushMe.ForeColor = System.Drawing.Color.White;
            this.customButtonPushMe.Location = new System.Drawing.Point(221, 174);
            this.customButtonPushMe.Name = "customButtonPushMe";
            this.customButtonPushMe.Size = new System.Drawing.Size(238, 98);
            this.customButtonPushMe.TabIndex = 1;
            this.customButtonPushMe.Text = "НАЖМИ МЕНЯ, \r\nЕСЛИ СМОЖЕШЬ!\r\n";
            this.customButtonPushMe.TextColor = System.Drawing.Color.White;
            this.customButtonPushMe.UseVisualStyleBackColor = false;
            this.customButtonPushMe.Click += new System.EventHandler(this.OnCustomButtonPushMeClick);
            this.customButtonPushMe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnCustomButtonPushMeMouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(860, 620);
            this.Controls.Add(this.customButtonPushMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private CustomButton customButtonPushMe;
    }
}