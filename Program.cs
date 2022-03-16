using System;
using System.Collections;

namespace Homework16._03
{
    class Program
    {
        static void Main(string[] args)

        {
            #region Task 2

            //SortedList sortedList = new SortedList();
            //sortedList.Add(1970, "C");
            //sortedList.Add(1980, "C++");
            //sortedList.Add(1993, "Lua");
            //sortedList.Add(1991, "Python");
            //sortedList.Add(2001, "C#");

            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}
            #endregion
            Fruits fruits = new Fruits();

            Apple<char> apple = new Apple<char>('B');

            PineApple<char> pine = new PineApple<char>('B');

            Lemon<char> lemon = new Lemon<char>('C');


            fruits.Basket.Add(apple.Vitamin);
            fruits.Basket.Add(pine.Vitamin);
            fruits.Basket.Add(lemon.Vitamin);

            foreach (var item in fruits.Basket)
            {
                Console.WriteLine(item);
            }

        }
    }
}
