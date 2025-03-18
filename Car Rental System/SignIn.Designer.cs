namespace Car_Rental_System
{
    partial class SignIn
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            signinButton = new Button();
            linkLabel1 = new LinkLabel();
            closeButton = new Button();
            linkLabel2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.r__1_;
            pictureBox1.Location = new Point(266, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(265, 290);
            label2.Name = "label2";
            label2.Size = new Size(46, 16);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(266, 308);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(402, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(264, 347);
            label1.Name = "label1";
            label1.Size = new Size(81, 16);
            label1.TabIndex = 6;
            label1.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(265, 365);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(402, 23);
            textBox2.TabIndex = 5;
            // 
            // signinButton
            // 
            signinButton.BackColor = Color.DarkSlateBlue;
            signinButton.Cursor = Cursors.Hand;
            signinButton.FlatAppearance.BorderSize = 0;
            signinButton.FlatStyle = FlatStyle.Flat;
            signinButton.Font = new Font("Heavitas", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signinButton.ForeColor = Color.White;
            signinButton.Location = new Point(385, 424);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(177, 46);
            signinButton.TabIndex = 7;
            signinButton.Text = "Sign In";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.White;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(264, 493);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Admin Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(904, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(25, 25);
            closeButton.TabIndex = 9;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.White;
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(618, 493);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(49, 15);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Register";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(941, 538);
            ControlBox = false;
            Controls.Add(closeButton);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(signinButton);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Button signinButton;
        private LinkLabel linkLabel1;
        private Button closeButton;
        private LinkLabel linkLabel2;
    }
}