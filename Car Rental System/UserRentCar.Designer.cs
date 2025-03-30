namespace Car_Rental_System
{
    partial class UserRentCar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            Transaction = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heavitas", 35F);
            label1.ForeColor = Color.PaleGreen;
            label1.Location = new Point(237, 9);
            label1.Name = "label1";
            label1.Size = new Size(336, 61);
            label1.TabIndex = 17;
            label1.Text = "Rent a car";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Heavitas", 15F);
            label2.ForeColor = Color.SlateBlue;
            label2.Location = new Point(16, 112);
            label2.Name = "label2";
            label2.Size = new Size(89, 26);
            label2.TabIndex = 18;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Heavitas", 25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 70);
            label3.Name = "label3";
            label3.Size = new Size(152, 45);
            label3.TabIndex = 19;
            label3.Text = "Brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Heavitas", 9F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(395, 142);
            label4.Name = "label4";
            label4.Size = new Size(144, 16);
            label4.TabIndex = 19;
            label4.Text = "Starting Rent Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(389, 163);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(337, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Heavitas", 9F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(395, 194);
            label5.Name = "label5";
            label5.Size = new Size(132, 16);
            label5.TabIndex = 19;
            label5.Text = "Ending Rent Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(389, 215);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(337, 23);
            dateTimePicker2.TabIndex = 21;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Heavitas", 15F);
            label6.ForeColor = Color.Plum;
            label6.Location = new Point(478, 365);
            label6.Name = "label6";
            label6.Size = new Size(153, 26);
            label6.TabIndex = 17;
            label6.Text = "Total Price";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cash", "Credit Card", "Online" });
            comboBox1.Location = new Point(387, 270);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(337, 23);
            comboBox1.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Heavitas", 15F);
            label7.ForeColor = Color.LimeGreen;
            label7.Location = new Point(389, 241);
            label7.Name = "label7";
            label7.Size = new Size(218, 26);
            label7.TabIndex = 17;
            label7.Text = "Payment Method";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // Transaction
            // 
            Transaction.BackColor = Color.SlateBlue;
            Transaction.Cursor = Cursors.Hand;
            Transaction.FlatAppearance.BorderColor = Color.Red;
            Transaction.FlatAppearance.BorderSize = 0;
            Transaction.FlatStyle = FlatStyle.Flat;
            Transaction.Font = new Font("Heavitas", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Transaction.ForeColor = Color.White;
            Transaction.Location = new Point(389, 469);
            Transaction.Name = "Transaction";
            Transaction.RightToLeft = RightToLeft.No;
            Transaction.Size = new Size(337, 27);
            Transaction.TabIndex = 23;
            Transaction.Text = "Pay now";
            Transaction.UseVisualStyleBackColor = false;
            Transaction.Click += Transaction_Click;
            // 
            // UserRentCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            Controls.Add(Transaction);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserRentCar";
            Size = new Size(791, 534);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Label label6;
        private ComboBox comboBox1;
        private Label label7;
        private Button Transaction;
    }
}
