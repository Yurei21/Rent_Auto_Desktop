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
            label6 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox2 = new TextBox();
            Register = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Heavitas", 35F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 14);
            label6.Name = "label6";
            label6.Size = new Size(635, 61);
            label6.TabIndex = 14;
            label6.Text = "Maintenance record";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(195, 174);
            label1.Name = "label1";
            label1.Size = new Size(161, 16);
            label1.TabIndex = 22;
            label1.Text = "Date of Maintenance";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 249);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 23);
            textBox1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(195, 230);
            label2.Name = "label2";
            label2.Size = new Size(98, 16);
            label2.TabIndex = 22;
            label2.Text = "Information";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(195, 193);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(378, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(195, 287);
            label3.Name = "label3";
            label3.Size = new Size(41, 16);
            label3.TabIndex = 22;
            label3.Text = "Cost";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 306);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(378, 23);
            textBox2.TabIndex = 23;
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
            Register.Location = new Point(300, 364);
            Register.Name = "Register";
            Register.Size = new Size(181, 46);
            Register.TabIndex = 25;
            Register.Text = "Submit";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click;
            // 
            // AddMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            Controls.Add(Register);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Name = "AddMaintenance";
            Size = new Size(775, 538);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox2;
        private Button Register;
    }
}
