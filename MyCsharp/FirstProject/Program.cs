using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            
            Console.WriteLine("Full name : {0}",customer.GetFullName("Huy","Dang"));
        }
    }
}
