using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iLyncClassLibrary;
using Common;
namespace TrafficLight_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ReInput:
            //让用户输入红灯、黄灯、绿灯的倒计时时间 
            Console.Clear();
            int greenTime, yellowTime, redTime;
            while (true)
            {
                PrintCustom.PrintUseColor("green", "请输入绿灯的时间：");
                string str = Console.ReadLine();
                if (CheckInput(str))
                {
                    greenTime = Convert.ToInt32(str);
                    break;
                }
            }
            while (true)
            {
                PrintCustom.PrintUseColor("yellow", "请输入黄灯的时间：");
                string str = Console.ReadLine();
                if (CheckInput(str))
                {
                    yellowTime = Convert.ToInt32(str);
                    break;
                }
            }
            while (true)
            {
                PrintCustom.PrintUseColor("red", "请输入红灯的时间：");
                string str = Console.ReadLine();
                if (CheckInput(str))
                {
                    redTime = Convert.ToInt32(str);
                    break;
                }
            }

         
            //如何让这三个颜色的灯交替循环倒计时
            //一直在做！直到---循环
            while (true)
            {
                //绿灯倒计时
                for (int i = greenTime; i >0 ; i--)
                {
                    TrafficLight objTraf = new TrafficLight(i);
                    Console.Clear();
                    objTraf.PrintNumber("green");
                    //捕获键盘响应
                    int action = TrafficLight.Wart();
                    if (action == 1) continue;
                    else if (action == 2) goto ReInput;
                    else if (action == 3) goto End;


                }
                //黄灯倒计时
                for (int i = yellowTime; i > 0; i--)
                {
                    TrafficLight objTraf = new TrafficLight(i);
                    Console.Clear();
                    objTraf.PrintNumber("yellow");
                    System.Threading.Thread.Sleep(1000);
                    //捕获键盘响应
                    int action = TrafficLight.Wart();
                    if (action == 1) continue;
                    else if (action == 2) goto ReInput;
                    else if (action == 3) goto End;

                }
                //红灯倒计时
                for (int i = redTime; i > 0; i--)
                {
                    TrafficLight objTraf = new TrafficLight(i);
                    Console.Clear();
                    objTraf.PrintNumber("red");
                    System.Threading.Thread.Sleep(1000);
                    //捕获键盘响应
                    int action = TrafficLight.Wart();
                    if (action == 1) continue;
                    else if (action == 2) goto ReInput;
                    else if (action == 3) goto End;
                }
            }
            End:
            Common.PrintCustom.PrintUseColor("red","\n程序已退出,按任意键结束！");
            Console.ReadKey();
        }
        static bool  CheckInput(string txt)
        {
            //如果没有输入任何值
            if (string.IsNullOrEmpty(txt))
            {
                Console.Write("没有输入任何值,请重新输入！");
                return false;
            }
            //如果输入的不是数字怎么办
            if (!Common.Validate.IsNumber(txt))
            {
                Console.Write("必须要输入数字！");
                return false;
            }
            //数字是否介于0-99
            if (Convert.ToInt32(txt) < 0 || Convert.ToInt32(txt) > 99)
            {
                Console.Write("输入的数字必须介于0-99");
                return false;
            }
            return true;
        }
    }
}
