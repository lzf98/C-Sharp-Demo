using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;
using Common;
using System.IO;
using System.Runtime.InteropServices;

namespace StudentManager
{
    public partial class frmMain : Form
    {
        FileOperator objFile = new FileOperator();
        private string fileName = string.Empty;//定义一个字段来储存文件名
        private string photoPath = string.Empty;
        private List<Student> objListStudent = new List<Student>();
        private List<Student> objListQuery = new List<Student>();
        private StudentService objStudentService = new StudentService();
        private int actionFlag = 0;//用来标识时添加还是修改  1==》添加，2==》修改
        private int photoChanged = 0;//用来表时修改时是否修改图片 0==》不修改 1==》修改

        
       
        public frmMain()
        {
            InitializeComponent();



            //禁用明细区域
            gboxStudentDetail.Enabled = false;
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
        private void frmMain_MouseDown(object sender, MouseEventArgs e)//获取鼠标按下时的位置
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
                currentYPosition = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
            }
        }
        private void frmMain_MouseMove(object sender, MouseEventArgs e)//获取鼠标移动到的位置
        {

            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根据鼠标x坐标确定窗体的左边坐标x
                this.Top += MousePosition.Y - currentYPosition;//根据鼠标的y坐标窗体的顶部，即Y坐标
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }
        private void frmMain_MouseUp(object sender, MouseEventArgs e)//释放鼠标时的位置
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //设置初始状态 试一下
                currentYPosition = 0;
                beginMove = false;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)//选择文件导入数据
        {
            //导入数据：选择文件==》读取文件==》List<student>==》展示在DateGridView中==》展示某一行的明细
            //打开选择文件窗体
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV文件(*.csv)|*.csv|txt文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
                fileName = openFile.FileName;  //获取文件的完全路径
            else return;

            //把文件读取到List<student>中======类
            try
            {
                objListStudent = objFile.ReadFile(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取数据失败，具体原因：" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //把读取到的List<student>展示在DateGridView中
            dgvStudent.DataSource = null;
            dgvStudent.AutoGenerateColumns = false;
            dgvStudent.DataSource = objListStudent;

            //展示某一个学生的明细
            Student objStudent = objStudentService.GetStudentBySNO(dgvStudent.Rows[0].Cells[0].Value.ToString(), objListStudent);
            LoadDataToDetail(objStudent);
        }
        private void dgvStudent_SelectionChanged(object sender, EventArgs e)//选择行发生变化时的事件
        {
            if (dgvStudent.Rows.Count == 0) return;
            else if (dgvStudent.CurrentRow.Selected == false) return;
            else
            {
                Student objStudent = objStudentService.GetStudentBySNO(dgvStudent.CurrentRow.Cells[0].Value.ToString(), objListStudent);
                LoadDataToDetail(objStudent);
            }
        }
        private void txtQuerySNO_TextChanged(object sender, EventArgs e)//按学号查询
        {
            //清空查询列表
            objListQuery.Clear();
            //调用类的方法
            objListQuery = objStudentService.GetAllStudentBySNO(txtQuerySNO.Text.Trim(), objListStudent);
            //清空DataGridView
            dgvStudent.DataSource = null;
            //绑定查询结果列表
            dgvStudent.DataSource = objListQuery;
            //展示第一行明细
            if (objListQuery.Count != 0)
            {
                //展示明细 （第一行）
                //展示某一个学生明细 (默认展示第一行)
                Student objStudent = objStudentService.GetStudentBySNO(dgvStudent.Rows[0].Cells[0].Value.ToString(), objListStudent);
                LoadDataToDetail(objStudent);
            }
        }
        private void txtQuerySName_TextChanged(object sender, EventArgs e)//按姓名查询
        {
            //清空查询列表
            objListQuery.Clear();
            //调用类的方法
            objListQuery = objStudentService.GetAllStudentBySName(txtQuerySName.Text.Trim(), objListStudent);
            //清空DataGridView
            dgvStudent.DataSource = null;
            //绑定查询结果列表
            dgvStudent.DataSource = objListQuery;
            //展示第一行明细
            if (objListQuery.Count != 0)
            {
                //展示明细 （第一行）
                //展示某一个学生明细 (默认展示第一行)
                Student objStudent = objStudentService.GetStudentBySNO(dgvStudent.Rows[0].Cells[0].Value.ToString(), objListStudent);
                LoadDataToDetail(objStudent);
            }
        }
        private void txtQueryMobile_TextChanged(object sender, EventArgs e)//按电话号码查询
        {
            //清空查询列表
            objListQuery.Clear();
            //调用类的方法
            objListQuery = objStudentService.GetAllStudentByMobile(txtQueryMobile.Text.Trim(), objListStudent);
            //清空DataGridView
            dgvStudent.DataSource = null;
            //绑定查询结果列表
            dgvStudent.DataSource = objListQuery;
            //展示第一行明细
            if (objListQuery.Count != 0)
            {
                //展示明细 （第一行）
                //展示某一个学生明细 (默认展示第一行)
                Student objStudent = objStudentService.GetStudentBySNO(dgvStudent.Rows[0].Cells[0].Value.ToString(), objListStudent);
                LoadDataToDetail(objStudent);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)//为添加学生信息做准备
        {
            //禁用按钮
            DisableButton();
            //清空明细为添加做准备
            txtSNO.Text = string.Empty;
            txtSName.Text = string.Empty;
            dtpBirthdy.Text = DateTime.Now.ToString();
            rbMale.Checked = true;
            txtMobile.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtHomeAddress.Text = string.Empty;
            pbCurrentPhoto.BackgroundImage = null;

            //让学号文本框获得焦点
            txtSNO.Focus();
            //修改操作标识符
            actionFlag = 1;

        }
        private void btnUpdate_Click(object sender, EventArgs e)//为修改学生信息做准备
        {
            //禁用按钮
            DisableButton();

            //禁用学号的修改
            txtSNO.Enabled = false;

            //让姓名获得焦点
            txtSName.Focus();

            //修改操作标识符
            actionFlag = 2;

        }
        private void btnChoosePhoto_Click(object sender, EventArgs e)//添加照片
        {
            photoChanged = 1;
            //跳出选择选择的窗体  
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "图片|*.png;*.jpg;*.bmp";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                photoPath = openFile.FileName;
                //把选择的文件展示在picturebox控件中
                pbCurrentPhoto.BackgroundImage = Image.FromFile(photoPath);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)//删除学生信息
        {
            if (dgvStudent.Rows.Count == 0) return;
            else if (dgvStudent.CurrentRow.Selected== false) return;
            else
            {
                Student objStudent = objStudentService.GetStudentBySNO(dgvStudent.CurrentRow.Cells[0].Value.ToString(), objListStudent);
                string info = "您确定要删除【学号：" + objStudent.SNO + "】【姓名" + objStudent.SName + "】的信息吗？";
                DialogResult result = MessageBox.Show(info, "系统消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        //执行删除操作
                        objStudentService.DeleteStudent(objStudent, objListStudent);
                        //提示删除成功
                        MessageBox.Show("删除成功！","系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //刷新数据
                        dgvStudent.DataSource = null;
                        dgvStudent.DataSource = objListStudent;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("删除失败！具体原因：" + ex, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else return; 
            }
        }
        private void dgvStudent_DoubleClick(object sender, EventArgs e)//双击查看学生明细（构造方法）
        {
            Student objStudent = new Student();
            objStudent = objStudentService.GetStudentBySNO(dgvStudent.CurrentRow.Cells[0].Value.ToString(), objListStudent);
            frmStudentDetail frmSD1 = new frmStudentDetail(objStudent);
            frmSD1.Show();
        }
        private void btnCommit_Click(object sender, EventArgs e)//提交（添加或修改）
        {
            //需要验证输入的数据是否有效（面向对象）==》静态类
            if (!ValidataInfo()) return;

            //封装；提交到List里面的是Student，就是把所有单元格的类封装成一个Student对象
            Student objStudent = new Student
            {
                SNO = txtSNO.Text.Trim(),
                SName = txtSName.Text.Trim(),
                Gender = rbMale.Checked == true ? "男" : "女",
                Birthday = Convert.ToDateTime(dtpBirthdy.Text),
                Mobile = txtMobile.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                HomeAddress = txtHomeAddress.Text.Trim(),
                PhotoPath = null,
            };
            //指定图片
            if (actionFlag == 1 && photoChanged == 1)  //如果添加学生时需要添加照片那么把照片存到指定文件夹否则PhotoPath=null
                objStudent.PhotoPath = PhotoSave(photoPath);

            if (actionFlag==2) //修改学生信息时的情况
            {
                Student st = new Student();
                st = objStudentService.GetStudentBySNO(txtSNO.Text.Trim(), objListStudent);
                string oldPhotoPath = st.PhotoPath;

                if (pbCurrentPhoto.BackgroundImage != null && photoChanged == 0) //当存在照片但是不用修改时照片路径还是原来的路径
                    objStudent.PhotoPath = oldPhotoPath;
                if(pbCurrentPhoto.BackgroundImage != null && photoChanged==1) //当存在照片但是需要修改时照片路径替换成新的照片路径
                {
                    objStudent.PhotoPath = PhotoSave(photoPath);
                }
                    
                    
            }

            //提交
            switch (actionFlag)
            {
                case 1: //添加代码
                    try
                    {
                        objStudentService.AddStudent(objStudent, objListStudent);
                        //提示添加成功
                        MessageBox.Show("添加成功！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //更新数据控制按钮
                        btnCancel_Click(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("添加失败，具体原因：" + ex.Message, "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 2: //修改代码
                    try
                    {
                        objStudentService.UpdateStudent(objStudent, objListStudent);
                        //提示添加成功
                        MessageBox.Show("修改成功！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //更新数据控制按钮
                        btnCancel_Click(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("修改失败，具体原因：" + ex.Message, "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                default:
                    break;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)//取消添加或修改
        {
            //控制按钮
            EnableButton();
            txtSNO.Enabled = true;
            //更新数据
            this.dgvStudent.DataSource = null;
            this.dgvStudent.DataSource = objListStudent;

            //展示明细
            if(objListStudent.Count!=0)
            {
                Student objStudent = objStudentService.GetStudentBySNO(dgvStudent.CurrentRow.Cells[0].Value.ToString(), objListStudent);
                LoadDataToDetail(objStudent);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)//退出保存源文件
        {
            DialogResult result = MessageBox.Show("系统退出，是否要保存数据？", "系统消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                if (fileName == string.Empty)
                {
                    MessageBox.Show("未加载文件无法保存！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //写入学生信息
                objFile.SaveFile(fileName, objListStudent);
                //完成写入
                MessageBox.Show("写入完成！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
            
        }
        //自定义方法
        private void LoadDataToDetail(Student objStudent)//显示学生信息明细
        {
            txtSNO.Text = objStudent.SNO;
            txtSName.Text = objStudent.SName;
            if (objStudent.Gender == "男") rbMale.Checked = true;
            else rbFemale.Checked = true;
            dtpBirthdy.Text = objStudent.Birthday.ToString();
            txtMobile.Text = objStudent.Mobile;
            txtEmail.Text = objStudent.Email;
            txtHomeAddress.Text = objStudent.HomeAddress;
            if (string.IsNullOrWhiteSpace(objStudent.PhotoPath))
                pbCurrentPhoto.BackgroundImage = null;
            else
            {
                try//当用户照片丢失时提醒用户重新上传
                {
                    pbCurrentPhoto.BackgroundImage = Image.FromFile(objStudent.PhotoPath);
                }
                catch (Exception ex)
                {
                    DialogResult result= MessageBox.Show("图片文件丢失请重新上传！", "系统消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result==DialogResult.Yes) 
                    {
                        btnUpdate_Click(null, null);
                        btnChoosePhoto_Click(null, null);
                    }
                }
            }
                
        }
        private void DisableButton()//禁用按钮
        {
            //禁用
            btnAdd.Enabled = false;
            btnImport.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            dgvStudent.Enabled = false;
            //启用
            gboxStudentDetail.Enabled = true;
        }
        private void EnableButton()//启用按钮
        {
            //启用
            btnAdd.Enabled = true;
            btnImport.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            dgvStudent.Enabled = true;
            //禁用
            gboxStudentDetail.Enabled = false;
        }
        private bool ValidataInfo()//信息录入真实性验证
        {
            bool b = true;

            //学号不能为空
            if(string.IsNullOrWhiteSpace(txtSNO.Text))
            {
                MessageBox.Show("学号不能为空！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSNO.Focus();
                return false;
            }
            //学号必须为10位数字
            if (!ValidataInput.IsSNo(txtSNO.Text))
            {
                MessageBox.Show("学号必须为16开头十位数字！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSNO.Focus();
                return false;
            }
            //学号不能重复
            if(actionFlag==1)
            {
                if (objStudentService.IsExistSNO(txtSNO.Text.Trim(), objListStudent))
                {
                    MessageBox.Show("该学号已存在！请重新输入", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSNO.Focus();
                    return false;
                }
            }
            //姓名不能为空
            if (string.IsNullOrWhiteSpace(txtSName.Text))
            {
                MessageBox.Show("姓名不能为空！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSName.Focus();
                return false;
            }
            //姓名必须为汉字
            if (!ValidataInput.IsChinese(txtSName.Text))
            {
                MessageBox.Show("姓名必须为汉字", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSName.Focus();
                return false;
            }
            //生日不能晚于当前系统时间
            if(Convert.ToDateTime(dtpBirthdy.Text)>DateTime.Now)
            {
                MessageBox.Show("日期必须小于当前日期！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpBirthdy.Focus();
                return false;
            }
            //手机号码
            if(!ValidataInput.IsMobileNo(txtMobile.Text))
            {
                MessageBox.Show("手机号必须为11位数字！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMobile.Focus();
                return false;
            }
            //邮箱地址
            if(!ValidataInput.IsEMail(txtEmail.Text))
            {
                MessageBox.Show("邮箱格式错误！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return b;
        }
        private string PhotoSave(string currentPhotoName)//把照片储存到指定文件夹内并返回相对路径
        {
            //生成16位图片名称
            string photoName = BuildName.BuildPhotoName(currentPhotoName);
            //产生路径
            photoName = ".\\image\\" +txtSNO.Text.Trim()+photoName;
            //储存图片
            Bitmap objBitmap = new Bitmap(pbCurrentPhoto.BackgroundImage);
            objBitmap.Save(photoName, pbCurrentPhoto.BackgroundImage.RawFormat);
            objBitmap.Dispose();

            return photoName;
        }
    }
}
