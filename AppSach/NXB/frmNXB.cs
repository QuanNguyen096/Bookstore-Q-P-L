using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSS;
using DTO;
namespace AppSach
{
    public partial class frmNXB : Form
    {
        private string id;
        public frmNXB()
        {
            InitializeComponent();
            LoadDATA();
           
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            frmThemNXB ThemNXB = new frmThemNXB(id);
            ThemNXB.ShowDialog();
            LoadDATA();
        }
        public void LoadDATA()
        {
            Constant.CustomDataGridView(dgvThongtinNXB);
            Constant.CustomDataGridView(dgvLSNXB);
            new NXBBUSS().XemBUSS(dgvThongtinNXB, txtKey.Text);
            new NXBBUSS().DSNXBDAXOA(dgvLSNXB, txtKeyXoa.Text);
        }

        private void dgvThongtinNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == dgvThongtinNXB.Columns["btnXoa"].Index)
                {
                    var ID = dgvThongtinNXB.Rows[e.RowIndex].Cells["colMaNXB"].Value.ToString();
                    MessageBox.Show("Xoa NXB So " + ID);
                    MsgBoxcs.Show("Xóa Nhà Xuất Bản số " + ID, Constant.THONGBAO, MsgBoxcs.Buttons.YesNo, MsgBoxcs.Icon.Info);
                    new NXBBUSS().XoaBUSS(ID);
                    LoadDATA();
                }
            }
        }
        private void dgvThongtinNXB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var ID = dgvThongtinNXB.Rows[e.RowIndex].Cells["colMaNXB"].Value.ToString();
                new frmThemNXB(ID).ShowDialog();
                LoadDATA();
            }
        }

        private void dgvLSNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)//hang 1 chi so 0, hang 2 so 1
            {


                var id = dgvLSNXB.Rows[e.RowIndex].Cells["colLSMaNXB"].Value.ToString();
                var name = dgvLSNXB.Rows[e.RowIndex].Cells["colLSTenNXB"].Value.ToString();

                var r = LoaiBUSS.LayLoaiBUSS(id);
                if (e.ColumnIndex == dgvLSNXB.Columns["btnRestore"].Index)//neu nhan nut xoa["btnLayLai"] tren luoi thi thuc thi xoa
                {


                    DialogResult rs = MessageBox.Show("Bạn có muốn khôi phục NXB" + name, "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (rs == DialogResult.OK)
                    {
                        var kq = new NXBBUSS().LayLaiDAL(id);
                    }
                    else
                    {
                        return;
                    }

                    LoadDATA();
                }
                return;

            }
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            LoadDATA();
        }

        private void txtKeyXoa_TextChanged(object sender, EventArgs e)
        {
            LoadDATA();
        }
    }
}
