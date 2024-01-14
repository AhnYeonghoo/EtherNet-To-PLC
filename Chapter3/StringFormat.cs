using System;
using System.Globalization;


namespace StringFormat
{
    class MainApp
    {
        static void Main()
        {
            string fmt = "{0,-20}{1,-15}{2, 30}";
            Console.WriteLine(fmt, "Publisher", "Author", "Title");
            Console.WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            Console.WriteLine(fmt, "Hanbit", "Sanghyun Park", "This is C#");

            // D: 10진수
            Console.WriteLine("10진수: {0:D}", 123);
            Console.WriteLine("10진수: {0:D5}", 123);

            // X: 16진수
            Console.WriteLine("16진수: 0x{0:X}", 0xFF1234);
            Console.WriteLine("16진수: 0x{0:X8}", 0xFF1234);

            // N: 숫자
            Console.WriteLine("숫자: {0:N}", 123456789);
            Console.WriteLine("숫자: {0:N0}", 123456789);

            // F: 고정 소수점
            Console.WriteLine("고정 소수점: {0:F}", 123.45);
            Console.WriteLine("고정 소수점: {0:F5}", 123.456);

            // E: 공학용
            Console.WriteLine("공학: {0:E}", 123.456789);

            DateTime dt = new DateTime(2023, 03, 04, 23, 18, 22);

            Console.WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            Console.WriteLine("24시간 형식: {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

            CultureInfo ciKo = new CultureInfo("ko-KR");
            Console.WriteLine();
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
            Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo));
            Console.WriteLine(dt.ToString(ciKo));

            Console.WriteLine();
            CultureInfo ciEn = new CultureInfo("en-US");
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));
            Console.WriteLine(dt.ToString(ciEn));

            Console.WriteLine();

            string name = "김튼튼";
            int age = 23;
            Console.WriteLine($"{name,-10}, {age:D3}");

            name = "박날씬";
            age = 30;
            Console.WriteLine($"{name}, {age,-10:D3}");

            name = "이비실";
            age = 17;
            Console.WriteLine($"{name}, {(age > 20 ? "성인" : "미성년자")}");

            return;
        }
    }
}