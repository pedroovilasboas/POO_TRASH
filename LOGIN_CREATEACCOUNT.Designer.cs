namespace TP_POO_25453
{
    partial class LOGIN_CREATEACCOUNT
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(115, 103);
            button1.Name = "button1";
            button1.Size = new Size(81, 37);
            button1.TabIndex = 0;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(202, 103);
            button2.Name = "button2";
            button2.Size = new Size(81, 37);
            button2.TabIndex = 1;
            button2.Text = "REGISTRY";
            button2.UseVisualStyleBackColor = true;
            // 
            // LOGIN_REGISTER
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 426);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "LOGIN_REGISTER";
            Text = "LOGIN_REGISTER";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}