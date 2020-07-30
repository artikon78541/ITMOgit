namespace EntityFramework
{
    partial class LoadPriceForm
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
            this.components = new System.ComponentModel.Container();
            this.listView = new System.Windows.Forms.ListView();
            this.btnBrowsOpen = new System.Windows.Forms.Button();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.loadPriceButton = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.LargeImageList = this.imageList;
            this.listView.Location = new System.Drawing.Point(12, 133);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 305);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // btnBrowsOpen
            // 
            this.btnBrowsOpen.Location = new System.Drawing.Point(74, 29);
            this.btnBrowsOpen.Name = "btnBrowsOpen";
            this.btnBrowsOpen.Size = new System.Drawing.Size(100, 39);
            this.btnBrowsOpen.TabIndex = 1;
            this.btnBrowsOpen.Text = "Добавить файлы";
            this.btnBrowsOpen.UseVisualStyleBackColor = true;
            this.btnBrowsOpen.Click += new System.EventHandler(this.btnBrowsOpen_Click);
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(268, 28);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(92, 40);
            this.btnRemoveFile.TabIndex = 2;
            this.btnRemoveFile.Text = "Удалить файл";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // loadPriceButton
            // 
            this.loadPriceButton.Location = new System.Drawing.Point(463, 29);
            this.loadPriceButton.Name = "loadPriceButton";
            this.loadPriceButton.Size = new System.Drawing.Size(101, 39);
            this.loadPriceButton.TabIndex = 3;
            this.loadPriceButton.Text = "Загрузить прайсы";
            this.loadPriceButton.UseVisualStyleBackColor = true;
            this.loadPriceButton.Click += new System.EventHandler(this.loadPriceButton_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LoadPriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadPriceButton);
            this.Controls.Add(this.btnRemoveFile);
            this.Controls.Add(this.btnBrowsOpen);
            this.Controls.Add(this.listView);
            this.Name = "LoadPriceForm";
            this.Text = "LoadPriceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnBrowsOpen;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Button loadPriceButton;
        private System.Windows.Forms.ImageList imageList;
    }
}