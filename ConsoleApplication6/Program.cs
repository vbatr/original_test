using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = @"\\\,/;\\\\’`?:”|<>[]{}()+&\\\";

            Console.WriteLine(txt.Replace(@"\\\", @"\"));

            Console.WriteLine(HttpUtility.UrlEncode(@"\,/;\\’`?:”|<>[]{}()+&\."));
        }
    }
}
