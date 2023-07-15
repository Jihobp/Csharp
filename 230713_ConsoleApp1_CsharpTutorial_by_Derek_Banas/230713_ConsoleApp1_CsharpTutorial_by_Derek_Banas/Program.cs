// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");




namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comment  /*long comment*/

            Console.WriteLine("Hello World!"); //acicute by line
            Console.Write("What is your name?");
            string name = Console.ReadLine(); //store string, letter,number, underscore ok but start with the alphabet
            Console.WriteLine("halo " + name);

            //data type
            bool canVote = true;
            char grade = 'A'; //hold single 16bit unicde
                              //little line : u defined variable, but you ain't do nothing!! 

            //numeric type
            //Integer with a max number of 2,147,483,647 정수형 int
            int maxInt = int.MaxValue;

            //Long with a max number of 9,223,372,036,854,775,807 정수형 long
            long maxLong = long.MaxValue; //instored

            //Decimal has a maximum value of 79,228,162,514,264,337,593,543,950,335
            //If you need something bigger look up BigInteger,
            decimal maxDec = decimal.MaxValue;

            //A float is a 32 bit number with a maxValue of 3.402823E + 38 with 7decimals of precison 소수점 이하 정밀도 7자리수만 가질 수 있다. 7자리수 넘으면 error accurate
            float maxFloat = float.MaxValue;

            //A float is a 32 bit number with a maxValue of 1.797693134E+308 with 15 decimals of precison 소수점 이하 15개의 자리수 float 보다 better

            //combine with string
            Console.WriteLine("Max int: " + maxInt);

            //var 프로그램이 컴파일 되는 시점에 정해져서 바꿀 수 없다.
            var anotherName = "Tom"; //자동으로 string type 됨
                                     //anotherName = 2; >> Error . can't change. 

            //We can bring 우리가 선언한 데이터 타입을 가져올 수 있다. 
            //we can semmon writeline, format, or throw in different data,다른 타입 데타를 포맷하거나 들여오고 싶을떄
            ////{} {} ..add up ok
            Console.WriteLine("Hello " + anotherName);

            // How to get the type and how to format strings
            Console.WriteLine("anotherName is a {0}", anotherName.GetTypeCode());

            // % mordular character : 나눗셈의 나머지 값 
            // The var data type is defined when compiled and then can't change



            // ---------- MATH ----------
            //increment and decrement shorthands, 증가 감소연산, 짧게 표현

            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5 - 3 = " + (5 - 3));
            Console.WriteLine("5 * 3 = " + (5 * 3));
            Console.WriteLine("5 / 3 = " + (5 / 3));
            Console.WriteLine("5.2 % 3 = " + (5.2 % 3)); //remainder  operator, decimal pointer. 소수점.

            int i = 0;

            Console.WriteLine("i++ = " + (i++)); //0 put 0 ++=
            Console.WriteLine("++i = " + (++i)); //2 ++ put 0
            Console.WriteLine("i-- = " + (i--)); //2 put 2 --
            Console.WriteLine("--i = " + (--i)); //0

            //equivalent 같은 의미다.
            i += 3;
            Console.WriteLine("i += 3 " + (i += 3));
            Console.WriteLine("i -= 2 " + (i -= 2));
            Console.WriteLine("i *= 2 " + (i *= 2));
            Console.WriteLine("i /= 2 " + (i /= 2));
            Console.WriteLine("i %= 2 " + (i %= 2));

            // Casting // 값에 손실이 되지 않는다면형변환은 자동으로 된다.
            // Casting : If no magnitude is lost casting happens automatically, but otherwise it must be done
            // like this

            double pi = 3.14;
            int intPi = (int)pi; // put the data type to convert to between braces
                                 //ㄴ> whatever you want cast 바꾸고 싶은거 집어 넣기.

            // <<Math Functions>>
            // Acos, Asin, Atan, Atan2, Cos, Cosh, Exp, Log, Sin, Sinh, Tan, Tanh
            double number1 = 10.5;
            double number2 = 15;

            Console.WriteLine("Math.Abs(number1) " + (Math.Abs(number1))); // absolute value 절대값
            Console.WriteLine("Math.Ceiling(number1) " + (Math.Ceiling(number1))); //ceiling 소수점 아래 값 올림//반올림 //round up the value
            Console.WriteLine("Math.Floor(number1) " + (Math.Floor(number1))); // floor 소수점 아래 값 내림 //round down the value 반내림
            Console.WriteLine("Math.Max(number1, number2) " + (Math.Max(number1, number2))); //최대값 반환
            Console.WriteLine("Math.Min(number1, number2) " + (Math.Min(number1, number2))); //최소값 반환
            Console.WriteLine("Math.Pow(number1, 2) " + (Math.Pow(number1, 2))); //power 거듭제곱
            Console.WriteLine("Math.Round(number1) " + (Math.Round(number1))); //round 반올림
            Console.WriteLine("Math.Sqrt(number1) " + (Math.Sqrt(number1))); //squre root 제곱근 

            // Random Numbers
            Random rand = new Random();
            Console.WriteLine("Random Number Between 1 and 10 " + (rand.Next(1, 11))); //up to 11 최대범위(10까지면)

            Random random = new Random();
            Console.WriteLine("random num betwwen 1 and 11" + rand.Next(1, 12));


            //relational operatos : 관계 연산자

            // ---------- CONDITIONALS ----------

            // Relational Operators : > < >= <= == != 관계 연산자
            // Logical Operators : && || ^ !
            // and, or, Xor(exclusive or 독점적?or), not
            //  Xor :  둘중 하나는 참, 하나는 거짓일때만 참 반환 
            // If Statement

            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else
            {
                Console.WriteLine("Go to high school");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't work");
            }

            Console.WriteLine("! true = " + (!true)); //not true == is equal to false!!!! 

            // Ternary Operator 조건 연산자 

            bool canDrive = age >= 16 ? true : false; // value, or condition(조건) comes back true, (참반환)
                                                      //assign the value of true to can drive if > canDrive 에 true 할당
                                                      //if comes back false, assign the value of false to cadDrive
                                                      // we can assign integer and then assign some arbitrary number 정수, 숫자값 할다 ㅇok 



            // switch statement 스위치 조건문
            // Switch is used when you have limited options 스위치는 옵션이 제한되어 있을 때 사용
            // Fall through isn't allowed with C# unless there are no statements between cases C#에서는 케이스 사이에 문이 없는 한 폴 스루가 허용되지 않습니다.
            // You can't check multiple values at once
            // 한 번에 여러 값을 확인할 수 없습니다.

            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant"); //유아
                    break; //꼭!!! 
                case 1: //stack this up 겹쳐서 사용 (check 1,2 둘다 )
                case 2:
                    Console.WriteLine("Toddler"); //좀더 자란 아기

                    // Goto can be used to jump to a label elsewhere in the code
                    // and, its a NIGHTMARE !!! -_- !!!
                    goto Cute; //junp out side of it. 
                default: // if nothing else matches. 
                    Console.WriteLine("Child");
                    break;
            }

        // Lable we can jump to with Goto
        Cute:
            Console.WriteLine("Toddlers are cute"); //조금 자란 아기들은 귀엽다:)

            // ---------- LOOPING ---------- 루프!!
            // continue executing statements as long as a condition is true
            // 루프는 조건이 참인 동안 계속해서 명령을 반복 시행하는 것.

            int ii = 0; // why 0? we are gonna  increment over and over agian  ! 


            // ------- while loop ---------
            while (ii < 10)
            {
                // If i = 7 then skip the rest of the code and start with i = 8
                if (ii == 7)
                {
                    ii++;
                    continue;
                }

                // Jump completely out of the loop if i = 9
                if (ii == 9)
                {
                    break;
                }

                // You can't convert an int into a bool : Print out only odds
                if ((ii % 2) > 0)
                {
                    Console.WriteLine(ii);
                }
                ii++;
            }

            // The do while loop will go through the loop at least once
            string guess;
            do
            {
                Console.WriteLine("Guess a Number ");
                guess = Console.ReadLine();
            } while (!guess.Equals("15")); // How to check String equality

            // Puts all changes to the iterator in one place
            for (int j = 0; j < 10; j++)
            {
                if ((j % 2) > 0)
                {
                    Console.WriteLine(j);
                }
            }

        }
    }
}