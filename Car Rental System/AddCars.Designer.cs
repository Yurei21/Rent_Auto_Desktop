﻿namespace Car_Rental_System
{
    partial class AddCars
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
            label6 = new Label();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            Register = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Heavitas", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(400, 77);
            label6.TabIndex = 13;
            label6.Text = "Add a car";
            // 
            // button1
            // 
            button1.BackColor = Color.SlateBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Heavitas", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(511, 368);
            button1.Name = "button1";
            button1.Size = new Size(181, 71);
            button1.TabIndex = 14;
            button1.Text = "Upload a picture of a car";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 266);
            label4.Name = "label4";
            label4.Size = new Size(44, 16);
            label4.TabIndex = 18;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 218);
            label3.Name = "label3";
            label3.Size = new Size(104, 16);
            label3.TabIndex = 19;
            label3.Text = "Plate Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 167);
            label2.Name = "label2";
            label2.Size = new Size(51, 16);
            label2.TabIndex = 20;
            label2.Text = "Brand";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 116);
            label1.Name = "label1";
            label1.Size = new Size(52, 16);
            label1.TabIndex = 21;
            label1.Text = "Model";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(25, 284);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(378, 23);
            textBox4.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(25, 236);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(378, 23);
            textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(24, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(378, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 23);
            textBox1.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(25, 312);
            label5.Name = "label5";
            label5.Size = new Size(55, 16);
            label5.TabIndex = 18;
            label5.Text = "Status";
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Available", "Rented", "Under Maintenance" });
            comboBox1.Location = new Point(26, 332);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(377, 23);
            comboBox1.TabIndex = 23;
            // 
            // Register
            // 
            Register.BackColor = Color.SlateBlue;
            Register.Cursor = Cursors.Hand;
            Register.FlatAppearance.BorderColor = Color.Red;
            Register.FlatAppearance.BorderSize = 0;
            Register.FlatStyle = FlatStyle.Flat;
            Register.Font = new Font("Heavitas", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Register.ForeColor = Color.White;
            Register.Location = new Point(111, 393);
            Register.Name = "Register";
            Register.Size = new Size(181, 46);
            Register.TabIndex = 24;
            Register.Text = "Submit";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(421, 105);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // AddCars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            Controls.Add(pictureBox1);
            Controls.Add(Register);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Name = "AddCars";
            Size = new Size(775, 538);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private ComboBox comboBox1;
        private Button Register;
        private PictureBox pictureBox1;
    }
}