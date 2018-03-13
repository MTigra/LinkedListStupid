using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                       
                List<int> lst = new List<int>(new int[] { 1, 2, 3, 4, 5 });
                CircularLinkedList<int> circular = new CircularLinkedList<int>(lst);
                do
                {
                    circular.Shift();
                    Console.WriteLine(circular.Current.Value);
                } while (Console.ReadKey().Key != ConsoleKey.Escape);
                Console.WriteLine("Удаления");
                do
                {
                    Console.WriteLine("удалил: " + circular.Remove());

                } while (Console.ReadKey().Key != ConsoleKey.Escape);
                circular.Shift();
                var a = circular.Current;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
