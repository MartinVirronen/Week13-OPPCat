using System;
using System.IO;

namespace OOPpart1
{
    class Program
    {

        class Dog
        {
            string name;
            int spots;
            double happiness;

            public Dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} with {spots} has been created.");
            }

            public string Name
            {
                get { return Name; }
            }
            public int Spots
            {
                get { return Spots; }
            }
            public double Happiness
            {
                get { return happiness; }
            }

            public void Barks()
            {
                Console.WriteLine("woof, woof");
                happiness += 0.2; //hapiness = happiness + 0.2
            }
        
        public void WagTail()
        {
            Console.WriteLine("wiggle-wiggle");
        }

        public void Rename(string newName)
            {
                name = newName;
            }




            static void Main(string[] args)
            {
                Dog myDog = new Dog("Koer", 15);
                //myDog.happiness = 10;
                //myDog.name = "Good dog";

                while (myDog.happiness != 1)
                {
                    myDog.Barks();
                }

                myDog.WagTail();
                Console.WriteLine("Rename your dog");
                string userInput = Console.ReadLine();
                myDog.Rename(userInput);
                Console.WriteLine($"Name{myDog}");
                Console.WriteLine($"Level of happiness {myDog.happiness}");
            }
        }
    }

}

