using System;
namespace Assignment
{
    class Program
    {
        static void Main2(string[] args)
        {
            Program p = new Program();
            p.GetInitials();
        }
        void GetInitials()
        {
            Console.Write("Enter two words separated by space: ");
            string s = Console.ReadLine();
            string[] output = s.Split(' ');
            Console.Write("Starting character of two words: ");

            foreach (string a in output)
            {
                if(output.Length!=2)
                {
                Console.WriteLine("Your Input is incoorect, Please Enter two words!!!!");
                }
                else{
                    Console.Write(a[0]);
                }
            }
        }
    }
}