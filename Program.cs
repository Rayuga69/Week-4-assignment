class Program
    {
        static void Main(string[] args){
        Car car = new Car("lambo", "2022", "1 million");
        Car car1 = new Car("lambuuuo", "2020", "2 million");
        car.Display();
        car1.Display();
        BankAccount bankAccount = new BankAccount("Samyok");
        bankAccount.Deposit(1000);
        bankAccount.Withdraw(500);
        bankAccount.Balance();
        Rectangle rectangle = new Rectangle(4.5f, 3.2f);
        Console.WriteLine(rectangle.CalculateArea());
        Circle circle = new Circle();
        Console.WriteLine
            (circle.CalculateArea(5));
        Student student = new Student("John Doe", 20, "Computer Science");
        student.Introduce();
        Stack<int> intStack = new Stack<int>();
        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);
        PrintStack(intStack);
        int poppedItem = intStack.Pop();
        Console.WriteLine($"Popped item: {poppedItem}");
        PrintStack(intStack);
        int topItem = intStack.Peek();
        Console.WriteLine($"Top item: {topItem}");
        PrintStack(intStack);
        Calendar calendar = new Calendar();
        calendar.PrintWeekdays();
        Point2D pointA = new Point2D { X = 1.0f, Y = 1.0f };
        Point2D pointB = new Point2D { X = 4.0f, Y = 6.0f };
        float distance = DistanceCalculator.CalculateDistance(pointA, pointB);
        Console.WriteLine($"Distance between points A and B: {distance}");}
    static void PrintStack(Stack<int> stack)
    {
        Console.Write("Stack: ");
        Console.WriteLine(stack.IsEmpty() ? "Empty" : string.Join(" ", stack));
    }
}
