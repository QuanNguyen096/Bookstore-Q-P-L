using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Guna.UI2.WinForms;

namespace AppSach
{
    public partial class frmQuanLyLuong : Form
    {
        public frmQuanLyLuong()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            Guna2Elipse elip =new Guna2Elipse();
            elip.TargetControl = this;
            elip.BorderRadius = 20;
            Guna2DragControl dr=new Guna2DragControl();
            Guna2DragControl dr2 = new Guna2DragControl();
            dr.TargetControl = this;
            dr2.TargetControl = _TabControl;

        }

        private void frmQuanLyLuong_Load(object sender, EventArgs e)
        {

        }
    }
}
