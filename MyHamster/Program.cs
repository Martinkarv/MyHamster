using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHamster
{
    class Animal
    {
        public string name;
        public int age = 0;
        public double weight;
       

        public void PrintBaseInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine();
          
        }


    }

    class Hamster : Animal
    {
        public int lifespan = 0;

        public void ShowLifespan()
        {
            Console.WriteLine($"Bryan's lifespan:{ lifespan}");
        }

        public void EatingMachine()
        {
            Console.WriteLine("Niom nom, so good food!");
            weight += 0.2;
            Console.WriteLine($"{name}'s weight;{weight}");
            lifespan++;
        }

        public void RunningWheel()
        {
            Console.WriteLine("Huh oh, I'm running!");
            weight -= 0.1;
            Console.WriteLine($"{name}'s weight;{weight}");
            lifespan++;
        }




    }

    class Program
    {
        static void Main(string[] args)
        {
            Hamster bryan = new Hamster();
             bryan.name = "Bryan";
             bryan.age = 0;
            bryan.weight = 0.5;
            bryan.lifespan = 0;

            bryan.PrintBaseInfo();




            for (int i = 0; i < 10; i++)
            {
                if(bryan.weight < 0.7)
                {
                    bryan.EatingMachine();
                    bryan.ShowLifespan();
                    Console.WriteLine();


                }
                else
                {
                    bryan.RunningWheel();
                    bryan.ShowLifespan();
                    Console.WriteLine();
                }


                if (bryan.lifespan == 10)
                {
                    Console.WriteLine($"{bryan.name} died. I'm sorry, can't stop the time.");
                    bryan = null;
                }

                
            }

           






















/*
kodutöö - 1. Create a class Animal that has got the following attributes:
- name
- age (0 by default)
- weight
- lifespan (0 by default)
2. inside the class, create methods:
- to display the base information about the animal
- to display lifespan
- to display weight
- to make the animal eat and gain weight (+ 0.2 with every food intake)
- to make the animal exercise and lose weight (-0.1 with every run)
2. Create an object hamster, give it a name and the weight
3. Make your hamster live ten cycles (using the for-loop),
inside this for-loop, do not forget to feed your hamster
4. Once your hamster's weight reaches the point of 0.7,
make him run to lose some weight to get it back to normal
(let's assume that 0.7 is the normal weight).
5. Once the cycle of 10 rounds is over the hamster dies
(I'm sorry, we can't help it).
*/




            Console.ReadLine();
        }
    }
}
