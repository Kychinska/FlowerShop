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
            this.PackId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddInBoquet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.Label();
            this.dateTimePicker_DeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox_CreateBouquet = new System.Windows.Forms.GroupBox();
            this.textBox_NumberOfBouquets = new System.Windows.Forms.TextBox();
            this.label_NumberOfBouquets = new System.Windows.Forms.Label();
            this.groupBox_Order = new System.Windows.Forms.GroupBox();
            this.button_ConfirmOrder = new System.Windows.Forms.Button();
            this.groupBox_Client = new System.Windows.Forms.GroupBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label_Phone = new System.Windows.Forms.Label();
            this.textBox_DeliveryAddress = new System.Windows.Forms.TextBox();
            this.label_DeliveryAddress = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.LastName_label = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_BouquetsInOrder = new System.Windows.Forms.Label();
            this.dataGridView_BouquetInOrder = new System.Windows.Forms.DataGridView();
            this.label_DeliveryDate = new System.Windows.Forms.Label();
            this.BooquetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooquetsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBouquetPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlowers)).BeginInit();
            this.groupBox_CreateBouquet.SuspendLayout();
            this.groupBox_Order.SuspendLayout();
            this.groupBox_Client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BouquetInOrder)).BeginInit();
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
            this.dataGridViewPacking.Location = new System.Drawing.Point(0, 296);
            this.dataGridViewPacking.Name = "dataGridViewPacking";
            this.dataGridViewPacking.RowHeadersVisible = false;
            this.dataGridViewPacking.RowHeadersWidth = 51;
            this.dataGridViewPacking.RowTemplate.Height = 24;
            this.dataGridViewPacking.Size = new System.Drawing.Size(813, 235);
            this.dataGridViewPacking.TabIndex = 2;
            this.dataGridViewPacking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPacking_CellContentClick);
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
            // label_Flowers
            // 
            this.label_Flowers.AutoSize = true;
            this.label_Flowers.Location = new System.Drawing.Point(6, 24);
            this.label_Flowers.Name = "label_Flowers";
            this.label_Flowers.Size = new System.Drawing.Size(60, 17);
            this.label_Flowers.TabIndex = 3;
            this.label_Flowers.Text = "Flowers:";
            // 
            // label_Packagings
            // 
            this.label_Packagings.AutoSize = true;
            this.label_Packagings.Location = new System.Drawing.Point(6, 275);
            this.label_Packagings.Name = "label_Packagings";
            this.label_Packagings.Size = new System.Drawing.Size(78, 17);
            this.label_Packagings.TabIndex = 4;
            this.label_Packagings.Text = "Packaging:";
            // 
            // button_CreateBoquet
            // 
            this.button_CreateBoquet.Location = new System.Drawing.Point(588, 555);
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
            this.dataGridViewFlowers.Location = new System.Drawing.Point(6, 46);
            this.dataGridViewFlowers.Name = "dataGridViewFlowers";
            this.dataGridViewFlowers.RowHeadersVisible = false;
            this.dataGridViewFlowers.RowHeadersWidth = 51;
            this.dataGridViewFlowers.RowTemplate.Height = 24;
            this.dataGridViewFlowers.Size = new System.Drawing.Size(807, 226);
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
            // textBox_Message
            // 
            this.textBox_Message.Location = new System.Drawing.Point(0, 563);
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(211, 22);
            this.textBox_Message.TabIndex = 8;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(0, 534);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(137, 17);
            this.Message.TabIndex = 9;
            this.Message.Text = "Message in Bouquet";
            // 
            // dateTimePicker_DeliveryDate
            // 
            this.dateTimePicker_DeliveryDate.Location = new System.Drawing.Point(311, 455);
            this.dateTimePicker_DeliveryDate.Name = "dateTimePicker_DeliveryDate";
            this.dateTimePicker_DeliveryDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_DeliveryDate.TabIndex = 10;
            // 
            // groupBox_CreateBouquet
            // 
            this.groupBox_CreateBouquet.Controls.Add(this.textBox_NumberOfBouquets);
            this.groupBox_CreateBouquet.Controls.Add(this.label_NumberOfBouquets);
            this.groupBox_CreateBouquet.Controls.Add(this.dataGridViewFlowers);
            this.groupBox_CreateBouquet.Controls.Add(this.dataGridViewPacking);
            this.groupBox_CreateBouquet.Controls.Add(this.button_CreateBoquet);
            this.groupBox_CreateBouquet.Controls.Add(this.Message);
            this.groupBox_CreateBouquet.Controls.Add(this.label_Flowers);
            this.groupBox_CreateBouquet.Controls.Add(this.textBox_Message);
            this.groupBox_CreateBouquet.Controls.Add(this.label_Packagings);
            this.groupBox_CreateBouquet.Location = new System.Drawing.Point(12, 12);
            this.groupBox_CreateBouquet.Name = "groupBox_CreateBouquet";
            this.groupBox_CreateBouquet.Size = new System.Drawing.Size(819, 606);
            this.groupBox_CreateBouquet.TabIndex = 11;
            this.groupBox_CreateBouquet.TabStop = false;
            this.groupBox_CreateBouquet.Text = "CreateBouquet";
            // 
            // textBox_NumberOfBouquets
            // 
            this.textBox_NumberOfBouquets.Location = new System.Drawing.Point(258, 563);
            this.textBox_NumberOfBouquets.Name = "textBox_NumberOfBouquets";
            this.textBox_NumberOfBouquets.Size = new System.Drawing.Size(211, 22);
            this.textBox_NumberOfBouquets.TabIndex = 11;
            this.textBox_NumberOfBouquets.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NumberOfBouquets_KeyPress);
            // 
            // label_NumberOfBouquets
            // 
            this.label_NumberOfBouquets.AutoSize = true;
            this.label_NumberOfBouquets.Location = new System.Drawing.Point(255, 534);
            this.label_NumberOfBouquets.Name = "label_NumberOfBouquets";
            this.label_NumberOfBouquets.Size = new System.Drawing.Size(137, 17);
            this.label_NumberOfBouquets.TabIndex = 10;
            this.label_NumberOfBouquets.Text = "Number of bouquets";
            // 
            // groupBox_Order
            // 
            this.groupBox_Order.Controls.Add(this.button_ConfirmOrder);
            this.groupBox_Order.Controls.Add(this.groupBox_Client);
            this.groupBox_Order.Controls.Add(this.label_BouquetsInOrder);
            this.groupBox_Order.Controls.Add(this.dataGridView_BouquetInOrder);
            this.groupBox_Order.Controls.Add(this.label_DeliveryDate);
            this.groupBox_Order.Controls.Add(this.dateTimePicker_DeliveryDate);
            this.groupBox_Order.Location = new System.Drawing.Point(837, 12);
            this.groupBox_Order.Name = "groupBox_Order";
            this.groupBox_Order.Size = new System.Drawing.Size(593, 606);
            this.groupBox_Order.TabIndex = 12;
            this.groupBox_Order.TabStop = false;
            this.groupBox_Order.Text = "Order";
            // 
            // button_ConfirmOrder
            // 
            this.button_ConfirmOrder.Location = new System.Drawing.Point(311, 506);
            this.button_ConfirmOrder.Name = "button_ConfirmOrder";
            this.button_ConfirmOrder.Size = new System.Drawing.Size(239, 61);
            this.button_ConfirmOrder.TabIndex = 10;
            this.button_ConfirmOrder.Text = "Confirm your order";
            this.button_ConfirmOrder.UseVisualStyleBackColor = true;
            this.button_ConfirmOrder.Click += new System.EventHandler(this.button_ConfirmOrder_Click);
            // 
            // groupBox_Client
            // 
            this.groupBox_Client.Controls.Add(this.textBox_Phone);
            this.groupBox_Client.Controls.Add(this.label_Phone);
            this.groupBox_Client.Controls.Add(this.textBox_DeliveryAddress);
            this.groupBox_Client.Controls.Add(this.label_DeliveryAddress);
            this.groupBox_Client.Controls.Add(this.textBox_LastName);
            this.groupBox_Client.Controls.Add(this.LastName_label);
            this.groupBox_Client.Controls.Add(this.textBox_FirstName);
            this.groupBox_Client.Controls.Add(this.label_FirstName);
            this.groupBox_Client.Location = new System.Drawing.Point(6, 429);
            this.groupBox_Client.Name = "groupBox_Client";
            this.groupBox_Client.Size = new System.Drawing.Size(283, 171);
            this.groupBox_Client.TabIndex = 13;
            this.groupBox_Client.TabStop = false;
            this.groupBox_Client.Text = "Client";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(124, 134);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(130, 22);
            this.textBox_Phone.TabIndex = 7;
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(7, 137);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(49, 17);
            this.label_Phone.TabIndex = 6;
            this.label_Phone.Text = "Phone";
            // 
            // textBox_DeliveryAddress
            // 
            this.textBox_DeliveryAddress.Location = new System.Drawing.Point(123, 96);
            this.textBox_DeliveryAddress.Name = "textBox_DeliveryAddress";
            this.textBox_DeliveryAddress.Size = new System.Drawing.Size(130, 22);
            this.textBox_DeliveryAddress.TabIndex = 5;
            // 
            // label_DeliveryAddress
            // 
            this.label_DeliveryAddress.AutoSize = true;
            this.label_DeliveryAddress.Location = new System.Drawing.Point(6, 96);
            this.label_DeliveryAddress.Name = "label_DeliveryAddress";
            this.label_DeliveryAddress.Size = new System.Drawing.Size(111, 17);
            this.label_DeliveryAddress.TabIndex = 4;
            this.label_DeliveryAddress.Text = "DeliveryAddress";
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(123, 58);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(130, 22);
            this.textBox_LastName.TabIndex = 3;
            // 
            // LastName_label
            // 
            this.LastName_label.AutoSize = true;
            this.LastName_label.Location = new System.Drawing.Point(6, 61);
            this.LastName_label.Name = "LastName_label";
            this.LastName_label.Size = new System.Drawing.Size(76, 17);
            this.LastName_label.TabIndex = 2;
            this.LastName_label.Text = "LastName ";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(123, 25);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(130, 22);
            this.textBox_FirstName.TabIndex = 1;
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(6, 28);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(72, 17);
            this.label_FirstName.TabIndex = 0;
            this.label_FirstName.Text = "FirstName";
            // 
            // label_BouquetsInOrder
            // 
            this.label_BouquetsInOrder.AutoSize = true;
            this.label_BouquetsInOrder.Location = new System.Drawing.Point(0, 24);
            this.label_BouquetsInOrder.Name = "label_BouquetsInOrder";
            this.label_BouquetsInOrder.Size = new System.Drawing.Size(125, 17);
            this.label_BouquetsInOrder.TabIndex = 12;
            this.label_BouquetsInOrder.Text = "Bouquets in order:";
            // 
            // dataGridView_BouquetInOrder
            // 
            this.dataGridView_BouquetInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BouquetInOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BooquetId,
            this.BooquetsNumber,
            this.TotalBouquetPrice});
            this.dataGridView_BouquetInOrder.Location = new System.Drawing.Point(0, 47);
            this.dataGridView_BouquetInOrder.Name = "dataGridView_BouquetInOrder";
            this.dataGridView_BouquetInOrder.RowHeadersWidth = 51;
            this.dataGridView_BouquetInOrder.RowTemplate.Height = 24;
            this.dataGridView_BouquetInOrder.Size = new System.Drawing.Size(587, 361);
            this.dataGridView_BouquetInOrder.TabIndex = 11;
            // 
            // label_DeliveryDate
            // 
            this.label_DeliveryDate.AutoSize = true;
            this.label_DeliveryDate.Location = new System.Drawing.Point(308, 429);
            this.label_DeliveryDate.Name = "label_DeliveryDate";
            this.label_DeliveryDate.Size = new System.Drawing.Size(93, 17);
            this.label_DeliveryDate.TabIndex = 10;
            this.label_DeliveryDate.Text = "DeliveryDate:";
            // 
            // BooquetId
            // 
            this.BooquetId.HeaderText = "BooquetId";
            this.BooquetId.MinimumWidth = 6;
            this.BooquetId.Name = "BooquetId";
            this.BooquetId.Width = 125;
            // 
            // BooquetsNumber
            // 
            this.BooquetsNumber.HeaderText = "BooquetsNumber";
            this.BooquetsNumber.MinimumWidth = 6;
            this.BooquetsNumber.Name = "BooquetsNumber";
            this.BooquetsNumber.Width = 125;
            // 
            // TotalBouquetPrice
            // 
            this.TotalBouquetPrice.HeaderText = "TotalBouquetPrice";
            this.TotalBouquetPrice.MinimumWidth = 6;
            this.TotalBouquetPrice.Name = "TotalBouquetPrice";
            this.TotalBouquetPrice.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 630);
            this.Controls.Add(this.groupBox_Order);
            this.Controls.Add(this.groupBox_CreateBouquet);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlowers)).EndInit();
            this.groupBox_CreateBouquet.ResumeLayout(false);
            this.groupBox_CreateBouquet.PerformLayout();
            this.groupBox_Order.ResumeLayout(false);
            this.groupBox_Order.PerformLayout();
            this.groupBox_Client.ResumeLayout(false);
            this.groupBox_Client.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BouquetInOrder)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DeliveryDate;
        private System.Windows.Forms.GroupBox groupBox_CreateBouquet;
        private System.Windows.Forms.GroupBox groupBox_Order;
        private System.Windows.Forms.Label label_DeliveryDate;
        private System.Windows.Forms.Label label_BouquetsInOrder;
        private System.Windows.Forms.DataGridView dataGridView_BouquetInOrder;
        private System.Windows.Forms.GroupBox groupBox_Client;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label LastName_label;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.TextBox textBox_DeliveryAddress;
        private System.Windows.Forms.Label label_DeliveryAddress;
        private System.Windows.Forms.Button button_ConfirmOrder;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.TextBox textBox_NumberOfBouquets;
        private System.Windows.Forms.Label label_NumberOfBouquets;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooquetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooquetsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBouquetPrice;
    }
}

