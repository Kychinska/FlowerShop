using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlowerShop.Data.Repositories;
using FlowerShop.Domain.Interfaces;
using FlowerShop.EF.Repositories;
using FlowerShop.Data.Entities;
namespace FlowerShop
{
    public partial class Form1 : Form, IUser
    {
        IFlowerRepository _flowerRepository;
        IProductFlowerRepository _productFlowerRepository;
        public Form1()
        {
            _flowerRepository = new FlowerRepository();
            _productFlowerRepository = new ProductFlowerRepository();
            InitializeComponent();
             LoadDate();
        }

        private void LoadDate()
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
        }


        private void button_CreateOrder_Click(object sender, EventArgs e)
        {
           Form form2 = new Form();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void button_CreateBoquet_Click(object sender, EventArgs e)
        {
            int flowerId = 0;
            int flowerNumber = 0;
            int count = dataGridViewFlowers.Rows.Count;
            for(int i=0; i<count; i++)
            {
               if (Convert.ToInt32(dataGridViewFlowers[5, i].Value.ToString())>0)
                { 
                    if( (Convert.ToInt32(dataGridViewFlowers[5,i].Value.ToString())) <= Convert.ToInt32(dataGridViewFlowers[4, i].Value.ToString()))
                    {
                        ProductFlower productFlower = new ProductFlower();
                        productFlower.Flower = _flowerRepository.Get(Convert.ToInt32(dataGridViewFlowers[5, i].Value.ToString()));
                        MessageBox.Show(productFlower.FlowerId.ToString());
                    }
                    else
                    {
                         MessageBox.Show("You cannot do this");
                    }
               }
            }
        }
    }
}
