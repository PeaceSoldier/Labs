namespace Lab06
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
            this.textBoxUsers = new System.Windows.Forms.TextBox();
            this.labelAdminInfo = new System.Windows.Forms.Label();
            this.buttonShowInfoMessage = new System.Windows.Forms.Button();
            this.buttonGetAdminRights = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUsers
            // 
            this.textBoxUsers.Location = new System.Drawing.Point(12, 7);
            this.textBoxUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUsers.Multiline = true;
            this.textBoxUsers.Name = "textBoxUsers";
            this.textBoxUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUsers.Size = new System.Drawing.Size(717, 435);
            this.textBoxUsers.TabIndex = 0;
            this.textBoxUsers.TextChanged += new System.EventHandler(this.textBoxUsers_TextChanged);
            // 
            // labelAdminInfo
            // 
            this.labelAdminInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminInfo.Location = new System.Drawing.Point(14, 451);
            this.labelAdminInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdminInfo.Name = "labelAdminInfo";
            this.labelAdminInfo.Size = new System.Drawing.Size(716, 22);
            this.labelAdminInfo.TabIndex = 1;
            this.labelAdminInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonShowInfoMessage
            // 
            this.buttonShowInfoMessage.Location = new System.Drawing.Point(12, 486);
            this.buttonShowInfoMessage.Name = "buttonShowInfoMessage";
            this.buttonShowInfoMessage.Size = new System.Drawing.Size(350, 38);
            this.buttonShowInfoMessage.TabIndex = 2;
            this.buttonShowInfoMessage.Text = "Отримати повідомлення для адміністратора";
            this.buttonShowInfoMessage.UseVisualStyleBackColor = true;
            this.buttonShowInfoMessage.Click += new System.EventHandler(this.buttonShowInfoMessage_Click);
            // 
            // buttonGetAdminRights
            // 
            this.buttonGetAdminRights.Location = new System.Drawing.Point(379, 486);
            this.buttonGetAdminRights.Name = "buttonGetAdminRights";
            this.buttonGetAdminRights.Size = new System.Drawing.Size(350, 38);
            this.buttonGetAdminRights.TabIndex = 3;
            this.buttonGetAdminRights.Text = "Отримати права адміністратора";
            this.buttonGetAdminRights.UseVisualStyleBackColor = true;
            this.buttonGetAdminRights.Click += new System.EventHandler(this.buttonGetAdminRights_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 536);
            this.Controls.Add(this.buttonGetAdminRights);
            this.Controls.Add(this.buttonShowInfoMessage);
            this.Controls.Add(this.labelAdminInfo);
            this.Controls.Add(this.textBoxUsers);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab06";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsers;
        private System.Windows.Forms.Label labelAdminInfo;
        private System.Windows.Forms.Button buttonShowInfoMessage;
        private System.Windows.Forms.Button buttonGetAdminRights;
    }
}

