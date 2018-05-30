using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Lib.Objects
{
    public enum ProjectName { AlmatyTaxi = 1, EcoTaxi, CityTaxi }

    public class Projects
    {
        public ProjectName ProjectName { get; set; }
        public List<Cars> car = new List<Cars>();

        public void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t<--- Project: {0} --->", ProjectName);

            foreach (Cars item in car)
            {   
                item.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}
