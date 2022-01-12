using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        // Değişkenler
        private bool oyuncu1_sira = true;
        private int[,] boardDegeri = new int[3, 3];
        const int X_degeri = 1;
        const int O_degeri = 2;

        public Form1()
        {
            InitializeComponent();
            yeniden_baslat();
            oyuncu1_sira = true;
        }

        // XOX DÜĞMELERİ -------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            if (oyuncu1_sira == true)
            {
                oyuncu1_sira = false;
                ((Button)sender).Text = "X";
                boardDegeri[0, 0] = X_degeri;
            }
            else
            {
                oyuncu1_sira = true;
                ((Button)sender).Text = "O";
                boardDegeri[0, 0] = O_degeri;
            }

            kazanani_kontrol_et();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (oyuncu1_sira == true)
            {
                oyuncu1_sira = false;
                ((Button)sender).Text = "X";
                boardDegeri[0, 1] = X_degeri;
            }
            else
            {
                oyuncu1_sira = true;
                ((Button)sender).Text = "O";
                boardDegeri[0, 1] = O_degeri;
            }
            kazanani_kontrol_et();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (oyuncu1_sira == true)
            {   
                oyuncu1_sira = false;
                ((Button)sender).Text = "X";
                boardDegeri[0, 2] = X_degeri;
            }
            else
            {
                oyuncu1_sira = true;
                ((Button)sender).Text = "O";
                boardDegeri[0, 2] = O_degeri;
            }
            kazanani_kontrol_et(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (oyuncu1_sira == true)
            {
                oyuncu1_sira = false;
                ((Button)sender).Text = "X";
                boardDegeri[1, 0] = X_degeri;
            }
            else
            {
                oyuncu1_sira = true;
                ((Button)sender).Text = "O";
                boardDegeri[1, 0] = O_degeri;
            }
            kazanani_kontrol_et();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (oyuncu1_sira == true)
            {
                oyuncu1_sira = false;
                ((Button)sender).Text = "X";
                boardDegeri[1, 1] = X_degeri;
            }
            else
            {
                oyuncu1_sira = true;
                ((Button)sender).Text = "O";
                boardDegeri[1, 1] = O_degeri;
            }
            kazanani_kontrol_et();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (oyuncu1_sira == true)
            {
                oyuncu1_sira = false;
                ((Button)sender).Text = "X";
                boardDegeri[1, 2] = X_degeri;
            }
            else
            {
                oyuncu1_sira = true;
                ((Button)sender).Text = "O";
                boardDegeri[1, 2] = O_degeri;
            }
            kazanani_kontrol_et();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (oyuncu1_sira == true)
            {
                oyuncu1_sira = false;
                ((Button)sender).Text = "X";
                boardDegeri[2, 0] = X_degeri;
            }
            else
            {
                oyuncu1_sira = true;
                ((Button)sender).Text = "O";
                boardDegeri[2, 0] = O_degeri;
            }
            kazanani_kontrol_et();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (oyuncu1_sira == true)
            {
                oyuncu1_sira = false;
                ((Button)sender).Text = "X";
                boardDegeri[2, 1] = X_degeri;
            }
            else
            {
                oyuncu1_sira = true;
                ((Button)sender).Text = "O";
                boardDegeri[2, 1] = O_degeri;
            }
            kazanani_kontrol_et();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (oyuncu1_sira == true)
            {
                oyuncu1_sira = false;
                ((Button)sender).Text = "X";
                boardDegeri[2, 2] = X_degeri;
            }
            else
            {
                oyuncu1_sira = true;
                ((Button)sender).Text = "O";
                boardDegeri[2, 2] = O_degeri;
            }
            kazanani_kontrol_et();
        }
        // XOX DÜĞMELERİ -------------------------------

        // XOX MATRİSİ
        private void kazanani_kontrol_et()
        {
            // SATIR KONTROLÜ
            for (int i = 0; i < 3; ++i)
            {
                if (Convert.ToInt32(boardDegeri[i, 0]) == Convert.ToInt32(boardDegeri[i, 1]) &&
                    Convert.ToInt32(boardDegeri[i, 1]) == Convert.ToInt32(boardDegeri[i, 2]) &&
                    Convert.ToInt32(boardDegeri[i, 1]) != 0)
                {
                    kazandin_dugmeleri_renk(degerden_dugme_bulma(i, 0),
                        degerden_dugme_bulma(i, 1),
                        degerden_dugme_bulma(i, 2));
                    kazandin_ekrani_goruntule(boardDegeri[i, 0]);

                    return;
                }
            }

            // SÜTUN KONTROLÜ
            for (int i = 0; i < 3; ++i)
            {
                if (Convert.ToInt32(boardDegeri[0, i]) == Convert.ToInt32(boardDegeri[1, i]) &&
                    Convert.ToInt32(boardDegeri[1, i]) == Convert.ToInt32(boardDegeri[2, i]) &&
                    Convert.ToInt32(boardDegeri[2, i]) != 0)
                {
                    kazandin_dugmeleri_renk(degerden_dugme_bulma(0, i),
                        degerden_dugme_bulma(1, i),
                        degerden_dugme_bulma(2, i));
                    kazandin_ekrani_goruntule(boardDegeri[1, i]);
                    return;
                }
            }

            // ÇAPRAZLAR KONTROLÜ
            if (Convert.ToInt32(boardDegeri[0, 0]) == Convert.ToInt32(boardDegeri[1, 1]) &&
                Convert.ToInt32(boardDegeri[1, 1]) == Convert.ToInt32(boardDegeri[2, 2]) &&
                Convert.ToInt32(boardDegeri[2, 2]) != 0)
            {
                kazandin_dugmeleri_renk(degerden_dugme_bulma(0, 0),
                    degerden_dugme_bulma(1, 1),
                    degerden_dugme_bulma(2, 2));
                kazandin_ekrani_goruntule(boardDegeri[1, 1]);
                return;
            }
            else if (Convert.ToInt32(boardDegeri[0, 2]) == Convert.ToInt32(boardDegeri[1, 1]) &&
              Convert.ToInt32(boardDegeri[1, 1]) == Convert.ToInt32(boardDegeri[2, 0]) &&
              Convert.ToInt32(boardDegeri[2, 0]) != 0)
            {
                kazandin_dugmeleri_renk(degerden_dugme_bulma(0, 2),
                    degerden_dugme_bulma(1, 1),
                    degerden_dugme_bulma(2, 0));
                kazandin_ekrani_goruntule(boardDegeri[1, 1]);
                return;
            }

            // BERABERE KONTROLÜ
            bool berabere = true;
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; j++)
                    if (boardDegeri[i, j] == 0)
                        berabere = false;
            if (berabere)
            {
                MessageBox.Show("BERABERE");
                yeniden_baslat();
            }
        }

        // KAZANDIN MESAJI
        private void kazandin_ekrani_goruntule(int deger)
        {
            if (deger == X_degeri)
            {
                MessageBox.Show("1. OYUNCU KAZANDI !");
                int oyuncu1_skoru = Convert.ToInt32(label6.Text);
                ++oyuncu1_skoru;
                label6.Text = oyuncu1_skoru.ToString();
            }
            else
            {
                MessageBox.Show("2. OYUNCU KAZANDI !");
                int oyuncu2_skoru = Convert.ToInt32(label7.Text);
                ++oyuncu2_skoru;
                label7.Text = oyuncu2_skoru.ToString();
            }

            yeniden_baslat();
        }

        // XOX OYUNU YENİDEN BAŞLAT
        private void yeniden_baslat()
        {
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    boardDegeri[i, j] = 0;

            temizle_dugmeleri();
            oyuncu1_sira = true;
        }

        // KAZANDIN DÜĞMELERİ
        private void kazandin_dugmeleri_renk(Button button1, Button button2, Button button3)
        {
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
        }

        // TEMİZLE DÜĞMELERİ
        private void temizle_dugmeleri()
        {
            // İÇERİK
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            // ARKAPLAN RENGİ
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Green;
            button4.BackColor = Color.Green;
            button5.BackColor = Color.Green;
            button6.BackColor = Color.Green;
            button7.BackColor = Color.Green;
            button8.BackColor = Color.Green;
            button9.BackColor = Color.Green;

            // KARAKTER RENKLERİ
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button8.ForeColor = Color.White;
            button9.ForeColor = Color.White;
        }

        
        private Button degerden_dugme_bulma(int deger_x, int deger_y)
        {
            switch (deger_x)
            {
                case 0:
                    if (deger_y == 0)
                        return button1;
                    if (deger_y == 1)
                        return button2;
                    if (deger_y == 2)
                        return button3;
                    return button1;
                    break;
                case 1:
                    if (deger_y == 0)
                        return button6;
                    if (deger_y == 1)
                        return button5;
                    if (deger_y == 2)
                        return button4;
                    return button1;
                    break;
                case 2:
                    if (deger_y == 0)
                        return button9;
                    if (deger_y == 1)
                        return button8;
                    if (deger_y == 2)
                        return button7;
                    return button1;
                    break;

                default:
                    yeniden_baslat();
                    MessageBox.Show("BİR AKSİLİK OLDU ?!");
                    return button1;
            }
        }

        // AKTİF OYUNCU
        private void zamanlayici1_isaret(object sender, EventArgs e)
        {
            if (oyuncu1_sira == true)
            {
                label1.ForeColor = Color.Green;
                label2.ForeColor = Color.Black;
            }
            else
            {
                label2.ForeColor = Color.Green;
                label1.ForeColor = Color.Black;
            }
        }

        // OYUNU BAŞTAN BAŞLAT
        private void button10_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void TITLE_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
