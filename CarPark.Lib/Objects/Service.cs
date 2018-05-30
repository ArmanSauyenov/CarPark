using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Lib.Objects
{
    class Service
    {
        public DateTime TimeApplicationAccepted { get; set; }
        public string Car { get; set; }
        public string BreakdownDiscription { get; set; }
        public string RepairRecommendation { get; set; }
        public string UserInspected { get; set; }

        public Cars Search(Projects project, int StateNumber)
        {
            foreach (Cars item in project.car)
            {
                if (item.CarStateNumber == StateNumber)
                    return item;
                Console.WriteLine();
                Console.Clear();
            }
            return null;
        }

        public Cars Search(Projects project, string CarModel)
        {
            foreach (Cars item in project.car)
            {
                if (item.CarModel == CarModel)
                    return item;
                Console.Clear();
            }
            return null;
        }
    }
}
