using KTGK.Models;
using System;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
using KTGK.Models;

namespace KTGK
{
    public partial class Form1 : Form
    {
        private readonly QLDichBenh db = new QLDichBenh();
        private bool isAscending = false;
        public Form1()
        {

            InitializeComponent();
            this.Load += Form1_Load;
            this.dgvDiaPhuong.SelectionChanged += dgvDiaPhuong_SelectionChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // 1. Load ComboBox
                var trangThais = db.TrangThai.ToList();
                cboTrangThai.DataSource = trangThais;
                cboTrangThai.DisplayMember = "TenTT";
                cboTrangThai.ValueMember = "MaTT";

                // 2. Prepare DataGridView columns binding
                // Prevent auto-generated columns so designer columns are used.
                dgvDiaPhuong.AutoGenerateColumns = false;

                // Map designer columns to returned data property names
                // The anonymous object below uses: MDP, TenDP, CaNhiem, TrangThai
                colMDP.DataPropertyName = "MDP";
                colTenDP.DataPropertyName = "TenDP";
                colCaNhiem.DataPropertyName = "CaNhiem";
                colTrangThai.DataPropertyName = "TrangThai";

                // Make cell lookup by the data-property names work in SelectionChanged:
                colMDP.Name = "MDP";
                colTenDP.Name = "TenDP";
                colCaNhiem.Name = "CaNhiem";
                colTrangThai.Name = "TrangThai";

                // 3. Load DataGridView (include related TrangThai name)
                var list = db.DiaPhuong.Select(p => new
                {
                    MDP = p.MaDP,
                    TenDP = p.TenDP,
                    CaNhiem = p.SoCaNhiemMoi,
                    TrangThai = p.TrangThai.TenTT
                }).ToList();

                dgvDiaPhuong.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtMaDP.Text) ||
                string.IsNullOrWhiteSpace(txtTenDP.Text) ||
                string.IsNullOrWhiteSpace(txtSoCa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            if (txtMaDP.Text.Length != 3)
            {
                MessageBox.Show("Mã ĐP phải 3 ký tự", "Thông báo");
                return;
            }

            if (!int.TryParse(txtSoCa.Text, out int soCa) || soCa < 0)
            {
                MessageBox.Show("Số ca phải là số nguyên >= 0", "Thông báo");
                return;
            }

            // Prevent duplicate key
            var existing = db.DiaPhuong.Find(txtMaDP.Text);
            if (existing != null)
            {
                MessageBox.Show("Mã địa phương đã tồn tại.", "Thông báo");
                return;
            }

            try
            {
                var dp = new DiaPhuong
                {
                    MaDP = txtMaDP.Text,
                    TenDP = txtTenDP.Text,
                    SoCaNhiemMoi = soCa,
                    MaTT = Convert.ToInt32(cboTrangThai.SelectedValue)
                };

                db.DiaPhuong.Add(dp);
                db.SaveChanges();
                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSoCa.Text, out int soCa) || soCa < 0)
            {
                MessageBox.Show("Số ca phải là số nguyên >= 0", "Thông báo");
                return;
            }

            var dp = db.DiaPhuong.Find(txtMaDP.Text);
            if (dp == null)
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo");
                return;
            }

            int maMoi = Convert.ToInt32(cboTrangThai.SelectedValue);

            if (dp.MaTT != maMoi)
            {
                DialogResult dr = MessageBox.Show(
                    $"Địa phương thay đổi từ {dp.TrangThai.TenTT} -> {cboTrangThai.Text}?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.No) return;
            }

            try
            {
                dp.TenDP = txtTenDP.Text;
                dp.SoCaNhiemMoi = soCa;
                dp.MaTT = maMoi;
                db.SaveChanges();
                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtMaDP.Clear();
            txtTenDP.Clear();
            txtSoCa.Clear();
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;
        }

        private void dgvDiaPhuong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiaPhuong.CurrentRow == null) return;

            var row = dgvDiaPhuong.CurrentRow;
            // Use column names that were set to match data property names
            txtMaDP.Text = row.Cells["MDP"].Value?.ToString() ?? string.Empty;
            txtTenDP.Text = row.Cells["TenDP"].Value?.ToString() ?? string.Empty;
            txtSoCa.Text = row.Cells["CaNhiem"].Value?.ToString() ?? string.Empty;

            var ttName = row.Cells["TrangThai"].Value?.ToString();
            if (!string.IsNullOrEmpty(ttName))
            {
                int idx = cboTrangThai.FindStringExact(ttName);
                if (idx >= 0) cboTrangThai.SelectedIndex = idx;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // intentionally blank
        }

        private void menuSapXep_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy danh sách dữ liệu kèm theo tên Trạng Thái (giống logic LoadData)
                var query = db.DiaPhuong.Select(p => new
                {
                    MDP = p.MaDP,
                    TenDP = p.TenDP,
                    CaNhiem = p.SoCaNhiemMoi,
                    TrangThai = p.TrangThai.TenTT
                });

                // 2. Thực hiện sắp xếp dựa trên biến isAscending
                if (isAscending)
                {
                    // Sắp xếp Tăng dần
                    dgvDiaPhuong.DataSource = query.OrderBy(p => p.CaNhiem).ToList();
                    // isAscending = false; // Đã xử lý ở bước 3
                }
                else
                {
                    // Sắp xếp Giảm dần (Yêu cầu 5.1: Lần đầu nhấn/F1 là giảm dần)
                    dgvDiaPhuong.DataSource = query.OrderByDescending(p => p.CaNhiem).ToList();
                }

                // 3. Đảo ngược trạng thái để lần nhấn sau sẽ sắp xếp ngược lại
                isAscending = !isAscending;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sắp xếp: " + ex.Message);
            }
        }

        private void menuNguyCo_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng LINQ để lọc các địa phương có TenTT khác "Bình thường"
                var listNguyCo = db.DiaPhuong
                    .Where(p => p.TrangThai.TenTT != "Bình thường")
                    .Select(p => new
                    {
                        MDP = p.MaDP,
                        TenDP = p.TenDP,
                        CaNhiem = p.SoCaNhiemMoi,
                        TrangThai = p.TrangThai.TenTT
                    }).ToList();

                // Cập nhật lại nguồn dữ liệu cho DataGridView
                dgvDiaPhuong.DataSource = listNguyCo;

                // Nếu danh sách trống, có thể thông báo cho người dùng
                if (listNguyCo.Count == 0)
                {
                    MessageBox.Show("Không có địa phương nào thuộc nhóm nguy cơ.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xuấtBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport reportForm = new frmReport();
            reportForm.ShowDialog();
        }
    }
}