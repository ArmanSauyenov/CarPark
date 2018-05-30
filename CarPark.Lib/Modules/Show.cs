using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPark.Lib.Objects;
using CarPark.Lib.Modules;
using CarPark.Lib;
using CarPark;

namespace CarPark.Lib.Modules
{
    public class Show
    {
        public void ShowInfo()
        {
            Generator gen = new Generator();

            List<Projects> projects = null;

            string message;
            if (!gen.GenerateProjects(ref projects, out message))
            {
                Console.WriteLine(message);
                return;
            }

            foreach (Projects item in projects)
            {
                item.PrintInfo();
            }
            Console.WriteLine();
            Console.WriteLine("Choose project: ");
            foreach (var item in projects)
                Console.WriteLine(" - " + item.ProjectName);

            Projects temp = null;
            do
            {
                Console.WriteLine();
                string name = Console.ReadLine();

                if (temp == null)
                break;
                else { Console.WriteLine("Проект не найден!"); }
                    
            }
            while (temp == null);

            Console.WriteLine("Выберите критерии поиска: 1 - по гаражному номеру, 2 - по модели");

            int choise = 0;
            do
            {
                Console.Write("-> ");
                Int32.TryParse(Console.ReadLine(), out choise);
            } while (choise != 1 && choise != 2);

            Service service = new Service();

            int StateNumber;
            Cars findCar = null;

            switch (choise)
            {
                case 1:
                    {
                        Console.Write("Enter car's state number: ");
                        Int32.TryParse(Console.ReadLine(), out StateNumber);
                        findCar = service.Search(temp, StateNumber);
                    }
                    break;
                case 2:
                    {

                        Console.Write("Enter car model: ");
                        findCar = service.Search(temp, Console.ReadLine());

                    }
                    break;
            }

            if (findCar == null)
                Console.WriteLine("The car wasn't found");
            else
                findCar.PrintInfo();
        }
    }
}
