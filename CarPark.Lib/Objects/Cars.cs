using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Lib.Objects
{
    public enum CarType { Jeep = 1, Minivan, Sedan, Coupe }
    public enum CarStatus { Active = 1, Inactive }

    public class Cars
    {
        public string CarModel {get ;set; }
        public CarType CarType { get; set; }
        public DateTime IssueDate { get; set; }
        public int CarStateNumber { get; set; }
        public CarStatus Status { get; set; }

        public List<Components> component = new List<Components>();

        public void PrintInfo()
        {
            if (Status == CarStatus.Active)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine();
            Console.WriteLine($"Car Model: {CarModel} \n Car Type: {CarType} \n Issue Date: {IssueDate} \n Car's State Number: A {CarStateNumber} \n Car Status: {Status} \n");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            foreach (Components item in component)
            {
                Console.WriteLine("{0}", item.CarParts);
            }
        }
    }
}
