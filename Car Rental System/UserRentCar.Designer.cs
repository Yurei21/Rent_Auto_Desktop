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
            button1 = new Button();
            labelPlate = new Label();
            labelStatus = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heavitas", 35F);
            label1.ForeColor = Color.PaleGreen;
            label1.Location = new Point(240, 15);
            label1.Name = "label1";
            label1.Size = new Size(420, 76);
            label1.TabIndex = 17;
            label1.Text = "Rent a car";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(18, 188);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(335, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Heavitas", 15F);
            label2.ForeColor = Color.SlateBlue;
            label2.Location = new Point(18, 149);
            label2.Name = "label2";
            label2.Size = new Size(113, 33);
            label2.TabIndex = 18;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Heavitas", 25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 93);
            label3.Name = "label3";
            label3.Size = new Size(183, 54);
            label3.TabIndex = 19;
            label3.Text = "Brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Heavitas", 9F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(451, 189);
            label4.Name = "label4";
            label4.Size = new Size(186, 20);
            label4.TabIndex = 19;
            label4.Text = "Starting Rent Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(445, 217);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(385, 27);
            dateTimePicker1.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Heavitas", 9F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(451, 259);
            label5.Name = "label5";
            label5.Size = new Size(168, 20);
            label5.TabIndex = 19;
            label5.Text = "Ending Rent Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(445, 287);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(385, 27);
            dateTimePicker2.TabIndex = 21;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Heavitas", 15F);
            label6.ForeColor = Color.Plum;
            label6.Location = new Point(451, 453);
            label6.Name = "label6";
            label6.Size = new Size(193, 33);
            label6.TabIndex = 17;
            label6.Text = "Total Price";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cash" });
            comboBox1.Location = new Point(444, 360);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(383, 28);
            comboBox1.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Heavitas", 15F);
            label7.ForeColor = Color.LimeGreen;
            label7.Location = new Point(445, 321);
            label7.Name = "label7";
            label7.Size = new Size(277, 33);
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
            Transaction.Location = new Point(445, 625);
            Transaction.Margin = new Padding(3, 4, 3, 4);
            Transaction.Name = "Transaction";
            Transaction.RightToLeft = RightToLeft.No;
            Transaction.Size = new Size(385, 36);
            Transaction.TabIndex = 23;
            Transaction.Text = "Pay now";
            Transaction.UseVisualStyleBackColor = false;
            Transaction.Click += Transaction_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Heavitas", 9F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(13, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 43);
            button1.TabIndex = 24;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelPlate
            // 
            labelPlate.AutoSize = true;
            labelPlate.Font = new Font("Heavitas", 12F);
            labelPlate.ForeColor = Color.White;
            labelPlate.Location = new Point(19, 488);
            labelPlate.Name = "labelPlate";
            labelPlate.Size = new Size(180, 26);
            labelPlate.TabIndex = 25;
            labelPlate.Text = "Plate Number";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Heavitas", 12F);
            labelStatus.ForeColor = Color.White;
            labelStatus.Location = new Point(19, 581);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(96, 26);
            labelStatus.TabIndex = 25;
            labelStatus.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Heavitas", 15F);
            label8.ForeColor = Color.SlateBlue;
            label8.Location = new Point(19, 453);
            label8.Name = "label8";
            label8.Size = new Size(226, 33);
            label8.TabIndex = 18;
            label8.Text = "Plate Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Heavitas", 15F);
            label9.ForeColor = Color.SlateBlue;
            label9.Location = new Point(19, 547);
            label9.Name = "label9";
            label9.Size = new Size(318, 33);
            label9.TabIndex = 18;
            label9.Text = "Availability Status";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(192, 0, 0);
            label10.Location = new Point(532, 581);
            label10.Name = "label10";
            label10.Size = new Size(220, 34);
            label10.TabIndex = 26;
            label10.Text = "WARNING: THERE WILL BE A LATE\r\nFEE OF  ₱ 3000 per day\r\n";
            // 
            // UserRentCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            Controls.Add(label10);
            Controls.Add(labelStatus);
            Controls.Add(labelPlate);
            Controls.Add(button1);
            Controls.Add(Transaction);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "UserRentCar";
            Size = new Size(904, 712);
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
        private Button button1;
        private Label labelPlate;
        private Label labelStatus;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
