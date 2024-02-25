using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter06
{
    internal class OptionalParameter
    {
        static void PrintProf(string name, string phone = "")
        {
            Console.WriteLine($"name: {name}, phone: {phone}");
        }

        static void MainOptionalParameter()
        {
            PrintProf("중근");
            PrintProf("존슨", "010-123-1234");
            PrintProf(name: "용길");
            PrintProf(name: "동주", phone: "010-222-2222");
        }
    }
}
