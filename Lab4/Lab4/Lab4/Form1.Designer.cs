﻿
namespace Lab4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.ttt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(18, 402);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(172, 36);
            this.Add.TabIndex = 2;
            this.Add.Text = "Додати";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(221, 402);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(173, 36);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Видалити";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(425, 402);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(181, 36);
            this.Copy.TabIndex = 4;
            this.Copy.Text = "Копіювати";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // ttt
            // 
            this.ttt.Location = new System.Drawing.Point(635, 402);
            this.ttt.Name = "ttt";
            this.ttt.Size = new System.Drawing.Size(166, 36);
            this.ttt.TabIndex = 5;
            this.ttt.Text = "Додати .ttt до асоціації";
            this.ttt.UseVisualStyleBackColor = true;
            this.ttt.Click += new System.EventHandler(this.ttt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.ttt);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button ttt;
    }
}

