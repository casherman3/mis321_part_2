using compund;

Simulate();

static void Simulate()
{
    CountingDuckFactory duckFactory = new CountingDuckFactory();

    IQuackable mallard = duckFactory.CreateMallard();
    IQuackable duckCall = duckFactory.CreateDuckCall();
    IQuackable gooseDuck = new GooseAdapter(new Goose());

    Quack(mallard);
    Quack(duckCall);
    Quack(gooseDuck);

    System.Console.WriteLine($"the ducks quacked {QuackCounter.GetNumebrOfQuacks()} times");
}

static void Quack(IQuackable duck)
{
    duck.Quack();
}