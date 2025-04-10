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
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
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
            textBox1.Location = new Point(252, 223);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
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
            buttonPrint.Location = new Point(252, 325);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.RightToLeft = RightToLeft.No;
            buttonPrint.Size = new Size(248, 27);
            buttonPrint.TabIndex = 25;
            buttonPrint.Text = "Print";
            buttonPrint.UseVisualStyleBackColor = false;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(252, 204);
            label2.Name = "label2";
            label2.Size = new Size(126, 16);
            label2.TabIndex = 26;
            label2.Text = "Barcode Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Heavitas", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(252, 262);
            label3.Name = "label3";
            label3.Size = new Size(91, 16);
            label3.TabIndex = 28;
            label3.Text = "Damage Fee";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(252, 281);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 23);
            textBox2.TabIndex = 27;
            // 
            // UserReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(buttonPrint);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "UserReturn";
            Size = new Size(775, 538);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button buttonPrint;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
    }
}
