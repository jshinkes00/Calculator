using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;

class MainClass
{
    public static void Main(string[] args)
    {
        int num1 = 0; int num2 = 0;
        double res = 0;

        
        //처음 인트로
        Console.WriteLine("계산기 프로그램");
        Thread.Sleep(1500); //1.5초 후 문자
        Console.Clear();


        //숫자 입력
        Console.WriteLine("첫번째 숫자 입력");


        //숫자 이외의 값을 넣을시 재입력 유도
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("잘못된 값입니다 다시 입력하세요");
        }

        Console.WriteLine("두번째 숫자 입력");

        while(!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("잘못된 값입니다 다시 입력하세요");
        }





        while (true)
        {
            Console.WriteLine("연산자를 입력하십시오 ( +,-,*,/): ");
            string op = Console.ReadLine().ToLower(); // 입력값이 ctrl z 같은 경우 오류가 나기때문에 이것도 나중에 해보겠습니다


            Console.WriteLine($"현재 숫자 {num1} , {num2}");
            if (op == "q")
            {
                break;
            }

            // 사칙연산 + - * / switch 문
            switch (op) 
            {
                case "+":
                    res = num1 + num2;

                    break;

                case "-":
                    res = num1 - num2;
                    break;


                case "*":
                    res = num1 * num2;
                    break;

                case "/":
                    res = num1 / num2;

                    if (num2 != 0)
                    {
                        res = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("오류: 0으로 나눌수 없습니다");
                    }
                    break;

                default:
                    Console.WriteLine("다시 입력하십시오");
                    continue; //break 대신 continue 넣어서 탈출 방지
            }

            Console.WriteLine($"결과는 {res} 입니다");
            break;
        }
        


        Console.WriteLine("프로그램을 종료합니다");


    }

    

}