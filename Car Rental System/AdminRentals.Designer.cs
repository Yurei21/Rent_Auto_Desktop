namespace Car_Rental_System
{
    partial class AdminRentals
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            cmbStatusFilter = new ComboBox();
            cmbPaymentFilter = new ComboBox();
            txtSearch = new TextBox();
            btnFilter = new Button();
            button1 = new Button();
            label2 = new Label();
            Filter = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(18, 18, 18);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.SlateBlue;
            dataGridView1.Location = new Point(12, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(764, 398);
            dataGridView1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heavitas", 35F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(482, 61);
            label1.TabIndex = 21;
            label1.Text = "Rental Records";
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Location = new Point(302, 95);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(140, 23);
            cmbStatusFilter.TabIndex = 22;
            // 
            // cmbPaymentFilter
            // 
            cmbPaymentFilter.FormattingEnabled = true;
            cmbPaymentFilter.Location = new Point(457, 95);
            cmbPaymentFilter.Name = "cmbPaymentFilter";
            cmbPaymentFilter.Size = new Size(140, 23);
            cmbPaymentFilter.TabIndex = 23;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(19, 95);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(267, 23);
            txtSearch.TabIndex = 24;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.SlateBlue;
            btnFilter.FlatStyle = FlatStyle.Popup;
            btnFilter.Font = new Font("Heavitas", 9F);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(613, 95);
            btnFilter.Margin = new Padding(3, 2, 3, 2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(86, 23);
            btnFilter.TabIndex = 25;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Heavitas", 9F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(705, 95);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(62, 23);
            button1.TabIndex = 26;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Heavitas", 9F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 76);
            label2.Name = "label2";
            label2.Size = new Size(58, 16);
            label2.TabIndex = 27;
            label2.Text = "Search";
            // 
            // Filter
            // 
            Filter.AutoSize = true;
            Filter.Font = new Font("Heavitas", 9F);
            Filter.ForeColor = Color.White;
            Filter.Location = new Point(296, 76);
            Filter.Name = "Filter";
            Filter.Size = new Size(138, 16);
            Filter.TabIndex = 28;
            Filter.Text = "Filter rent status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Heavitas", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(457, 76);
            label3.Name = "label3";
            label3.Size = new Size(121, 16);
            label3.TabIndex = 29;
            label3.Text = "Payment Status";
            // 
            // AdminRentals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            Controls.Add(label3);
            Controls.Add(Filter);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(btnFilter);
            Controls.Add(txtSearch);
            Controls.Add(cmbPaymentFilter);
            Controls.Add(cmbStatusFilter);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "AdminRentals";
            Size = new Size(791, 534);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox cmbStatusFilter;
        private ComboBox cmbPaymentFilter;
        private TextBox txtSearch;
        private Button btnFilter;
        private Button button1;
        private Label label2;
        private Label Filter;
        private Label label3;
    }
}
