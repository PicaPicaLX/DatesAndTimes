using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 几种简单的获取当前系统时间并以不同格式显示的方法
namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args) 
        {
            DateTime myValue = DateTime.Now; // 获取当前系统时间

            Console.WriteLine(myValue.ToString()); // 将获取的系统时间以当地的习惯显示出来
            //Console.WriteLine(myValue.ToShortDateString()); // 只显示年月日
            //Console.WriteLine(myValue.ToShortTimeString()); // 只显示小时和分钟
            //Console.WriteLine(myValue.ToLongDateString()); // 以xx年xx月xx日显示
            //Console.WriteLine(myValue.ToLongTimeString()); // 只显示小时分钟和秒

            Console.ReadLine();
        }
    }
}
