namespace Car_Rental_System
{
    partial class AddMaintenance
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
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            Register = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heavitas", 30F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(624, 52);
            label1.TabIndex = 14;
            label1.Text = "Maintenance of the car";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(300, 168);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(271, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Heavitas", 18F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(208, 164);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 22;
            label2.Text = "Date:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Heavitas", 18F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(207, 209);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 24;
            label3.Text = "Info";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(213, 244);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(358, 23);
            textBox2.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Heavitas", 18F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(212, 283);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 25;
            label4.Text = "Price";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(213, 318);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(358, 23);
            textBox4.TabIndex = 26;
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
            Register.Location = new Point(313, 371);
            Register.Name = "Register";
            Register.Size = new Size(181, 46);
            Register.TabIndex = 27;
            Register.Text = "Submit";
            Register.UseVisualStyleBackColor = false;
            // 
            // AddMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            Controls.Add(Register);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddMaintenance";
            Size = new Size(775, 538);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox4;
        private Button Register;
    }
}
