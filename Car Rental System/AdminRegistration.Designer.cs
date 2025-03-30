namespace Car_Rental_System
{
    partial class AdminRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRegistration));
            label5 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            Register = new Button();
            closeButton = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(296, 296);
            label5.Name = "label5";
            label5.Size = new Size(81, 16);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(297, 314);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(378, 23);
            textBox3.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(297, 243);
            label2.Name = "label2";
            label2.Size = new Size(46, 16);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(298, 192);
            label1.Name = "label1";
            label1.Size = new Size(78, 16);
            label1.TabIndex = 8;
            label1.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(298, 261);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(378, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(299, 210);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 23);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(296, 346);
            label3.Name = "label3";
            label3.Size = new Size(128, 16);
            label3.TabIndex = 12;
            label3.Text = "Code to proceed";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(297, 364);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(378, 23);
            textBox4.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Heavitas", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(141, 1);
            label6.Name = "label6";
            label6.Size = new Size(536, 154);
            label6.TabIndex = 14;
            label6.Text = "REGISTRATION \r\nAdmin\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
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
            Register.Location = new Point(402, 433);
            Register.Name = "Register";
            Register.Size = new Size(177, 46);
            Register.TabIndex = 16;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click;
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI", 9F);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(897, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(42, 44);
            closeButton.TabIndex = 15;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.White;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(470, 537);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(43, 15);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign In";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AdminRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(951, 577);
            Controls.Add(linkLabel1);
            Controls.Add(Register);
            Controls.Add(closeButton);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox textBox3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox4;
        private Label label6;
        private PictureBox pictureBox1;
        private Button Register;
        private Button closeButton;
        private LinkLabel linkLabel1;
    }
}