using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.ClassLib
{
    // note the class is seald, this is belts and braces, as the private constructor prevents
    // it being inherited from
    //https://csharpindepth.com/Articles/Singleton

    public sealed class SingletonBorrowUser
    {

        // this is our one and only static instance of this class.
        // Because its static, it is created before the nornmal constructor is executed.
        private static readonly SingletonBorrowUser instance = new SingletonBorrowUser();

        // If a static constructor exists, it is called once and once only, and this is before the instance of the object is actually created.
        // Doing this looks after issues created in normal singletons by checking for null when using mutithreading (see notes).
        // in this case the first thread to execute it will genrate the instance of 'instance'.
        // The second thread will be given this already created instance.
        static SingletonBorrowUser()
        {
           
        }

        // The constructor is private and so can never be called on a 'new' or used to by a subclass when inherited from.
        private SingletonBorrowUser()
        {
           
        }

        // when Get instance is called, it returns its one and only onject instance.
        public static SingletonBorrowUser GetInstance
        {
            get
            {
                return instance;
            }
        }


        // Above this line is the singleton part

        public int UsersRemaining { get; private set; } = 10;

        public string BorrowUser()
        {
            if (UsersRemaining > 0)
            {
                UsersRemaining--;
                return "User Borrowed OK. " + UsersRemaining.ToString() + " users remaining";
            }
            else
            {
                return "Failed to borrow user. There are no users to left";
            }


        }

        public string ReturnUser()
        {
            UsersRemaining++;
            return "user returned. there are now " + UsersRemaining.ToString() + " users remaining";

        }
    }

}
