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
namespace AppSach
{
    public partial class frmLSXoaKH : Form
    {
        public frmLSXoaKH()
        {
            InitializeComponent();
            LoadDATA();
        }
        private void LoadDATA()
        {
            new KhachHangBUSS().DSKHDelBUSS(dgvLSKH, txtKey.Text);
        }

    }
}
