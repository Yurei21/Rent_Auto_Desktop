namespace Car_Rental_System
{
    partial class UserReturn
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
            textBox1 = new TextBox();
            buttonPrint = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heavitas", 45.9998F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(594, 80);
            label1.TabIndex = 1;
            label1.Text = "Returning Car";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(307, 451);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 23);
            textBox1.TabIndex = 2;
            // 
            // buttonPrint
            // 
            buttonPrint.BackColor = Color.SlateBlue;
            buttonPrint.Cursor = Cursors.Hand;
            buttonPrint.FlatAppearance.BorderColor = Color.Red;
            buttonPrint.FlatAppearance.BorderSize = 0;
            buttonPrint.FlatStyle = FlatStyle.Flat;
            buttonPrint.Font = new Font("Heavitas", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPrint.ForeColor = Color.White;
            buttonPrint.Location = new Point(629, 451);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.RightToLeft = RightToLeft.No;
            buttonPrint.Size = new Size(240, 27);
            buttonPrint.TabIndex = 25;
            buttonPrint.Text = "Print";
            buttonPrint.UseVisualStyleBackColor = false;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // UserReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            Controls.Add(buttonPrint);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "UserReturn";
            Size = new Size(941, 538);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button buttonPrint;
    }
}
