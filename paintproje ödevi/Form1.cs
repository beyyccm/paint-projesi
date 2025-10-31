using System; // Gerekli System kütüphanesini kullanarak temel özelliklere erişim sağlanır.
using System.Collections.Generic; // List ve Stack gibi veri yapıları için kullanılır.
using System.ComponentModel; // Bileşen özellikleri için gereken yapılar için gerekli olan kütüphanedir.
using System.Data; // Veritabanı ile ilgili işlemler için.
using System.Drawing; // Grafik işlemleri ve resim oluşturma ile ilgili sınıflar için gerekli kütüphane.
using System.Drawing.Imaging; // Resimlerin kaydedilmesi ve düzenlenmesi ile ilgili gerekli sınıflar.
using System.Linq; // Koleksiyonlar üzerinde LINQ sorguları yapmak için.
using System.Reflection; // Reflection ile türler hakkında bilgi almak için.
using System.Text; // String işlemleri ve metin manipülasyonları için.
using System.Threading.Tasks; // Asenkron işlemler ve paralel işleme desteği sağlamak için.
using System.Windows.Forms; // Windows Forms bileşenlerini, form yönetimini sağlayan kütüphane.

namespace paintproje_ödevi
{
    public partial class Form1 : Form
    {
        Bitmap bm; // Çizimlerin yapılacağı Bitmap (resim) nesnesi.
        Graphics g; // Grafikler üzerinde çizim yapmayı sağlayan nesne.
        bool paint = false; // Çizim işlemi aktif mi, onu belirler.
        Point px, py; // Çizim başlatıldığında başlangıç noktasını (x, y) belirlemek için kullanılır.
        Pen p = new Pen(Color.Black, 1); // Kalemin rengi siyah ve boyutu 1px.
        Pen silgi = new Pen(Color.White, 10); // Silginin rengi beyaz ve boyutu 10px.
        int index; // Yapılacak işlemin türünü belirleyen değişken.
        int x, y, sx, sy, cx, cy; // Çizim koordinatları ve konum farkları için kullanılan değişkenler.
        Color New_Color; // Yeni renk seçimi için kullanılan renk değişkeni.
        ColorDialog cd = new ColorDialog(); // Kullanıcıya renk seçim penceresi açar.

        public Form1()
        {
            InitializeComponent(); // Formun tüm bileşenlerini başlatır.
            bm = new Bitmap(pic.Width, pic.Height); // PictureBox'ın boyutunda bir Bitmap oluşturur.
            g = Graphics.FromImage(bm); // Bitmap üzerinde çizim yapabilmek için Graphics nesnesini oluşturur.
            g.Clear(Color.White); // Çizim alanını beyaz renkle temizler.
            pic.Image = bm; // PictureBox'a, Bitmap'i gösterir.

            // Kalem boyutu için varsayılan değer
            p.Width = 1; // Kalem için başlangıç boyutunu 1 olarak ayarlar.
            silgi.Width = 10; // Silginin boyutunu 10 olarak ayarlar.

            // Varsayılan boyut NumericUpDown veya TrackBar kontrolüne bağlı
            numPenSize.Value = 1; // Eğer mevcutsa numPenSize kontrolüne varsayılan değeri atar.
        }

        // Kalem seçildiğinde yapılacak işlemleri belirleyen buton olay fonksiyonu
        private void btnkalem_Click(object sender, EventArgs e)
        {
            index = 1; // Çizim modu aktif edilir.
        }

        // Fare tıklama işlemi başlatıldığında kullanılacak fonksiyon
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true; // Çizim işlemine başla.
            py = e.Location; // Fare basıldığında, farenin konumunu al.
            cx = e.X; // Başlangıç X koordinatını kaydet.
            cy = e.Y; // Başlangıç Y koordinatını kaydet.
        }

        // Çizgi butonuna tıklanması durumunda çizim tipi değiştirilir.
        private void btnçizgi_Click(object sender, EventArgs e)
        {
            index = 5; // Çizgi çizme modu seçilir.
        }

