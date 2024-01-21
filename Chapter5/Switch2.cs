using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5
{
    class Switch2
    {
        static void MaindSwitch(string[] args)
        {
            object obj = null;

            string s = Console.ReadLine();
            if (int.TryParse(s, out int out_i))
                obj = out_i;
            else if (float.TryParse(s, out float out_f))
                obj = out_f;
            else
                obj = s;

            switch (obj)
            {
                case int:
                    Console.WriteLine($"{(int)obj}는 int 형식입니다.");
                    break;
                case float:
                    Console.WriteLine($"{(float)obj}는 float 형식입니다.");
                    break;
                default:
                    Console.WriteLine($"{obj}는 모르는 형식입니다.");
                    break;
            }

            Console.WriteLine("점수를 입력하세요: ");
            int score = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("재수강인가요:? (y/n)");
            string line = Console.ReadLine();
            bool repeated = line == "y" ? true : false;

            string grade = (int)(Math.Truncate(score / 10.0) * 10) switch
            {
                90 when repeated == true => "B+",
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F"
            };
        }
    }
}
