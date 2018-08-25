using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class StudentService
    {
        public Student GetStudentBySNO(string sno,List<Student> objList)//按学号查找学生
        {
            Student objStudent = new Student();
            //遍历List
            foreach(Student item in objList)
            {
                if (item.SNO.Equals(sno))
                {
                    objStudent = new Student
                    {
                        SNO = item.SNO,
                        SName = item.SName,
                        Gender = item.Gender,
                        Birthday = item.Birthday,
                        Mobile = item.Mobile,
                        Email = item.Email,
                        HomeAddress = item.HomeAddress,
                        PhotoPath = item.PhotoPath,
                    };
                    break;
                }
            }
            return objStudent;
        }
        public List<Student> GetAllStudentBySNO(string sno, List<Student> objList)//按学号模糊查询学生
        {
            List<Student> objQueryList = new List<Student>();
            //遍历objList
            foreach(Student item in objList)
            {
                if (item.SNO.Contains(sno))
                {
                    objQueryList.Add(new Student
                    {
                        SNO = item.SNO,
                        SName = item.SName,
                        Gender = item.Gender,
                        Birthday = item.Birthday,
                        Mobile = item.Mobile,
                        Email = item.Email,
                        HomeAddress = item.HomeAddress,
                        PhotoPath = item.PhotoPath,
                    });
                }
            }
            return objQueryList;
        }
        public List<Student> GetAllStudentBySName(string sname, List<Student> objList)//按姓名模糊查询学生
        {
            List<Student> objQueryList = new List<Student>();
            //遍历objList
            foreach (Student item in objList)
            {
                if (item.SName.Contains(sname))
                {
                    objQueryList.Add(new Student
                    {
                        SNO = item.SNO,
                        SName = item.SName,
                        Gender = item.Gender,
                        Birthday = item.Birthday,
                        Mobile = item.Mobile,
                        Email = item.Email,
                        HomeAddress = item.HomeAddress,
                        PhotoPath = item.PhotoPath,
                    });
                }
            }
            return objQueryList;
        }
        public List<Student> GetAllStudentByMobile(string mobile, List<Student> objList)//按手机号模糊查询学生
        {
            List<Student> objQueryList = new List<Student>();
            //遍历objList
            foreach (Student item in objList)
            {
                if (item.Mobile.Contains(mobile))
                {
                    objQueryList.Add(new Student
                    {
                        SNO = item.SNO,
                        SName = item.SName,
                        Gender = item.Gender,
                        Birthday = item.Birthday,
                        Mobile = item.Mobile,
                        Email = item.Email,
                        HomeAddress = item.HomeAddress,
                        PhotoPath = item.PhotoPath,
                    });
                }
            }
            return objQueryList;
        }
        public bool IsExistSNO(string sno, List<Student> objList)//查询学号是否存在
        {
            foreach(Student item in objList)
            {
                if (item.SNO.Equals(sno))
                    return true;
            }
            return false;
        }
        public void AddStudent(Student objStudent,List<Student> objList)//添加学生信息
        {
            try
            {
                objList.Add(objStudent);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void UpdateStudent(Student objStudent, List<Student> objList)//修改学生信息
        {
            try
            {
                for (int i = 0; i < objList.Count; i++)
                {
                    if(objList[i].SNO.StartsWith(objStudent.SNO))
                    {
                        //删除
                        objList.RemoveAt(i);
                        //再添加
                        objList.Insert(i, objStudent);
                        //退出
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void DeleteStudent(Student objStudent, List<Student> objList)//删除学生信息
        {
            try
            {
                for (int i = 0; i < objList.Count; i++)
                {
                    if (objList[i].SNO.StartsWith(objStudent.SNO))
                    {
                        //删除
                        objList.RemoveAt(i);
                        //退出
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
