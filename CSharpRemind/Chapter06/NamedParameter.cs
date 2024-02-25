using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter06
{
    internal class NamedParameter
    {
        static void PrintProf(string name, string phone)
        {
            Console.WriteLine($"Name : {name}, Phone: {phone}");
        }
        
        static void MainNamedParameter()
        {
            PrintProf(name: "박찬호", phone: "010-123-1234");
            PrintProf(phone: "010987-98555", name: "박지성");
            PrintProf("박세라", "0102222222");
            PrintProf("박상현", phone: "010-2222-2222");
        }
    }
}
