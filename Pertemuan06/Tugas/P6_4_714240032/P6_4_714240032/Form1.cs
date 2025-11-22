using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace P6_4_714240032
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTampilkan(object sender, EventArgs e)
        {
            // REQUIRED
            if (string.IsNullOrWhiteSpace(txtNamaCustomer.Text) ||
                string.IsNullOrWhiteSpace(txtNamaMakanan.Text) ||
                string.IsNullOrWhiteSpace(txtHarga.Text) ||
                string.IsNullOrWhiteSpace(txtJumlah.Text))
            {
                MessageBox.Show("Semua field wajib diisi!");
                return;
            }

            // NUMERIC VALIDATION
            if (!int.TryParse(txtHarga.Text.Trim(), out _) ||
                !int.TryParse(txtJumlah.Text.Trim(), out _))
            {
                MessageBox.Show("Harga dan Jumlah harus berupa angka!");
                return;
            }

            // CHAR VALIDATION
            if (!Regex.IsMatch(txtNamaCustomer.Text, @"^[A-Za-z ]+$"))
            {
                MessageBox.Show("Nama customer hanya boleh huruf!");
                return;
            }

            // UPPERCASE Customer
            if (txtNamaCustomer.Text != txtNamaCustomer.Text.ToUpper())
            {
                MessageBox.Show("Nama customer harus UPPERCASE!");
                return;
            }

            // LOWERCASE Makanan
            if (txtNamaMakanan.Text != txtNamaMakanan.Text.ToLower())
            {
                MessageBox.Show("Nama makanan harus lowercase!");
                return;
            }

            if (!Regex.IsMatch(txtNamaMakanan.Text, @"^[a-z ]+$"))
            {
                MessageBox.Show("Nama makanan hanya huruf kecil!");
                return;
            }

            // LENGTH
            if (txtCatatan.Text.Length < 5)
            {
                MessageBox.Show("Catatan minimal 5 karakter!");
                return;
            }

            // RADIO BUTTON VALIDATION
            string kategori = "";
            if (rbBerat.Checked) kategori = "Makanan Berat";
            else if (rbRingan.Checked) kategori = "Makanan Ringan";
            else if (rbMinuman.Checked) kategori = "Minuman";
            else
            {
                MessageBox.Show("Pilih kategori makanan!");
                return;
            }

            string metode = "";
            if (rbDineIn.Checked) metode = "Dine In";
            else if (rbTakeAway.Checked) metode = "Take Away";
            else
            {
                MessageBox.Show("Pilih metode pengambilan!");
                return;
            }

            // OUTPUT MESSAGE
            string output =
                "=== INFORMASI PEMESANAN ===\n\n" +
                "Nama Customer : " + txtNamaCustomer.Text + "\n" +
                "Nama Makanan : " + txtNamaMakanan.Text + "\n" +
                "Tanggal Pesan : " + dateTimePicker1.Value.ToLongDateString() + "\n" +
                "Kategori : " + kategori + "\n" +
                "Metode Pengambilan : " + metode + "\n" +
                "Harga : Rp " + txtHarga.Text + "\n" +
                "Jumlah : " + txtJumlah.Text + "\n" +
                "Catatan : " + txtCatatan.Text;

            MessageBox.Show(output, "Informasi Pesanan",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtTanggal(object sender, EventArgs e)
        {

        }
    }
}
