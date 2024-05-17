using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1
{
    class task1
    {
        public void oddeven()
        {
            int a = 11;
            if (a % 2 == 0)
            {
                Console.WriteLine(a + "is an even number");  
            }
            else {
                Console.WriteLine(a + "is an odd number");
            }
            
        }


        public void oddnum1to10()
        {
            for(int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }

        public void evennumfrom1to600()
        {
            for(int i = 1; i <= 600; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }


        

        public void oddnumfrom1to100()
        {
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
                Console.WriteLine(count);
            }
        }



        public void evennumberfrom1to300()
        {
            int count = 0;
            for (int i = 0; i < 300; i++)
            {
                if (i % 2== 0)
                {
                    count++;
                }
                Console.WriteLine(count);
            }
        }



        public  void evensumfrom1to90()
        {
            int sum = 0;
            for (int i = 1; i <= 90; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }
        }

        public void oddsumfrom1to80()
        {
            int sum = 0;    
            for(int i=1;i<=80;i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }



        public void reversethenum123()
        {
            int num = 123;
            int rev = 0;
            while (num > 0)
            {
                int n = num % 10;
                rev = (rev * 10) + n;
                num /= 10;
            }
            Console.WriteLine(rev);
        }


        public void palindromenumber()
        {
            int num = 12321;
            int temp = num;
            int rev = 0;
            while(num > 0){
                int n = num % 10;
                rev = (rev * 10) + n;
                num /= 10;
                 }
            if (rev == temp)
            {
                Console.WriteLine("palindrome number");
            }
            else
            {
                Console.WriteLine("not a palindrome number");
            }
        }



        public void countthenumeberofdigit()
        {
            int num = 12321;
            int count = 0;
            while (num > 0)
            {
                count++;

                num /= 10;
            }
            Console.WriteLine("number of digits in the given number" + count);
        }




        public void armstrongnumber()
        {
            int num = 153;
            int temp = num;
            int arm = 0;
            while (num > 0)
            {
                int n = num % 10;
                arm = arm + (n * n * n );
                num /= 10;
            }
            if (arm == temp)
            {
                Console.WriteLine("armstrong number");

            }
            else
            {
                Console.WriteLine("not a armstrong number");
            }
        }

        public void sumofdigits()
        {
            int num = 12321;
            int sum = 0;
            while (num > 0)
            {
                int n = num % 10;
                sum = sum + n;
                num /= 10;
2

            }
            Console.WriteLine("sum of digits in the given number" + sum);
        }


        public void swaptwonumberwith3variable()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("a="+a);
            Console.WriteLine("b=" + b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);

        }

        public void swaptwonumwithoutvariable()
        {

        }
    }

}
