using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace FirstApp
{
    internal class Program
    {

        static void avg()
        {
            int n1,n2,n3,n4,n5,n6,n7,n8,n9,n10;
            Console.WriteLine("Enter 10 number");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            n4 = Convert.ToInt32(Console.ReadLine());
            n5 = Convert.ToInt32(Console.ReadLine());
            n6 = Convert.ToInt32(Console.ReadLine());
            n7 = Convert.ToInt32(Console.ReadLine());
            n8 = Convert.ToInt32(Console.ReadLine());
            n9 = Convert.ToInt32(Console.ReadLine());
            n10 = Convert.ToInt32(Console.ReadLine());
            int avg = (n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10) / 10;
            
                Console.WriteLine("Average is "+ avg);
           

        }
        static void Main(string[] args)
        {

            avg();

        }
    }
}