namespace TP_POO_25453
{
    partial class CreateAccount
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            dateTimePicker1 = new DateTimePicker();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 63);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 192);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 125);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Secund name";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(119, 81);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(139, 31);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(119, 145);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(139, 31);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(119, 210);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(139, 31);
            richTextBox3.TabIndex = 5;
            richTextBox3.Text = "";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(119, 288);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 255);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 8;
            label4.Text = "Date of bird";
            // 
            // button1
            // 
            button1.Location = new Point(119, 358);
            button1.Name = "button1";
            button1.Size = new Size(139, 23);
            button1.TabIndex = 9;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
            // 
            // RESGISTRY
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 436);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RESGISTRY";
            Text = "Create account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private DateTimePicker dateTimePicker1;
        private ContextMenuStrip contextMenuStrip1;
        private Label label4;
        private Button button1;
    }
}