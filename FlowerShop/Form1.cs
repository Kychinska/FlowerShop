using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using FlowerShop.Data.Repositories;
using FlowerShop.Domain.Interfaces;
using FlowerShop.Data.Entities;

namespace FlowerShop
{
    public partial class Form1 : Form, IUser
    {
        protected IFlowerRepository _flowerRepository;
        protected IProductFlowerRepository _productFlowerRepository;
        protected IBouquetRepository _bouquetRepository;
        protected IProductPackagingRepository _productPackagingRepository;
        protected IPackagingRepository _packagingRepository;
        protected IBoquetPrice _boquetPrice;
        protected IBouquetInOrderRepository _bouquetInOrderRepository;
        protected IOrderRepository _orderRepository;
        protected ICreate _create;
        protected List<BouquetInOrder> _BouquetInOrder;
        public Form1(IFlowerRepository flowerRepository,
                        IProductFlowerRepository productFlowerRepository,
                        IBouquetRepository bouquetRepository,
                        IPackagingRepository packagingRepository,
                        IProductPackagingRepository productPackagingRepository,IBoquetPrice boquetPrice,
                        IBouquetInOrderRepository bouquetInOrderRepository,
                        ICreate create,IOrderRepository orderRepository)
        {
            _flowerRepository = flowerRepository;
            _productFlowerRepository = productFlowerRepository;
            _bouquetRepository = bouquetRepository;
            _packagingRepository = packagingRepository;
            _productPackagingRepository = productPackagingRepository;
            _boquetPrice = boquetPrice;
            _bouquetInOrderRepository = bouquetInOrderRepository;
            _orderRepository = orderRepository;
            _create = create;
            _BouquetInOrder = new List<BouquetInOrder>();
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = "Server=localhost\\sqlexpress;Database=FlowersShop;Integrated Security=true;";
             SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            string query = "Select Flower.Id ,Name,FlowerPrice.PriceFlower,Color, Number From Flower LEFT JOIN FlowerPrice on dbo.Flower.Id = FlowerPrice.FlowerId";
            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[5]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }
            reader.Close();
            myConnection.Close();
            foreach (string[] s in data)              
                dataGridViewFlowers.Rows.Add(s);
            myConnection.Open();
            
            query = "Select PackagingId, Material, Color, Packaging.Price, Number From Packaging LEFT JOIN PackagingPrice on Packaging.Id = PackagingPrice.PackagingId";
            command = new SqlCommand(query, myConnection);
            reader = command.ExecuteReader();
            data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[5]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }
            reader.Close();
            myConnection.Close();
            foreach (string[] s in data)             
                dataGridViewPacking.Rows.Add(s);
            for (int i = 0; i < dataGridViewFlowers.Rows.Count; i++)
                dataGridViewFlowers.Rows[i].Cells[5].Value = 0;
            for (int j = 0; j < dataGridViewPacking.Rows.Count; j++)
                dataGridViewPacking.Rows[j].Cells[5].Value = false;
        }

        private void button_CreateBoquet_Click(object sender, EventArgs e)
        {
            List<int> FlowerId = new List<int>();
            List<int> FlowerNumber = new List<int>();
            int PackagingId = 0;
            int flowerNumber;
            for (int j = 0; j < dataGridViewPacking.Rows.Count; j++)
            {
                if (Convert.ToBoolean(dataGridViewPacking.Rows[j].Cells[5].Value) == true)
                {
                    PackagingId = Convert.ToInt32(dataGridViewPacking[0, j].Value);
                }
            }
            for (int i = 0; i < dataGridViewFlowers.Rows.Count; i++)
            {
                flowerNumber = Convert.ToInt32(dataGridViewFlowers[5, i].Value);
                if (flowerNumber > 0)
                {
                    if (flowerNumber <= Convert.ToInt32(dataGridViewFlowers[4, i].Value))
                    {
                        FlowerId.Add(Convert.ToInt32(dataGridViewFlowers[0, i].Value));
                        FlowerNumber.Add(flowerNumber);
                    }
                }
            }
            Bouquet bouquet = _create.CreateBouquet(FlowerId, FlowerNumber, PackagingId, textBox_Message.Text);
            if (bouquet.Flowers.Count() > 0)
            {
                _bouquetRepository.AddBouquet(bouquet);
                MessageBox.Show("Add bouquet");
                int bouquetsNumber;
                if (textBox_NumberOfBouquets.Text == string.Empty)
                   bouquetsNumber = 1;
                else 
                   bouquetsNumber = Convert.ToInt32(textBox_NumberOfBouquets.Text);
                
                BouquetInOrder bouquetInOrder = _create.CreateBouquetInOrder(bouquet, bouquetsNumber);

                _BouquetInOrder.Add(bouquetInOrder);
            }
            for(int j=0; j<_BouquetInOrder.Count;j++)
            {
                dataGridView_BouquetInOrder.Rows[j].Cells[0].Value = _BouquetInOrder[j].BouquetId;
                dataGridView_BouquetInOrder.Rows[j].Cells[1].Value = _BouquetInOrder[j].Number;
                dataGridView_BouquetInOrder.Rows[j].Cells[2].Value = _BouquetInOrder[j].Price;
            }
        }

        private void dataGridViewPacking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridViewPacking.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridViewPacking.Rows[i].Cells[5].Value) == true)
                    dataGridViewPacking.Rows[i].Cells[5].Value = false;
            }
        }

        private void button_ConfirmOrder_Click(object sender, EventArgs e)
        {
            Order order = _create.CreateOrder(_BouquetInOrder,dateTimePicker_DeliveryDate.Value,textBox_FirstName.Text, textBox_LastName.Text,textBox_DeliveryAddress.Text,textBox_Phone.Text);
            _orderRepository.AddOrder(order);
            for (int i=0; i< order.BouquetInOrders.Count;i++)
            {
                _bouquetInOrderRepository.AddBouquetInOrder(order.BouquetInOrders[i]);
            }
            string str = string.Format("Tour order id :{0} and order price: {1}", order.Id.ToString(), order.Price.ToString());
            MessageBox.Show(str);
        }

        private void textBox_NumberOfBouquets_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
