namespace Hashing_code_in_password
{
    partial class Forget_Password
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
            this.Forgetten_username = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailDisplay = new System.Windows.Forms.Label();
            this.Code_Time = new System.Windows.Forms.Label();
            this.CodeTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Forgetten_username
            // 
            this.Forgetten_username.Location = new System.Drawing.Point(276, 176);
            this.Forgetten_username.Name = "Forgetten_username";
            this.Forgetten_username.Size = new System.Drawing.Size(215, 22);
            this.Forgetten_username.TabIndex = 0;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(344, 220);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(70, 28);
            this.ConfirmButton.TabIndex = 1;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Username";
            // 
            // EmailDisplay
            // 
            this.EmailDisplay.AutoSize = true;
            this.EmailDisplay.ForeColor = System.Drawing.Color.Red;
            this.EmailDisplay.Location = new System.Drawing.Point(313, 265);
            this.EmailDisplay.Name = "EmailDisplay";
            this.EmailDisplay.Size = new System.Drawing.Size(0, 16);
            this.EmailDisplay.TabIndex = 3;
            // 
            // Code_Time
            // 
            this.Code_Time.AutoSize = true;
            this.Code_Time.ForeColor = System.Drawing.Color.IndianRed;
            this.Code_Time.Location = new System.Drawing.Point(361, 361);
            this.Code_Time.Name = "Code_Time";
            this.Code_Time.Size = new System.Drawing.Size(0, 16);
            this.Code_Time.TabIndex = 4;
            // 
            // CodeTime
            // 
            this.CodeTime.Enabled = true;
            // 
            // Forget_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Code_Time);
            this.Controls.Add(this.EmailDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.Forgetten_username);
            this.Name = "Forget_Password";
            this.Text = "Forget_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Forgetten_username;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EmailDisplay;
        private System.Windows.Forms.Label Code_Time;
        private System.Windows.Forms.Timer CodeTime;
    }
}