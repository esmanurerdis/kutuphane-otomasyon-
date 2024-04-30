using Kutuphane.Models;

namespace Kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BookDbContext _db = new BookDbContext();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void uye_submit_Click(object sender, EventArgs e)
        {
            if (uyeId.Text != null)
            {
                int id = int.Parse(uyeId.Text);
                Uye uye = _db.Uyeler.Find(id);

                // INJECT TO OBJ
                uye.adsoyad = uye_adsoyad.Text;
                uye.tc = uye_tc.Text;
                uye.yas = uye_yas.Text;
                uye.cinsiyet = uye_cinsiyet.Text;
                uye.telefon = uye_telefon.Text;
                uye.adres = uye_adres.Text;
                uye.email = uye_email.Text;

                // CLEAN FORM
                uye_adres.Text = null;
                uye_telefon.Text = null;
                uye_cinsiyet.Text = null;
                uye_yas.Text = null;
                uye_tc.Text = null;
                uye_adsoyad.Text = null;
                uye_email.Text = null;

                // SAVE TO DB
                _db.Uyeler.Update(uye);
            }
            else
            {
                // CREATE NEW OBJ
                Uye uye = new Uye();

                // INJECT TO OBJ
                uye.adsoyad = uye_adsoyad.Text;
                uye.tc = uye_tc.Text;
                uye.yas = uye_yas.Text;
                uye.cinsiyet = uye_cinsiyet.Text;
                uye.telefon = uye_telefon.Text;
                uye.adres = uye_adres.Text;
                uye.email = uye_email.Text;

                // CLEAN FORM
                uye_adres.Text = null;
                uye_telefon.Text = null;
                uye_cinsiyet.Text = null;
                uye_yas.Text = null;
                uye_tc.Text = null;
                uye_adsoyad.Text = null;
                uye_email.Text = null;

                // SAVE TO DB
                _db.Uyeler.Add(uye);
            }

            if (_db.SaveChanges() > 0)
            {
                MessageBox.Show("Baþarýlý bir þekilde kaydedildi!");

            }
            else
            {
                MessageBox.Show("Bir hata oluþtu!");
            }
        }

        private void ara_submit_Click(object sender, EventArgs e)
        {
            var type = ara_list.SelectedItem.ToString();
            MessageBox.Show(type + " listesi içinde aranýyor.");
            if (type == "Kitap")
            {
                var kitapListesi = _db.Kitaplar.Where(x => x.barkodno.Contains(searchBox.Text));
                if (kitapListesi != null)
                {
                    Result.Items.Clear();
                    foreach (var kitap in kitapListesi)
                    {
                        Result.Items.Add("kitap-" + kitap.Id+"-"+kitap.barkodno+" , "+kitap.kitapadi);
                    }
                }
                else { MessageBox.Show("Kitap bulunamadý"); }
            }
            else if (type == "Üye")
            {
                var uyeListesi = _db.Uyeler.Where(x => x.adsoyad.Contains(searchBox.Text));
                if (uyeListesi != null)
                {
                    Result.Items.Clear();
                    foreach (var uye in uyeListesi)
                    {
                        Result.Items.Add("uye-" + uye.Id + "-" + uye.adsoyad);
                    }
                    MessageBox.Show("Üyeler bulundu! Sonuç: " + uyeListesi.Count());
                }
                else { MessageBox.Show("Üye bulunamadý"); }
            }
        }

        private void kitap_submit_Click(object sender, EventArgs e)
        {
            if (kitapId.Text != null)
            {
                int id = int.Parse(kitapId.Text);
                Kitap kitap = _db.Kitaplar.Find(id);

                kitap.barkodno = kitap_barkod.Text;
                kitap.kitapadi = kitap_adi.Text;
                kitap.yazari = kitap_yazari.Text;
                kitap.yayinevi = kitap_yayinevi.Text;
                kitap.sayfasayisi = kitap_sayfa.Text;
                kitap.turu = kitap_turu.SelectedItem.ToString();
                kitap.stoksayisi = int.Parse(kitap_stok.Text);
                kitap.rafno = kitap_raf.Text;
                kitap.aciklama = kitap_aciklama.Text;
                kitap.kayittarihi = DateTime.UtcNow;

                kitap_barkod.Text = null;
                kitap_adi.Text = null;
                kitap_yazari.Text = null;
                kitap_yayinevi.Text = null;
                kitap_sayfa.Text = null;
                kitap_stok.Text = null;
                kitap_raf.Text = null;
                kitap_aciklama.Text = null;

                // SAVE TO DB
                _db.Kitaplar.Update(kitap);
            }
            else
            {
                Kitap kitap = new Kitap();

                kitap.barkodno = kitap_barkod.Text;
                kitap.kitapadi = kitap_adi.Text;
                kitap.yazari = kitap_yazari.Text;
                kitap.yayinevi = kitap_yayinevi.Text;
                kitap.sayfasayisi = kitap_sayfa.Text;
                kitap.turu = kitap_turu.SelectedItem.ToString();
                kitap.stoksayisi = int.Parse(kitap_stok.Text);
                kitap.rafno = kitap_raf.Text;
                kitap.aciklama = kitap_aciklama.Text;
                kitap.kayittarihi = DateTime.UtcNow;

                kitap_barkod.Text = null;
                kitap_adi.Text = null;
                kitap_yazari.Text = null;
                kitap_yayinevi.Text = null;
                kitap_sayfa.Text = null;
                kitap_stok.Text = null;
                kitap_raf.Text = null;
                kitap_aciklama.Text = null;

                // SAVE TO DB
                _db.Kitaplar.Add(kitap);
            }


            if (_db.SaveChanges() > 0)
            {
                MessageBox.Show("Baþarýlý bir þekilde kaydedildi!");
            }
            else
            {
                MessageBox.Show("Bir hata oluþtu!");
            }
        }

        private void Result_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = Result.SelectedItem.ToString();
            String[] selectedList = selected.Split('-');
            if (selectedList[0] == "kitap")
            {
                int id = int.Parse(selectedList[1]);
                Kitap data = _db.Kitaplar.Find(id);

                kitap_barkod.Text = data.barkodno;
                kitap_adi.Text = data.kitapadi;
                kitap_yazari.Text = data.yazari;
                kitap_yayinevi.Text = data.yayinevi;
                kitap_sayfa.Text = data.sayfasayisi;
                kitap_stok.Text = data.stoksayisi.ToString();
                kitap_raf.Text = data.rafno;
                kitap_aciklama.Text = data.aciklama;
                kitapId.Text = data.Id.ToString();

            }
            else if (selectedList[0] == "uye")
            {
                int id = int.Parse(selectedList[1]);
                Uye data = _db.Uyeler.Find(id);

                uye_adres.Text = data.adres;
                uye_telefon.Text = data.telefon;
                uye_cinsiyet.Text = data.cinsiyet;
                uye_yas.Text = data.yas;
                uye_tc.Text = data.tc;
                uye_adsoyad.Text = data.adsoyad;
                uye_email.Text = data.email;
                uyeId.Text = data.Id.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selected = Result.SelectedItem.ToString();
            String[] selectedList = selected.Split('-');
            if (selectedList[0] == "kitap")
            {
                int id = int.Parse(selectedList[1]);
                Kitap data = _db.Kitaplar.Find(id);
                _db.Kitaplar.Remove(data);
                _db.SaveChanges();
            }
            else if(selectedList[0] == "uye")
            {
                int id = int.Parse(selectedList[1]);
                Uye data = _db.Uyeler.Find(id);
                _db.Uyeler.Remove(data);
                _db.SaveChanges();
            }
        }
    }
}