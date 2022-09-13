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

namespace AppSach.Loai
{
    public partial class Loai : Form
    {
        private static string Key;
        public Loai()
        {
            InitializeComponent();
            dgvLsLoai.AutoGenerateColumns = false;
            dgvLoai.AutoGenerateColumns = false;
        }

        private void Loai_Load(object sender, EventArgs e)
        {
            LoadDATA();
        }
        private void LoadDATA()
        {
            Constant.CustomDataGridView(dgvLoai);
            new LoaiBUSS().LayLoaiBUSS(dgvLoai, txtKey.Text);
            new LoaiBUSS().DSLOAIDAXOABUSS(dgvLsLoai, txtKeyXoa.Text);
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            new frmAddOrEdit_Loai(null, dgvLoai.Rows.Count.ToString()).ShowDialog();
            new LoaiBUSS().LayLoaiBUSS(dgvLoai, txtKey.Text);
        }

        private void dgvLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dt = DateTime.Today.AddDays(Constant.DATA_DELETION_DATE_1);
            if (e.RowIndex > -1)//hang 1 chi so 0, hang 2 so 1
            {
                if (e.ColumnIndex == dgvLoai.Columns["colXoa"].Index)//neu nhan nut xoa["btnDel"] tren luoi thi thuc thi xoa
                {
                    var Maloai = dgvLoai.Rows[e.RowIndex].Cells["colMaLoai"].Value.ToString();



                    int a = new LoaiBUSS().XoaLoaiBUSS(Maloai, dt);
                    if (a == 1)
                    {
                        MsgBoxcs.Show(Constant.DELETE_SUCCESSFULLY,Constant.NOTIFICATION,MsgBoxcs.Buttons.OK);
                    }
                    else
                    {
                        MsgBoxcs.Show(Constant.DELETE_SUCCESSFULLY, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK);

                        // MsgBoxcs.Show(Constant.DELETE_FAILED, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK);
                        new LoaiBUSS().XoaLoaiBUSS(Maloai, dt);
                    }

                    LoadDATA();
                }

            }
        }

        private void dgvLoai_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var maloai = dgvLoai.Rows[e.RowIndex].Cells["colMaLoai"].Value.ToString();
                new frmAddOrEdit_Loai(maloai, maloai).ShowDialog();
                LoadDATA();
            }
        }

        private void dgvLsLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)//hang 1 chi so 0, hang 2 so 1
            {


                var id = dgvLsLoai.Rows[e.RowIndex].Cells["colLsMaLoai"].Value.ToString();
                var name = dgvLsLoai.Rows[e.RowIndex].Cells["colLsTenLoai"].Value.ToString();

                var r = LoaiBUSS.LayLoaiBUSS(id);
                if (e.ColumnIndex == dgvLsLoai.Columns["colLayLai"].Index)//neu nhan nut xoa["btnLayLai"] tren luoi thi thuc thi xoa
                {


                        var kq = new LoaiBUSS().LayLaiBUSS(id);
                   

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
