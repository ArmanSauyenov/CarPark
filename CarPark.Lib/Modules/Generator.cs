using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPark.Lib.Objects;
using CarPark.Lib.Modules;
using CarPark;

namespace CarPark.Lib.Modules
{
    public class Generator
    {
        private Random rand = new Random();

        public bool GenerateProjects(ref List<Projects> project, out string message)
        {
            try
            {
                if (project == null)
                    project = new List<Projects>();

                    project.Add(new Projects() { ProjectName = ProjectName.AlmatyTaxi });
                    project[0].car = GenerateCars(out message);

                    project.Add(new Projects() { ProjectName = ProjectName.CityTaxi });
                    project[1].car = GenerateCars(out message);

                    project.Add(new Projects() { ProjectName = ProjectName.EcoTaxi });
                    project[2].car = GenerateCars(out message);

                message = "The project was added successfully!";
                return true;
            }
            catch(Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public List<Cars> GenerateCars(out string message)
        {
            List<Cars> cars = new List<Cars>();
            for (int i = 0; i < 9; i++)
            {
                Cars car = new Cars();
                car.CarModel = "№" + rand.Next(100, 299);
                car.IssueDate = DateTime.Now.AddMonths((rand.Next(10, 100) * -1));
                car.CarType = (CarType)rand.Next(1, 4);
                car.CarStateNumber = rand.Next(100, 999);
                car.Status = (CarStatus)rand.Next(1, 3);
                car.component = GenerateComponents(out message);

                cars.Add(car);
            }
            message = "Cars were added successfully!";
            return cars;
        }

        public List<Components> GenerateComponents(out string message)
        {
            List<Components> components = new List<Components>();
            for (int i = 0; i < 3; i++)
            {
                Components component = new Components();
                component.CarPartsID = i;
                component.CarParts = (CarParts)rand.Next(1, 13);

                components.Add(component);   
            }
            message = "The component was added successfully!";
            return components;
        }
    }
}
