using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class FileOperator
    {
        /// <summary>
        /// 把某一个文件读取出来以List<Student>方式返回数据
        /// </summary>
        /// <param name="fileName">文件的完全路径</param>
        /// <returns>List<Student></returns>
        public List<Student> ReadFile (string fileName)
        {
            List<Student> objList = new List<Student>();
            string line = string.Empty;
            try
            {
                StreamReader sr = new StreamReader(fileName,Encoding.Default); //读取标准文本文件的各行信息
                line =sr.ReadLine();
                while (line!=null)
                {
                    string[] student = line.Split(',');

                    
                    ////传统写法
                    //Student objStudent = new Student();
                    //objStudent.SNO = student[0];
                    //objStudent.SName = student[1];
                    //objStudent.Gender = student[2];
                    //objStudent.Birthday = Convert.ToDateTime(student[3]);
                    //objStudent.Mobile = student[4];
                    //objStudent.Email = student[5];
                    //objStudent.HomeAddress = student[6];
                    //objStudent.PhotoPath = student[7];
                    //objList.Add(objStudent);

                    //推荐写法
                    objList.Add(
                        new Student
                        {
                            SNO = student[0],
                            SName = student[1],
                            Gender = student[2],
                            Birthday = Convert.ToDateTime(student[3]),
                            Mobile = student[4],
                            Email = student[5],
                            HomeAddress = student[6],
                            PhotoPath = student[7],
                        }
                                );
                    line = sr.ReadLine(); //逐行读取到末尾则为null
                }
                sr.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return objList;
        }

        public void SaveFile(string fileName,List<Student> objListStudent)
        {
            //1.清空源文件中的信息
            File.WriteAllText(fileName, string.Empty);
            //2.逐行写入（把objListStudent中的数据逐行写入）
            StreamWriter sw = new StreamWriter(fileName, true, Encoding.Default);
            string line;
            foreach (Student item in objListStudent)
            {
                line = item.SNO + ',' + item.SName + ',' + item.Gender + ',' + item.Birthday.ToString("yyyy/MM/dd") + ','
                    + item.Mobile + ',' + item.Email + ',' + item.HomeAddress + ',' + item.PhotoPath;
                sw.WriteLine(line);
            }
            sw.Close();
        }
    }
}
