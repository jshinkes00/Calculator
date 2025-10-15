using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;

class MainClass
{
    public static void Main(string[] args)
    {
        int num1 = 0; int num2 = 0; int result = 0;

        

        Console.WriteLine("계산기 프로그램");
        Thread.Sleep(3000);
        Console.Clear();

        Console.WriteLine("첫번째 숫자를 입력하세요");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("두번째 숫자를 입력하십시오");
        num2 = Convert.ToInt32(Console.ReadLine());

        

        
        while (true)
        {
        Console.WriteLine("연산자를 입력하십시오 ( +,-,*,/): ");
        string op = Console.ReadLine();


            switch (op)
            {
                case "+":
                    result = num1 + num2;

                    break;

                case "-":
                    result = num1 - num2;
                    break;


                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    result = num1 / num2;
                    break;

                default:
                    Console.WriteLine("다시 입력하십시오");
                    break;
            }

            Console.WriteLine($"결과는 {result} 입니다");
            break;
        }


        Console.WriteLine("프로그램을 종료합니다");


    }

    

}