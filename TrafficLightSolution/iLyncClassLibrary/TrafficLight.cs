using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace iLyncClassLibrary
{
    /// <summary>
    /// 信号灯的实例类
    /// </summary>
    public class TrafficLight
    {
        //属性和字段
        //思考： 200个灯（每个灯有四种颜色：白色，绿色，黄色和红色） ---1: 白色  2：绿色   3：黄色  4：红色----》写下去！
        //我的想法：在同一个时刻，值显示两中演示：白色+ 绿色/黄色/红色：  就两种状态----bool类型(节约内存空间 )
        //----字段Field----
        private bool[,] light01 = new bool[20, 10];
        private bool[,] light02 = new bool[20, 10];

        //---属性：-----
        public bool[,] Light01
        {
            get { return light01; }
            set { light01= value; }
        }
        public bool[,] Light02
        {
            get { return light02; }
            set { light02 = value; }
        }

        //方法
        //构造方法：无参数
        public TrafficLight() { }
        //构造方法：有参数
        public TrafficLight(int number)
        {

            //定义第三个数组 
            bool[,] light = new bool[20, 10];
            char charNumber;

            for (int i = 0; i < 2; i++)   //两次初始化
            {
                if (i == 0)
                {
                    light = light01;
                    charNumber = char.Parse(number.ToString("00").Substring(0, 1));
                }
                else
                {
                    light = light02;
                    charNumber = char.Parse(number.ToString("00").Substring(1, 1));
                }

                switch (charNumber)
                {
                    case '0':
                        for (int row = 0; row < light.GetLength(0); row++)  //20行
                        {
                            for (int col = 0; col < light.GetLength(1); col++)//10列
                            {

                                if (row < 2) light[row, col] = true;//最上面两行
                                else if (row >= light.GetLength(0) - 2) light[row, col] = true;   //最下面两行
                                else if (col < 2) light[row, col] = true;   //前两列
                                else if (col >= light.GetLength(1) - 2) light[row, col] = true;   //最下面两行
                                else light[row, col] = false;  //其他亮白等
                            }
                        }
                        break;
                    case '1':
                        for (int row = 0; row < light.GetLength(0); row++)  //20行
                        {
                            for (int col = 0; col < light.GetLength(1); col++)//10列
                            {
                                if (col >= light.GetLength(1) - 2) light[row, col] = true;   //最后两列
                                else light[row, col] = false;  //其他亮白等
                            }
                        }
                        break;
                    case '2':
                        // 最上，右上，中间，坐下，最下
                        for (int row = 0; row < light.GetLength(0); row++)  //20行
                        {
                            for (int col = 0; col < light.GetLength(1); col++)//10列
                            {
                                if (row < 2) light[row, col] = true;   //最上
                                else if (col >= light.GetLength(1) - 2 && row < light.GetLength(0) / 2) light[row, col] = true;   //右上
                                else if (row == light.GetLength(0) / 2 || row == light.GetLength(0) / 2 - 1) light[row, col] = true;   //中间
                                else if (col < 2 && row >= light.GetLength(0) / 2) light[row, col] = true;  //左下 
                                else if (row >= light.GetLength(0) - 2) light[row, col] = true; //最下
                                else light[row, col] = false;  //其他亮白等
                            }
                        }
                        break;
                    case '3':
                        for (int row = 0; row < light.GetLength(0); row++)  //20行
                        {
                            for (int col = 0; col < light.GetLength(1); col++)//10列
                            {
                                if (row < 2) light[row, col] = true;   //最上
                                else if (col >= light.GetLength(1) - 2) light[row, col] = true;   //最后两列
                                else if (row == light.GetLength(0) / 2 || row == light.GetLength(0) / 2 - 1) light[row, col] = true;   //中间
                                else if (row >= light.GetLength(0) - 2) light[row, col] = true; //最下
                                else light[row, col] = false;  //其他亮白等
                            }
                        }
                        break;
                    case '4':
                        for (int row = 0; row < light.GetLength(0); row++)  //20行
                        {
                            for (int col = 0; col < light.GetLength(1); col++)//10列
                            {

                                if (col >= light.GetLength(1) - 2) light[row, col] = true;//最后两列
                                else if (col < 2 && row < light.GetLength(0) / 2) light[row, col] = true;   //左上
                                else if (row == light.GetLength(0) / 2 || row == light.GetLength(0) / 2 - 1) light[row, col] = true;   //中间
                                else light[row, col] = false;  //其他亮白等
                            }
                        }
                        break;
                    case '5':
                        for (int row = 0; row < light.GetLength(0); row++)  //20行
                        {
                            for (int col = 0; col < light.GetLength(1); col++)//10列
                            {

                                if (row < 2) light[row, col] = true;//最上面两行
                                else if (row >= light.GetLength(0) - 2) light[row, col] = true;//最下面两行
                                else if (col < 2 && row < light.GetLength(0) / 2) light[row, col] = true;   //左上
                                else if (row == light.GetLength(0) / 2 || row == light.GetLength(0) / 2 - 1) light[row, col] = true;   //中间
                                else if (col >= light.GetLength(1) - 2 && row > light.GetLength(0) / 2) light[row, col] = true;   //右下
                                else light[row, col] = false;  //其他亮白等
                            }
                        }
                        break;
                    case '6':
                        for (int row = 0; row < light.GetLength(0); row++)  //20行
                        {
                            for (int col = 0; col < light.GetLength(1); col++)//10列
                            {

                                if (row < 2) light[row, col] = true;//最上面两行
                                else if (row >= light.GetLength(0) - 2) light[row, col] = true;//最下面两行
                                else if (col < 2) light[row, col] = true;   //最左边两列
                                else if (row == light.GetLength(0) / 2 || row == light.GetLength(0) / 2 - 1) light[row, col] = true;   //中间
                                else if (col >= light.GetLength(1) - 2 && row > light.GetLength(0) / 2) light[row, col] = true;   //右下
                                else light[row, col] = false;  //其他亮白等
                            }
                        }
                        break;
                    case '7':
                        for (int row = 0; row < light.GetLength(0); row++)  //20行
                        {
                            for (int col = 0; col < light.GetLength(1); col++)//10列
                            {

                                if (row < 2) light[row, col] = true;//最上面两行
                                else if (col >= light.GetLength(1) - 2) light[row, col] = true;   //最后两列
                                else light[row, col] = false;  //其他亮白等
                            }
                        }
                        break;
                    case '8':
                        for (int row = 0; row < light.GetLength(0); row++)  //20行
                        {
                            for (int col = 0; col < light.GetLength(1); col++)//10列
                            {

                                if (row < 2) light[row, col] = true;//最上面两行
                                else if (row >= light.GetLength(0) - 2) light[row, col] = true;   //最下面两行
                                else if (col < 2) light[row, col] = true;   //前两列
                                else if (col >= light.GetLength(1) - 2) light[row, col] = true;   //最下面两行
                                else if (row == light.GetLength(0) / 2 || row == light.GetLength(0) / 2 - 1) light[row, col] = true;   //中间
                                else light[row, col] = false;  //其他亮白等
                            }
                        }
                        break;
                    case '9':
                        for (int row = 0; row < light.GetLength(0); row++)  //20行
                        {
                            for (int col = 0; col < light.GetLength(1); col++)//10列
                            {

                                if (row < 2) light[row, col] = true;//最上面两行
                                else if (row >= light.GetLength(0) - 2) light[row, col] = true;   //最下面两行
                                else if (col < 2 && row < light.GetLength(0) / 2) light[row, col] = true;   //前两列
                                else if (col >= light.GetLength(1) - 2) light[row, col] = true;   //最下面两行
                                else if (row == light.GetLength(0) / 2 || row == light.GetLength(0) / 2 - 1) light[row, col] = true;   //中间
                                else light[row, col] = false;  //其他亮白等
                            }
                        }
                        break;

                }
            }
           

        }
        //打印方法
        public void PrintNumber(string color)
        {
            for (int row = 0; row < light01.GetLength(0); row++)
            {
                for (int col01 = 0; col01 < light01.GetLength(1); col01++)
                {
                    if (light01[row, col01] == true)
                    {
                        PrintCustom.PrintUseColor(color, "●");
                    }
                    else
                    {
                        PrintCustom.PrintUseColor("white", "●");
                    }
                }
                Console.Write("\t");
                for (int col02 = 0; col02 < light01.GetLength(1); col02++)
                {
                    if (light02[row, col02] == true)
                    {
                        PrintCustom.PrintUseColor(color, "●");
                    }
                    else
                    {
                        PrintCustom.PrintUseColor("white", "●");
                    }
                }

                Console.WriteLine();
            }
            Console.Write("\n\n\n");
            PrintCustom.PrintUseColor("cyan", "【暂停/启动：Space   重新设定时间：Enter    结束：End】");
        }
        //等待响应
        public static int Wart()
        {
            int flag = 1;
            int times = 0;
            while (true)
            {
                times++;
                //停止一秒
                System.Threading.Thread.Sleep(50);

                //检测键盘的响应
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo info = Console.ReadKey(); //记录按了什么键
                    switch (info.Key)
                    {
                        case ConsoleKey.Spacebar:
                            if (flag == 1) flag = 2;
                            else if (flag == 2) flag = 3;
                            break;
                        case ConsoleKey.Enter:
                            flag = 4;
                            break;
                        case ConsoleKey.End:
                            flag = 5;
                            break;
                    }

                }
                switch (flag)
                {
                    case 1:   //继续
                        if(times==20) return 1;
                        break;
                    case 2:   //暂停
                        times = 0;
                        break;  //一直在停止！
                    case 3:   //暂停后继续
                        return 1;
                    case 4:  //重新设置系统时间
                        return 2;
                    case 5:    //直接退出系统
                        return 3;
                }

            }
        }
    }
}
