namespace ChatBotProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.InputTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTyping = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputTxt
            // 
            this.outputTxt.Location = new System.Drawing.Point(7, 8);
            this.outputTxt.Multiline = true;
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ReadOnly = true;
            this.outputTxt.Size = new System.Drawing.Size(304, 391);
            this.outputTxt.TabIndex = 0;
            this.outputTxt.TextChanged += new System.EventHandler(this.outputTxt_TextChanged);
            // 
            // InputTxt
            // 
            this.InputTxt.Location = new System.Drawing.Point(7, 416);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(238, 20);
            this.InputTxt.TabIndex = 1;
            this.InputTxt.TextChanged += new System.EventHandler(this.InputTxt_TextChanged);
            this.InputTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTxt_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTyping
            // 
            this.txtTyping.AutoSize = true;
            this.txtTyping.Location = new System.Drawing.Point(4, 440);
            this.txtTyping.Name = "txtTyping";
            this.txtTyping.Size = new System.Drawing.Size(73, 13);
            this.txtTyping.TabIndex = 3;
            this.txtTyping.Text = "Bot is typing...";
            this.txtTyping.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 462);
            this.Controls.Add(this.txtTyping);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputTxt);
            this.Controls.Add(this.outputTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTxt;
        private System.Windows.Forms.TextBox InputTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtTyping;
    }
}

