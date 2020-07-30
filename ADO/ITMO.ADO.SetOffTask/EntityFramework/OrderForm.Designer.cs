namespace EntityFramework
{
    partial class OrderForm
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
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.makeAnOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderGridView
            // 
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(12, 70);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.Size = new System.Drawing.Size(775, 285);
            this.orderGridView.TabIndex = 0;
            // 
            // makeAnOrder
            // 
            this.makeAnOrder.Location = new System.Drawing.Point(351, 415);
            this.makeAnOrder.Name = "makeAnOrder";
            this.makeAnOrder.Size = new System.Drawing.Size(106, 23);
            this.makeAnOrder.TabIndex = 1;
            this.makeAnOrder.Text = "Оформить заказ";
            this.makeAnOrder.UseVisualStyleBackColor = true;
            this.makeAnOrder.Click += new System.EventHandler(this.makeAnOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбрать клиента";
            // 
            // clientTextBox
            // 
            this.clientTextBox.Location = new System.Drawing.Point(113, 17);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.Size = new System.Drawing.Size(173, 20);
            this.clientTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.makeAnOrder);
            this.Controls.Add(this.orderGridView);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.Button makeAnOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.Label label2;
    }
}