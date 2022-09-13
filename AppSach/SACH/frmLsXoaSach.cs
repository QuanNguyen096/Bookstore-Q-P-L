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
    public partial class frmLsXoaSach : Form
    {


        public frmLsXoaSach()
        {

            InitializeComponent();
            LoadDATA();
        }

        private void LoadDATA()
        {
            Constant.CustomDataGridView(dgvLsXoaSach);
            BUSS.SachBUSS.DSSACHDAXOABUSS(dgvLsXoaSach, txtKey.Text);
        }

        private void dgvLsXoaSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex !=-1)//hang 1 chi so 0, hang 2 so 1
            {
                var id = dgvLsXoaSach.Rows[e.RowIndex].Cells["colMaSach"].Value.ToString();
                var name = dgvLsXoaSach.Rows[e.RowIndex].Cells["colTenSach"].Value.ToString();
                var r = SachBUSS.Lay1Sach(id);
                if (e.ColumnIndex == dgvLsXoaSach.Columns["colHoiPhuc"].Index)//neu nhan nut xoa["btnLayLai"] tren luoi thi thuc thi xoa
                {
                    try
                    {
                        picSach.Image = Image.FromFile(r["Anh"].ToString().Trim());
                    }
                    catch
                    {
                        Bitmap bm = new Bitmap(Application.StartupPath + Constant.FORDER_IMAGE_DEFAULT + Constant.LINK_IMAGE_DEFAULT);
                        picSach.Image = bm;
                    }
                  
                    DialogResult rs = MsgBoxcs.Show("Bạn có muốn khôi phục sách " + name, "THÔNG BÁO", MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Question);
                    if (rs == DialogResult.OK)
                    {
                        var kq = new SachBUSS().RestoreBUSS(id);
                        picSach.Image = null;
                    }
                    else
                    {
                        return;
                    }
                    LoadDATA();
                }
                else
                {
                    id = dgvLsXoaSach.Rows[e.RowIndex].Cells["colMaSach"].Value.ToString();
                    r = SachBUSS.Lay1Sach(id);
                    try
                    {
                        picSach.Image = Image.FromFile(r["Anh"].ToString().Trim());
                    }
                    catch
                    {
                        Bitmap bm = new Bitmap(Application.StartupPath + Constant.FORDER_IMAGE_DEFAULT + Constant.LINK_IMAGE_DEFAULT);
                        picSach.Image = bm;
                        MsgBoxcs.Show("Đã có lỗi xãy ra ở hình ảnh của nhân viên này !", Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Error); 
                        return;
                    }
                }
            }
        }
    }
}
