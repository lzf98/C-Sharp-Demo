using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    public static class ValidataInput
    {
        public static bool IsNumber(string txt) //判断是不是数字
        {
            Regex objRegex = new Regex(@"^[0-9]*$");
            return objRegex.IsMatch(txt);
        }
        public static bool IsSNo(string txt) //判断是不是学号:16开头的10位数字
        {
            Regex objRegex = new Regex(@"^[1][6]\d{8}$");
            return objRegex.IsMatch(txt);
        }
        public static bool IsChinese(string txt) //判断是不是汉字
        { 
            Regex objRegex = new Regex(@"^[\u4e00-\u9fa5]{0,}$");
            return objRegex.IsMatch(txt);
        }
        public static bool IsGender(string txt) //判断是不是填写的男或者女
        {
            Regex objRegex = new Regex(@"^男|女$");
            return objRegex.IsMatch(txt);
        }
        public static bool IsMobileNo(string txt) //判断手机号码
        {
            Regex objRegex = new Regex(@"^[1][3578]\d{9}$");
            return objRegex.IsMatch(txt);
        }
        public static bool IsEMail(string txt) //判断Email 
        {
            Regex objRegex = new Regex(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            return objRegex.IsMatch(txt);
        }
    }
}
