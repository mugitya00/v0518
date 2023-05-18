namespace v0518
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
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(292, 85);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 0;
            button1.Text = "押すなよ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "ボタン";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(292, 156);
            button2.Name = "button2";
            button2.Size = new Size(94, 28);
            button2.TabIndex = 2;
            button2.Text = "押すなよ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ForeColor = Color.Black;
            button3.Location = new Point(189, 118);
            button3.Name = "button3";
            button3.Size = new Size(97, 35);
            button3.TabIndex = 3;
            button3.Text = "押すなよ";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(373, 120);
            button4.Name = "button4";
            button4.Size = new Size(104, 30);
            button4.TabIndex = 4;
            button4.Text = "押すなよ";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.ForeColor = Color.Maroon;
            button5.Location = new Point(292, 114);
            button5.Name = "button5";
            button5.Size = new Size(94, 43);
            button5.TabIndex = 5;
            button5.Text = "爆弾";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLightLight;
            button6.ForeColor = Color.Maroon;
            button6.Location = new Point(292, 124);
            button6.Name = "button6";
            button6.Size = new Size(94, 26);
            button6.TabIndex = 6;
            button6.Text = "ボン";
            button6.UseVisualStyleBackColor = false;
            button6.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}