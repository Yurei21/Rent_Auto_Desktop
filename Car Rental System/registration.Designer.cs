namespace Car_Rental_System
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            closeButton = new Button();
            Register = new Button();
            checkBoxShowPassword = new CheckBox();
            labelEmailError = new Label();
            labelPhoneError = new Label();
            labelPasswordError = new Label();
            button1 = new Button();
            textBox6 = new TextBox();
            label7 = new Label();
            labelNameError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -11);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 277);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(431, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(173, 253);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 345);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(431, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(171, 321);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(174, 412);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(431, 27);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(173, 388);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(174, 476);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(431, 27);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(173, 452);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 2;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(173, 516);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(174, 540);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(431, 27);
            textBox5.TabIndex = 3;
            textBox5.UseSystemPasswordChar = true;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Heavitas", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(269, 16);
            label6.Name = "label6";
            label6.Size = new Size(646, 97);
            label6.TabIndex = 2;
            label6.Text = "REGISTRATION";
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI", 9F);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(1035, 16);
            closeButton.Margin = new Padding(3, 4, 3, 4);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(48, 59);
            closeButton.TabIndex = 5;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
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
            Register.Location = new Point(171, 661);
            Register.Margin = new Padding(3, 4, 3, 4);
            Register.Name = "Register";
            Register.Size = new Size(433, 44);
            Register.TabIndex = 6;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.ForeColor = Color.White;
            checkBoxShowPassword.Location = new Point(613, 543);
            checkBoxShowPassword.Margin = new Padding(3, 4, 3, 4);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(134, 24);
            checkBoxShowPassword.TabIndex = 8;
            checkBoxShowPassword.Text = "Show password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // labelEmailError
            // 
            labelEmailError.AutoSize = true;
            labelEmailError.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmailError.ForeColor = Color.Red;
            labelEmailError.Location = new Point(253, 380);
            labelEmailError.Name = "labelEmailError";
            labelEmailError.Size = new Size(0, 20);
            labelEmailError.TabIndex = 9;
            labelEmailError.Visible = false;
            labelEmailError.Click += labelEmailError_Click;
            // 
            // labelPhoneError
            // 
            labelPhoneError.AutoSize = true;
            labelPhoneError.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPhoneError.ForeColor = Color.Red;
            labelPhoneError.Location = new Point(275, 447);
            labelPhoneError.Name = "labelPhoneError";
            labelPhoneError.Size = new Size(0, 20);
            labelPhoneError.TabIndex = 10;
            labelPhoneError.Visible = false;
            // 
            // labelPasswordError
            // 
            labelPasswordError.AutoSize = true;
            labelPasswordError.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPasswordError.ForeColor = Color.Red;
            labelPasswordError.Location = new Point(400, 580);
            labelPasswordError.Name = "labelPasswordError";
            labelPasswordError.Size = new Size(0, 20);
            labelPasswordError.TabIndex = 11;
            labelPasswordError.Visible = false;
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
            button1.Location = new Point(691, 395);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(344, 48);
            button1.TabIndex = 6;
            button1.Text = "have an account?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(173, 605);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(431, 27);
            textBox6.TabIndex = 12;
            textBox6.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(173, 580);
            label7.Name = "label7";
            label7.Size = new Size(190, 20);
            label7.TabIndex = 4;
            label7.Text = "Confirm Password";
            // 
            // labelNameError
            // 
            labelNameError.Font = new Font("Heavitas", 8.999999F);
            labelNameError.ForeColor = Color.Red;
            labelNameError.Location = new Point(253, 246);
            labelNameError.Name = "labelNameError";
            labelNameError.Size = new Size(335, 27);
            labelNameError.TabIndex = 0;
            labelNameError.Visible = false;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1087, 769);
            Controls.Add(labelNameError);
            Controls.Add(textBox6);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(button1);
            Controls.Add(Register);
            Controls.Add(closeButton);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(labelEmailError);
            Controls.Add(labelPhoneError);
            Controls.Add(labelPasswordError);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Button closeButton;
        private Button Register;
        private CheckBox checkBoxShowPassword;
        private Label labelEmailError;
        private Label labelPhoneError;
        private Label labelPasswordError;
        private Button button1;
        private TextBox textBox6;
        private Label label7;
        private Label labelNameError;
    }
}