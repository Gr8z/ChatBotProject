namespace ChatBotProject
{
    partial class WelcomeScreen
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
            this.lblWelcome1 = new System.Windows.Forms.Label();
            this.lblWelcome2 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTimer1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltimer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome1
            // 
            this.lblWelcome1.AutoSize = true;
            this.lblWelcome1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblWelcome1.Location = new System.Drawing.Point(52, 45);
            this.lblWelcome1.Name = "lblWelcome1";
            this.lblWelcome1.Size = new System.Drawing.Size(180, 18);
            this.lblWelcome1.TabIndex = 0;
            this.lblWelcome1.Text = "PEE-BOO-PEE-BOO";
            // 
            // lblWelcome2
            // 
            this.lblWelcome2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWelcome2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblWelcome2.Location = new System.Drawing.Point(12, 84);
            this.lblWelcome2.Name = "lblWelcome2";
            this.lblWelcome2.Size = new System.Drawing.Size(257, 92);
            this.lblWelcome2.TabIndex = 1;
            this.lblWelcome2.Text = "Welcome to the ChatBot";
            this.lblWelcome2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTimer.Location = new System.Drawing.Point(20, 188);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(173, 27);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "ChatBot will open in...";
            // 
            // lblTimer1
            // 
            this.lblTimer1.AutoSize = true;
            this.lblTimer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTimer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTimer1.Location = new System.Drawing.Point(209, 188);
            this.lblTimer1.Name = "lblTimer1";
            this.lblTimer1.Size = new System.Drawing.Size(44, 18);
            this.lblTimer1.TabIndex = 4;
            this.lblTimer1.Text = "secs";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbltimer2
            // 
            this.lbltimer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbltimer2.Location = new System.Drawing.Point(192, 187);
            this.lbltimer2.Name = "lbltimer2";
            this.lbltimer2.Size = new System.Drawing.Size(20, 18);
            this.lbltimer2.TabIndex = 5;
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.lbltimer2);
            this.Controls.Add(this.lblTimer1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblWelcome2);
            this.Controls.Add(this.lblWelcome1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeScreen";
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome1;
        private System.Windows.Forms.Label lblWelcome2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTimer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltimer2;
    }
}