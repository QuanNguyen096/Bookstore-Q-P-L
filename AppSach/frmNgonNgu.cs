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
    public partial class frmNgonNgu : Form
    {
        public frmNgonNgu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            Constant.CustomDrag(panel1);
            Constant.CustomElipGuna(btnVN);
            Constant.CustomElipGuna(btnEN);
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVN_Click_1(object sender, EventArgs e)
        {

            var gtri = new NgonNguBUSS().Them("1", "1");
            if (gtri != Constant.GTRI_KHONG_THUC_THI_THANH_CONG)
            {
                this.Close();
            }

        }

        private void btnEN_Click_1(object sender, EventArgs e)
        {
            var gtri = new NgonNguBUSS().Them("1", "2");
            if (gtri != Constant.GTRI_KHONG_THUC_THI_THANH_CONG)
            {
                this.Close();
            }
        }

        private void frmNgonNgu_FormClosing(object sender, FormClosingEventArgs e)
        {

       
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
