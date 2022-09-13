using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace AppSach
{
    public partial class frmDocBarCode : Form
    {
        public delegate void TruyenMa(string data);
        public TruyenMa truyenMa;
        public frmDocBarCode()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        FilterInfoCollection filterInfoCollection;
        VideoCapabilities videoCapabilities;
        VideoCaptureDevice videoCaptureDevice;
        private void frmDocBarCode_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cmbCamera.Items.Add(filterInfo.Name);
            cmbCamera.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmbCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var rs = reader.Decode(bitmap);
            if (rs != null)
            {
                txtBarCode.Invoke(new MethodInvoker(delegate ()
                {
                    txtBarCode.Text = rs.ToString();
                }));
            }
            picCamera.Image = bitmap;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            CloseCamera();
           // Application.Exit();

        }
        private void CloseCamera()
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                    picCamera.Image = null;
                }
                else
                {
                    videoCaptureDevice = null;

                    this.Close();

                }
            }
        }
        private void txtBarCode_TextChanged(object sender, EventArgs e)
        {
            if (txtBarCode.Text.Length > 0)
            {
                if (truyenMa != null)
                    truyenMa(txtBarCode.Text);
                //videoCaptureDevice.Stop();
                //this.Close();
            }
        }
    }
}
