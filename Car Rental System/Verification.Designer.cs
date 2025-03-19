namespace Car_Rental_System
{
    partial class Verification
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
            closeButton = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            Register = new Button();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(904, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(25, 25);
            closeButton.TabIndex = 10;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.r__1_;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Heavitas", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(135, 25);
            label6.Name = "label6";
            label6.Size = new Size(763, 77);
            label6.TabIndex = 12;
            label6.Text = "Upload Documents ";
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
            Register.Location = new Point(721, 285);
            Register.Name = "Register";
            Register.Size = new Size(177, 46);
            Register.TabIndex = 13;
            Register.Text = "Submit";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click;
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
            button1.Location = new Point(150, 401);
            button1.Name = "button1";
            button1.Size = new Size(181, 71);
            button1.TabIndex = 13;
            button1.Text = "Upload your \r\nDriver's License";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Red;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Heavitas", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(437, 401);
            button2.Name = "button2";
            button2.Size = new Size(189, 71);
            button2.TabIndex = 13;
            button2.Text = "Upload your\r\nNational ID";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(104, 199);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(270, 165);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(396, 199);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(270, 165);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // Verification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(941, 538);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Register);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(closeButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Verification";
            Text = "Verification";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton;
        private PictureBox pictureBox1;
        private Label label6;
        private Button Register;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}