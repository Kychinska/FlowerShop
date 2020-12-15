namespace FlowerShop
{
    partial class Form1
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
            this.dataGridViewPacking = new System.Windows.Forms.DataGridView();
            this.label_Flowers = new System.Windows.Forms.Label();
            this.label_Packagings = new System.Windows.Forms.Label();
            this.button_CreateBoquet = new System.Windows.Forms.Button();
            this.dataGridViewFlowers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerColour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddInBouquet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddInBoquet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlowers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPacking
            // 
            this.dataGridViewPacking.AllowUserToAddRows = false;
            this.dataGridViewPacking.AllowUserToDeleteRows = false;
            this.dataGridViewPacking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackId,
            this.Material,
            this.Colour,
            this.Price,
            this.PackNumber,
            this.AddInBoquet});
            this.dataGridViewPacking.Location = new System.Drawing.Point(0, 284);
            this.dataGridViewPacking.Name = "dataGridViewPacking";
            this.dataGridViewPacking.RowHeadersVisible = false;
            this.dataGridViewPacking.RowHeadersWidth = 51;
            this.dataGridViewPacking.RowTemplate.Height = 24;
            this.dataGridViewPacking.Size = new System.Drawing.Size(786, 299);
            this.dataGridViewPacking.TabIndex = 2;
            // 
            // label_Flowers
            // 
            this.label_Flowers.AutoSize = true;
            this.label_Flowers.Location = new System.Drawing.Point(-3, 0);
            this.label_Flowers.Name = "label_Flowers";
            this.label_Flowers.Size = new System.Drawing.Size(60, 17);
            this.label_Flowers.TabIndex = 3;
            this.label_Flowers.Text = "Flowers:";
            // 
            // label_Packagings
            // 
            this.label_Packagings.AutoSize = true;
            this.label_Packagings.Location = new System.Drawing.Point(-3, 264);
            this.label_Packagings.Name = "label_Packagings";
            this.label_Packagings.Size = new System.Drawing.Size(78, 17);
            this.label_Packagings.TabIndex = 4;
            this.label_Packagings.Text = "Packaging:";
            // 
            // button_CreateBoquet
            // 
            this.button_CreateBoquet.Location = new System.Drawing.Point(802, 14);
            this.button_CreateBoquet.Name = "button_CreateBoquet";
            this.button_CreateBoquet.Size = new System.Drawing.Size(225, 39);
            this.button_CreateBoquet.TabIndex = 7;
            this.button_CreateBoquet.Text = "Create Boquet";
            this.button_CreateBoquet.UseVisualStyleBackColor = true;
            this.button_CreateBoquet.Click += new System.EventHandler(this.button_CreateBoquet_Click);
            // 
            // dataGridViewFlowers
            // 
            this.dataGridViewFlowers.AllowUserToAddRows = false;
            this.dataGridViewFlowers.AllowUserToDeleteRows = false;
            this.dataGridViewFlowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlowers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FlowerName,
            this.FlowerPrice,
            this.FlowerColour,
            this.Number,
            this.AddInBouquet});
            this.dataGridViewFlowers.Location = new System.Drawing.Point(0, 14);
            this.dataGridViewFlowers.Name = "dataGridViewFlowers";
            this.dataGridViewFlowers.RowHeadersVisible = false;
            this.dataGridViewFlowers.RowHeadersWidth = 51;
            this.dataGridViewFlowers.RowTemplate.Height = 24;
            this.dataGridViewFlowers.Size = new System.Drawing.Size(786, 247);
            this.dataGridViewFlowers.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // FlowerName
            // 
            this.FlowerName.HeaderText = "FlowerName";
            this.FlowerName.MinimumWidth = 6;
            this.FlowerName.Name = "FlowerName";
            this.FlowerName.Width = 125;
            // 
            // FlowerPrice
            // 
            this.FlowerPrice.HeaderText = "FlowerPrice";
            this.FlowerPrice.MinimumWidth = 6;
            this.FlowerPrice.Name = "FlowerPrice";
            this.FlowerPrice.Width = 125;
            // 
            // FlowerColour
            // 
            this.FlowerColour.HeaderText = "FlowerColour";
            this.FlowerColour.MinimumWidth = 6;
            this.FlowerColour.Name = "FlowerColour";
            this.FlowerColour.Width = 125;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.Width = 50;
            // 
            // AddInBouquet
            // 
            this.AddInBouquet.HeaderText = "AddInBouquet";
            this.AddInBouquet.MinimumWidth = 6;
            this.AddInBouquet.Name = "AddInBouquet";
            this.AddInBouquet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AddInBouquet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AddInBouquet.Width = 125;
            // 
            // PackId
            // 
            this.PackId.HeaderText = "PackId";
            this.PackId.MinimumWidth = 6;
            this.PackId.Name = "PackId";
            this.PackId.Width = 80;
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.MinimumWidth = 6;
            this.Material.Name = "Material";
            this.Material.Width = 125;
            // 
            // Colour
            // 
            this.Colour.HeaderText = "Colour";
            this.Colour.MinimumWidth = 6;
            this.Colour.Name = "Colour";
            this.Colour.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 80;
            // 
            // PackNumber
            // 
            this.PackNumber.HeaderText = "PackNumber";
            this.PackNumber.MinimumWidth = 6;
            this.PackNumber.Name = "PackNumber";
            this.PackNumber.Width = 125;
            // 
            // AddInBoquet
            // 
            this.AddInBoquet.HeaderText = "AddInBoquet";
            this.AddInBoquet.MinimumWidth = 6;
            this.AddInBoquet.Name = "AddInBoquet";
            this.AddInBoquet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AddInBoquet.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 595);
            this.Controls.Add(this.button_CreateBoquet);
            this.Controls.Add(this.label_Packagings);
            this.Controls.Add(this.label_Flowers);
            this.Controls.Add(this.dataGridViewPacking);
            this.Controls.Add(this.dataGridViewFlowers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlowers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPacking;
        private System.Windows.Forms.Label label_Flowers;
        private System.Windows.Forms.Label label_Packagings;
        private System.Windows.Forms.Button button_CreateBoquet;
        private System.Windows.Forms.DataGridView dataGridViewFlowers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerColour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddInBouquet;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AddInBoquet;
    }
}