        // PictureBox üzerinde çizim yapılırken çağrılır
        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Event üzerinden gelen Graphics nesnesi ile çizim yapılacak alan belirlenir.
            if (paint) // Çizim işlemi aktifse
            {
                if (index == 3) // Eğer şekil tipi "Elips" ise
                {
                    g.DrawEllipse(p, cx, cy, sx, sy); // Elips çizer.
                }
                if (index == 4) // Eğer şekil tipi "Dikdörtgen" ise
                {
                    g.DrawRectangle(p, cx, cy, sx, sy); // Dikdörtgen çizer.
                }
                if (index == 5) // Eğer şekil tipi "Çizgi" ise
                {
                    g.DrawLine(p, cx, cy, x, y); // Çizgi çizer.
                }
                if (index == 7) // Eğer şekil tipi "Üçgen" ise
                {
                    Point[] points = {
                      new Point((cx + x) / 2, cy), // Üçgenin üst köşesi
                      new Point(cx, y),           // Üçgenin sol alt köşesi
                      new Point(x, y)             // Üçgenin sağ alt köşesi
                 };
                    g.DrawPolygon(p, points); // Üçgen çizer.
                }
            }
        }

        // Fare hareket ederken çizimi yapmak için kullanılır
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint) // Eğer çizim yapılıyorsa
            {
                if (index == 1) // Eğer kalem seçiliyse
                {
                    px = e.Location; // Fare konumunu kaydet
                    g.DrawLine(p, px, py); // Kalemle çizgi çizer
                    py = px; // Yeni başlangıç noktasını güncelle
                }
                if (index == 2) // Eğer silgi seçiliyse
                {
                    px = e.Location; // Fare konumunu kaydet
                    g.DrawLine(silgi, px, py); // Silgi ile çizgi çizer
                    py = px; // Yeni başlangıç noktasını güncelle
                }
            }
            pic.Refresh(); // PictureBox'ı yeniden çizer, böylece çizim sürekli güncellenir.

            x = e.X; // Fare X koordinatını güncelle
            y = e.Y; // Fare Y koordinatını güncelle
            sx = e.X - cx; // Başlangıç ve şimdiki X arasındaki farkı hesapla
            sy = e.Y - cy; // Başlangıç ve şimdiki Y arasındaki farkı hesapla
        }

        // Fare tuşu bırakıldığında çizimi sonlandıran işlem
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false; // Çizim sona erer.

            sx = x - cx; // X farkını hesapla
            sy = y - cy; // Y farkını hesapla
            if (index == 3) // Eğer şekil elipsse
            {
                g.DrawEllipse(p, cx, cy, sx, sy); // Elips çizer.
            }
            if (index == 4) // Eğer şekil dikdörtgense
            {
                g.DrawRectangle(p, cx, cy, sx, sy); // Dikdörtgen çizer.
            }
            if (index == 5) // Eğer şekil çizgi ise
            {
                g.DrawLine(p, cx, cy, x, y); // Çizgi çizer.
            }
            if (index == 7) // Eğer şekil üçgen ise
            {
                Point[] points = {
                      new Point((cx + x) / 2, cy), // Üçgenin üst köşesi
                      new Point(cx, y),           // Üçgenin sol alt köşesi
                      new Point(x, y)             // Üçgenin sağ alt köşesi
                 };
                g.DrawPolygon(p, points); // Üçgen çizer.
            }
        }

        // Silgi butonuna tıklandığında çizim modunu değiştirir
        private void btnsilgi_Click(object sender, EventArgs e)
        {
            index = 2; // Silgi modu aktif edilir.
        }

        // Üçgen butonuna tıklandığında çizim modunu üçgen yapar
        private void btnüçgen_Click(object sender, EventArgs e)
        {
            index = 7; // Üçgen çizme modu seçilir.
        }

        // Elips butonuna tıklandığında elips çizme moduna geçilir
        private void btnelips_Click(object sender, EventArgs e)
        {
            index = 3; // Elips çizme modu seçilir.
        }

        // Kare butonuna tıklanınca dikdörtgen (kare) çizme moduna geçilir
        private void btnkare_Click(object sender, EventArgs e)
        {
            index = 4; // Dikdörtgen (kare) çizme modu seçilir.
        }

        // Temizleme butonuna tıklanınca çizim alanını temizler
        private void btntemizle_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White); // Çizim alanını beyaz ile temizler.
            pic.Image = bm; // Temizlenen Bitmap tekrar PictureBox'a eklenir.
            index = 0; // Tüm çizim modları sıfırlanır.
        }

        // Boyama butonuna tıklandığında renk doldurma işlemine geçilir
        private void btnboyama_Click(object sender, EventArgs e)
        {
            index = 6; // Boyama (doldurma) modu aktif edilir.
        }

        // Kalem boyutu NumericUpDown kontrolüyle değiştiğinde yapılacak işlemi belirler
        private void numPenSize_ValueChanged(object sender, EventArgs e)
        {
            p.Width = (float)numPenSize.Value; // Kalem boyutunu NumericUpDown'dan alınan değere ayarlar.
            silgi.Width = (float)numPenSize.Value; // Silgi boyutunu aynı değere ayarlar.
        }

        // Dosya açma işlemi; resmi yükler
        private void btnDosyaAc_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()) // Resim dosyası açma penceresi başlatılır
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*"; 
                // Yalnızca resim dosyalarını seçmeye izin verir.
                if (ofd.ShowDialog() == DialogResult.OK) // Kullanıcı bir dosya seçerse
                {
                    try
                    {
                        // Seçilen resmi yükleme
                        Bitmap openedImage = new Bitmap(ofd.FileName); // Dosyayı bir Bitmap nesnesine çevirir.

                        // PictureBox'a ve Bitmap değişkenine yükleme
                        bm = openedImage; // Bitmap'i günceller
                        g = Graphics.FromImage(bm); // Grafik nesnesini oluşturur
                        pic.Image = bm; // PictureBox'ı yeni resimle günceller
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Resmi yüklerken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                        // Hata mesajı gösterir.
                    }
                }
            }
        }

        // Belirli bir noktayı yeniden boyutlandırarak PictureBox ile uyumlu hale getirir
        static Point set_Point(PictureBox pb, Point pt)
        {
            float px = 1f * pb.Width / pb.Width; // X koordinatının doğru boyutlandırılması
            float py = 1f * pb.Height / pb.Height; // Y koordinatının doğru boyutlandırılması
            return new Point((int)(pt.X * px), (int)(pt.Y * py)); // Yeni noktayı döndürür
        }

        // Pixels üzerinde yıkama (flood fill) işlemi yapmak için fonksiyon
        private void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color Old_color, Color New_color)
        {
            Color cx = bm.GetPixel(x, y); // Mevcut piksel rengini al.
            if (cx == Old_color) // Eğer eski renk ile uyuşuyorsa
            {
                sp.Push(new Point(x, y)); // Yeni pikseli yığına ekle
                bm.SetPixel(x, y, New_color); // Yeni renge boya.
            }
        }

        // Yıkama işlemi; tüm yüklü pikselleri tarayarak doldurma işlemi yapar.
        public void Fill(Bitmap bm, int x, int y, Color New_Clr)
        {
            Color Old_Color = bm.GetPixel(x, y); // Başlangıç rengi alınır.
            Stack<Point> pixcel = new Stack<Point>(); // Stack üzerinden işlemler yapılacak.
            pixcel.Push(new Point(x, y)); // İlk noktayı yığına ekleriz.
            bm.SetPixel(x, y, New_Clr); // İlk noktayı yeni renge boyar.
            if (Old_Color == New_Clr) { return; } // Yeni renk ile aynıysa işlemi sonlandır.

            while (pixcel.Count > 0) // Yığın boşalana kadar
            {
                Point pt = (Point)pixcel.Pop(); // Yığından bir piksel al
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1) 
                    // Pikselin bitmap'in içinde olup olmadığını kontrol et
                {
                    // Yandaki piksellere yıkama uygula
                    Validate(bm, pixcel, pt.X - 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixcel, pt.X, pt.Y - 1, Old_Color, New_Clr);
                    Validate(bm, pixcel, pt.X + 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixcel, pt.X, pt.Y + 1, Old_Color, New_Clr);
                }
            }
        }

        // Fare tıklama işlemi gerçekleştirilince dolgu yapar
        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 6) // Boyama modunda olduğunda
            {
                Point point = set_Point(pic, e.Location); // Konumu doğru boyutlandır.
                Fill(bm, point.X, point.Y, New_Color); // Yıkama işlemi yaparak resmi doldur.
            }
        }

        // Renk seçme butonuna tıklandığında renk seçim penceresi açılır
        private void btnrenkler_Click(object sender, EventArgs e)
        {
            cd.ShowDialog(); // Renk seçme penceresini açar.
            New_Color = cd.Color; // Yeni rengi alır.
            pic.BackColor = cd.Color; // PictureBox'ın arka plan rengini yeni renk ile günceller.
            p.Color = cd.Color; // Kalemin rengini yeni renk ile değiştirir.
        }

        // Çizim alanını kaydeder
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog(); // Kaydetme işlemi için yeni bir pencere açar.
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*"; // Dosya türü filtresi, resimleri jpg formatında kaydeder.
            if (sfd.ShowDialog() == DialogResult.OK) // Dosya kaydedilmek üzere seçilmişse
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                // Bitmap'i kopyalar.
                btm.Save(sfd.FileName, ImageFormat.Jpeg); // JPG formatında kaydeder.
            }
        }
    }
}
