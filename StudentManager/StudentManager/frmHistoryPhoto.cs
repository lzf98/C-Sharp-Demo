using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class frmHistoryPhoto : Form
    {
        public frmHistoryPhoto()
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
        private void frmHistoryPhoto_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
                currentYPosition = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
            }
        }
        private void frmHistoryPhoto_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根据鼠标x坐标确定窗体的左边坐标x
                this.Top += MousePosition.Y - currentYPosition;//根据鼠标的y坐标窗体的顶部，即Y坐标
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }
        private void frmHistoryPhoto_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //设置初始状态
                currentYPosition = 0;
                beginMove = false;
            }
        }

        public frmHistoryPhoto(string sno):this() //带一个参数的构造方法传进学号来查找学生的历史照片
        {
            //把多个picturebox控件添加到List<picturebox>中用于循环动态插入图片
            List<PictureBox> pictureList = new List<PictureBox>();
            pictureList.Add(pbHistoryPhoto0);
            pictureList.Add(pbHistoryPhoto1);
            pictureList.Add(pbHistoryPhoto2);
            pictureList.Add(pbHistoryPhoto3);
            pictureList.Add(pbHistoryPhoto4);
            pictureList.Add(pbHistoryPhoto5);

            //获取image文件夹下文件名
            DirectoryInfo dir = new DirectoryInfo(".\\image\\");
            FileInfo[] fileInfo = dir.GetFiles();
            List<string> fileNames = new List<string>();
            foreach (FileInfo item in fileInfo)
            {
                if (item.ToString().Contains(sno))
                fileNames.Add(item.Name);
            }

            //通过遍历6个picturebox控件把6个历史照片展示出来
            int i = 0;
            foreach (var pbox in pictureList)
            {
                if (fileNames.Count() == 0) break;
                    pbox.BackgroundImage = Image.FromFile(".\\image\\" + fileNames[i]);
                    i++;
                if (i == fileNames.Count()) break;
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
