using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8; // Boruların hızı
        int gravity = 10; // Yerçekimi
        int score = 0; // Skor
        bool gameOver = false; // Oyunun bitip bitmediğini kontrol eden bayrak
        Timer gameTimer = new Timer();

        public Form1()
        {
            InitializeComponent();

            // Timer ayarları
            gameTimer.Interval = 20; // 20 ms aralıklarla çalışacak
            gameTimer.Tick += new EventHandler(gameTimerevent);
            gameTimer.Start();

            // Klavye olaylarını form üzerinde kullanmak için tanımlama
            this.KeyDown += new KeyEventHandler(gamekeyisdown);
            this.KeyUp += new KeyEventHandler(gamekeyisup);
            this.KeyPreview = true; // Form klavye olaylarını algılar
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Oyunun başlatılması için gerekli ayarlar yapılabilir
        }

        private void gameTimerevent(object sender, EventArgs e)
        {
            if (gameOver) return; // Eğer oyun bittiyse, işlemleri durdur

            // Oyuncunun yerçekimi etkisiyle aşağı düşmesi
            salihkafa.Top += gravity;

            // Boruların sola hareket etmesi
            ustDirek.Left -= pipeSpeed;
            altDirek.Left -= pipeSpeed;

            // Skor güncellenmesi
            scoreLbl.Text = "Score: " + score;

            // Üst boru ekrandan çıkarsa yeniden pozisyonla
            if (ustDirek.Left < -150)
            {
                ustDirek.Left = this.ClientSize.Width;
                score++;
            }

            // Alt boru ekrandan çıkarsa yeniden pozisyonla
            if (altDirek.Left < -150)
            {
                altDirek.Left = this.ClientSize.Width;
                score++;
            }

            // Çarpışma kontrolü
            if (salihkafa.Bounds.IntersectsWith(ustDirek.Bounds) || salihkafa.Bounds.IntersectsWith(altDirek.Bounds) ||
                salihkafa.Top < 0 || salihkafa.Bottom > this.ClientSize.Height)
            {
                endGame();
            }

            // Skor belirli bir seviyeye gelince boru hızını arttır
            if (score > 5)
            {
                pipeSpeed = 10;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10; // Boşluk tuşuna basıldığında yerçekimini tersine çevir
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10; // Boşluk tuşu bırakıldığında yerçekimini normale döndür
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            gameOver = true; // Oyunun bittiğini belirten bayrak
            scoreLbl.Text += " Game Over!!!";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Buraya `Label` tıklama olayında yapılması gereken işlemleri ekleyebilirsiniz.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Buraya `PictureBox` tıklama olayında yapılması gereken işlemleri ekleyebilirsiniz.
        }
    }
}
