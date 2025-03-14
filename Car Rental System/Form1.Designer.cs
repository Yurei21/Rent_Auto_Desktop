namespace Car_Rental_System
{
    partial class Landing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            signinButton = new Button();
            Register = new Button();
            SuspendLayout();
            // 
            // signinButton
            // 
            signinButton.BackColor = Color.DarkSlateBlue;
            signinButton.Cursor = Cursors.Hand;
            signinButton.Font = new Font("Heavitas", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signinButton.ForeColor = Color.White;
            signinButton.Location = new Point(253, 238);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(177, 46);
            signinButton.TabIndex = 0;
            signinButton.Text = "Sign In";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += button1_Click;
            // 
            // Register
            // 
            Register.BackColor = Color.SlateBlue;
            Register.Cursor = Cursors.Hand;
            Register.FlatAppearance.BorderColor = Color.Red;
            Register.FlatAppearance.BorderSize = 0;
            Register.Font = new Font("Heavitas", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Register.ForeColor = Color.White;
            Register.Location = new Point(452, 238);
            Register.Name = "Register";
            Register.Size = new Size(177, 46);
            Register.TabIndex = 1;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;
            // 
            // Landing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(881, 441);
            Controls.Add(Register);
            Controls.Add(signinButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Landing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rent_an_auto";
            ResumeLayout(false);
        }

        #endregion

        private Button signinButton;
        private Button Register;
    }
}
