namespace Car_Rental_System
{
    partial class UserRentCar
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heavitas", 35F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(336, 61);
            label1.TabIndex = 17;
            label1.Text = "Rent a car";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // UserRentCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserRentCar";
            Size = new Size(791, 534);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
