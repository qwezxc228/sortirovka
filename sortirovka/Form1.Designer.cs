namespace sortirovka
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(289, 132);
            button1.Name = "button1";
            button1.Size = new Size(75, 82);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(105, 91);
            button2.Name = "button2";
            button2.Size = new Size(102, 83);
            button2.TabIndex = 0;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(406, 193);
            button3.Name = "button3";
            button3.Size = new Size(95, 54);
            button3.TabIndex = 0;
            button3.Text = "button1";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(582, 278);
            button4.Name = "button4";
            button4.Size = new Size(157, 112);
            button4.TabIndex = 0;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button5_Click;
            // 
            // button5
            // 
            button5.Location = new Point(536, 149);
            button5.Name = "button5";
            button5.Size = new Size(75, 79);
            button5.TabIndex = 0;
            button5.Text = "button1";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
