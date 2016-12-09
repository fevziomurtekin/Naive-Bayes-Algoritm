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
    public partial class Form4 : Form
    {
        MySqlConnection baglanti;
        Form2 frm = new Form2();

        String ad_soyad = "";



        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ad = textBox1.Text.ToString();
            String soyad = textBox2.Text.ToString();
            ad_soyad = ad + " " + soyad;

            if (textBox1.Text == "" ||textBox2.Text == "")
            {
                MessageBox.Show("Eksik Alanları doldurunuz..");
                this.Update();
            }
            else {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
                String insertQuery = "Insert into tibbi.kisi(adi,soyad) Values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Giriş yapılıyor...");
                    }

                    else { MessageBox.Show("Giriş yapılmadı."); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Hide();
                frm.label17.Text = ad_soyad;
                frm.Show();

            }
        }
    }

}
