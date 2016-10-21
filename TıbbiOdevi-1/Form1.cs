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
    public partial class Form1 : Form
    {

        MySqlConnection baglanti;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false; label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false; label7.Visible = false; label8.Visible = false;
            listBox1.Visible = false; listBox2.Visible = false; listBox3.Visible = false; listBox4.Visible = false; listBox5.Visible = false; listBox6.Visible = false; listBox7.Visible = false; listBox8.Visible = false;
            button4.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            String bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

            build.UserID = "user_name";
            build.Password = "password";
            build.Database = "db_name";
            build.Server = "localhost";

            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

            String sql = "SELECT * FROM 'table_name'";
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;

            baglanti.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            label1.Visible = false; label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false; label7.Visible = false; label8.Visible = false;
            listBox1.Visible = false; listBox2.Visible = false; listBox3.Visible = false; listBox4.Visible = false; listBox5.Visible = false; listBox6.Visible = false; listBox7.Visible = false; listBox8.Visible = false;
            button4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            int evet_sayaci = 0,hayir_sayaci= 0 , hepatit_tanisi_evet_sayaci=0, hepatit_tanisi_hayir_sayaci = 0,damar_evet_sayaci=0,damar_hayir_sayaci=0,homo_evet_sayaci=0,homo_hayir_sayaci=0,temiz_evet_sayaci=0,temiz_hayir_sayaci=0,kan_evet_sayaci=0,kan_hayir_sayaci=0,diyaliz_evet_sayaci=0,diyaliz_hayir_sayaci=0, hemofili_evet_sayaci=0, hemofili_hayir_sayaci=0;
            int veri_sayisi = dataGridView1.RowCount;
            int soru_sayisi = dataGridView1.ColumnCount;
            for(int i = 1; i <= veri_sayisi; i++)
            {
                for(int y=1;y<=soru_sayisi; y++)
                {
                    if (dataGridView1.Rows[i].Cells[8].Equals("Evet"))
                    {
                        evet_sayaci++;
                    }
                    else if (dataGridView1.Rows[i].Cells[8].Equals("Hayir"))
                    {
                        hayir_sayaci++;
                    }
                    int hepatit_olasiligi = (evet_sayaci / (evet_sayaci + hayir_sayaci));
                    if (dataGridView1.Rows[i].Cells[1].Equals("Evet"))
                    {
                        hepatit_tanisi_evet_sayaci++;
                    }
                    else if (dataGridView1.Rows[i].Cells[1].Equals("Hayir"))
                    {
                        hepatit_tanisi_hayir_sayaci++;
                    }
                    int hepatit_tani_evet = hepatit_tanisi_evet_sayaci / evet_sayaci;
                    int hepatit_tani_hayir = hepatit_tanisi_hayir_sayaci / hayir_sayaci;

                    if (dataGridView1.Rows[i].Cells[2].Equals("Evet"))
                    {
                        damar_evet_sayaci++;
                    }
                    else if (dataGridView1.Rows[i].Cells[2].Equals("Hayir"))
                    {
                        damar_hayir_sayaci++;
                    }
                    int damar_evet = damar_evet_sayaci / evet_sayaci;
                    int damar_hayir = damar_hayir_sayaci / hayir_sayaci;

                    if (dataGridView1.Rows[i].Cells[3].Equals("Evet"))
                    {
                        homo_evet_sayaci++;
                    }
                    else if (dataGridView1.Rows[i].Cells[3].Equals("Hayir"))
                    {
                        homo_hayir_sayaci++;
                    }
                    int homo_evet = homo_evet_sayaci / evet_sayaci;
                    int homo_hayir = homo_hayir_sayaci / hayir_sayaci;

                    if (dataGridView1.Rows[i].Cells[3].Equals("Evet"))
                    {
                        temiz_evet_sayaci++;
                    }
                    else if (dataGridView1.Rows[i].Cells[3].Equals("Hayir"))
                    {
                        temiz_hayir_sayaci++;
                    }
                    int temiz_evet = temiz_evet_sayaci / evet_sayaci;
                    int temiz_hayir = temiz_hayir_sayaci / hayir_sayaci;

                    if (dataGridView1.Rows[i].Cells[4].Equals("Evet"))
                    {
                        kan_evet_sayaci++;
                    }
                    else if (dataGridView1.Rows[i].Cells[4].Equals("Hayir"))
                    {
                        kan_hayir_sayaci++;
                    }
                    int kan_evet = kan_evet_sayaci / evet_sayaci;
                    int kan_hayir = kan_hayir_sayaci / hayir_sayaci;

                    if (dataGridView1.Rows[i].Cells[5].Equals("Evet"))
                    {
                        diyaliz_evet_sayaci++;
                    }
                    else if (dataGridView1.Rows[i].Cells[5].Equals("Hayir"))
                    {
                        diyaliz_hayir_sayaci++;
                    }
                    int diyaliz_evet = kan_evet_sayaci / evet_sayaci;
                    int diyaliz_hayir = kan_hayir_sayaci / hayir_sayaci;

                    if (dataGridView1.Rows[i].Cells[8].Equals("Evet"))
                    {
                        hemofili_evet_sayaci++;
                    }
                    else if (dataGridView1.Rows[i].Cells[8].Equals("Hayir"))
                    {
                        hemofili_hayir_sayaci++;
                    }
                    int hemofili_evet = hemofili_evet_sayaci / evet_sayaci;
                    int hemofili_hayir = hemofili_hayir_sayaci / hayir_sayaci;

                    float evet_olasiligi = ((hepatit_tani_evet * damar_evet * homo_evet * temiz_evet * kan_evet * diyaliz_evet * hemofili_evet*evet_sayaci) / 100);
                    float hayir_olasiligi = ((hepatit_tani_hayir * damar_hayir * homo_hayir * temiz_hayir * kan_hayir * diyaliz_hayir * hemofili_hayir*hayir_sayaci) / 100);

                    if (evet_olasiligi > hayir_olasiligi) { MessageBox.Show("Hepatit belirtileri gözüküyor."); }
                    else { MessageBox.Show("Hepatit belirtileri gözükmüyor"); }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible =true; label7.Visible = true; label8.Visible = true;
            listBox1.Visible = true; listBox2.Visible = true; listBox3.Visible = true; listBox4.Visible = true; listBox5.Visible = true; listBox6.Visible = true; listBox7.Visible = true; listBox8.Visible = true;
            button4.Visible = true;
            dataGridView1.Visible = false;
         

        }

   

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=port_no;username=user_name;password=");
            string insertQuery = "INSERT INTO hepatittani.hepatit(aile,Damar,Homo,temiz,kan,diyaliz,hemofili,hepatit) VALUES ('" + listBox1.SelectedItem.ToString()+ "','" + listBox2.SelectedItem.ToString() + "','" + listBox3.SelectedItem.ToString() + "','" + listBox4.SelectedItem.ToString() + "','" + listBox5.SelectedItem.ToString() + "','" + listBox6.SelectedItem.ToString() + "','" + listBox7.SelectedItem.ToString() + "','" + listBox8.SelectedItem.ToString() + "')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
            try { 
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Veri Eklendi");

            }
            else
            {
                MessageBox.Show("Veri eklenemedi");
            }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
    }
}
