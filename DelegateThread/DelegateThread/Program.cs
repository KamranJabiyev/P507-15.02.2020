using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateThread
{
    class Program
    {
        #region Generic delegate
        //public delegate bool Callback(int n);

        //public delegate void Generic<T>(T t);

        //public delegate U Generic<T,U>(T t);
        #endregion


        static void Main(string[] args)
        {
            #region Delegate,Anonimous function,Lambda expression
            //Console.WriteLine(Sum(new int[] {10,15,20,25},IsEven));
            //Console.WriteLine(Sum(new int[] { 10, 15, 20, 25 }, IsOdd));
            //Console.WriteLine(Sum(new int[] { 10, 15, 20, 25 }, IsGreater));

            //anonim function
            //Console.WriteLine(Sum(new int[] { 10, 15, 20, 25 },delegate(int n) { return n < 13; } ));

            //lambda expression

            //Console.WriteLine(Sum(new int[] { 10, 15, 20, 25 }, n=>n<20));

            //Info info = new Info(Word);

            //info("Mubariz");
            //info.Invoke("Mubush");

            //Info info = Word;

            //info("Mubush");
            //AboutNumber number = IsOddOrEven;
            //number += IsElder;
            //number -= IsOddOrEven;

            //number += delegate (int n)
            //  {
            //      Console.WriteLine("Anonim");
            //  };
            //number -= delegate (int n)
            //{
            //    Console.WriteLine("Anonim");
            //};

            //number += n =>
            //{
            //    Console.WriteLine("Mubush");
            //};

            //number(86);

            //Info info = (s1, s2) =>
            //{
            //    Console.WriteLine(s1 + " " + s2);
            //};

            //info("Mubush", "Memmedzade");
            #endregion

            #region Generic delegate
            //Generic<int> generic = delegate (int n)
            //{
            //    Console.WriteLine(n);
            //};

            //Generic<string> generic1=delegate(string s)
            //{
            //    Console.WriteLine(s);
            //};
            #endregion

            #region Action,Func
            //Action<string, string> FullInfo = delegate (string s1, string s2)
            //   {
            //       Console.WriteLine("{0} {1}",s1,s2);
            //   };
            //FullInfo += Fullname;
            //FullInfo("Mubush","Memmedzade");

            //Func<int, double> func = delegate (int n)
            //   {
            //       return (double)n /2;
            //   };

            //Console.WriteLine(func(5));

            //Action<Person> action = delegate (Person p)
            //  {

            //  };

            //action(new Person());
            #endregion

            Thread thread1 = new Thread(Loop1);
            //Thread thread2 = new Thread(Loop2);
            //Thread thread3 = new Thread(Loop3);

            thread1.Start();

            //thread2.Start();
            //thread2.Join();
            Loop2();
            Loop3();
            //Loop1();
            //Loop2();
        }

        static void Loop1()
        {
            for (int i = 1; i <= 1000; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Loop1 "+i);
            }
        }

        static void Loop2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Loop2 " + i);
            }
        }
        static void Loop3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Loop3 " + i);
            }
        }

        #region Action,Func
        //class Person { }

        //static void Fullname(string name,string surname)
        //{
        //    Console.WriteLine($"{name} {surname}");
        //}
        #endregion

        #region Delegate,Anonimous function,Lambda expression
        //public delegate void Info(string s1, string s2);
        //public delegate void Info(string s1);

        //public delegate void AboutNumber(int n);

        //static void IsOddOrEven(int n)
        //{
        //    string result = n % 2 == 0 ? "Even" : "Odd";
        //    Console.WriteLine($"{n} is {result}");
        //}

        //static void IsElder(int n)
        //{
        //    Console.WriteLine($"{n} is {(n >10 ? "Greater" : "Less")} than 10");
        //}


        //static void Word(string str)
        //{
        //    Console.WriteLine(str);
        //}


        //static int Sum(int[] arr,Callback func)
        //{
        //    int result = 0;
        //    foreach (int num in arr)
        //    {
        //        if (func(num)) 
        //            result += num;
        //    }
        //    return result;
        //}

        //static bool IsEven(int n)
        //{
        //    return n % 2 == 0;
        //}

        //static bool IsOdd(int n)
        //{
        //    return n % 2 != 0;
        //}

        //static bool IsGreater(int n)
        //{
        //    return n >10;
        //}
        #endregion

    }
}
