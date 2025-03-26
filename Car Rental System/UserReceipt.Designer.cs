namespace Car_Rental_System
{
    partial class UserReceipt
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            buttonPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heavitas", 11.9999981F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(350, 92);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 0;
            label1.Text = "Rental ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Heavitas", 11.9999981F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(350, 128);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 0;
            label2.Text = "User ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Heavitas", 11.9999981F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(350, 165);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 0;
            label3.Text = "Brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Heavitas", 11.9999981F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(350, 196);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 0;
            label4.Text = "Model";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Heavitas", 11.9999981F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(352, 230);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 0;
            label5.Text = "Start Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Heavitas", 11.9999981F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(353, 263);
            label6.Name = "label6";
            label6.Size = new Size(98, 21);
            label6.TabIndex = 0;
            label6.Text = "End Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Heavitas", 11.9999981F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(353, 297);
            label7.Name = "label7";
            label7.Size = new Size(118, 21);
            label7.TabIndex = 0;
            label7.Text = "Total Cost";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Heavitas", 11.9999981F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(350, 331);
            label8.Name = "label8";
            label8.Size = new Size(176, 21);
            label8.TabIndex = 0;
            label8.Text = "Payment Method";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Heavitas", 45.9998F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(312, 80);
            label9.TabIndex = 0;
            label9.Text = "Receipt";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(350, 386);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 54);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buttonPrint
            // 
            buttonPrint.BackColor = Color.SlateBlue;
            buttonPrint.Cursor = Cursors.Hand;
            buttonPrint.FlatAppearance.BorderColor = Color.Red;
            buttonPrint.FlatAppearance.BorderSize = 0;
            buttonPrint.FlatStyle = FlatStyle.Flat;
            buttonPrint.Font = new Font("Heavitas", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPrint.ForeColor = Color.White;
            buttonPrint.Location = new Point(334, 472);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.RightToLeft = RightToLeft.No;
            buttonPrint.Size = new Size(240, 27);
            buttonPrint.TabIndex = 24;
            buttonPrint.Text = "Print";
            buttonPrint.UseVisualStyleBackColor = false;
            buttonPrint.Click += buttonPrint_Click_1;
            // 
            // UserReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(941, 538);
            Controls.Add(buttonPrint);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserReceipt";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox1;
        private Button buttonPrint;
    }
}