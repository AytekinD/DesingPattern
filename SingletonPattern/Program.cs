using SingletonPattern.Lab1;
using SingletonPattern.Lab2;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lab1
            //var instance1 = DatabaseConnection.GetConnection();
            //var instance2 = DatabaseConnection.GetConnection();

            //Console.WriteLine(instance1.GetHashCode());
            //Console.WriteLine(instance2.GetHashCode()); 
            #endregion

            #region Lab2

            var singleton1 = SingletonClass.SingletonObject;
            var singleton2 = SingletonClass.SingletonObject;

            Console.WriteLine(singleton1.GetHashCode());
            Console.WriteLine(singleton2.GetHashCode());

            #endregion
        }
    }
}