namespace EntityFramework
{
    partial class ReportsForm
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
            this.repGridView = new System.Windows.Forms.DataGridView();
            this.custRepButton = new System.Windows.Forms.Button();
            this.prodRepButton = new System.Windows.Forms.Button();
            this.salesRepButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SoldProdsRepButton = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // repGridView
            // 
            this.repGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.repGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repGridView.Location = new System.Drawing.Point(12, 115);
            this.repGridView.Name = "repGridView";
            this.repGridView.Size = new System.Drawing.Size(775, 238);
            this.repGridView.TabIndex = 0;
            // 
            // custRepButton
            // 
            this.custRepButton.Location = new System.Drawing.Point(29, 12);
            this.custRepButton.Name = "custRepButton";
            this.custRepButton.Size = new System.Drawing.Size(75, 23);
            this.custRepButton.TabIndex = 1;
            this.custRepButton.Text = "Покупатели";
            this.custRepButton.UseVisualStyleBackColor = true;
            this.custRepButton.Click += new System.EventHandler(this.custRepButton_Click);
            // 
            // prodRepButton
            // 
            this.prodRepButton.Location = new System.Drawing.Point(29, 41);
            this.prodRepButton.Name = "prodRepButton";
            this.prodRepButton.Size = new System.Drawing.Size(75, 23);
            this.prodRepButton.TabIndex = 2;
            this.prodRepButton.Text = "Товары";
            this.prodRepButton.UseVisualStyleBackColor = true;
            this.prodRepButton.Click += new System.EventHandler(this.prodRepButton_Click);
            // 
            // salesRepButton
            // 
            this.salesRepButton.Location = new System.Drawing.Point(11, 59);
            this.salesRepButton.Name = "salesRepButton";
            this.salesRepButton.Size = new System.Drawing.Size(89, 23);
            this.salesRepButton.TabIndex = 3;
            this.salesRepButton.Text = "Заказы";
            this.salesRepButton.UseVisualStyleBackColor = true;
            this.salesRepButton.Click += new System.EventHandler(this.salesRepButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SoldProdsRepButton);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.salesRepButton);
            this.groupBox1.Location = new System.Drawing.Point(120, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отчет по продажам";
            // 
            // SoldProdsRepButton
            // 
            this.SoldProdsRepButton.Location = new System.Drawing.Point(106, 59);
            this.SoldProdsRepButton.Name = "SoldProdsRepButton";
            this.SoldProdsRepButton.Size = new System.Drawing.Size(79, 23);
            this.SoldProdsRepButton.TabIndex = 8;
            this.SoldProdsRepButton.Text = "Артикулы";
            this.SoldProdsRepButton.UseVisualStyleBackColor = true;
            this.SoldProdsRepButton.Click += new System.EventHandler(this.SoldProdsRepButton_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(178, 24);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(89, 20);
            this.dateTimePicker3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "По";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(56, 24);
            this.dateTimePicker2.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(89, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "С даты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(449, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "l";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.prodRepButton);
            this.Controls.Add(this.custRepButton);
            this.Controls.Add(this.repGridView);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.repGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView repGridView;
        private System.Windows.Forms.Button custRepButton;
        private System.Windows.Forms.Button prodRepButton;
        private System.Windows.Forms.Button salesRepButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button SoldProdsRepButton;
        private System.Windows.Forms.Label label3;
    }
}