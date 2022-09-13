using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSS;
using DTO;
using AppSach.NhanVien;
namespace AppSach
{
    public partial class frmNhanVien : Form
    {
        int VnEn;
        string VN_EN = string.Empty;
        string IDLogin;
        public frmNhanVien(int VnEn,string ID)
        {
            this.IDLogin = ID;
            this.VnEn = VnEn;
            InitializeComponent();
        }
        private void LoadData()
        {
            Constant.CustomDataGridView(dgvNV);
            VietNam_Anh();
            NhanVienBUSS.XemBUSS(dgvNV, txtKey.Text,IDLogin);
  
        }
        ResourceManager rm;
        private void VietNam_Anh()
        {
            if (VnEn == 1)
            {
                VN_EN = Constant.EN_VN; 
            }
            else
            {
                VN_EN = Constant.VN_EN;
            }
            rm = new ResourceManager(VN_EN, Assembly.GetExecutingAssembly());
            btnThem.Text = rm.GetString("btnThem").ToUpper();
            txtKey.PlaceholderText = rm.GetString("search");
            Id.HeaderText= rm.GetString("mssv");
            HoVaTen.HeaderText = rm.GetString("hoten");
            GioiTinh.HeaderText = rm.GetString("gioitinh");
            SDT.HeaderText = rm.GetString("sdt");
            CCCD.HeaderText = rm.GetString("CCCD");
            DiaChi.HeaderText = rm.GetString("diachi");
            Luong.HeaderText = rm.GetString("luong");
            ChucVu.HeaderText = rm.GetString("chucvu");
            NgaySinh.HeaderText = rm.GetString("ngaysinh");
            NgayVaoLam.HeaderText = rm.GetString("ngayvaolam");
            taikhoan.HeaderText = rm.GetString("taikhoan");
            btnDel.Text= rm.GetString("btnXoa").ToUpper();
            new ToolTip().SetToolTip(btnThungRac, rm.GetString("txtLichSuXoaNV"));
        }

        public void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new frmAddOrEdit_NV(null).ShowDialog();
            picNV.Image = null;
            LoadData();
            #region sua truc tiep tren luoi
            //if (NhanVienBUSS.Instance.Sua(dgvNV))
            //{
            //    MessageBox.Show("Thanh cong");
            //}
            //else
            //{
            //    MessageBox.Show("Loi");
            //}
            #endregion
        }

        private void dgvNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex != -1)
            {
                var id = dgvNV.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                //Khong the chinh sua chinh minh
                //Tai khoan ad id=1 khong duoc sua
                if(id != IDLogin && id !="1")
                {
                    new frmAddOrEdit_NV(id).ShowDialog();
                }
                else
                {
                    return;
                }
                picNV.Image = null;
                LoadData();
            }

        }
        string sql = string.Empty;
        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)//hang 1 chi so 0, hang 2 so 1
            {
                DateTime dt = DateTime.Today.AddDays(Constant.DATA_DELETION_DATE_1);//-----------------------------------------------Ngay co the lay lai
                if (e.ColumnIndex == dgvNV.Columns["btnDel"].Index && dgvNV.Rows[e.RowIndex].Cells["Id"].Value.ToString()!= IDLogin)//neu nhan nut xoa["btnDel"] tren luoi thi thuc thi xoa
                {
                    var ID = dgvNV.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    int a = new NhanVienBUSS().XoaBUSS(IDLogin, ID,dt);
                    if (a == 1)
                    {
                        MsgBoxcs.Show(Constant.DELETE_SUCCESSFULLY, Constant.THONGBAO, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Question);
                    }
                    else
                    {
                        MsgBoxcs.Show(Constant.DELETE_FAILED, Constant.THONGBAO, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Question);
                    }
                    picNV.Image = null;
                    LoadData();
                }
                else
                {
                    var id = dgvNV.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    var r = NhanVienBUSS.LayNVBUSS(id);
                    try
                    {
                        picNV.Image = Image.FromFile(r["Anh"].ToString().Trim());
                        ResetAllControlsBackColor2( picNV);
                    }
                    catch
                    {
                        Bitmap bm = new Bitmap(Application.StartupPath +Constant.FORDER_IMAGE_DEFAULT+ Constant.LINK_IMAGE_DEFAULT);
                        ResetAllControlsBackColor(picNV);
                        picNV.Image = bm;
                        MsgBoxcs.Show(Constant.IMAGE_FAILED, Constant.THONGBAO, MsgBoxcs.Buttons.YesNo, MsgBoxcs.Icon.Error);
                        return;
                    }
                }
            }

        }
        #region Reset backgroud picturebox
        public virtual System.Drawing.Color BackColor
        {
            get; set;
        }
        // Reset all the controls to the user's default Control color. 
        private void ResetAllControlsBackColor(Control control)
        {
            control.BackColor = SystemColors.Control;
            control.ForeColor = SystemColors.ControlText;
            if (control.HasChildren)
            {
                // Recursively call this method for each child control.
                foreach (Control childControl in control.Controls)
                {
                    ResetAllControlsBackColor(childControl);
                }
            }
        }
        private void ResetAllControlsBackColor2(Control control)
        {
            control.BackColor = SystemColors.GrayText;
            control.ForeColor = SystemColors.ControlText;
            if (control.HasChildren)
            {
                // Recursively call this method for each child control.
                foreach (Control childControl in control.Controls)
                {
                    ResetAllControlsBackColor(childControl);
                }
            }
        }
        #endregion Reset backgroud picturebox

        private void btnThungRac_Click(object sender, EventArgs e)
        {
            new frmLSXoaNV().ShowDialog();
            LoadData();
        }
        private void CongThemNgay()
        {
            DateTime D = DateTime.Now;
            int day = D.Day;
            int month = D.Month;
            int year = D.Year;
            DateTime date = new DateTime(year, month, day + 7);
            txtKey.Text = date.ToString();
        }

        private void btnInNV_Click(object sender, EventArgs e)
        {
            new NhanVien.frmInNV().ShowDialog();
        }

        private void btnCa_Click(object sender, EventArgs e)
        {
            new frmCa().ShowDialog();
        }

        private void frmLsLogin_Click(object sender, EventArgs e)
        {
            new frmChamCong().ShowDialog();
        }

        private void btnDSDD_Click(object sender, EventArgs e)
        {
            new frmDSDD().ShowDialog();
        }
    }
}
