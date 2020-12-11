
namespace tthk_products_db
{
    partial class TootedForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataSet1 = new tthk_products_db.ProductsDataSet();
            this.priceNumeric = new System.Windows.Forms.NumericUpDown();
            this.amountNumeric = new System.Windows.Forms.NumericUpDown();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureLabel = new System.Windows.Forms.Label();
            this.tableLabel = new System.Windows.Forms.Label();
            this.pictureTextBoxLabel = new System.Windows.Forms.Label();
            this.pictureTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.productsTableAdapter = new tthk_products_db.ProductsDataSetTableAdapters.productsTableAdapter();
            this.categoryCheckbox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nimi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.Location = new System.Drawing.Point(170, 27);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(188, 35);
            this.titleTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(84, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kogus";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(100, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hind";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(92, 286);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(268, 62);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Lisa";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(92, 354);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(268, 62);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Uuenda";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(90, 422);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(268, 62);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Kustuta";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.productsDataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(456, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(622, 458);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn2.HeaderText = "title";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "amount";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn4.HeaderText = "price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "imageSource";
            this.dataGridViewTextBoxColumn5.HeaderText = "imageSource";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // productsDataSet1BindingSource
            // 
            this.productsDataSet1BindingSource.DataMember = "products";
            this.productsDataSet1BindingSource.DataSource = this.productsDataSet1;
            // 
            // productsDataSet1
            // 
            this.productsDataSet1.DataSetName = "ProductsDataSet";
            this.productsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // priceNumeric
            // 
            this.priceNumeric.DecimalPlaces = 2;
            this.priceNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.priceNumeric.Location = new System.Drawing.Point(170, 124);
            this.priceNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priceNumeric.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.priceNumeric.Name = "priceNumeric";
            this.priceNumeric.Size = new System.Drawing.Size(190, 35);
            this.priceNumeric.TabIndex = 10;
            // 
            // amountNumeric
            // 
            this.amountNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountNumeric.Location = new System.Drawing.Point(170, 75);
            this.amountNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amountNumeric.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.amountNumeric.Name = "amountNumeric";
            this.amountNumeric.Size = new System.Drawing.Size(190, 35);
            this.amountNumeric.TabIndex = 10;
            // 
            // productPictureBox
            // 
            this.productPictureBox.Location = new System.Drawing.Point(1086, 94);
            this.productPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(442, 458);
            this.productPictureBox.TabIndex = 11;
            this.productPictureBox.TabStop = false;
            // 
            // pictureLabel
            // 
            this.pictureLabel.AutoSize = true;
            this.pictureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pictureLabel.Location = new System.Drawing.Point(1080, 58);
            this.pictureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pictureLabel.Name = "pictureLabel";
            this.pictureLabel.Size = new System.Drawing.Size(47, 29);
            this.pictureLabel.TabIndex = 12;
            this.pictureLabel.Text = "Pilt";
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLabel.Location = new System.Drawing.Point(450, 58);
            this.tableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(76, 29);
            this.tableLabel.TabIndex = 12;
            this.tableLabel.Text = "Tabel";
            // 
            // pictureTextBoxLabel
            // 
            this.pictureTextBoxLabel.AutoSize = true;
            this.pictureTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pictureTextBoxLabel.Location = new System.Drawing.Point(39, 176);
            this.pictureTextBoxLabel.Name = "pictureTextBoxLabel";
            this.pictureTextBoxLabel.Size = new System.Drawing.Size(47, 29);
            this.pictureTextBoxLabel.TabIndex = 8;
            this.pictureTextBoxLabel.Text = "Pilt";
            this.pictureTextBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureTextBox
            // 
            this.pictureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pictureTextBox.Location = new System.Drawing.Point(90, 171);
            this.pictureTextBox.Name = "pictureTextBox";
            this.pictureTextBox.Size = new System.Drawing.Size(268, 35);
            this.pictureTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(92, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kustuta kõik";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.deleteAllButton_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // categoryCheckbox
            // 
            this.categoryCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryCheckbox.FormattingEnabled = true;
            this.categoryCheckbox.Location = new System.Drawing.Point(89, 212);
            this.categoryCheckbox.Name = "categoryCheckbox";
            this.categoryCheckbox.Size = new System.Drawing.Size(271, 37);
            this.categoryCheckbox.TabIndex = 13;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryLabel.Location = new System.Drawing.Point(17, 215);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(69, 29);
            this.categoryLabel.TabIndex = 8;
            this.categoryLabel.Text = "Tüüp";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TootedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 560);
            this.Controls.Add(this.categoryCheckbox);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.pictureLabel);
            this.Controls.Add(this.productPictureBox);
            this.Controls.Add(this.amountNumeric);
            this.Controls.Add(this.priceNumeric);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureTextBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.pictureTextBoxLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label1);
            this.Name = "TootedForm";
            this.Text = "Tooted";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown priceNumeric;
        private System.Windows.Forms.NumericUpDown amountNumeric;
        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Label pictureLabel;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.Label pictureTextBoxLabel;
        private System.Windows.Forms.TextBox pictureTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productsDataSet1BindingSource;
        private ProductsDataSet productsDataSet1;
        private ProductsDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox categoryCheckbox;
        private System.Windows.Forms.Label categoryLabel;
    }
}

