using DTO_PolyCafe;
using UTIL_PolyCafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BLL_PolyCafe;
using DTO_PolyCafe;
using UTIL_PolyCafe;
using GUI_PolyCafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace TB01228_PolyCafe
{
    public partial class FRMLogin : Form
    {
        BUSNhanVien busNhanVien = new BUSNhanVien();
        public FRMLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            //Làm xong cần sửa lại trong ngoặc "" thành username, password
            NhanVien nv = busNhanVien.DangNhap("hoa.nguyen@cafe.com", "Phuong1");
            //Làm xong cần sửa lại trong ngoặc "" thành username, password
            if (nv == null)
            {
                MessageBox.Show(this, "Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nv.TrangThai == false)
                {
                    MessageBox.Show(this, "Tài khoản đang bị khóa, vui lòng cute");
                    return;
                }
                AuthUtil.user = nv;
                FRMMain mainForm = new FRMMain();
                mainForm.Show();
                this.Hide();

            }
        }

        private void rdbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = rdbHienThiMatKhau.Checked ? '\0' : '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            Application.Exit();
        }

        private void FRMLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
