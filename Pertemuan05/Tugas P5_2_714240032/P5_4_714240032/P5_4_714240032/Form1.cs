using System;
using System.Linq;
using System.Windows.Forms;

namespace P5_4_714240032
{
    public partial class Form1 : Form
    {
        // ===== Deklarasi kontrol (nama-nama sesuai yang kamu pakai) =====
        private TextBox txtNama;
        private ComboBox comboJK;
        private DateTimePicker dtpLahir;

        private GroupBox groupBoxKelas;
        private RadioButton rbSepakBola, rbBasket, rbRenang, rbBuluTangkis,
                             rbTenis, rbYoga, rbVoli, rbPanahan;

        private GroupBox groupBoxJadwal;
        private CheckBox cbSeninRabu, cbSelasaKamis, cbSabtuMingguPagi, cbMingguSiang,
                         cbSeninJumatPagi, cbRabuJumatSore, cbKamisSabtuPagi, cbMingguMalam;

        private Button btnTampilkan, btnSelesai;

        public Form1()
        {
            InitializeComponent(); // method kita sendiri, didefinisikan di bawah
        }

        // ====== Buat seluruh UI lewat kode (tanpa Designer) ======
        private void InitializeComponent()
        {
            // Form
            this.Text = "FORM PENDAFTARAN";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 820;
            this.Height = 520;

            // Label judul kecil
            var lblNama = new Label { Text = "Nama", AutoSize = true, Left = 40, Top = 40 };
            var lblJK = new Label { Text = "Jenis Kelamin", AutoSize = true, Left = 40, Top = 80 };
            var lblTL = new Label { Text = "Tanggal Lahir", AutoSize = true, Left = 40, Top = 120 };

            // Input
            txtNama = new TextBox { Name = "txtNama", Left = 180, Top = 36, Width = 220, MaxLength = 50 };

            comboJK = new ComboBox { Name = "comboJK", Left = 180, Top = 76, Width = 220, DropDownStyle = ComboBoxStyle.DropDownList };
            comboJK.Items.AddRange(new object[] { "Pria", "Wanita" });
            comboJK.SelectedIndex = 0;

            dtpLahir = new DateTimePicker
            {
                Name = "dtpLahir",
                Left = 180,
                Top = 116,
                Width = 220,
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd MMMM yyyy"
            };

            // GroupBox Kelas + RadioButton
            groupBoxKelas = new GroupBox
            {
                Name = "groupBoxKelas",
                Text = "Pilihan Kelas",
                Left = 40,
                Top = 170,
                Width = 300,
                Height = 180
            };

            // Kolom kiri
            rbSepakBola = new RadioButton { Text = "Sepak Bola", Left = 20, Top = 30, AutoSize = true };
            rbRenang = new RadioButton { Text = "Renang", Left = 20, Top = 60, AutoSize = true };
            rbTenis = new RadioButton { Text = "Tenis", Left = 20, Top = 90, AutoSize = true };
            rbYoga = new RadioButton { Text = "Yoga", Left = 20, Top = 120, AutoSize = true };

            // Kolom kanan
            rbBasket = new RadioButton { Text = "Basket", Left = 150, Top = 30, AutoSize = true };
            rbBuluTangkis = new RadioButton { Text = "Bulu Tangkis", Left = 150, Top = 60, AutoSize = true };
            rbVoli = new RadioButton { Text = "Voli", Left = 150, Top = 90, AutoSize = true };
            rbPanahan = new RadioButton { Text = "Panahan", Left = 150, Top = 120, AutoSize = true };

            groupBoxKelas.Controls.AddRange(new Control[]
            {
    rbSepakBola, rbRenang, rbTenis, rbYoga,
    rbBasket, rbBuluTangkis, rbVoli, rbPanahan
            });


            // GroupBox Jadwal + CheckBox (8 item)
            groupBoxJadwal = new GroupBox { Name = "groupBoxJadwal", Text = "Pilihan Jadwal", Left = 380, Top = 170, Width = 360, Height = 220 };

            cbSeninRabu = new CheckBox { Text = "Senin s/d Rabu, 14.00 - 16.00", Left = 20, Top = 30, AutoSize = true };
            cbSelasaKamis = new CheckBox { Text = "Selasa s/d Kamis, 10.00 - 12.00", Left = 20, Top = 60, AutoSize = true };
            cbSabtuMingguPagi = new CheckBox { Text = "Jum s/d Minggu, 09.00 - 11.00", Left = 20, Top = 90, AutoSize = true };
            cbMingguSiang = new CheckBox { Text = "Minggu, 13.00 - 20.00", Left = 20, Top = 120, AutoSize = true };
            cbSeninJumatPagi = new CheckBox { Text = "Senin s/d Jumat, 08.00 - 10.00", Left = 20, Top = 150, AutoSize = true };
            cbRabuJumatSore = new CheckBox { Text = "Rabu s/d Jumat, 15.00 - 17.00", Left = 20, Top = 180, AutoSize = true };
            cbKamisSabtuPagi = new CheckBox { Text = "Kamis s/d Sabtu, 07.00 - 09.00", Left = 20, Top = 210, AutoSize = true };
            cbMingguMalam = new CheckBox { Text = "Minggu, 19.00 - 21.00", Left = 20, Top = 240, AutoSize = true };

            groupBoxJadwal.Controls.AddRange(new Control[] {
                cbSeninRabu, cbSelasaKamis, cbSabtuMingguPagi, cbMingguSiang,
                cbSeninJumatPagi, cbRabuJumatSore, cbKamisSabtuPagi, cbMingguMalam
            });

            // Tombol
            btnTampilkan = new Button { Name = "btnTampilkan", Text = "Tampilkan", Left = 480, Top = 410, Width = 110, Height = 32 };
            btnSelesai = new Button { Name = "btnSelesai", Text = "Selesai", Left = 610, Top = 410, Width = 110, Height = 32 };

            btnTampilkan.Click += btnTampilkan_Click;
            btnSelesai.Click += btnSelesai_Click;

            // Tambahkan kontrol ke Form
            this.Controls.AddRange(new Control[] {
                lblNama, lblJK, lblTL,
                txtNama, comboJK, dtpLahir,
                groupBoxKelas, groupBoxJadwal,
                btnTampilkan, btnSelesai
            });
        }

        // ====== Event handler ======
        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            // Validasi RadioButton (kelas)
            if (!groupBoxKelas.Controls.OfType<RadioButton>().Any(r => r.Checked))
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning");
                return;
            }

            // Validasi CheckBox (jadwal)
            if (!groupBoxJadwal.Controls.OfType<CheckBox>().Any(c => c.Checked))
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal", "Warning");
                return;
            }

            // ambil kelas
            var kelas = groupBoxKelas.Controls.OfType<RadioButton>()
                                              .First(r => r.Checked).Text;

            // ambil checklist jadwal
            var jadwal = groupBoxJadwal.Controls.OfType<CheckBox>()
                                                .Where(c => c.Checked).Select(c => c.Text);

            // tampilkan info
            MessageBox.Show(
                "Nama : " + txtNama.Text + "\n" +
                "Jenis Kelamin : " + comboJK.Text + "\n" +
                "Tanggal Lahir : " + dtpLahir.Text + "\n" +
                "Pilihan Kelas : " + kelas + "\n" +
                "Pilihan Jadwal : " + string.Join(", ", jadwal),
                "Informasi Pendaftaran"
            );
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
