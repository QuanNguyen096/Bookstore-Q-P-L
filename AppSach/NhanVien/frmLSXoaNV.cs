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
    public partial class frmLSXoaNV : Form
    {
        public frmLSXoaNV()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadDATA();
        }

        private void LoadDATA()
        {
            Constant.CustomDataGridView(dgvNV);
            BUSS.NhanVienBUSS.DSNVDAXOABUSS(dgvNV,txtKey.Text);
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            LoadDATA();
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
            if (e.RowIndex >= 0)//hang 1 chi so 0, hang 2 so 1
            {
                

                var id = dgvNV.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                var name = dgvNV.Rows[e.RowIndex].Cells["HoVaTen"].Value.ToString();

                var r = NhanVienBUSS.LayNVBUSS(id);
                if (e.ColumnIndex == dgvNV.Columns["btnLayLai"].Index)//neu nhan nut xoa["btnLayLai"] tren luoi thi thuc thi xoa
                {
                    try
                    {
                        picNV.Image = Image.FromFile(r["Anh"].ToString().Trim());
                    }
                    catch
                    {
                        Bitmap bm = new Bitmap(Application.StartupPath + Constant.FORDER_IMAGE_DEFAULT + Constant.LINK_IMAGE_DEFAULT);
                        picNV.Image = bm;
                    }
                    DialogResult rs = MsgBoxcs.Show(Constant.DO_YOU_WANT_TO + name,Constant.NOTIFICATION , MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Question);
                    if(rs == DialogResult.OK)
                    {
                        var kq =new NhanVienBUSS().RestoreBUSS(id);
                        picNV.Image = null;
                    }
                    else
                    {
                        return;
                    }
                    
                    LoadDATA();
                }
                else
                {
                    id = dgvNV.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    r = NhanVienBUSS.LayNVBUSS(id);
                    try
                    {
                        picNV.Image = Image.FromFile(r["Anh"].ToString().Trim());
                    }
                    catch
                    {
                        Bitmap bm = new Bitmap(Application.StartupPath + Constant.FORDER_IMAGE_DEFAULT + Constant.LINK_IMAGE_DEFAULT);
                        picNV.Image = bm;
                        MsgBoxcs.Show(Constant.IMAGE_FAILED, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Error);
                        return;
                    }
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
