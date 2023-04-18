using Class_04182023;


Simulate();


static void Simulate()
{
    AbstractDuckFactory duckFactory = new CountingDuckFactory();

    IQuackable mallardDuck = duckFactory.CreateMallardDuck();
    IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
    IQuackable duckCall = duckFactory.CreateDuckCall();
    IQuackable rubberDuck = duckFactory.CreateRubberDuck();

    IQuackable gooseDuck = new GooseAdapter(new Goose());

    Console.WriteLine("Duck Simulator");


    SimulateQuack(mallardDuck);
    SimulateQuack(redheadDuck);
    SimulateQuack(duckCall);
    SimulateQuack(rubberDuck);

    SimulateQuack(gooseDuck);

    System.Console.WriteLine("The ducks quacked " + QuackCounter.GetQuacks() + " times");
    
}

static void SimulateQuack(IQuackable duck)
{
    duck.Quack();
}