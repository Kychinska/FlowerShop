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
        protected IOrderFactory _orderFactory;
        protected IFlowerRepository _flowerRepository;
        protected IProductFlowerRepository _productFlowerRepository;
        protected IBouquetRepository _bouquetRepository;
        protected IProductPackagingRepository _productPackagingRepository;
        protected IPackagingRepository _packagingRepository;
        protected IBoquetPrice _boquetPrice;
        protected IFlowerInShopDTORepository _flowerInShopDTORepository;
        protected IPackagingInShopDTORepository _packagingInShopDTORepository;
        protected IFlowerPriceRepository _flowerPriceRepository;
        protected IPackagingPriceRepository _packagingPriceRepository;
        protected List<BouquetInOrder> _BouquetInOrder;

        public Form1(IFlowerRepository flowerRepository,
                        IProductFlowerRepository productFlowerRepository,
                        IBouquetRepository bouquetRepository,
                        IPackagingRepository packagingRepository,
                        IProductPackagingRepository productPackagingRepository,
                        IBoquetPrice boquetPrice, IOrderFactory orderFactory,
                        IFlowerInShopDTORepository flowerInShopDTORepository,
                        IPackagingInShopDTORepository packagingInShopDTORepository,
                        IFlowerPriceRepository flowerPriceRepository, IPackagingPriceRepository packagingPriceRepository)
        {
            _flowerRepository = flowerRepository;
            _productFlowerRepository = productFlowerRepository;
            _bouquetRepository = bouquetRepository;
            _packagingRepository = packagingRepository;
            _productPackagingRepository = productPackagingRepository;
            _boquetPrice = boquetPrice;           
            _flowerInShopDTORepository = flowerInShopDTORepository;
            _packagingInShopDTORepository = packagingInShopDTORepository;
            _BouquetInOrder = new List<BouquetInOrder>();
            _orderFactory = orderFactory;
            _flowerPriceRepository = flowerPriceRepository;
            _packagingPriceRepository = packagingPriceRepository;
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
            Bouquet bouquet = new Bouquet();
            bouquet.Flowers = new List<ProductFlower>();
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
                        bouquet.Flowers.Add(productFlower);
                    }
                }
            }
            int bouquetsNumber = Convert.ToInt32(textBox_NumberOfBouquets.Text);
            if (bouquetsNumber < 1)
            {
                bouquetsNumber = 1;
            }
            foreach(var flower in bouquet.Flowers )
            {
                int reqestedNumber = flower.Number * bouquetsNumber;
                if (reqestedNumber >_flowerPriceRepository.GetAvailableFlowerNumber(flower.FlowerId))
                {
                    MessageBox.Show("Sorry, but we can`t to do so much bouqets");
                    return;
                }
            }
            for (int j = 0; j < dataGridViewPacking.Rows.Count; j++)
            {
                if (Convert.ToBoolean(dataGridViewPacking.Rows[j].Cells[5].Value) == true)
                {
                    packagingId = Convert.ToInt32(dataGridViewPacking[0, j].Value);
                }
            }
            if(bouquetsNumber>_packagingPriceRepository.GetAvailablePacakagingNumber(packagingId))
            {
                MessageBox.Show("Sorry, but we can`t to do so much bouqets");
                return;
            }
            ProductPackaging productPackaging = new ProductPackaging();
            productPackaging.PackagingId = packagingId;
            bouquet.Packaging = productPackaging;
            bouquet.PackagingId = productPackaging.PackagingId;
            bouquet.Message = textBox_Message.Text;

            if (bouquet.Flowers.Count() > 0)
            {
                _bouquetRepository.AddBouquet(bouquet);
                MessageBox.Show("Add bouquet");
                
                BouquetInOrder bouquetInOrder = new BouquetInOrder();
                bouquetInOrder.BouquetId = bouquet.Id;
                bouquetInOrder.Number = bouquetsNumber;
                bouquetInOrder.Price = _boquetPrice.CalculateBouquetPrice(bouquetInOrder.BouquetId);
                _BouquetInOrder.Add(bouquetInOrder);
            }
            for(int j=0; j<_BouquetInOrder.Count;j++)
            {
                dataGridView_BouquetInOrder.Rows[j].Cells[0].Value = _BouquetInOrder[j].BouquetId;
                dataGridView_BouquetInOrder.Rows[j].Cells[1].Value = _BouquetInOrder[j].Number;
                dataGridView_BouquetInOrder.Rows[j].Cells[2].Value = _BouquetInOrder[j].Price;
            }
            LoadData();
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
            Order order = _orderFactory.CreateOrder(_BouquetInOrder, client, dateTimePicker_DeliveryDate.Value);
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
