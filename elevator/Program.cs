using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello I'm {GetElevatorName()}. How can I help you");
            Console.ReadLine();
        }

        public static string GetElevatorName()
        {
            return "Elevator 01";
        }
    }
}
