using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace StudentManager
{
    public partial class frmStudentDetail : Form
    {
        public frmStudentDetail()//无参构造方法
        {
            InitializeComponent();
        }

        //***************************无边框窗体拖动
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        bool beginMove = false;//初始化鼠标位置
        int currentXPosition;
        int currentYPosition;
        //***************************加上下面三个鼠标事件

        //控件事件
        private void frmStudentDetail_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
                currentYPosition = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
            }
        }
        private void frmStudentDetail_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根据鼠标x坐标确定窗体的左边坐标x
                this.Top += MousePosition.Y - currentYPosition;//根据鼠标的y坐标窗体的顶部，即Y坐标
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }
        private void frmStudentDetail_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //设置初始状态
                currentYPosition = 0;
                beginMove = false;
            }
        }

        public frmStudentDetail(Student objStudent):this()//带一个参数的构造方法:
        {
            //禁用控件
            txtSNO.ReadOnly = true;
            txtSname.ReadOnly = true;
            rbMale.Enabled = false;
            rbFemale.Enabled = false;
            dtpBirthday.Enabled = false;
            txtMobile.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtHomeAddress.ReadOnly = true;

            //展示数据
            txtSNO.Text = objStudent.SNO;
            txtSname.Text = objStudent.SName;
            if (objStudent.Gender == "男") rbMale.Checked = true;
            else rbFemale.Checked = true;
            dtpBirthday.Text = Convert.ToString(objStudent.Birthday);
            txtMobile.Text = objStudent.Mobile;
            txtEmail.Text = objStudent.Email;
            txtHomeAddress.Text = objStudent.HomeAddress;
            if (string.IsNullOrWhiteSpace(objStudent.PhotoPath)) pbCurrentPhoto.BackgroundImage = null;
            else pbCurrentPhoto.BackgroundImage = Image.FromFile(objStudent.PhotoPath);

        }
        private void btnHistoryPhoto_Click(object sender, EventArgs e)
        {
            frmHistoryPhoto frmHP1 = new frmHistoryPhoto(txtSNO.Text);
            frmHP1.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
