namespace Singleton_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DbConnection dbConnection1 = DbConnection.GetInstance();
            DbConnection dbConnection2 = DbConnection.GetInstance();
            if(dbConnection1 == dbConnection2)
            {
                Console.WriteLine($"Instances are same");
            }
            //dbConnection1.Display();
        }
    }
}