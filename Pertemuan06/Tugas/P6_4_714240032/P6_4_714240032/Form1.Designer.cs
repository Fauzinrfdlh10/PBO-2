namespace P6_4_714240032
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NamaCustomer = new System.Windows.Forms.Label();
            this.NamaMakanan = new System.Windows.Forms.Label();
            this.Harga = new System.Windows.Forms.Label();
            this.rbBerat = new System.Windows.Forms.RadioButton();
            this.rbRingan = new System.Windows.Forms.RadioButton();
            this.rbMinuman = new System.Windows.Forms.RadioButton();
            this.rbDineIn = new System.Windows.Forms.RadioButton();
            this.rbTakeAway = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.Catatan = new System.Windows.Forms.Label();
            this.Jumlah = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtCatatan = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupKategori = new System.Windows.Forms.GroupBox();
            this.groupMetode = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNamaMakanan = new System.Windows.Forms.TextBox();
            this.txtNamaCustomer = new System.Windows.Forms.TextBox();
            this.groupKategori.SuspendLayout();
            this.groupMetode.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Pemesanan";
            // 
            // NamaCustomer
            // 
            this.NamaCustomer.AutoSize = true;
            this.NamaCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaCustomer.Location = new System.Drawing.Point(37, 66);
            this.NamaCustomer.Name = "NamaCustomer";
            this.NamaCustomer.Size = new System.Drawing.Size(104, 16);
            this.NamaCustomer.TabIndex = 1;
            this.NamaCustomer.Text = "Nama Customer";
            // 
            // NamaMakanan
            // 
            this.NamaMakanan.AutoSize = true;
            this.NamaMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaMakanan.Location = new System.Drawing.Point(37, 106);
            this.NamaMakanan.Name = "NamaMakanan";
            this.NamaMakanan.Size = new System.Drawing.Size(103, 16);
            this.NamaMakanan.TabIndex = 2;
            this.NamaMakanan.Text = "Nama Makanan";
            // 
            // Harga
            // 
            this.Harga.AutoSize = true;
            this.Harga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Harga.Location = new System.Drawing.Point(37, 147);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(100, 16);
            this.Harga.TabIndex = 3;
            this.Harga.Text = "Tanggal Pesan";
            this.Harga.Click += new System.EventHandler(this.dtTanggal);
            // 
            // rbBerat
            // 
            this.rbBerat.AutoSize = true;
            this.rbBerat.Location = new System.Drawing.Point(12, 19);
            this.rbBerat.Name = "rbBerat";
            this.rbBerat.Size = new System.Drawing.Size(98, 17);
            this.rbBerat.TabIndex = 9;
            this.rbBerat.TabStop = true;
            this.rbBerat.Text = "Makanan Berat";
            this.rbBerat.UseVisualStyleBackColor = true;
            // 
            // rbRingan
            // 
            this.rbRingan.AutoSize = true;
            this.rbRingan.Location = new System.Drawing.Point(12, 42);
            this.rbRingan.Name = "rbRingan";
            this.rbRingan.Size = new System.Drawing.Size(107, 17);
            this.rbRingan.TabIndex = 10;
            this.rbRingan.TabStop = true;
            this.rbRingan.Text = "Makanan Ringan";
            this.rbRingan.UseVisualStyleBackColor = true;
            // 
            // rbMinuman
            // 
            this.rbMinuman.AutoSize = true;
            this.rbMinuman.Location = new System.Drawing.Point(12, 66);
            this.rbMinuman.Name = "rbMinuman";
            this.rbMinuman.Size = new System.Drawing.Size(68, 17);
            this.rbMinuman.TabIndex = 11;
            this.rbMinuman.TabStop = true;
            this.rbMinuman.Text = "Minuman";
            this.rbMinuman.UseVisualStyleBackColor = true;
            // 
            // rbDineIn
            // 
            this.rbDineIn.AutoSize = true;
            this.rbDineIn.Location = new System.Drawing.Point(15, 19);
            this.rbDineIn.Name = "rbDineIn";
            this.rbDineIn.Size = new System.Drawing.Size(59, 17);
            this.rbDineIn.TabIndex = 12;
            this.rbDineIn.TabStop = true;
            this.rbDineIn.Text = "Dine In";
            this.rbDineIn.UseVisualStyleBackColor = true;
            // 
            // rbTakeAway
            // 
            this.rbTakeAway.AutoSize = true;
            this.rbTakeAway.Location = new System.Drawing.Point(15, 42);
            this.rbTakeAway.Name = "rbTakeAway";
            this.rbTakeAway.Size = new System.Drawing.Size(79, 17);
            this.rbTakeAway.TabIndex = 13;
            this.rbTakeAway.TabStop = true;
            this.rbTakeAway.Text = "Take Away";
            this.rbTakeAway.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Harga";
            // 
            // Catatan
            // 
            this.Catatan.AutoSize = true;
            this.Catatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catatan.Location = new System.Drawing.Point(37, 375);
            this.Catatan.Name = "Catatan";
            this.Catatan.Size = new System.Drawing.Size(53, 16);
            this.Catatan.TabIndex = 15;
            this.Catatan.Text = "Catatan";
            // 
            // Jumlah
            // 
            this.Jumlah.AutoSize = true;
            this.Jumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jumlah.Location = new System.Drawing.Point(248, 340);
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.Size = new System.Drawing.Size(50, 16);
            this.Jumlah.TabIndex = 16;
            this.Jumlah.Text = "Jumlah";
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(119, 336);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(76, 20);
            this.txtHarga.TabIndex = 17;
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(325, 339);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(84, 20);
            this.txtJumlah.TabIndex = 18;
            // 
            // txtCatatan
            // 
            this.txtCatatan.Location = new System.Drawing.Point(119, 375);
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.Size = new System.Drawing.Size(290, 47);
            this.txtCatatan.TabIndex = 19;
            this.txtCatatan.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Tampilkan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTampilkan);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Selesai";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupKategori
            // 
            this.groupKategori.Controls.Add(this.rbBerat);
            this.groupKategori.Controls.Add(this.rbMinuman);
            this.groupKategori.Controls.Add(this.rbRingan);
            this.groupKategori.Location = new System.Drawing.Point(27, 194);
            this.groupKategori.Name = "groupKategori";
            this.groupKategori.Size = new System.Drawing.Size(200, 100);
            this.groupKategori.TabIndex = 22;
            this.groupKategori.TabStop = false;
            this.groupKategori.Text = "Kategori";
            // 
            // groupMetode
            // 
            this.groupMetode.Controls.Add(this.rbDineIn);
            this.groupMetode.Controls.Add(this.rbTakeAway);
            this.groupMetode.Location = new System.Drawing.Point(251, 194);
            this.groupMetode.Name = "groupMetode";
            this.groupMetode.Size = new System.Drawing.Size(200, 100);
            this.groupMetode.TabIndex = 23;
            this.groupMetode.TabStop = false;
            this.groupMetode.Text = "Metode Pengambilan";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // txtNamaMakanan
            // 
            this.txtNamaMakanan.Location = new System.Drawing.Point(210, 105);
            this.txtNamaMakanan.Name = "txtNamaMakanan";
            this.txtNamaMakanan.Size = new System.Drawing.Size(135, 20);
            this.txtNamaMakanan.TabIndex = 5;
            // 
            // txtNamaCustomer
            // 
            this.txtNamaCustomer.Location = new System.Drawing.Point(210, 66);
            this.txtNamaCustomer.Name = "txtNamaCustomer";
            this.txtNamaCustomer.Size = new System.Drawing.Size(135, 20);
            this.txtNamaCustomer.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(504, 497);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupMetode);
            this.Controls.Add(this.groupKategori);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCatatan);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.Jumlah);
            this.Controls.Add(this.Catatan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNamaMakanan);
            this.Controls.Add(this.txtNamaCustomer);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.NamaMakanan);
            this.Controls.Add(this.NamaCustomer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Pemesanan";
            this.groupKategori.ResumeLayout(false);
            this.groupKategori.PerformLayout();
            this.groupMetode.ResumeLayout(false);
            this.groupMetode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NamaCustomer;
        private System.Windows.Forms.Label NamaMakanan;
        private System.Windows.Forms.Label Harga;
        private System.Windows.Forms.RadioButton rbBerat;
        private System.Windows.Forms.RadioButton rbRingan;
        private System.Windows.Forms.RadioButton rbMinuman;
        private System.Windows.Forms.RadioButton rbDineIn;
        private System.Windows.Forms.RadioButton rbTakeAway;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Catatan;
        private System.Windows.Forms.Label Jumlah;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.RichTextBox txtCatatan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupKategori;
        private System.Windows.Forms.GroupBox groupMetode;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNamaMakanan;
        private System.Windows.Forms.TextBox txtNamaCustomer;
    }
}

