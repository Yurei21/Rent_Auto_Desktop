namespace Car_Rental_System
{
    partial class AdminEditCar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            Modify = new Button();
            DELETE = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            Maintenance = new Button();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label11 = new Label();
            textBox5 = new TextBox();
            label12 = new Label();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(33, 445);
            label4.Name = "label4";
            label4.Size = new Size(55, 16);
            label4.TabIndex = 2;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(33, 374);
            label3.Name = "label3";
            label3.Size = new Size(44, 16);
            label3.TabIndex = 3;
            label3.Text = "price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 335);
            label2.Name = "label2";
            label2.Size = new Size(52, 16);
            label2.TabIndex = 4;
            label2.Text = "Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heavitas", 25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 45);
            label1.TabIndex = 5;
            label1.Text = "Brand";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(33, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Heavitas", 9F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(34, 294);
            label5.Name = "label5";
            label5.Size = new Size(51, 16);
            label5.TabIndex = 5;
            label5.Text = "Brand";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 291);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 332);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(91, 371);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 23);
            textBox3.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Available", "Rented", "Under Maintenance" });
            comboBox1.Location = new Point(91, 442);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 23);
            comboBox1.TabIndex = 8;
            // 
            // Modify
            // 
            Modify.BackColor = Color.SlateBlue;
            Modify.Cursor = Cursors.Hand;
            Modify.FlatAppearance.BorderColor = Color.Red;
            Modify.FlatAppearance.BorderSize = 0;
            Modify.FlatStyle = FlatStyle.Flat;
            Modify.Font = new Font("Heavitas", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Modify.ForeColor = Color.White;
            Modify.Location = new Point(33, 483);
            Modify.Name = "Modify";
            Modify.RightToLeft = RightToLeft.No;
            Modify.Size = new Size(104, 27);
            Modify.TabIndex = 18;
            Modify.Text = "Modify";
            Modify.UseVisualStyleBackColor = false;
            Modify.Click += Modify_Click;
            // 
            // DELETE
            // 
            DELETE.BackColor = Color.SlateBlue;
            DELETE.Cursor = Cursors.Hand;
            DELETE.FlatAppearance.BorderColor = Color.Red;
            DELETE.FlatAppearance.BorderSize = 0;
            DELETE.FlatStyle = FlatStyle.Flat;
            DELETE.Font = new Font("Heavitas", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DELETE.ForeColor = Color.White;
            DELETE.Location = new Point(223, 483);
            DELETE.Name = "DELETE";
            DELETE.RightToLeft = RightToLeft.No;
            DELETE.Size = new Size(104, 27);
            DELETE.TabIndex = 18;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = false;
            DELETE.Click += Delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(18, 18, 18);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.SlateBlue;
            dataGridView1.Location = new Point(390, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(359, 178);
            dataGridView1.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Heavitas", 20F);
            label6.ForeColor = Color.Tomato;
            label6.Location = new Point(390, 45);
            label6.Name = "label6";
            label6.Size = new Size(364, 36);
            label6.TabIndex = 5;
            label6.Text = "maintenance Record";
            // 
            // Maintenance
            // 
            Maintenance.BackColor = Color.SlateBlue;
            Maintenance.Cursor = Cursors.Hand;
            Maintenance.FlatAppearance.BorderColor = Color.Red;
            Maintenance.FlatAppearance.BorderSize = 0;
            Maintenance.FlatStyle = FlatStyle.Flat;
            Maintenance.Font = new Font("Heavitas", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Maintenance.ForeColor = Color.White;
            Maintenance.Location = new Point(398, 438);
            Maintenance.Name = "Maintenance";
            Maintenance.RightToLeft = RightToLeft.No;
            Maintenance.Size = new Size(359, 27);
            Maintenance.TabIndex = 18;
            Maintenance.Text = "Add a maintenance record";
            Maintenance.UseVisualStyleBackColor = false;
            Maintenance.Click += Maintenance_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(27, 404);
            label7.Name = "label7";
            label7.Size = new Size(61, 32);
            label7.TabIndex = 3;
            label7.Text = "Plate\r\nNumber\r\n";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(91, 407);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(236, 23);
            textBox4.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Heavitas", 15F);
            label8.ForeColor = Color.SlateBlue;
            label8.Location = new Point(33, 55);
            label8.Name = "label8";
            label8.Size = new Size(89, 26);
            label8.TabIndex = 5;
            label8.Text = "Model";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(417, 767);
            label9.Name = "label9";
            label9.Size = new Size(52, 16);
            label9.TabIndex = 4;
            label9.Text = "Model";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Heavitas", 9F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(399, 306);
            label10.Name = "label10";
            label10.Size = new Size(102, 32);
            label10.TabIndex = 5;
            label10.Text = "Maintenance\r\ndate\r\n";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(516, 311);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 23);
            dateTimePicker1.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Heavitas", 9F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(402, 355);
            label11.Name = "label11";
            label11.Size = new Size(59, 16);
            label11.TabIndex = 5;
            label11.Text = "Details";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(475, 352);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(274, 23);
            textBox5.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Heavitas", 9F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(402, 398);
            label12.Name = "label12";
            label12.Size = new Size(41, 16);
            label12.TabIndex = 5;
            label12.Text = "Cost";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(475, 395);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(274, 23);
            textBox6.TabIndex = 21;
            // 
            // AdminEditCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(Maintenance);
            Controls.Add(DELETE);
            Controls.Add(Modify);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "AdminEditCar";
            Size = new Size(791, 534);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Button Modify;
        private Button DELETE;
        private DataGridView dataGridView1;
        private Label label6;
        private Button Maintenance;
        private Label label7;
        private TextBox textBox4;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private TextBox textBox5;
        private Label label12;
        private TextBox textBox6;
    }
}
