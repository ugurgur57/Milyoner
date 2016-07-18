using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milyoner
{
    public partial class frmSoruEkranı : Form
    {
        int zaman = 30;
        int sorusayisi = 1;

        string[] sorular = new string[25];
        char[] cvplar = new char[25];
        string[] buton1 = new string[25];
        string[] buton2 = new string[25];
        string[] buton3 = new string[25];
        string[] buton4 = new string[25];
        int cvp = 0;
        Random rnd = new Random();
        public frmSoruEkranı()
        {
            InitializeComponent();

            sorular[0] = "Aşağıdakilerden hangisi milli bir maçta 4 gol atan futbolcularımızdan değildir?";
            sorular[1] = "Aşağıdakilerden hangisi en fazla milli olan futbolcumuzdur?";
            sorular[2] = "Aşağıdakilerden hangisi Avrupa Birliği’ne üye devletler arasında yer almaz?";
            sorular[3] = "Birleşmiş Milletler Güvenlik Konseyi’nin daimi üyesi olan ülkeler aşağıdakilerden hangisidir?";
            sorular[4] = "Dünya İnsan Hakları Günü hangi gün kutlanır?";
            sorular[5] = "Aşağıdakilerden hangi ikisi 1 Ocak 2007 tarihi itibari ile Avrupa Birliği’ne tam üye olan ülkelerdendir?";
            sorular[6] = "FIFA tarafından 2006 yılının en iyi futbolcusu kim seçilmiştir?";
            sorular[7] = "2006-2007 UEFA Kupasını hangi takım kazanmıştır?";
            sorular[8] = "Amerika Basketbol Liginde (NBA) oynayan ilk Türk oyuncu kimdir";
            sorular[9] = "Mehmet OKUR hangi takımın formasını giymektedir?";
            sorular[10] = "Aşağıdaki takımlardan hangisi 2006-2007 sezonu sonunda Süper Lige yükselen takımlardan değildir?";
            sorular[11] = "Aşağıdakilerden hangisi 2008 Avrupa Eleme Grubu’ndaki rakiplerimizden değildir?";
            sorular[12] = "2007 yılında yapılan 60. Cannes Film Festivali “Altın Palmiye” ödülünü kazanan film hangisidir?";
            sorular[13] = "“Yaşamın Kıyısında” filmi ile 2007 yılında düzenlenen 60. Cannes Film Festivalinde en iyi senaryo ödülü kazanan filmin yönetmeni kimdir?";
            sorular[14] = "23 Mayıs 2007 günü Atina’da oynanan Milan-Liverpol maçı sonucu Şampiyonlar Ligi Kupasını kazanan Milanın gollerini atan futbolcu kimdir?";
            sorular[15] = "2007 yılı Mayıs ayında İstanbulda düzenlenen Sony Ericsson WTA Tour İstanbul Cup 2007 Uluslar arası Bayanlar Tenis Turnuvası’nı kazanan bayan tenisçi kimdir ?";
            sorular[16] = "2006 yılı Kültür Bakanlığı “Kültür ve Sanat Büyük Ödülü”nü alan, özellikle “Mona Roza” isimle şiiri ile tanınan şair, yazar ve düşünce adamı kimdir?";
            sorular[17] = "14. Altın Koza Film Festivalinde (2007) en iyi film ödülü alan sinema filimi aşağıdakilerden hangisidir?";
            sorular[18] = "Türkiye de kaç tane büyük şehir belediyesi vardır?";
            sorular[19] = "Gerekli önlemleri alıp sonra Allah’a güvenmek hangi kavramla ifade edilir?";
            sorular[20] = "İslam dininde karşılık  beklemeden yapılan her güzel davranışa ne ad verilir?";
            sorular[21] = "Abdesti olmayan bir kişi  aşağıdakilerden hangisini yapamaz?";
            sorular[22] = "BBC hangi ülkenin TV kanalıdır?";
            sorular[23] = "Bilgisayar çalışırken bilgilerin geçici olarak üzerine kayıt edildiği birime ne ad verilir?";
            sorular[24] = "Çini işlemeciliğiyle ünlü ilimiz hangisidir?";
            

            cvplar[0] = 'b';
            cvplar[1] = 'd';
            cvplar[2] = 'c';
            cvplar[3] = 'd';
            cvplar[4] = 'b';
            cvplar[5] = 'c';
            cvplar[6] = 'a';
            cvplar[7] = 'b';
            cvplar[8] = 'd';
            cvplar[9] = 'b';
            cvplar[10] = 'b';
            cvplar[11] = 'd';
            cvplar[12] = 'd';
            cvplar[13] = 'd';
            cvplar[14] = 'c';
            cvplar[15] = 'a';
            cvplar[16] = 'b';
            cvplar[17] = 'd';
            cvplar[18] = 'c';
            cvplar[19] = 'a';
            cvplar[20] = 'b';
            cvplar[21] = 'd';
            cvplar[22] = 'c';
            cvplar[23] = 'b';
            cvplar[24] = 'a';
            


            buton1[0] = "a) hakan sukur";
            buton2[0] = "b) tanju çolak";
            buton3[0] = "c) Rıza Saporel";
            buton4[0] = "d) Oktay Dereli";

            buton1[1] = "a) Hakan Şükür";
            buton2[1] = "b) Tugay KErimoğlu";
            buton3[1] = "c) Alpay Ozalan";
            buton4[1] = "d) Rüştü Rençber";

            buton1[2] = "a) Almanya";
            buton2[2] = "b) Belçika";
            buton3[2] = "c) Norveç";
            buton4[2] = "d) Malta";

            buton1[3] = "a) Almanya";
            buton2[3] = "b) Fransa";
            buton3[3] = "c) Çin";
            buton4[3] = "d) Fransa ve Çin";

            buton1[4] = "a) 27 Aralık";
            buton2[4] = "b) 10 Aralık";
            buton3[4] = "c) 27 Nisan";
            buton4[4] = "d) 1 Eylül";

            buton1[5] = "a) Macaristan-Yunanistan";
            buton2[5] = "b) Polonya-Macaristan";
            buton3[5] = "c) Bulgaristan-Romanya";
            buton4[5] = "d) Romanya-Malta";

            buton1[6] = "a) Zidane";
            buton2[6] = "b) Cannavaro";
            buton3[6] = "c) Nedved";
            buton4[6] = "d) Ronaldinho";

            buton1[7] = "a) Barcelona";
            buton2[7] = "b) Sevilla";
            buton3[7] = "c) Espanyol";
            buton4[7] = "d) Real Madrid";

            buton1[8] = "a) Mehmet OKUR";
            buton2[8] = "b) İbrahim KUTLU AY";
            buton3[8] = "c) Hidayet TÜRKOĞLU";
            buton4[8] = "d) Mirsad TÜRKCAN";

            buton1[9] = "a) Miami Heat";
            buton2[9] = "b) Utah Jazz";
            buton3[9] = "c) Chichago Bulls";
            buton4[9] = "d) Detroid Pistons";

            buton1[10] = "a) Gençlerbirliği";
            buton2[10] = "b) İstanbulspor";
            buton3[10] = "c) İstanbul B.B Spor";
            buton4[10] = "d) Kasımpaşa";

            buton1[11] = "a) Yunanistan";
            buton2[11] = "b) Norveç";
            buton3[11] = "c) Moldova";
            buton4[11] = "d) İsveç";
            
            buton1[12] = "a) Yasamın Kıyısında";
            buton2[12] = "b) Tarantiono";
            buton3[12] = "c) Coen Biraderler";
            buton4[12] = "d) 4 Ay 3 Hafta 2 Gün";

            buton1[13] = "a) Yüksel Aksu";
            buton2[13] = "b) Julian Schabel";
            buton3[13] = "c) Osman Sınav";
            buton4[13] = "d) Fatih Akın";

            buton1[14] = "a) Kaka";
            buton2[14] = "b) Pirlo";
            buton3[14] = "c) İnzaghi";
            buton4[14] = "d) gattuso";

            buton1[15] = "a) Elena Demetieve";
            buton2[15] = "b) Aravane Reazi";
            buton3[15] = "c) Maria Sharapova";
            buton4[15] = "d) Venüs Williams";

            buton1[16] = "a) Hilmi Yavuz";
            buton2[16] = "b) Sezai KArakoç";
            buton3[16] = "c) Gülten Dayıoğlu";
            buton4[16] = "d) Fazıl Hüsnü Dağlarca";

            buton1[17] = "a) Cenneti Beklerken";
            buton2[17] = "b) Dondurmam Gaymak";
            buton3[17] = "c) Takva";
            buton4[17] = "d) Beyneminel";

            buton1[18] = "a) 14";
            buton2[18] = "b) 15";
            buton3[18] = "c) 16";
            buton4[18] = "d) 18";

            buton1[19] = "a) Tevekkül";
            buton2[19] = "b) Tefekkül";
            buton3[19] = "c) Teesür";
            buton4[19] = "d) Tedbir";

            buton1[20] = "a) Zekat";
            buton2[20] = "b) Sadaka";
            buton3[20] = "c) Fidye";
            buton4[20] = "d) Hosgörü";

            buton1[21] = "a) Namaz Kılamaz";
            buton2[21] = "b) Habeyi Tavaf Edemez";
            buton3[21] = "c) Kuranı Tutamaz";
            buton4[21] = "d) Hepsi";

            buton1[22] = "a) Almanya";
            buton2[22] = "b) Fransa";
            buton3[22] = "c) İngiltere";
            buton4[22] = "d) İtalya";

            buton1[23] = "a) Harddisk";
            buton2[23] = "b) Ram";
            buton3[23] = "c) Anakart";
            buton4[23] = "d) İşlemci";

            buton1[24] = "a) Kütahya";
            buton2[24] = "b) Bursa";
            buton3[24] = "c) Ankara";
            buton4[24] = "d) İzmit";

            bilince();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        void paraagaci()
        {

            if (sorusayisi == 1)
                lbl1.BackColor = Color.Orange;
            if (sorusayisi == 2)
                lbl2.BackColor = Color.Orange;
            if (sorusayisi == 3)
                lbl3.BackColor = Color.Orange;
            if (sorusayisi == 4)
                lbl4.BackColor = Color.Orange;
            if (sorusayisi == 5)
                lbl5.BackColor = Color.Orange;
            if (sorusayisi == 6)
                lbl6.BackColor = Color.Orange;
            if (sorusayisi == 7)
                lbl7.BackColor = Color.Orange;
            if (sorusayisi == 8)
                lbl8.BackColor = Color.Orange;
            if (sorusayisi == 9)
                lbl9.BackColor = Color.Orange;
            if (sorusayisi == 10)
                lbl10.BackColor = Color.Orange;
            if (sorusayisi == 11)
                lbl11.BackColor = Color.Orange;
            if (sorusayisi == 12)
                lbl12.BackColor = Color.Orange;
        }

        private void btnCekil_Click(object sender, EventArgs e)
        {
            if (sorusayisi == 2)
                MessageBox.Show("Ödülünüz 500TL");
            if (sorusayisi == 3)
                MessageBox.Show("Ödülünüz 1000TL");
            if (sorusayisi == 4)
                MessageBox.Show("Ödülünüz 2000TL");
            if (sorusayisi == 5)
                MessageBox.Show("Ödülünüz 3000TL");
            if (sorusayisi == 6)
                MessageBox.Show("Ödülünüz 5000TL");
            if (sorusayisi == 7)
                MessageBox.Show("Ödülünüz 7500TL");
            if (sorusayisi == 8)
                MessageBox.Show("Ödülünüz 15000TL");
            if (sorusayisi == 9)
                MessageBox.Show("Ödülünüz 30000TL");
            if (sorusayisi == 10)
                MessageBox.Show("Ödülünüz 60000TL");
            if (sorusayisi == 11)
                MessageBox.Show("Ödülünüz 125000TL");
            if (sorusayisi == 12)
                MessageBox.Show("Ödülünüz 250000TL");
            Application.Restart();
        }
        void sorusayisiniartir()
        {
            sorusayisi++;
            
            if (sorusayisi>7)
            {
                tmrZaman.Enabled = false;
                tmrZaman.Stop();
                lblZaman.Visible = false;
                btnCiftCevap.Visible = true;
            }
            if (sorusayisi == 12)
            {
                MessageBox.Show("Tebrikler 1000000 TL Kazandınız");
                Application.Restart();
            }

        }
        void kaybet()
        {
            if (sorusayisi == 1 || sorusayisi == 2)
            {
                MessageBox.Show("Elendiniz... Doğru Cevap Şıkkı "+cvplar[cvp]);
            }
            else if (sorusayisi == 3 || sorusayisi == 4 || sorusayisi == 5 || sorusayisi == 6)
            {
                MessageBox.Show("1000 TL kazandınız... Doğru Cevap Şıkkı "+cvplar[cvp]);
            }
            else if (sorusayisi == 7 || sorusayisi == 8 || sorusayisi == 9 || sorusayisi == 10 || sorusayisi == 111 || sorusayisi == 12)
            {
                MessageBox.Show("15000 TL kazandınız... Doğru Cevap Şıkkı "+cvplar[cvp]);
            }
            Application.Restart();
        }

        public int rastgele()
        {
            int ara = 0;
            int sayac = 0;
            int[] dizi = new int[25];
            dizi[sayac] = ara;
            don:
            cvp = rnd.Next(0, 25);
            if (dizi.Contains(cvp))
            {
                goto don;
            }
            else
            {
                dizi[sayac] = cvp;
                sayac++;
                return cvp;
            }
            
            
        }
        void butongetir()
        {
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;

        }
        void bilince()
        {
            butongetir();
            rastgele();
            txtSoru.Text = sorular[cvp].ToUpper();
            btn1.Text = buton1[cvp].ToUpper();
            btn2.Text = buton2[cvp].ToUpper();
            btn3.Text = buton3[cvp].ToUpper();
            btn4.Text = buton4[cvp].ToUpper();
            if (sorusayisi == 2)
            {
                btnCekil.Visible = true;
            }
            
        }

        void cvpkontrol(char harf)
        {

            if (cvplar[cvp] == harf)
            {
                zaman = 30;
                tmrZaman.Stop();
                MessageBox.Show("Doğru Cevap Verdiniz");
                tmrZaman.Start();
                bilince();
                paraagaci();
            }
            else
            {
                if (ccvp==true && kullan==true)
                {
                    ciftcevap(harf);
                } else
                    kaybet();
            }
                

            sorusayisiniartir();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.Green;
            cvpkontrol('a');
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.BackColor = Color.Green;
            cvpkontrol('b');
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.BackColor = Color.Green;
            cvpkontrol('c');
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.BackColor = Color.Green;
            cvpkontrol('d');
        }

        private void btnYuzde50_Click(object sender, EventArgs e)
        {
            if (cvplar[cvp] == 'a')
            {
                btn2.Visible = false;
                btn4.Visible = false;
            }
            else if (cvplar[cvp] == 'b')
            {
                btn1.Visible = false;
                btn3.Visible = false;
            }
            else if (cvplar[cvp] == 'c')
            {
                btn2.Visible = false;
                btn4.Visible = false;
            }
            else if (cvplar[cvp] == 'd')
            {
                btn1.Visible = false;
                btn2.Visible = false;
            }
            btnYuzde50.Enabled = false;
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
                zaman--;
                lblZaman.Text = zaman.ToString();
                if (zaman == 0)
                {
                    tmrZaman.Enabled = false;
                    MessageBox.Show("Süreniz doldu,Kaybettiniz");
                    Application.Exit();
                }
           
            
        }
        bool ccvp = false; bool kullan = false;
        void ciftcevap(char gelensecenek)
        {
            
            if (gelensecenek == 'a')
                btn1.Hide();
            else if (gelensecenek == 'b')
                btn2.Hide();
            else if (gelensecenek == 'c')
                btn3.Hide();
            else if (gelensecenek == 'd')
                btn4.Hide();
            
        }

        private void btnCiftCevap_Click(object sender, EventArgs e)
        {
            ccvp = true;
            kullan = true;
            btnCiftCevap.Enabled = kullan;
            btnCiftCevap.Visible = false;
        }

        private void btnTelefon_Click(object sender, EventArgs e)
        {
            tmrZaman.Stop(); 
            btnTelefon.Visible = false;
            int a = rnd.Next(1, 101);
            int b = rnd.Next(1, 101 - a);
            int c = rnd.Next(1, (101 - (a + b)));
            int d = rnd.Next(1, (101 - (a + b + c)));
            frmTelefon telefon = new frmTelefon();
            telefon.btnA.Height = a;
            telefon.btnB.Height = b;
            telefon.btnC.Height = c;
            telefon.btnD.Height = d;
            telefon.btnA.Text = a.ToString();
            telefon.btnB.Text = b.ToString();
            telefon.btnC.Text = c.ToString();
            telefon.btnD.Text = d.ToString();
            telefon.Show();
        }

        private void btnSeyirci_Click(object sender, EventArgs e)
        {
            tmrZaman.Stop();
            btnSeyirci.Visible = false;
            int a = rnd.Next(1, 101);
            int b = rnd.Next(1, 101 - a);
            int c = rnd.Next(1, (101 - (a + b)));
            int d = rnd.Next(1, (101 - (a + b + c)));
            frmSeyirci seyirci = new frmSeyirci();
            seyirci.btnA.Height = a;
            seyirci.btnB.Height = b;
            seyirci.btnC.Height = c;
            seyirci.btnD.Height = d;
            seyirci.btnA.Text = a.ToString();
            seyirci.btnB.Text = b.ToString();
            seyirci.btnC.Text = c.ToString();
            seyirci.btnD.Text = d.ToString();
            seyirci.Show();
        }
       
    }
}
