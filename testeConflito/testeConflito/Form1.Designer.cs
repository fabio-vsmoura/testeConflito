﻿namespace testeConflito
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
            button1 = new Button();
            bt_juior = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(336, 230);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 0;
            button1.Text = "Mensagem";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 

            bt_juior.Location = new Point(650, 230);
            bt_juior.Name = "bt_juior";
            bt_juior.Size = new Size(75, 23);
            bt_juior.TabIndex = 1;
            bt_juior.Text = "junior";
            bt_juior.UseVisualStyleBackColor = true;

            button2.Location = new Point(78, 215);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Botão dev";
            button2.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_juior);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;

        private Button bt_juior;

        private Button button2;

    }
}
