﻿using System;
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
        protected IFlowerRepository _flowerRepository;
        protected IProductFlowerRepository _productFlowerRepository;
        protected IBouquetRepository _bouquetRepository;
        protected IProductPackagingRepository _productPackagingRepository;
        protected IPackagingRepository _packagingRepository;
        protected IBoquetPrice _boquetPrice;
        protected IOrderRepository _orderRepository;
        protected ICreate _create;
        protected IFlowerInShopDTORepository _flowerInShopDTORepository;
        protected IPackagingInShopDTORepository _packagingInShopDTORepository;
        protected List<BouquetInOrder> _BouquetInOrder;
        public Form1(IFlowerRepository flowerRepository,
                        IProductFlowerRepository productFlowerRepository,
                        IBouquetRepository bouquetRepository,
                        IPackagingRepository packagingRepository,
                        IProductPackagingRepository productPackagingRepository,IBoquetPrice boquetPrice,
                        ICreate create,IOrderRepository orderRepository, 
                        IFlowerInShopDTORepository flowerInShopDTORepository,
                        IPackagingInShopDTORepository packagingInShopDTORepository)
        {
            _flowerRepository = flowerRepository;
            _productFlowerRepository = productFlowerRepository;
            _bouquetRepository = bouquetRepository;
            _packagingRepository = packagingRepository;
            _productPackagingRepository = productPackagingRepository;
            _boquetPrice = boquetPrice;
            _orderRepository = orderRepository;
            _create = create;
            _flowerInShopDTORepository = flowerInShopDTORepository;
            _packagingInShopDTORepository = packagingInShopDTORepository;
            _BouquetInOrder = new List<BouquetInOrder>();

            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            List <FlowerInShopDTO> flowersInShop = _flowerInShopDTORepository.GetNotAvailableFlowers();
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
                int bouquetsNumber= Convert.ToInt32(textBox_NumberOfBouquets.Text);

                if (bouquetsNumber < 1)
                { 
                    bouquetsNumber = 1; 
                }
                                
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
