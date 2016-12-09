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
    public partial class Form2 : Form
    {
        MySqlConnection baglanti;
        String ad_soyad = "";
        
        DialogResult cikis = new DialogResult();
        Form3 frm = new Form3();
       
        double i;
        double evet_sayisi = 0;
 
        double hayir_sayisi = 0;
        double veriler = 0;
       double class_sayisi_evet = 0, yas_sayisi_evet = 0,histology_evet=0, sex_sayisi_evet = 0, streoid_sayisi_evet = 0, antiviral_evet_sayisi = 0, fatigue_evet_sayisi = 0, malasie_evet_sayisi = 0, anorexia_evet_sayisi = 0, liverbig_evet_sayisi = 0, liverfirm_evet_sayisi = 0, spleen_evet_sayisi = 0, spiders_evet_sayisi = 0, actites_evet_sayisi = 0, varices_evet_sayisi = 0, bilirubin_evet_sayisi = 0, alkphosphate_evet_sayisi = 0, sgot_evet_sayisi = 0, albumin_evet_sayisi, protime_evet_sayisi = 0;

        private void label20_Click(object sender, EventArgs e)
        {

        }

        double class_sayisi_hayir = 0, yas_sayisi_hayir = 0, histology_hayir = 0, sex_sayisi_hayir = 0, streoid_sayisi_hayir = 0, antiviral_hayir_sayisi = 0, fatigue_hayir_sayisi = 0, malasie_hayir_sayisi = 0, anorexia_hayir_sayisi = 0, liverbig_hayir_sayisi = 0, liverfirm_hayir_sayisi = 0, spleen_hayir_sayisi = 0, spiders_hayir_sayisi = 0, actites_hayir_sayisi = 0, varices_hayir_sayisi = 0, bilirubin_hayir_sayisi = 0, alkphosphate_hayir_sayisi = 0, sgot_hayir_sayisi = 0, albumin_hayir_sayisi = 0, protime_hayir_sayisi = 0;
        
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    
        String sonuc;
        String veri;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
                       ad_soyad = label17.Text.ToString();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
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
            MySqlCommand evet_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet'", baglanti);
            MySqlCommand hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir'", baglanti);
            MySqlCommand histology_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HISTOLOGY='"+comboBox19.SelectedItem.ToString()+"' and HepatitTanisi='Evet'",baglanti);
            MySqlCommand histology_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HISTOLOGY='" + comboBox19.SelectedItem.ToString() + "' and HepatitTanisi='Hayir'",baglanti);
            MySqlCommand class_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and CLASS='" + comboBox2.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand yas_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and YAS='" + comboBox3.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand sex_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and SEX='" + comboBox4.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand streoid_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and STEROİD='" + comboBox5.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand antiviral_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and ANTIVIRALS='" + comboBox6.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand fatigue_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and FATIGUE='" + comboBox1.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand malaise_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and MALAISE='" + comboBox20.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand anoreixa_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and ANOREXIA='" + comboBox7.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand liverbig_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and LIVERBIG='" + comboBox8.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand liverfirm_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and LIVERFIRM='" + comboBox9.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand spleen_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and SPLEENPALPABLE='" + comboBox10.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand spider_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and SPIDERS='" + comboBox11.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand accites_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and ASCITES='" + comboBox12.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand varices_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and VARICES='" + comboBox13.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand bilirubin_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and BILIRUBIN='" + comboBox14.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand alk_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and ALKPHOSPHATE='" + comboBox15.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand sgot_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and SGOT='" + comboBox16.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand albumin_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and ALBUMIN='" + comboBox17.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand protime_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Evet' and PROTIME='" + comboBox18.SelectedItem.ToString() + "'", baglanti);

            MySqlCommand class_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and CLASS='" + comboBox2.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand yas_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and YAS='" + comboBox3.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand sex_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and SEX='" + comboBox4.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand streoid_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and STEROİD='" + comboBox5.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand antiviral_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and ANTIVIRALS='" + comboBox6.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand fatigue_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and FATIGUE='" + comboBox1.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand malaise_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and MALAISE='" + comboBox20.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand anoreixa_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and ANOREXIA='" + comboBox7.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand liverbig_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and LIVERBIG='" + comboBox8.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand liverfirm_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and LIVERFIRM='" + comboBox9.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand spleen_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and SPLEENPALPABLE='" + comboBox10.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand spider_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and SPIDERS='" + comboBox11.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand accites_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and ASCITES='" + comboBox12.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand varices_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and VARICES='" + comboBox13.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand bilirubin_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and BILIRUBIN='" + comboBox14.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand alk_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and ALKPHOSPHATE='" + comboBox15.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand sgot_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and SGOT='" + comboBox16.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand albumin_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and ALBUMIN='" + comboBox17.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand protime_hayir_s = new MySqlCommand("SELECT count(*) FROM bilgiler where HepatitTanisi='Hayir' and PROTIME='" + comboBox18.SelectedItem.ToString() + "'", baglanti);
            MySqlCommand veri_sayisi = new MySqlCommand("Select count(id) from bilgiler",baglanti);
            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;

            baglanti.Open();
            evet_sayisi = Convert.ToDouble(evet_s.ExecuteScalar());
            hayir_sayisi = Convert.ToDouble(hayir_s.ExecuteScalar());
            histology_evet = Convert.ToDouble(histology_s.ExecuteScalar());
            histology_hayir = Convert.ToDouble(histology_hayir_s.ExecuteScalar());
            class_sayisi_evet = Convert.ToDouble(class_s.ExecuteScalar());
            class_sayisi_hayir = Convert.ToDouble(class_hayir_s.ExecuteScalar());
            sex_sayisi_evet = Convert.ToDouble(sex_s.ExecuteScalar());
            sex_sayisi_hayir = Convert.ToDouble(sex_hayir_s.ExecuteScalar());
            yas_sayisi_evet = Convert.ToDouble(yas_s.ExecuteScalar());
            yas_sayisi_hayir = Convert.ToDouble(yas_hayir_s.ExecuteScalar());
            streoid_sayisi_evet = Convert.ToDouble(streoid_s.ExecuteScalar());
            streoid_sayisi_hayir = Convert.ToDouble(streoid_hayir_s.ExecuteScalar());
            antiviral_evet_sayisi = Convert.ToDouble(antiviral_s.ExecuteScalar());
            antiviral_hayir_sayisi = Convert.ToDouble(antiviral_hayir_s.ExecuteScalar());
            fatigue_evet_sayisi = Convert.ToDouble(fatigue_s.ExecuteScalar());
            fatigue_hayir_sayisi = Convert.ToDouble(fatigue_hayir_s.ExecuteScalar());
            malasie_evet_sayisi = Convert.ToDouble(malaise_s.ExecuteScalar());
            malasie_hayir_sayisi = Convert.ToDouble(malaise_hayir_s.ExecuteScalar());
            anorexia_evet_sayisi = Convert.ToDouble(anoreixa_s.ExecuteScalar());
            anorexia_hayir_sayisi = Convert.ToDouble(anoreixa_hayir_s.ExecuteScalar());
            liverbig_evet_sayisi = Convert.ToDouble(liverbig_s.ExecuteScalar());
            liverbig_hayir_sayisi = Convert.ToDouble(liverbig_hayir_s.ExecuteScalar());
            liverfirm_evet_sayisi = Convert.ToDouble(liverfirm_s.ExecuteScalar());
            liverfirm_hayir_sayisi = Convert.ToDouble(liverfirm_hayir_s.ExecuteScalar());
            spleen_evet_sayisi = Convert.ToDouble(spleen_s.ExecuteScalar());
            spleen_hayir_sayisi = Convert.ToDouble(spleen_hayir_s.ExecuteScalar());
            spiders_evet_sayisi = Convert.ToDouble(spider_s.ExecuteScalar());
            spiders_hayir_sayisi = Convert.ToDouble(spider_hayir_s.ExecuteScalar());
            actites_evet_sayisi = Convert.ToDouble(accites_s.ExecuteScalar());
            actites_hayir_sayisi = Convert.ToDouble(accites_hayir_s.ExecuteScalar());
            varices_evet_sayisi = Convert.ToDouble(varices_s.ExecuteScalar());
            varices_hayir_sayisi = Convert.ToDouble(varices_hayir_s.ExecuteScalar());
            bilirubin_evet_sayisi = Convert.ToDouble(bilirubin_s.ExecuteScalar());
            bilirubin_hayir_sayisi = Convert.ToDouble(bilirubin_hayir_s.ExecuteScalar());
            alkphosphate_evet_sayisi = Convert.ToDouble(alk_s.ExecuteScalar());
            alkphosphate_hayir_sayisi = Convert.ToDouble(alk_hayir_s.ExecuteScalar());
            sgot_evet_sayisi = Convert.ToDouble(sgot_s.ExecuteScalar());
            sgot_hayir_sayisi = Convert.ToDouble(sgot_hayir_s.ExecuteScalar());
            albumin_evet_sayisi = Convert.ToDouble(albumin_s.ExecuteScalar());
            albumin_hayir_sayisi = Convert.ToDouble(albumin_hayir_s.ExecuteScalar());
            protime_evet_sayisi = Convert.ToDouble(protime_s.ExecuteScalar());
            protime_hayir_sayisi = Convert.ToDouble(protime_hayir_s.ExecuteScalar());
            veriler = Convert.ToDouble(veri_sayisi.ExecuteScalar());

            /*diğerlerini de bu şekilde yapıcaz sonra da devam ettireceğiz.*/

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;


            if (comboBox2.SelectedItem==null|| comboBox3.SelectedItem == null || comboBox4.SelectedItem == null || comboBox5.SelectedItem == null || comboBox6.SelectedItem == null || comboBox7.SelectedItem == null || comboBox8.SelectedItem == null || comboBox9.SelectedItem == null || comboBox10.SelectedItem == null || comboBox11.SelectedItem == null || comboBox12.SelectedItem == null || comboBox13.SelectedItem == null || comboBox14.SelectedItem == null || comboBox15.SelectedItem == null || comboBox16.SelectedItem == null || comboBox17.SelectedItem == null || comboBox18.SelectedItem == null ||  comboBox19.SelectedItem == null ||  comboBox20.SelectedItem == null)
            {
                MessageBox.Show("Eksik Alanları doldurunuz..");
                this.Update();
            }
            else {

                double evet_oran = evet_sayisi / veriler;
                double hayir_oran = hayir_sayisi / veriler;
                double class_sayİsi_evet_oran = class_sayisi_evet / evet_sayisi;
                double yas_sayisi_evet_oran = yas_sayisi_evet / evet_sayisi;
                double sex_sayisi_evet_oran = sex_sayisi_evet / evet_sayisi;
                double antiviral_evet_sayisi_oran = antiviral_evet_sayisi / evet_sayisi;
                double streoid_sayisi_evet_oran = streoid_sayisi_evet / evet_sayisi;
                double fatigue_evet_sayisi_oran = fatigue_evet_sayisi / evet_sayisi;
                double malasie_evet_sayisi_oran = malasie_evet_sayisi / evet_sayisi;
                double anorexia_evet_sayisi_oran = anorexia_evet_sayisi / evet_sayisi;
                double liverbig_evet_sayisi_oran = liverbig_evet_sayisi / evet_sayisi;
                double liverfirm_evet_sayisi_oran = liverbig_evet_sayisi / evet_sayisi;
                double spleen_evet_sayisi_oran = spleen_evet_sayisi / evet_sayisi;
                double spiders_evet_sayisi_oran = spiders_evet_sayisi / evet_sayisi;
                double actites_evet_sayisi_oran = actites_evet_sayisi / evet_sayisi;
                double varices_evet_sayisi_oran = varices_evet_sayisi / evet_sayisi;
                double bilirubin_evet_oran = bilirubin_evet_sayisi / evet_sayisi;
                double alkphosphate_evet_sayisi_oran_oran = alkphosphate_evet_sayisi / evet_sayisi;
                double sgot_evet_sayisi_oran = sgot_evet_sayisi / evet_sayisi;
                double albumin_evet_sayisi_oran = albumin_evet_sayisi / evet_sayisi;
                double protime_evet_sayisi_oran = protime_evet_sayisi / evet_sayisi;
                double histology_evet_oran = histology_evet / evet_sayisi;
                double histology_hayir_oran = histology_hayir / hayir_sayisi;
                double class_sayisi_hayir_oran = class_sayisi_hayir / hayir_sayisi;
                double yas_sayisi_hayir_oran = yas_sayisi_hayir / hayir_sayisi;
                double sex_sayisi_hayir_oran = sex_sayisi_hayir / hayir_sayisi;
                double antiviral_hayir_oran = antiviral_hayir_sayisi / hayir_sayisi;
                double streoid_sayisi_hayir_oran = streoid_sayisi_hayir / hayir_sayisi;
                double fatigue_hayir_sayisi_oran = fatigue_hayir_sayisi / hayir_sayisi;
                double malasie_hayir_sayisi_oran = malasie_hayir_sayisi / hayir_sayisi;
                double anorexia_hayir_sayisi_oran = anorexia_hayir_sayisi / hayir_sayisi;
                double liverbig_hayir_sayisi_oran = liverbig_hayir_sayisi / hayir_sayisi;
                double liverfirm_hayir_sayisi_oran = liverfirm_hayir_sayisi / hayir_sayisi;
                double spleen_hayir_sayisi_oran = spleen_hayir_sayisi / hayir_sayisi;
                double spiders_hayir_sayisi_oran = spiders_hayir_sayisi / hayir_sayisi;
                double actites_hayir_sayisi_oran = actites_hayir_sayisi / hayir_sayisi;
                double varices_hayir_sayisi_oran = varices_hayir_sayisi / hayir_sayisi;
                double bilirubin_hayir_sayisi_oran = bilirubin_hayir_sayisi / hayir_sayisi;
                double alkphosphate_hayir_sayisi_oran = alkphosphate_hayir_sayisi / hayir_sayisi;
                double sgot_hayir_sayisi_oran = sgot_hayir_sayisi / hayir_sayisi;
                double albumin_hayir_sayisi_oran = albumin_hayir_sayisi / hayir_sayisi;
                double protime_hayir_sayisi_oran = protime_hayir_sayisi / hayir_sayisi;

                double tani_evet = class_sayİsi_evet_oran * yas_sayisi_evet_oran * antiviral_evet_sayisi_oran * streoid_sayisi_evet_oran * fatigue_evet_sayisi_oran * histology_evet_oran * anorexia_evet_sayisi_oran * liverbig_evet_sayisi_oran * liverfirm_evet_sayisi_oran * spleen_evet_sayisi_oran * spiders_evet_sayisi_oran * actites_evet_sayisi_oran * varices_evet_sayisi_oran * alkphosphate_evet_sayisi_oran_oran * bilirubin_evet_oran * albumin_evet_sayisi_oran * protime_evet_sayisi_oran * sgot_evet_sayisi_oran;

                double tani_hayir = class_sayisi_hayir_oran * yas_sayisi_hayir_oran * antiviral_hayir_oran * streoid_sayisi_hayir_oran * fatigue_hayir_sayisi_oran * histology_hayir_oran * anorexia_hayir_sayisi_oran * liverbig_hayir_sayisi_oran * liverfirm_hayir_sayisi_oran * spleen_hayir_sayisi_oran * spiders_hayir_sayisi_oran * actites_hayir_sayisi_oran * varices_hayir_sayisi_oran * alkphosphate_hayir_sayisi_oran * bilirubin_hayir_sayisi_oran * albumin_hayir_sayisi_oran * sgot_hayir_sayisi_oran * protime_hayir_sayisi_oran;

                if (tani_evet > tani_hayir)
                {
                    sonuc = "Hepatitsiniz";
                    MessageBox.Show(sonuc);
                }
                else {
                    sonuc = "hepatit değilsiniz";
                    MessageBox.Show(sonuc);
                }

            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            String insertQuery = "Insert into tibbi.bilgiler(adi_soyadi,CLASS,YAS,SEX,STEROID,ANTIVIRALS,FATIGUE,MALAISE,ANOREXIA,LIVERBIG,LIVERFIRM,SPLEENPALPABLE,SPIDERS,ASCITES,VARICES,BILIRUBIN,ALKPHOSPHATE,SGOT,ALBUMIN,PROTIME,HISTOLOGY,HepatitTanisi) Values('" + ad_soyad+"','" + comboBox2.SelectedItem + "','" + comboBox3.SelectedItem + "','" + comboBox4.SelectedItem + "','" + comboBox5.SelectedItem + "','" + comboBox6.SelectedItem + "','" + comboBox1.SelectedItem + "','" + comboBox20.SelectedItem + "','" + comboBox7.SelectedItem + "','" + comboBox8.SelectedItem + "','" + comboBox9.SelectedItem + "','" + comboBox10.SelectedItem + "','" + comboBox11.SelectedItem + "','" + comboBox12.SelectedItem + "','" + comboBox13.SelectedItem + "','" + comboBox14.SelectedItem + "','" + comboBox15.SelectedItem + "','" + comboBox16.SelectedItem + "','" + comboBox17.SelectedItem + "','" + comboBox18.SelectedItem + "','" + comboBox19.SelectedItem + "','" + sonuc.ToString()+ "')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
            try
            {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        //MessageBox.Show("Veri Eklendi");

                    }
                    else
                    {
                       // MessageBox.Show("Veri eklenemedi");
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            
            cikis = MessageBox.Show("Diğer sonuçları görmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                this.Hide();
                frm.Show();

            }
            else if(cikis == DialogResult.No) { 
                Application.Exit();
            }

        }
        }
    }
}
   
