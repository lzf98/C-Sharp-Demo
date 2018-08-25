using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class BuildName
    {
        public static string BuildPhotoName(string fileName)
        {
            //产生名称
            string photoName = DateTime.Now.ToString("yyyyMMddHHmmsss");
            //生成最后两位随机数
            Random objRandom = new Random();
            photoName += objRandom.Next(0, 99).ToString("00");
            //添加原上传文件的类型
            photoName += fileName.Substring(fileName.LastIndexOf("."));

            return photoName;
        }
    }
}
