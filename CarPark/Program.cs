using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CarPark.Lib.Modules;
using CarPark.Lib.Objects;
using CarPark.Lib;

namespace CarPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Show show = new Show();
            show.ShowInfo();
        }
    }
}
