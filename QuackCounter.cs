namespace Class_04182023
{
    public class QuackCounter : IQuackable
    { //Decorator Pattern
        IQuackable duck;
        static int numberOfQuacks;

        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
        }

        public void Quack()
        {
            duck.Quack();
            numberOfQuacks++;
        }

        public static int GetQuacks()
        {
            return numberOfQuacks;
        }
    }
}