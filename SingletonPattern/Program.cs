using SingletonPattern.ClassLib;
using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            SingletonBorrowUser myUser1 = SingletonBorrowUser.GetInstance;
            SingletonBorrowUser myUser2 = SingletonBorrowUser.GetInstance;
            SingletonBorrowUser myUser3 = SingletonBorrowUser.GetInstance;
            SingletonBorrowUser myUser4 = SingletonBorrowUser.GetInstance;
            SingletonBorrowUser myUser5 = SingletonBorrowUser.GetInstance;




            Console.WriteLine(myUser1.BorrowUser());
            Console.WriteLine(myUser2.BorrowUser());
            Console.WriteLine(myUser3.BorrowUser());
            Console.WriteLine(myUser4.BorrowUser());
            Console.WriteLine(myUser5.BorrowUser());
            Console.WriteLine(myUser1.BorrowUser());
            Console.WriteLine(myUser2.BorrowUser());
            Console.WriteLine(myUser3.BorrowUser());
            Console.WriteLine(myUser4.BorrowUser());
            Console.WriteLine(myUser5.BorrowUser());
            Console.WriteLine(myUser1.BorrowUser());
        


        }
    }
}
