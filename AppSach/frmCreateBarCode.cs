using AppSach.Resource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Zen.Barcode;
using static System.Net.WebRequestMethods;
using DTO;

namespace AppSach
{
    public partial class frmCreateBarCode : Form
    {
        string ID;
        public frmCreateBarCode(string ID)
        {
            this.ID = ID;
            InitializeComponent();
            this.Text = "TẠO QR VÀ BARCODE";
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            txtID.Text = ID;
            txtID.Enabled = false;

        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID))
            {
                QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
                var data = qr.CreateQrCode(txtID.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
                var code = new QRCoder.QRCode(data);
                picQR.Image = code.GetGraphic(10);
            }
            else
            {
                QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
                var data = qr.CreateQrCode(ID, QRCoder.QRCodeGenerator.ECCLevel.Q);
                var code = new QRCoder.QRCode(data);
                picQR.Image = code.GetGraphic(10);
            }
            


        }

        private void btnBarCode_Click(object sender, EventArgs e)
        {

            
            string barcode = txtID.Text;


            try
            {
                Zen.Barcode.Code128BarcodeDraw br = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                picBar.Image = br.Draw(barcode, 120);
            }
            catch (Exception ex)
            {
                MsgBoxcs.Show(ex.Message, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
