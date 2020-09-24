using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num1;
            //string ipt;
            Console.WriteLine("Hello C# world");
            Console.Write("첫번째 정수 입력:");
            /*
            ipt = Console.ReadLine();
            num = int.Parse(ipt);
            */
            num = int.Parse(Console.ReadLine());
            Console.Write("두번째 정수 입력:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine(num + "+" + num1 + "=" + (num+ num1));
            Console.WriteLine(num + "-" + num1 + "=" + (num - num1));
            Console.WriteLine(num + "*" + num1 + "=" + (num * num1));
            Console.WriteLine(num + "/" + num1 + "=" + (num / num1));

        }
    }
}
