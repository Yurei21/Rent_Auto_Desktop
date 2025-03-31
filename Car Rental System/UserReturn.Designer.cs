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
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(736, 100);
            label1.TabIndex = 1;
            label1.Text = "Returning Car";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 207);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 27);
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
            buttonPrint.Location = new Point(49, 274);
            buttonPrint.Margin = new Padding(3, 4, 3, 4);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.RightToLeft = RightToLeft.No;
            buttonPrint.Size = new Size(283, 36);
            buttonPrint.TabIndex = 25;
            buttonPrint.Text = "Print";
            buttonPrint.UseVisualStyleBackColor = false;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // UserReturn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            Controls.Add(buttonPrint);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserReturn";
            Size = new Size(1075, 717);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button buttonPrint;
    }
}
