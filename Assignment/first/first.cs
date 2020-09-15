using System;  
 namespace add  
{  
    class Program  
    {  
        static void Main3(string[] args)
        {
            Program p=new Program();
            p.GetInitials();
        }

        void GetInitials()  
        {  
            int Number1, Number2;  
            Console.WriteLine("please enter the Number1");  
            Number1 = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("please enter the Number2");  
            Number2 = Convert.ToInt32(Console.ReadLine());  
            int Result;  
            Result = Number1 + Number2;  
            Console.WriteLine("Sum of two Numbers:" + Result.ToString());  
            if(Result>500)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");

            }
        }  
    }  
} 