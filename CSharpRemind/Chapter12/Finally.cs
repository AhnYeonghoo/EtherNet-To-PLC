using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter12
{
    internal class Finally
    {
        static int Divide(int divisor, int dividend)
        {
            try
            {
                Console.WriteLine("Divide() 시작");
                return divisor / dividend;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide() 예외 발생");
                throw e;
            }
        }

        static void Main()
        {
            try
            {
                Console.WriteLine("제수를 입력하세요 :");
                int divisor = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("피제수를 입력하세요: ");
                int dividend = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}/{1} = {2}", divisor, dividend, Divide(divisor, dividend));
            }
            catch (FormatException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            catch ( DivideByZeroException e)
            {
                Console.WriteLine("에러: " + e.Message);
            }
            finally
            {
                Console.WriteLine("프로그램을 종료합니다.")
            }
        }
    }
}
