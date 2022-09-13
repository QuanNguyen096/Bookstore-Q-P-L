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
    public partial class frmGift : Form
    {
        private bool HD;
        private string ID;
        public frmGift()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            RandDOM();
            txtMaKM.Enabled = false;
            LoadDATA();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RandDOM()
        {
            string value = string.Empty;

            string a="A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,0,1,2,3,4,5,6,7,8,9";
            string[] T = a.Split(',');
            int Dodai = new Random().Next(6,12);
            Random random=new Random();
            while (value.Length < Dodai)
            {
                value+=T[random.Next(T.Length)];
            }
            txtMaKM.Text = value;
        }
        private bool KTNgay(DateTimePicker dt)
        {
            DateTime d1 = dt.Value;
            DateTime d2 = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day+1);
            if(d1 < d2)
            {
                return false;
            }
          
            return true;
        }
        private void KTNhap()
        {
            if (string.IsNullOrEmpty(txtDonGia.Text) || int.Parse(txtDonGia.Text)>100 || int.Parse(txtDonGia.Text) <1)
            {
                HD=false;
                txtDonGia.Select();
                errorProvider1.SetError(txtDonGia, "Vui lòng điền đúng thông tin.");return;
            }
            else
            {
                HD = true;
            }
          
        }
        private void btnThemGift_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter()
            {
                Key = "@MaKM",
                Value = txtMaKM.Text
            });
            pr.Add(new CustomParameter()
            {
                Key = "@DonGia",
                Value = txtDonGia.Text
            });
            pr.Add(new CustomParameter()
            {
                Key = "@MoTa",
                Value = txtMoTa.Text
            });
            pr.Add(new CustomParameter()
            {
                Key = "@ngayKT",
                Value = dateKT.Value.ToString("yyyy/MM/dd")
            });

            KTNhap();
            if (HD)
            {
                if (KTNgay(dateKT))
                {
                    MessageBox.Show("Hop le");
                    ResetGtri();
                    HD = true;
                }
                else
                {
                    MessageBox.Show("khong Hop le");
                    HD = false;
                    errorProvider1.SetError(dateKT, "Vui lòng điền đúng thông tin.");
                    dateKT.Select();

                }
            }
            
            if (HD == true)
            {
                new KhuyenMaiBUSS().ThemKMBUSS(pr);
                LoadDATA();
                RandDOM();

            }
        }
        private void ResetGtri()
        {
            errorProvider1.Clear();
            txtDonGia.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            dateKT.Value = DateTime.Now;
        }
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void LoadDATA()
        {
           
            dgvKhuyenMai.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhuyenMai.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dgvKhuyenMai.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255);
           
            dgvKhuyenMai.EnableHeadersVisualStyles = false;
            new KhuyenMaiBUSS().DSKMBUSS(dgvKhuyenMai);
        }

        private void dgvKhuyenMai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = dgvKhuyenMai.Rows[e.RowIndex].Cells["MaKM"].Value.ToString();
                ID = id;
            }
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            new frmCreateBarCode(ID).ShowDialog();
        }
    }
}
