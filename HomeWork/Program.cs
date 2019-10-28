using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        class Body
        {
            public int weight;
            public string colour;
        }
        class Planet: Body
        {
            public int NumberOfInhabitants;

        }

        class SolarSystem
        {
            public int numberOfPlanets;
            Planet Earth = new Planet();


        }
        class Sun: Body
        {
            public int Temperature;

            
        }

        static void Main(string[] args)
        {
            
        }
    }
}
