using System;

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
                Console.WriteLine($"The dog {name} with {spots} spots has been created");
            }
            //getters for class properties
            public string Name
            {
                get { return name; }
            }
            public double Happiness
            {
                get { return happiness;  }
            }

            public void Barks()
            {
                Console.WriteLine("Woof-woof!");
                happiness += 0.2; //happiness = happiness + 0.2
            }

            public void WagTail()
            {
                Console.WriteLine("Wiggle-wiggle");
            }

            public void Rename(string newName)
            {
                name = newName;
            }


        }




        static void Main(string[] args)
        {
            Dog myDog = new Dog("Koer", 15);            //koer on nagu koera nimi ja "15" laikude arv koeral,sest eelnevalt olen kirja pannud

            /*myDog.happiness = 10;                       //et saada myDog.name jne tuleb panna publicusse neid aga kuna see pole turvaline tuleb teha gettereid
            myDog.name = "DogCucumber";*/
            myDog.Barks();

            while(myDog.Happiness != 1)
            {
                myDog.Barks();
            }

            myDog.WagTail();

            Console.WriteLine("Rename your dog");
            string userInput = Console.ReadLine();
            myDog.Rename(userInput);

            Console.WriteLine($"Name: {myDog.Name}");
            Console.WriteLine($"Level of happiness: {myDog.Happiness}");

        }
    }
}
