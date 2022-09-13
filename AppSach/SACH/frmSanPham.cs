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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            
            InitializeComponent();
            LoadData();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            new frmThemOrEditSach(null,dgvSach.Rows.Count.ToString()).ShowDialog();
            LoadData();
        }

        private void LoadData()
        {
          
            dgvSach.AutoGenerateColumns = false;
            Constant.CustomDataGridView(dgvSach);
            new SachBUSS().LaySachBUSS(dgvSach,txtKey.Text);
        }
        private void btnGift_Click(object sender, EventArgs e)
        {
            new frmGift().ShowDialog();
        }

        private void barcode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID))
            {
                return;
            }
            else
            {
                new frmCreateBarCode(ID).ShowDialog();
            }
        }
        private string ID;
        string linkAnhMacDinh=null;
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == dgvSach.Columns["btnDel"].Index)//neu nhan nut xoa["btnDel"] tren luoi thi thuc thi xoa
                {
                    var ID = dgvSach.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();
                    int a = new SachBUSS().XoaBUSS(ID);
                    if (a == 1)
                    {
                        MsgBoxcs.Show(Constant.DELETE_SUCCESSFULLY, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);
                    }
                    else
                    {
                        MsgBoxcs.Show(Constant.DELETE_FAILED, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);

                    }
                    picSach.Image = null;
                    LoadData();
                }
                else
                {
                    var MS = dgvSach.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();
                    var r = BUSS.SachBUSS.Lay1Sach(MS);
                    ID = MS;
                    try
                    {
                        picSach.Image = Image.FromFile(r["Anh"].ToString());
                    }
                    catch
                    {
                        return;
                        Bitmap bm = new Bitmap(Application.StartupPath +Constant.FORDER_IMAGE_DEFAULT + linkAnhMacDinh);

                        picSach.Image = bm;
                        MsgBoxcs.Show(Constant.IMAGE_FAILED, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);
                         return;
                    }
                }
            }
        }

        private void dgvSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var MS = dgvSach.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();
                new frmThemOrEditSach(MS,MS).ShowDialog();
                LoadData();
            }
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInDSSach_Click(object sender, EventArgs e)
        {
            new Sach.inDSSP().ShowDialog(); 
        }
    }
}
