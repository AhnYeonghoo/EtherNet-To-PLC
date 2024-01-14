using System;

namespace SignedUnsigned
{
    class MainApp
    {
        static void MainSignedUnsigned(string[] args)
        {
            byte a = 255;
            sbyte b = (sbyte)a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            uint overflowA = uint.MaxValue;

            Console.WriteLine(overflowA);

            overflowA += 1;
            Console.WriteLine(overflowA);

            float floatA = 3.1415_9265_3589_8932_3846f;
            double doubleA = 3.1415_9265_3589_7932_3846;
            decimal decimalA = 3.1415_9265_3589_7932_3846_2643_3832_89m;
            Console.WriteLine(decimalA);
            Console.WriteLine(floatA);
            Console.WriteLine(doubleA);

            char charA = '안';
            char charB = '녕';
            char charC = '하';
            char charD = '세';
            char charE = '요';
            Console.WriteLine(charA);
            Console.WriteLine(charB);
            Console.WriteLine(charC);
            Console.WriteLine(charD);
            Console.WriteLine(charE);

            string stringA = "안녕하세요?";
            string stringB = "안영후입니다.";
            Console.WriteLine(stringA);
            Console.WriteLine(stringB);

            string multiline =
                $"별 하나의 추억과\n" +
                $"별 하나의 사랑과\n" +
                $"별 하나에 쓸쓸함과\n" +
                $"별 하나에 동경과\n" +
                $"별 하나에 시와\n" +
                $"별 하나에 어머니, 아버지";
            Console.WriteLine(multiline);

            bool boolA = true;
            bool boolB = false;
            Console.WriteLine(boolA);
            Console.WriteLine(boolB);

            object objectA = 123;
            object objectB = 3.141592653589793238462643383269m;
            object objectC = true;
            object objectD = "안녕하세요";
            Console.WriteLine(objectA);
            Console.WriteLine(objectB);
            Console.WriteLine(objectC);
            Console.WriteLine(objectD);
            Console.Clear();

            int intA = 123;
            object objectBB = (object)intA;
            int intC = (int)objectBB;
            Console.WriteLine(intA);
            Console.WriteLine(objectBB);
            Console.WriteLine(intC);
            objectBB = 111;
            Console.WriteLine(intA);
            Console.WriteLine(objectBB);
            Console.WriteLine(intC);

            return;
        }
    }
}