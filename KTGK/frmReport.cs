
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using KTGK.Models;

namespace KTGK
{
    public partial class frmReport : Form
    {
        private readonly QLDichBenh db = new QLDichBenh();

        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // Load danh sách trạng thái, thêm tùy chọn "Tất cả"
            var items = db.TrangThai
                          .Select(t => new { MaTT = t.MaTT, TenTT = t.TenTT })
                          .ToList();

            // Insert "Tất cả" option at top (MaTT = 0)
            items.Insert(0, new { MaTT = 0, TenTT = "Tất cả" });

            cboTrangThai.DisplayMember = "TenTT";
            cboTrangThai.ValueMember = "MaTT";
            cboTrangThai.DataSource = items;

            // Clear report panel
            reportViewer1.Controls.Clear();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTrangThai.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int selectedMaTT = Convert.ToInt32(cboTrangThai.SelectedValue);

                // Query DiaPhuong and map to DTO
                List<ReportRow> rows;
                if (selectedMaTT == 0)
                {
                    rows = db.DiaPhuong
                             .Select(p => new ReportRow
                             {
                                 MaDP = p.MaDP,
                                 TenDP = p.TenDP,
                                 SoCaNhiemMoi = p.SoCaNhiemMoi,
                                 TenTT = p.TrangThai.TenTT
                             }).ToList();
                }
                else
                {
                    rows = db.DiaPhuong
                             .Where(p => p.MaTT == selectedMaTT)
                             .Select(p => new ReportRow
                             {
                                 MaDP = p.MaDP,
                                 TenDP = p.TenDP,
                                 SoCaNhiemMoi = p.SoCaNhiemMoi,
                                 TenTT = p.TrangThai.TenTT
                             }).ToList();
                }

                // If no results, show message and clear panel
                if (rows == null || rows.Count == 0)
                {
                    reportViewer1.Controls.Clear();
                    MessageBox.Show("Không có dữ liệu cho trạng thái đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Create a DataGridView inside the panel to display results (no ReportViewer dependency)
                reportViewer1.Controls.Clear();
                var dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    ReadOnly = true,
                    AutoGenerateColumns = true,
                    DataSource = rows,
                    AllowUserToAddRows = false
                };

                // Basic appearance tweaks
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                reportViewer1.Controls.Add(dgv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }

        // DTO for grid display
        private class ReportRow
        {
            public string MaDP { get; set; }
            public string TenDP { get; set; }
            public int SoCaNhiemMoi { get; set; }
            public string TenTT { get; set; }
        }
    }
}