using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using FlowerShop.Data.Repositories;
using FlowerShop.Domain.Interfaces;
using FlowerShop.Data.Entities;
using FlowerShop.Data;

namespace FlowerShop
{
    public partial class Form1 : Form, IUser
    {
#region IFactories
        protected IOrderFactory _orderFactory;
        protected IBouquetFactory _bouquetFactory;
        protected IBouquetInOrderFactory _bouquetInOrderFactory;
#endregion
#region IRepositories
        protected IFlowerInShopDTORepository _flowerInShopDTORepository;
        protected IPackagingInShopDTORepository _packagingInShopDTORepository;
        protected IFlowerPriceRepository _flowerPriceRepository;
        protected IPackagingPriceRepository _packagingPriceRepository;
#endregion     
        protected List<BouquetInOrder> _BouquetsInOrder;
        public Form1(   IBouquetInOrderFactory bouquetInOrderFactory,
                        IOrderFactory orderFactory,
                        IBouquetFactory bouquetFactory,
                        IFlowerInShopDTORepository flowerInShopDTORepository,
                        IPackagingInShopDTORepository packagingInShopDTORepository,
                        IFlowerPriceRepository flowerPriceRepository, 
                        IPackagingPriceRepository packagingPriceRepository)
        {
            _flowerInShopDTORepository = flowerInShopDTORepository;
            _packagingInShopDTORepository = packagingInShopDTORepository;                       
            _flowerPriceRepository = flowerPriceRepository;
            _packagingPriceRepository = packagingPriceRepository;
            _orderFactory = orderFactory;
            _bouquetFactory = bouquetFactory;
            _bouquetInOrderFactory = bouquetInOrderFactory;
            _BouquetsInOrder = new List<BouquetInOrder>();

            InitializeComponent();           
            LoadData();
        }
        private void LoadData()
        {
            List <FlowerInShopDTO> flowersInShop = _flowerInShopDTORepository.GetAvailableFlowers();
            dataGridViewFlowers.Rows.Clear();
            for(int i=0; i<flowersInShop.Count;i++)
            {
                dataGridViewFlowers.Rows.Add();
                dataGridViewFlowers.Rows[i].Cells[0].Value = flowersInShop[i].FlowerId;
                dataGridViewFlowers.Rows[i].Cells[1].Value = flowersInShop[i].FlowerName;
                dataGridViewFlowers.Rows[i].Cells[2].Value = flowersInShop[i].FlowerPrice;
                dataGridViewFlowers.Rows[i].Cells[3].Value = flowersInShop[i].Color;
                dataGridViewFlowers.Rows[i].Cells[4].Value = flowersInShop[i].FlowerNumber;
                dataGridViewFlowers.Rows[i].Cells[5].Value = 0;
            }
            List<PackagingInShopDTO> packagingsInShop = _packagingInShopDTORepository.GetAvailablePackagings();
            dataGridViewPacking.Rows.Clear();
            for(int j=0; j<packagingsInShop.Count; j++)
            {
                dataGridViewPacking.Rows.Add();
                dataGridViewPacking.Rows[j].Cells[0].Value = packagingsInShop[j].PackagingId;
                dataGridViewPacking.Rows[j].Cells[1].Value = packagingsInShop[j].Material;
                dataGridViewPacking.Rows[j].Cells[2].Value = packagingsInShop[j].Color;
                dataGridViewPacking.Rows[j].Cells[3].Value = packagingsInShop[j].Price;
                dataGridViewPacking.Rows[j].Cells[4].Value = packagingsInShop[j].PackagingNumber;
                dataGridViewPacking.Rows[j].Cells[5].Value = false;
            }            
        }
        private void button_CreateBoquet_Click(object sender, EventArgs e)
        {         
            int packagingId = 0;
            int flowerNumber;
            List<ProductFlower> productFlowers = new List<ProductFlower>();
            for (int i = 0; i < dataGridViewFlowers.Rows.Count; i++)
            {
                flowerNumber = Convert.ToInt32(dataGridViewFlowers[5, i].Value);
                if (flowerNumber > 0)
                {
                    if (flowerNumber <= Convert.ToInt32(dataGridViewFlowers[4, i].Value))
                    {
                        ProductFlower productFlower = new ProductFlower();
                        productFlower.FlowerId = Convert.ToInt32(dataGridViewFlowers[0, i].Value) ;
                        productFlower.Number = flowerNumber;
                        productFlowers.Add(productFlower);
                    }
                }
            }
            for (int j = 0; j < dataGridViewPacking.Rows.Count; j++)
            {
                if (Convert.ToBoolean(dataGridViewPacking.Rows[j].Cells[5].Value) == true)
                {
                    packagingId = Convert.ToInt32(dataGridViewPacking[0, j].Value);
                }
            }
            ProductPackaging productPackaging = new ProductPackaging();
            productPackaging.PackagingId = packagingId;
            Bouquet bouquet = _bouquetFactory.CreateBouquet(productFlowers, textBox_Message.Text,productPackaging);
            
            int bouquetsNumber = Convert.ToInt32(textBox_NumberOfBouquets.Text);
            if (CheckBouquetsNumber(bouquetsNumber,bouquet))
            {
                MessageBox.Show("Sorry, but we can`t to do so much bouqets");
                textBox_NumberOfBouquets.Text = string.Empty;
                return;
            }
            if (bouquet.Flowers.Count() > 0)
            {
                _BouquetsInOrder.Add(_bouquetInOrderFactory.CreateBouquetInOrder(bouquet,bouquetsNumber));
            }
            dataGridView_BouquetInOrder.Rows.Clear();
            for(int j=0; j<_BouquetsInOrder.Count;j++)
            {
                dataGridView_BouquetInOrder.Rows[j].Cells[0].Value = _BouquetsInOrder[j].BouquetId;
                dataGridView_BouquetInOrder.Rows[j].Cells[1].Value = _BouquetsInOrder[j].Number;
                dataGridView_BouquetInOrder.Rows[j].Cells[2].Value = _BouquetsInOrder[j].Price;
                dataGridView_BouquetInOrder.Rows[j].Cells[3].Value = _BouquetsInOrder[j].Price * _BouquetsInOrder[j].Number;
            }
            LoadData();
        }
        private bool CheckBouquetsNumber(int bouquetsNumber, Bouquet bouquet)
        {
            if (bouquetsNumber < 1)
            {
                bouquetsNumber = 1;
            }
            foreach (var flower in bouquet.Flowers)
            {
                int requestedNumber = flower.Number * bouquetsNumber;
                if (requestedNumber > _flowerPriceRepository.GetAvailableFlowerNumber(flower.FlowerId))
                {
                    return true;
                }
            }
            if (bouquetsNumber > _packagingPriceRepository.GetAvailablePacakagingNumber(bouquet.PackagingId))
            {                
                return true;
            }
            return false;
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
            Client client = new Client();
            client.DeliveryAddress = textBox_DeliveryAddress.Text;
            client.FirstName = textBox_FirstName.Text;
            client.LastName = textBox_LastName.Text;
            client.Phone = textBox_Phone.Text;
            Order order = _orderFactory.CreateOrder(_BouquetsInOrder, client, dateTimePicker_DeliveryDate.Value);
            string str = string.Format("Your order id {0} and order price {1}", order.Id.ToString(), order.Price.ToString());
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
