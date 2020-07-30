namespace EntityFramework
{
    partial class AddProduct
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
            this.vendortextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brandtextBox = new System.Windows.Forms.TextBox();
            this.numbertextBox = new System.Windows.Forms.TextBox();
            this.descriptiontextBox = new System.Windows.Forms.TextBox();
            this.quantitytextBox = new System.Windows.Forms.TextBox();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vendortextBox
            // 
            this.vendortextBox.Location = new System.Drawing.Point(152, 24);
            this.vendortextBox.Name = "vendortextBox";
            this.vendortextBox.Size = new System.Drawing.Size(210, 20);
            this.vendortextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поставщик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Наименование";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Бренд";
            // 
            // brandtextBox
            // 
            this.brandtextBox.Location = new System.Drawing.Point(152, 50);
            this.brandtextBox.Name = "brandtextBox";
            this.brandtextBox.Size = new System.Drawing.Size(210, 20);
            this.brandtextBox.TabIndex = 5;
            // 
            // numbertextBox
            // 
            this.numbertextBox.Location = new System.Drawing.Point(152, 76);
            this.numbertextBox.Name = "numbertextBox";
            this.numbertextBox.Size = new System.Drawing.Size(210, 20);
            this.numbertextBox.TabIndex = 6;
            // 
            // descriptiontextBox
            // 
            this.descriptiontextBox.Location = new System.Drawing.Point(152, 103);
            this.descriptiontextBox.Name = "descriptiontextBox";
            this.descriptiontextBox.Size = new System.Drawing.Size(210, 20);
            this.descriptiontextBox.TabIndex = 7;
            // 
            // quantitytextBox
            // 
            this.quantitytextBox.Location = new System.Drawing.Point(152, 130);
            this.quantitytextBox.Name = "quantitytextBox";
            this.quantitytextBox.Size = new System.Drawing.Size(210, 20);
            this.quantitytextBox.TabIndex = 8;
            // 
            // pricetextBox
            // 
            this.pricetextBox.Location = new System.Drawing.Point(152, 156);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Size = new System.Drawing.Size(210, 20);
            this.pricetextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Цена";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить товар";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 267);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pricetextBox);
            this.Controls.Add(this.quantitytextBox);
            this.Controls.Add(this.descriptiontextBox);
            this.Controls.Add(this.numbertextBox);
            this.Controls.Add(this.brandtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vendortextBox);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vendortextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox brandtextBox;
        private System.Windows.Forms.TextBox numbertextBox;
        private System.Windows.Forms.TextBox descriptiontextBox;
        private System.Windows.Forms.TextBox quantitytextBox;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}