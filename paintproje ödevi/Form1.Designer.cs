namespace paintproje_ödevi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnkalem = new System.Windows.Forms.Button();
            this.btnsilgi = new System.Windows.Forms.Button();
            this.btndikdörtgen = new System.Windows.Forms.Button();
            this.btnçizgi = new System.Windows.Forms.Button();
            this.btnboyama = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnelips = new System.Windows.Forms.Button();
            this.btnüçgen = new System.Windows.Forms.Button();
            this.btnrenkler = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numPenSize = new System.Windows.Forms.NumericUpDown();
            this.btnDosyaAc = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPenSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnDosyaAc);
            this.panel1.Controls.Add(this.numPenSize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btntemizle);
            this.panel1.Controls.Add(this.btnkalem);
            this.panel1.Controls.Add(this.btnsilgi);
            this.panel1.Controls.Add(this.btndikdörtgen);
            this.panel1.Controls.Add(this.btnçizgi);
            this.panel1.Controls.Add(this.btnboyama);
            this.panel1.Controls.Add(this.btnkaydet);
            this.panel1.Controls.Add(this.btnelips);
            this.panel1.Controls.Add(this.btnüçgen);
            this.panel1.Controls.Add(this.btnrenkler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 164);
            this.panel1.TabIndex = 0;
            // 
            // btntemizle
            // 
            this.btntemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntemizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btntemizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btntemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntemizle.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntemizle.ForeColor = System.Drawing.Color.Turquoise;
            this.btntemizle.Location = new System.Drawing.Point(895, 57);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(84, 36);
            this.btntemizle.TabIndex = 2;
            this.btntemizle.Text = "Sil";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnkalem
            // 
            this.btnkalem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnkalem.BackgroundImage = global::paintproje_ödevi.Properties.Resources.sticker_png_pencil_drawing_mechanical_pencil_black_blackandwhite_line_triangle_logo;
            this.btnkalem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnkalem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkalem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnkalem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnkalem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkalem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnkalem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkalem.Location = new System.Drawing.Point(237, 16);
            this.btnkalem.Name = "btnkalem";
            this.btnkalem.Size = new System.Drawing.Size(104, 105);
            this.btnkalem.TabIndex = 2;
            this.btnkalem.UseVisualStyleBackColor = false;
            this.btnkalem.Click += new System.EventHandler(this.btnkalem_Click);
            // 
            // btnsilgi
            // 
            this.btnsilgi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsilgi.BackgroundImage = global::paintproje_ödevi.Properties.Resources.png_transparent_eraser_guesswork_heroes_of_cosplay_drawing_eraser_blue_pencil_logo;
            this.btnsilgi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsilgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsilgi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnsilgi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnsilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsilgi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnsilgi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsilgi.Location = new System.Drawing.Point(347, 16);
            this.btnsilgi.Name = "btnsilgi";
            this.btnsilgi.Size = new System.Drawing.Size(104, 105);
            this.btnsilgi.TabIndex = 3;
            this.btnsilgi.UseVisualStyleBackColor = false;
            this.btnsilgi.Click += new System.EventHandler(this.btnsilgi_Click);
            // 
            // btndikdörtgen
            // 
            this.btndikdörtgen.BackgroundImage = global::paintproje_ödevi.Properties.Resources.png_transparent_square_squares_miscellaneous_angle_white_thumbnail;
            this.btndikdörtgen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndikdörtgen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndikdörtgen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btndikdörtgen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btndikdörtgen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndikdörtgen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btndikdörtgen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndikdörtgen.Location = new System.Drawing.Point(567, 16);
            this.btndikdörtgen.Name = "btndikdörtgen";
            this.btndikdörtgen.Size = new System.Drawing.Size(104, 105);
            this.btndikdörtgen.TabIndex = 5;
            this.btndikdörtgen.UseVisualStyleBackColor = true;
            this.btndikdörtgen.Click += new System.EventHandler(this.btnkare_Click);
            // 
            // btnçizgi
            // 
            this.btnçizgi.BackgroundImage = global::paintproje_ödevi.Properties.Resources.png_transparent_line_font_line_rectangle_black_art;
            this.btnçizgi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnçizgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnçizgi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnçizgi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnçizgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnçizgi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnçizgi.Location = new System.Drawing.Point(785, 16);
            this.btnçizgi.Name = "btnçizgi";
            this.btnçizgi.Size = new System.Drawing.Size(104, 105);
            this.btnçizgi.TabIndex = 7;
            this.btnçizgi.UseVisualStyleBackColor = true;
            this.btnçizgi.Click += new System.EventHandler(this.btnçizgi_Click);
            // 
            // btnboyama
            // 
            this.btnboyama.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnboyama.BackgroundImage = global::paintproje_ödevi.Properties.Resources.png_transparent_computer_icons_microsoft_paint_blue_square_text_box_material_free_material_text_logo_paint;
            this.btnboyama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnboyama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnboyama.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnboyama.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnboyama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnboyama.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnboyama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnboyama.Location = new System.Drawing.Point(122, 16);
            this.btnboyama.Name = "btnboyama";
            this.btnboyama.Size = new System.Drawing.Size(104, 105);
            this.btnboyama.TabIndex = 1;
            this.btnboyama.UseVisualStyleBackColor = false;
            this.btnboyama.Click += new System.EventHandler(this.btnboyama_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnkaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaydet.ForeColor = System.Drawing.Color.Turquoise;
            this.btnkaydet.Location = new System.Drawing.Point(895, 16);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(84, 35);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnelips
            // 
            this.btnelips.BackgroundImage = global::paintproje_ödevi.Properties.Resources.png_transparent_ellipse_shape_circle_oval_shape_black_auto_part_rim_thumbnail;
            this.btnelips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnelips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnelips.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnelips.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnelips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnelips.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnelips.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnelips.Location = new System.Drawing.Point(677, 16);
            this.btnelips.Name = "btnelips";
            this.btnelips.Size = new System.Drawing.Size(104, 105);
            this.btnelips.TabIndex = 6;
            this.btnelips.UseVisualStyleBackColor = true;
            this.btnelips.Click += new System.EventHandler(this.btnelips_Click);
            // 
            // btnüçgen
            // 
            this.btnüçgen.BackgroundImage = global::paintproje_ödevi.Properties.Resources.png_transparent_equilateral_triangle_right_triangle_triangular_shape_angle_rectangle_triangle_thumbnail;
            this.btnüçgen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnüçgen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnüçgen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnüçgen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnüçgen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnüçgen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnüçgen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnüçgen.Location = new System.Drawing.Point(457, 16);
            this.btnüçgen.Name = "btnüçgen";
            this.btnüçgen.Size = new System.Drawing.Size(104, 105);
            this.btnüçgen.TabIndex = 4;
            this.btnüçgen.UseVisualStyleBackColor = true;
            this.btnüçgen.Click += new System.EventHandler(this.btnüçgen_Click);
            // 
            // btnrenkler
            // 
            this.btnrenkler.BackgroundImage = global::paintproje_ödevi.Properties.Resources.color_palette_2484;
            this.btnrenkler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnrenkler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrenkler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnrenkler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnrenkler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrenkler.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnrenkler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrenkler.Location = new System.Drawing.Point(12, 16);
            this.btnrenkler.Name = "btnrenkler";
            this.btnrenkler.Size = new System.Drawing.Size(104, 105);
            this.btnrenkler.TabIndex = 0;
            this.btnrenkler.UseVisualStyleBackColor = true;
            this.btnrenkler.Click += new System.EventHandler(this.btnrenkler_Click);
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 164);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(982, 347);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(267, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "kalem silgi boyutu";
            // 
            // numPenSize
            // 
            this.numPenSize.Location = new System.Drawing.Point(270, 142);
            this.numPenSize.Name = "numPenSize";
            this.numPenSize.Size = new System.Drawing.Size(120, 22);
            this.numPenSize.TabIndex = 9;
            this.numPenSize.ValueChanged += new System.EventHandler(this.numPenSize_ValueChanged);
            // 
            // btnDosyaAc
            // 
            this.btnDosyaAc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDosyaAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDosyaAc.Font = new System.Drawing.Font("Showcard Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDosyaAc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDosyaAc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaAc.Location = new System.Drawing.Point(895, 100);
            this.btnDosyaAc.Name = "btnDosyaAc";
            this.btnDosyaAc.Size = new System.Drawing.Size(87, 39);
            this.btnDosyaAc.TabIndex = 10;
            this.btnDosyaAc.Text = "dosya aç";
            this.btnDosyaAc.UseVisualStyleBackColor = false;
            this.btnDosyaAc.Click += new System.EventHandler(this.btnDosyaAc_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 511);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAİNT";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPenSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btndikdörtgen;
        private System.Windows.Forms.Button btnçizgi;
        private System.Windows.Forms.Button btnboyama;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnelips;
        private System.Windows.Forms.Button btnüçgen;
        private System.Windows.Forms.Button btnrenkler;
        private System.Windows.Forms.Button btnkalem;
        private System.Windows.Forms.Button btnsilgi;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.NumericUpDown numPenSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDosyaAc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

