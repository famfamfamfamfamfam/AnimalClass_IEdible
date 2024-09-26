namespace ABSTRACTCLASSANDINTERFACE
{
    class KiemThu
    {
        static void Main(string[] args)
        {
            Animal[] animals = { new Tiger(), new Chicken() };
            foreach (Animal an in animals)
            {
                Console.WriteLine(an.MakeSound());
                if (an is Chicken)
                {
                    Edible edible = (Chicken)an;
                    Console.WriteLine(edible.HowToEat());
                }
            }

            Fruit[] fruits = { new Apple(), new Orange() };
            foreach (Fruit f in fruits)
            {
                Console.WriteLine(f.HowToEat());
            }
        }
    }
}