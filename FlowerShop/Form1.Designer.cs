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
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.dataGridViewFlowers = new System.Windows.Forms.DataGridView();
            this.dataGridViewPacking = new System.Windows.Forms.DataGridView();
            this.label_Flowers = new System.Windows.Forms.Label();
            this.label_Packagings = new System.Windows.Forms.Label();
            this.label_Order = new System.Windows.Forms.Label();
            this.button_CreateOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacking)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(859, 34);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(358, 483);
            this.dataGridViewOrder.TabIndex = 0;
            // 
            // dataGridViewFlowers
            // 
            this.dataGridViewFlowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlowers.Location = new System.Drawing.Point(0, 34);
            this.dataGridViewFlowers.Name = "dataGridViewFlowers";
            this.dataGridViewFlowers.RowHeadersWidth = 51;
            this.dataGridViewFlowers.RowTemplate.Height = 24;
            this.dataGridViewFlowers.Size = new System.Drawing.Size(419, 483);
            this.dataGridViewFlowers.TabIndex = 1;
            this.dataGridViewFlowers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewPacking
            // 
            this.dataGridViewPacking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacking.Location = new System.Drawing.Point(425, 34);
            this.dataGridViewPacking.Name = "dataGridViewPacking";
            this.dataGridViewPacking.RowHeadersWidth = 51;
            this.dataGridViewPacking.RowTemplate.Height = 24;
            this.dataGridViewPacking.Size = new System.Drawing.Size(419, 483);
            this.dataGridViewPacking.TabIndex = 2;
            // 
            // label_Flowers
            // 
            this.label_Flowers.AutoSize = true;
            this.label_Flowers.Location = new System.Drawing.Point(162, 14);
            this.label_Flowers.Name = "label_Flowers";
            this.label_Flowers.Size = new System.Drawing.Size(60, 17);
            this.label_Flowers.TabIndex = 3;
            this.label_Flowers.Text = "Flowers:";
            // 
            // label_Packagings
            // 
            this.label_Packagings.AutoSize = true;
            this.label_Packagings.Location = new System.Drawing.Point(608, 14);
            this.label_Packagings.Name = "label_Packagings";
            this.label_Packagings.Size = new System.Drawing.Size(78, 17);
            this.label_Packagings.TabIndex = 4;
            this.label_Packagings.Text = "Packaging:";
            // 
            // label_Order
            // 
            this.label_Order.AutoSize = true;
            this.label_Order.Location = new System.Drawing.Point(1028, 14);
            this.label_Order.Name = "label_Order";
            this.label_Order.Size = new System.Drawing.Size(80, 17);
            this.label_Order.TabIndex = 5;
            this.label_Order.Text = "Your order:";
            // 
            // button_CreateOrder
            // 
            this.button_CreateOrder.Location = new System.Drawing.Point(950, 544);
            this.button_CreateOrder.Name = "button_CreateOrder";
            this.button_CreateOrder.Size = new System.Drawing.Size(225, 39);
            this.button_CreateOrder.TabIndex = 6;
            this.button_CreateOrder.Text = "Create order";
            this.button_CreateOrder.UseVisualStyleBackColor = true;
            this.button_CreateOrder.Click += new System.EventHandler(this.button_CreateOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 595);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_CreateOrder);
            this.Controls.Add(this.label_Order);
            this.Controls.Add(this.label_Packagings);
            this.Controls.Add(this.label_Flowers);
            this.Controls.Add(this.dataGridViewPacking);
            this.Controls.Add(this.dataGridViewFlowers);
            this.Controls.Add(this.dataGridViewOrder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlowers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.DataGridView dataGridViewFlowers;
        private System.Windows.Forms.DataGridView dataGridViewPacking;
        private System.Windows.Forms.Label label_Flowers;
        private System.Windows.Forms.Label label_Packagings;
        private System.Windows.Forms.Label label_Order;
        private System.Windows.Forms.Button button_CreateOrder;
        private System.Windows.Forms.Button button2;
    }
}

