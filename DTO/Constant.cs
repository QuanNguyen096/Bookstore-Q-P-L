using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace DTO
{
    public static class Constant
    {
        public static string THONGBAO = "Thông báo";
        #region Var
        public static string Error_Login = "Đăng nhập sai hoặc tài khoản không tồn tại !";
        public static string DD_S = "Điểm danh thành công";
        public static string DD_NS = "Điểm danh không thành công";

        public static string ErrorTK = "Tên tài khoản sai.";
        public static string PleaseFillInInfor = "Vui lòng điền thông tin";
        public static string ErrorMk = "Mật khẩu sai.";
        public static string GmailTXT = "@gmail.com";
        public static string LinkFB = "www.facebook.com/tranthoilong";
        public static string Name_Error = "Tên có vấn đề";
        public static string Tooltip_Enter = "Nhấn enter để lưu.";
        public static string Add_NV = "Thêm mới nhân viên";
        public static string Update_NV = "Cập nhật nhân viên";
        public static string NotYearOld = "Chưa đủ tuổi !";
        public static string Error_CCCD = "Sai CCCD";
        public static string Error_Time = "Lỗi thời gian !";
        public static string CHUA_DD = "Chưa điểm danh";
        public static string MOTA = "MoTa";
        public static string TIME = "ThoiGian";
        public static string STATUS_LOGIN = "Đăng nhập";
        public static string STATUS_LOGOUT = "Đăng xuất";
        public static string ADMIN = "Admin";
        public static string NHANVIEN = "Nhân Viên";
        public static int GTRI_KHONG_THUC_THI_THANH_CONG = -100;
        public static string LUONG_MD = "100000";
        public static string DATEOFBIRTH_FAIL = "Vui Lòng nhập lại ngày sinh";
        #endregion
        #region Connection SQL
        public static string CONNECTION_STRING_MYSQL = @"Data Source=.\sqlexpress;Initial Catalog=AppSach;Integrated Security=True";
        #endregion
        #region Loai
        public static string TYPE_CODE = "MaLoai";
        public static string TYPE_NAME = "TenLoai";
        #endregion
        #region NXB
        public static string NXB_CODE = "MaNXB";
        public static string NXB_NAME = "TenNXB";
        #endregion

        #region Ca
        public static string Ca_CODE = "MaCa";
        public static string Ca_NAME = "TenCa";
        #endregion

        public static string DO_YOU_WANT_TO ="Bạn có muốn khôi phục nhân viên ";
        public static string NOTIFICATION = "THÔNG BÁO";
        public static string IMAGE_FAILED = "Đã có lỗi xảy ra với ảnh này";
        public static string LINK_IMAGE_DEFAULT = @"1627332073_119463_gif-url.gif";

        public static string FAILURE = "Thất bại";

        public static string FORDER_IMAGE_DEFAULT = @"\\MacDinh\\";
        public static string IDAMIN = "1";

        public static string DELETE_SUCCESSFULLY = "Xóa thành công";
        public static string DELETE_FAILED = "Xóa không thành công";
        public static string ADD_SUCCESSFULLY = "Thêm thành công";
        public static string ADD_FAILED = "Thêm không thành công";
        public static string FIX_SUCCESSFULLY = "Sửa thành công";
        public static string FIX_FAILED = "Sửa không thành công";
        public static string SAVE_SUCCESSFULLY = "Lưu thành công";
        public static string DESTRUCT_SUCCESSFULLY = "Hủy thành công";


        public static int DATA_DELETION_DATE_1 = 1;
        public static int DATA_DELETION_DATE_2 = 3;
        public static int DATA_DELETION_DATE_3 = 7;

        //Ngon Ngu
        public static string VN_EN = @"AppSach.Resource.EN";
        public static string EN_VN = "AppSach.Resource.VN";


        #region Funtision
        public static void CustomDataGridView(DataGridView data)
        {
            data.AutoGenerateColumns = false;
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
           // data.Columns[1].HeaderCell.Style.BackColor = Color.Red;
            data.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            data.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255);
            data.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.None;
            data.RowHeadersVisible=false;
            data.EnableHeadersVisualStyles = false;
        }

        public static void CustomElipGuna(Control oj)
        {
            Guna2Elipse elipse = new Guna2Elipse();
            elipse.BorderRadius = 20;
            elipse.TargetControl = oj;
        }
        public static void CustomDrag(Control crl)
        {
            Guna2DragControl a = new Guna2DragControl();
            a.TargetControl = crl;
        }


        //ComboBox - Custom
        public static void CusTomComBoBox(ComboBox cmb)
        {
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        //public static void CusTomComBoBox(Guna2ComboBox cmb)
        //{
        //    cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    cmb.AutoCompleteSource = AutoCompleteSource.ListItems;
        //}
        #endregion

        //Mat khau
        public static char HIDEN_HIDEN_PASSWORD = '•';
        public static char HIDEN_HIDENT_PASSWORD = '\0';


        public static string FILL_OUT_REQUEST = "Điền đúng thông tin...!!!";

        public static string PLEASE_CHOOSE_PHOTO = "Vui lòng chọn ảnh.";
        public static string TYPE_IMAGE = "Image Files(*.png;*.jpg)|*.png;*.jpg";

        #region MessBox
        public static string _ICON_WARNING = @"C:\Users\trant\Downloads\1587611661_270_Cach-ve-kinh.png";
        public static string _ICON_ERROR = @"C:\Users\trant\Downloads\1587611661_270_Cach-ve-kinh.png";
        public static string _ICON_QUESTION = @"C:\Users\trant\Downloads\1587611661_270_Cach-ve-kinh.png";
        public static string BTN_OK = "Ok";
        public static string BTN_CANCEL = "Cancel";
        public static string BTN_YES = "Yes";
        public static string BTN_NO = "No";
        public static string BTN_CLOSE = "Close";
        public static string DO_YOU_WANT_TO_CLOSE = "Bạn có muốn thoát chương trình.";
        public static string DO_YOU_WANT_TO_SAVE = "Bạn có muốn lưu chương trình.";
        public static string DO_YOU_WANT_TO_EXPOT = "Bạn có muốn xuất file";


        public static string HAPPY_WORK = "Chúc bạn một ngày làm việc tốt lành.";
        public static string HAPPY_WORK_EN = "Have a good day at work.";


        #endregion

        #region Ca lam viec
        public static string CA_1 = "Ca thứ nhất : ";
        public static string CA_2 = "Ca thứ hai : ";
        public static string CA_TRONG = "Ca rỗng.";
        public static string GTRI_RONG = "00:00-00:00";

        #endregion

        #region CODE_RANDOM
        public static DateTime dt = DateTime.Now;
        public static string CODE = dt.Day.ToString() + dt.Month.ToString() + dt.Year.ToString() + dt.Hour.ToString() + dt.Minute.ToString();
        public static string LOAI = "L";
        public static string NXB = "L";
        public static string APPROVAL_SUCCESSFULLY = "Duyệt thành công";
        public static string APPROVAL_FAILED = "Duyệt thất bại";
        public static string VAT = "5";

        #endregion

    }
}
