using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 几种简单的获取自定义时间并进行简单操作的方法
namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args) 
        {
            DateTime myValue = DateTime.Now; // 获取当前系统时间,DateTime对象表示一个时刻
            Console.WriteLine(myValue); // 显示当前时间,默认格式是当地格式
            //Console.WriteLine(myValue.ToShortDateString().ToString()); // 只显示年月日
            //Console.WriteLine(myValue.ToLongDateString().ToString()); // 以xx年xx月xx日的格式显示年月日
            //Console.WriteLine(myValue.ToShortTimeString().ToString()); // 只显示小时和分钟
            //Console.WriteLine(myValue.ToLongTimeString().ToString()); // 显示小时分钟和秒
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString()); // 调用.AddDays()在当前时间上加3天,括号里是负的则减天数
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString()); // 调用.AddHours()在当前时间上加3小时，括号里是负的则减小时
            //Console.WriteLine(myValue.Month); // 抽取显示当前月份

            //DateTime myBirthday = new DateTime(1998, 1, 24); // 输入我的生日(或其他具体时间)并初始化为DateTime
            //Console.WriteLine(myBirthday.ToShortDateString());  // 以年月日显示我的生日
            
            DateTime myBirthday = DateTime.Parse("1998年01月24日"); // 这里怎么输都行，汉字也无所谓，但是19980124这种纯数字不行
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday); // TimeSpan对象表示时间间隔，首先使用Subtract方法将我的生日和当前时间相减，再赋值给myAge
            Console.WriteLine(myAge); // 显示我活了多久，默认是天.小时.分钟.秒,在括号里myAge后面输入.total还可以换算成其他格式
            
            Console.ReadLine();
        }
    }
}
