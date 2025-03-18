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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            Register.Location = new Point(721, 304);
            Register.Name = "Register";
            Register.Size = new Size(177, 46);
            Register.TabIndex = 13;
            Register.Text = "Submit";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click;
            // 
            // Verification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(941, 538);
            Controls.Add(Register);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(closeButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Verification";
            Text = "Verification";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton;
        private PictureBox pictureBox1;
        private Label label6;
        private Button Register;
    }
}