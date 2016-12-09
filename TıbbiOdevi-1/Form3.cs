using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TıbbiOdevi_1
{
    public partial class Form3 : Form
    {
        MySqlConnection baglanti;
        int evet_sayisi = 0;
        int hayir_sayisi = 0;
        int class_evet = 0, class_hayir = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            String bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

            build.UserID = "root";
            build.Password = "";
            build.Database = "tibbi";
            build.Server = "localhost";

            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

            String sql = "SELECT * FROM bilgiler";
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;

            baglanti.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            
          

            }
               

            //String bag;
            //MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

            //build.UserID = "root";
            //build.Password = "";
            //build.Database = "tibbi";
            //build.Server = "localhost";

            //bag = build.ToString();
            //baglanti = new MySqlConnection(bag);


          
           
            //MySqlCommand command = new MySqlCommand("SELECT COUNT(id) FROM bilgiler", baglanti);
            //baglanti.Open();
            //MySqlDataReader o1 = command.ExecuteReader();
            //// sql komutlarını okut.
            //if (o1.Read()) { MessageBox.Show("alındı"); }
            
         
        }
    }

