using SingletonPattern.ClassLib;
using System;
using System.Collections.Generic;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            // Note the constuctor of SingletonBorrowUser is private.
            // this stops us (eternally) producing multiple instances by using
            // SingletonBorrowUser myUser1 = new SingletonBorrowUser();

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
