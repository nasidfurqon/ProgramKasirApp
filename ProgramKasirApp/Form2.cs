using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramKasirApp
{
    public partial class Form2 : Form
    {     
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            tbSubTtlNasi.Enabled=false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void tbHarga_TextChanged(object sender, EventArgs e)
        {
            tbHargaNasi.Enabled = false;
        }

        private void tbSubTotal_TextChanged(object sender, EventArgs e)
        {
            var jmlNasiGoreng = Convert.ToInt32(tbJmNasiGoreng.Text);
            var hargaNasiGoreng = Convert.ToInt32(tbHargaNasiGoreng.Text);
            var subNasiGoreng = jmlNasiGoreng*hargaNasiGoreng;
            var subNasiGorengString = Convert.ToString(subNasiGoreng);
            tbSubTtlNasiGoreng.Text=subNasiGorengString;
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            tbTotal.Enabled = false;
        }

        private void tbBayar_TextChanged(object sender, EventArgs e)
        {
            var bayar = Convert.ToInt32(tbBayar.Text);
            var total = Convert.ToInt32(tbTotal.Text);
            var kembali = bayar - total;
            var StringKembali = Convert.ToString(kembali);
            tbKembali.Text = StringKembali;
        }

        private void tbKembali_TextChanged(object sender, EventArgs e)
        {
            tbKembali.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbHargaNasi.Text="3000";
        }

        private void checkedListBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbHargaTeh.Text="3000";
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbHargaNasiGoreng.Text="10000";
        }

        private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbAyamBakar.Text="15000";
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbAyamGoreng.Text="13000";
        }

        private void checkedListBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbHargaJeruk.Text="3000";
        }

        private void checkedListBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbHargaKelapa.Text="5000";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbHargaBuah.Text="7000";
        }

        private void tbJumlahNasi_TextChanged(object sender, EventArgs e)
        {
            var jmlNasi = Convert.ToInt32(tbJumlahNasi.Text);
            var hrgNasi = Convert.ToInt32(tbHargaNasi.Text);
            var subttlNasi = jmlNasi*hrgNasi;
            var subttlNasiString = Convert.ToString(subttlNasi);
            tbSubTtlNasi.Text=subttlNasiString;
        }

        private void tbJmAyamBakar_TextChanged(object sender, EventArgs e)
        {
            var jmlAyamBakar = Convert.ToInt32(tbJmAyamBakar.Text);
            var hrgAyamBakar = Convert.ToInt32(tbAyamBakar.Text);
            var subttlAyamBakar = jmlAyamBakar*hrgAyamBakar;
            var subttlAyamBakarString = Convert.ToString(subttlAyamBakar);
            tbSubTtlAyamBkr.Text=subttlAyamBakarString;
        }

        private void tbJmAyamGoreng_TextChanged(object sender, EventArgs e)
        {
            var jmlAyamGoreng = Convert.ToInt32(tbJmAyamGoreng.Text);
            var hrgAyamGoreng = Convert.ToInt32(tbAyamGoreng.Text);
            var subttlAyamGoreng = jmlAyamGoreng*hrgAyamGoreng;
            var subttlAyamGorengString = Convert.ToString(subttlAyamGoreng);
            tbSubTlAyamGrng.Text=subttlAyamGorengString;
        }

        private void tbSubTtlNasiGoreng_TextChanged(object sender, EventArgs e)
        {
            tbSubTtlNasiGoreng.Enabled=false;
        }

        private void tbSubTtlAyamBkr_TextChanged(object sender, EventArgs e)
        {
            tbSubTtlAyamBkr.Enabled=false;
        }

        private void tbSubTlAyamGrng_TextChanged(object sender, EventArgs e)
        {
            tbSubTlAyamGrng.Enabled=false;
        }

        private void tbHargaNasiGoreng_TextChanged(object sender, EventArgs e)
        {
            tbHargaNasiGoreng.Enabled=false;
        }

        private void tbAyamBakar_TextChanged(object sender, EventArgs e)
        {
            tbAyamBakar.Enabled=false;
        }

        private void tbAyamGoreng_TextChanged(object sender, EventArgs e)
        {
            tbAyamGoreng.Enabled=false;
        }

        private void tbHargaTeh_TextChanged(object sender, EventArgs e)
        {
            tbHargaTeh.Enabled=false;
        }

        private void tbHargaJeruk_TextChanged(object sender, EventArgs e)
        {
            tbHargaJeruk.Enabled=false;
        }

        private void tbHargaKelapa_TextChanged(object sender, EventArgs e)
        {
            tbHargaKelapa.Enabled=false;
        }

        private void tbHargaBuah_TextChanged(object sender, EventArgs e)
        {
            tbHargaBuah.Enabled=false;
        }

        private void tbJumlahTeh_TextChanged(object sender, EventArgs e)
        {
            var jmlTeh = Convert.ToInt32(tbJumlahTeh.Text);
            var hargaTeh = Convert.ToInt32(tbHargaTeh.Text);
            var subTeh = jmlTeh*hargaTeh;
            var subTehString = Convert.ToString(subTeh);
            tbSubTtlTeh.Text=subTehString;
        }

        private void tbJumlahJeruk_TextChanged(object sender, EventArgs e)
        {
            var jmlJeruk = Convert.ToInt32(tbJumlahJeruk.Text);
            var hargaJeruk = Convert.ToInt32(tbHargaJeruk.Text);
            var subJeruk = jmlJeruk*hargaJeruk;
            var subJerukString = Convert.ToString(subJeruk);
            tbSubTtlJeruk.Text=subJerukString;
        }

        private void tbJumlahKlp_TextChanged(object sender, EventArgs e)
        {
            var jmlKelapa = Convert.ToInt32(tbJumlahKlp.Text);
            var hargaKelapa = Convert.ToInt32(tbHargaKelapa.Text);
            var subKelapa = jmlKelapa*hargaKelapa;
            var subKelapaString = Convert.ToString(subKelapa);
            tbSubTtlKlp.Text=subKelapaString;
        }

        private void tbJumlahBuah_TextChanged(object sender, EventArgs e)
        {
            var jmlBuah = Convert.ToInt32(tbJumlahBuah.Text);
            var hargaBuah = Convert.ToInt32(tbHargaBuah.Text);
            var subBuah = jmlBuah*hargaBuah;
            var subBuahString = Convert.ToString(subBuah);
            tbSubTtlBuah.Text=subBuahString;
        }

        private void tbSubTtlTeh_TextChanged(object sender, EventArgs e)
        {
            tbSubTtlTeh.Enabled=false;
        }

        private void tbSubTtlJeruk_TextChanged(object sender, EventArgs e)
        {
            tbSubTtlJeruk.Enabled=false;
        }

        private void tbSubTtlKlp_TextChanged(object sender, EventArgs e)
        {
            tbSubTtlKlp.Enabled=false;
        }

        private void tbSubTtlBuah_TextChanged(object sender, EventArgs e)
        {
            tbSubTtlBuah.Enabled=false;
        }

        private void tbTanggal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var ttlAyamGoreng = Convert.ToInt32(tbSubTlAyamGrng.Text);
            var ttlAyamBakar = Convert.ToInt32(tbSubTtlAyamBkr.Text);
            var ttlNasi = Convert.ToInt32(tbSubTtlNasi.Text);
            var ttlNasiGoreng = Convert.ToInt32(tbSubTtlNasiGoreng.Text);
            var ttlTeh = Convert.ToInt32(tbSubTtlTeh.Text);
            var ttlJeruk = Convert.ToInt32(tbSubTtlJeruk.Text);
            var ttlKlp = Convert.ToInt32(tbSubTtlKlp.Text);
            var ttlBuah = Convert.ToInt32(tbSubTtlBuah.Text);
            var totalPembelian = ttlAyamGoreng+ttlAyamBakar+ttlNasi+ttlNasiGoreng+ttlTeh+ttlJeruk+ttlKlp
                +ttlBuah;
            var totalString = Convert.ToString(totalPembelian);
            tbTotal.Text=totalString;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}




