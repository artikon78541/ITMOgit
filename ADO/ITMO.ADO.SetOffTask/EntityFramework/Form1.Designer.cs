namespace EntityFramework
{
    partial class Form1
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
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.numradioButton = new System.Windows.Forms.RadioButton();
            this.descradioButton = new System.Windows.Forms.RadioButton();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.addCustomer = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toOrder = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.inCartLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.repButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(26, 15);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(342, 20);
            this.searchtextBox.TabIndex = 0;
            this.searchtextBox.Click += new System.EventHandler(this.searchtextBox_Click);
            this.searchtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchtextBox_KeyDown);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(383, 15);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // numradioButton
            // 
            this.numradioButton.AutoSize = true;
            this.numradioButton.Location = new System.Drawing.Point(26, 41);
            this.numradioButton.Name = "numradioButton";
            this.numradioButton.Size = new System.Drawing.Size(112, 17);
            this.numradioButton.TabIndex = 2;
            this.numradioButton.TabStop = true;
            this.numradioButton.Text = "Поиск по номеру";
            this.numradioButton.UseVisualStyleBackColor = true;
            // 
            // descradioButton
            // 
            this.descradioButton.AutoSize = true;
            this.descradioButton.Location = new System.Drawing.Point(144, 41);
            this.descradioButton.Name = "descradioButton";
            this.descradioButton.Size = new System.Drawing.Size(151, 17);
            this.descradioButton.TabIndex = 3;
            this.descradioButton.TabStop = true;
            this.descradioButton.Text = "Поиск по наименованию";
            this.descradioButton.UseVisualStyleBackColor = true;
            // 
            // GridView
            // 
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(26, 98);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(751, 340);
            this.GridView.TabIndex = 4;
            this.GridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellValueChanged);
            // 
            // addCustomer
            // 
            this.addCustomer.Location = new System.Drawing.Point(170, 69);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(138, 23);
            this.addCustomer.TabIndex = 5;
            this.addCustomer.Text = "Добавить покупателя";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(26, 69);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(138, 23);
            this.addProduct.TabIndex = 6;
            this.addProduct.Text = "Добавить товар";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(659, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "В заказе";
            // 
            // toOrder
            // 
            this.toOrder.Location = new System.Drawing.Point(662, 41);
            this.toOrder.Name = "toOrder";
            this.toOrder.Size = new System.Drawing.Size(115, 23);
            this.toOrder.TabIndex = 9;
            this.toOrder.Text = "К заказу";
            this.toOrder.UseVisualStyleBackColor = true;
            this.toOrder.Click += new System.EventHandler(this.toOrder_Click);
            // 
            // clearCartButton
            // 
            this.clearCartButton.Location = new System.Drawing.Point(662, 69);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(115, 23);
            this.clearCartButton.TabIndex = 11;
            this.clearCartButton.Text = "Очистить корзину";
            this.clearCartButton.UseVisualStyleBackColor = true;
            this.clearCartButton.Click += new System.EventHandler(this.clearCartButton_Click);
            // 
            // inCartLabel
            // 
            this.inCartLabel.AutoSize = true;
            this.inCartLabel.Location = new System.Drawing.Point(718, 15);
            this.inCartLabel.Name = "inCartLabel";
            this.inCartLabel.Size = new System.Drawing.Size(10, 13);
            this.inCartLabel.TabIndex = 12;
            this.inCartLabel.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(734, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "поз.";
            // 
            // repButton
            // 
            this.repButton.Location = new System.Drawing.Point(339, 69);
            this.repButton.Name = "repButton";
            this.repButton.Size = new System.Drawing.Size(75, 23);
            this.repButton.TabIndex = 14;
            this.repButton.Text = "Отчеты";
            this.repButton.UseVisualStyleBackColor = true;
            this.repButton.Click += new System.EventHandler(this.repButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Загрузка прайсов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.repButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inCartLabel);
            this.Controls.Add(this.clearCartButton);
            this.Controls.Add(this.toOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.descradioButton);
            this.Controls.Add(this.numradioButton);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.searchtextBox);
            this.Name = "Form1";
            this.Text = "Поиск запчастей";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.RadioButton numradioButton;
        private System.Windows.Forms.RadioButton descradioButton;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button toOrder;
        private System.Windows.Forms.TextBox inCart;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.Label inCartLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button repButton;
        private System.Windows.Forms.Button button1;
    }
}

