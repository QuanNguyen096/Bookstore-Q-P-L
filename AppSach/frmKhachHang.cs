using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSS;
using DTO;
namespace AppSach
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
            txtMaKH.Enabled = false;
            LoadDATA();
            
        }

        private void LoadDATA()
        {
           new KhachHangBUSS().DSKH(dgvKH,txtKey.Text);
        }
        string ID;
        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex==0)ResetGtri();
            if(e.RowIndex > 0)
            {
                btnHuy_Click(sender, e);
                var id = dgvKH.Rows[e.RowIndex].Cells["MaKH"].Value.ToString().Trim();
                ID= id;
                txtMaKH.Text = id;
                //txtMaKH.Enabled = false;
                //txtMaKH.ReadOnly=true;
                txtTenKH.Text= dgvKH.Rows[e.RowIndex].Cells["TenKH"].Value.ToString().Trim();
                if (dgvKH.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString().Trim() == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked= true;
                }
                txtDiaChi.Text = dgvKH.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString().Trim();
                txtTTLH.Text = dgvKH.Rows[e.RowIndex].Cells["LienHe"].Value.ToString().Trim();

                DateTime ngaysinh = DateTime.ParseExact(dgvKH.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dateNgSinh.Value = ngaysinh;
                if (e.ColumnIndex == dgvKH.Columns["btnXoa"].Index)//neu nhan nut xoa["btnDel"] tren luoi thi thuc thi xoa
                {
                    var ID = dgvKH.Rows[e.RowIndex].Cells["makh"].Value.ToString();

                    MsgBoxcs.Show("Xóa khách hàng mã " + ID, Constant.THONGBAO, MsgBoxcs.Buttons.YesNo, MsgBoxcs.Icon.Question);
                    List<CustomParameter> parameter = new List<CustomParameter>();
                    parameter.Add(new CustomParameter()
                    {
                        Key = "@Key",
                        Value = ID
                    });

                    int a = new KhachHangBUSS().XoaBUSS(parameter);
                    if (a == 1)
                    {
                        MessageBox.Show("xoa Thanh cong");

                    }
                    else
                    {
                        MessageBox.Show("Xoa khong Thanh cong");
                    }
                    LoadDATA();

                }
            }
        }
        private bool HD;
     
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //List<CustomParameter> pr = new List<CustomParameter>();
            string gioitinh = radNam.Checked ? "1" : "0";
            //pr.Add(new CustomParameter()
            //{
            //    Key = "@MaKH",
            //    Value = txtMaKH.Text
            //});
            //pr.Add(new CustomParameter()
            //{
            //    Key = "@TenKH",
            //    Value = txtTenKH.Text
            //});
            //pr.Add(new CustomParameter()
            //{
            //    Key = "@GioiTinh",
            //    Value = gioitinh
            //});
            //pr.Add(new CustomParameter()
            //{
            //    Key = "@LienHe",
            //    Value = txtTTLH.Text
            //});
            //pr.Add(new CustomParameter()
            //{
            //    Key = "@DiaChi",
            //    Value = txtDiaChi.Text
            //});
            //pr.Add(new CustomParameter()
            //{
            //    Key = "@NgaySinh",
            //   Value = dateNgSinh.Value.ToString("yyyy/MM/dd")
            //});
            
            er.Clear();
            ChuoiRong();
            if (HD)
            {
                if (KTNgSinh(dateNgSinh))
                {
                    HD = true; 
                }
                else
                {
                    er.SetError(dateNgSinh, Constant.DATEOFBIRTH_FAIL);
                    HD = false;
                }

            }
            if (HD)
            {
                new KhachHangBUSS().ThemBUSS(txtMaKH.Text,txtTenKH.Text,gioitinh,txtTTLH.Text,txtDiaChi.Text,dateNgSinh.Value);
                LoadDATA();
                btnHuy_Click(sender, e);
            }
            else
            {
                MsgBoxcs.Show(Constant.ADD_FAILED, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Warning);
            }
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int a = dgvKH.RowCount + 1;
            Random random = new Random();
            ResetGtri();
            txtMaKH.Text = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + a+ random.Next(0, 100).ToString();
            btnThem.Visible = false;
            btnLuu.Visible = true;
            btnSua.Enabled=false;
            btnHuy.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            er.Clear();
            ResetGtri();
            dateNgSinh.Value = DateTime.Now.Date;
            btnSua.Enabled = true;
            btnThem.Visible = true;
            btnLuu.Visible=false;
            btnHuy.Enabled = false;

        }

        private void ResetGtri()
        {
            txtMaKH.Text = string.Empty;
            txtTenKH.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtTTLH.Text = string.Empty;
            dateNgSinh.Value = DateTime.Now.Date;
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            LoadDATA();
        }
        private bool KTNgSinh(DateTimePicker dt)
        {
            int d1 = int.Parse(dt.Value.Year.ToString());
            if (int.Parse(DateTime.Now.Year.ToString()) -d1 > 18)
            {
                return true;
            }
            return false;
        }
        private void ChuoiRong()
        {
            er.Clear();
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                er.SetError(txtTenKH, "Vui lòng nhập đầy đủ thông tin");
                txtTenKH.Select();
                HD = false;
                return;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                er.SetError(txtDiaChi, "Vui lòng nhập đầy đủ thông tin");
                txtDiaChi.Select();
                HD = false;
                return;

            }
            if (string.IsNullOrEmpty(txtTTLH.Text))
            {
                er.SetError(txtTTLH, "Vui lòng nhập đầy đủ thông tin");
                txtDiaChi.Select();
                HD = false;
                return;

            }
            HD = true;


        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            string gioitinh = radNam.Checked ? "1" : "0";
            pr.Add(new CustomParameter()
            {
                Key = "@MaKH",
                Value = txtMaKH.Text
            });
            pr.Add(new CustomParameter()
            {
                Key = "@TenKH",
                Value = txtTenKH.Text
            });
            pr.Add(new CustomParameter()
            {
                Key = "@GioiTinh",
                Value = gioitinh
            });
            pr.Add(new CustomParameter()
            {
                Key = "@LienHe",
                Value = txtTTLH.Text
            });
            pr.Add(new CustomParameter()
            {
                Key = "@DiaChi",
                Value = txtDiaChi.Text
            });
            pr.Add(new CustomParameter()
            {
                Key = "@NgaySinh",
                Value = dateNgSinh.Value.ToString("yyyy/MM/dd")
            });

            er.Clear();
            ChuoiRong();
            if (HD)
            {
                if (KTNgSinh(dateNgSinh))
                {
                    HD = true;
                }
                else
                {
                    er.SetError(dateNgSinh, "Vui lòng nhập đúng thông tin");
                    HD = false;
                }

            }
            if (HD)
            {
                new KhachHangBUSS().SuaBUSS(pr);
                LoadDATA();
                btnHuy_Click(sender, e);
            }
        }

        private void btnThungRac_Click(object sender, EventArgs e)
        {
            new frmLSXoaKH().ShowDialog();
            LoadDATA();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(ID))
                new frmCreateBarCode(ID).ShowDialog();
        }

        private void txtTTLH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled =false;
            }
        }

        private void txtTTLH_TextChanged(object sender, EventArgs e)
        {
            txtTTLH.MaxLength = 10;
        }
    }
}
