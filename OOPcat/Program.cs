using System;

namespace OOPcat
{
    class Program
    {
        class cat
        {
            string name;
            string color;
            double hungry;

            public cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hungry = 0;
                Console.WriteLine($"The Cat {name} with {color} has been created.");
            }

            public string Name
            {
                get { return name; }
            }
            public string Color
            {
                get { return color; }
            }
            public double Hungry
            {
                get { return hungry; }
            }
         
            public void Sleep()
            {
                Console.WriteLine("zzz");
                hungry += 0.2;
            }
            public void Meow()
            {
                Console.WriteLine("Meow");
            }
        
            static void Main(string[] args)
            {
                cat myCat = new cat("KarlOrav", "blacknigger");

                while(myCat.Hungry != 1)
                {
                    myCat.Sleep();
                }
                myCat.Meow();

                Console.WriteLine($"name: {myCat.Name}");
                Console.WriteLine($"Level of hungriness: {myCat.Hungry}");


            }
        
        
        }

    }
}