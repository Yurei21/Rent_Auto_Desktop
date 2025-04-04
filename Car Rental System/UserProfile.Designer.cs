namespace Car_Rental_System
{
    partial class UserProfile
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heavitas", 35F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(237, 61);
            label1.TabIndex = 17;
            label1.Text = "Profile";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Heavitas", 18F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 127);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 19;
            label2.Text = "Name";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Heavitas", 14F);
            label3.ForeColor = Color.SlateBlue;
            label3.Location = new Point(38, 176);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 20;
            label3.Text = "Details";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Heavitas", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(42, 216);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 21;
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Heavitas", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(42, 257);
            label5.Name = "label5";
            label5.Size = new Size(153, 21);
            label5.TabIndex = 22;
            label5.Text = "Phone Number";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Heavitas", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(42, 301);
            label6.Name = "label6";
            label6.Size = new Size(149, 21);
            label6.TabIndex = 23;
            label6.Text = "Home Address";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(397, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(357, 169);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(397, 283);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(357, 169);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserProfile";
            Size = new Size(791, 534);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
