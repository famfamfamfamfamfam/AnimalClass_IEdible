namespace ABSTRACTCLASSANDINTERFACE
{
    class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "CHIP";
        }
        public string HowToEat()
        {
            return "Nhai va nuot";
        }
    }
}