using System.Runtime.CompilerServices;

List<string> list = [];
while (true)
{
    Console.WriteLine(@"
[A] = Add

[R] = Remove

[S]  = Show

[E] = Exit
");

    string input = Console.ReadLine();
    switch (input)
    {
        case "A":
        case "a":
            addToDo();
            break;

        case "R":
        case "r":
            removeToDo();
            break;

        case "S":
        case "s":
            showToDo();
            break;

        case "E":
        case "e":
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Invalid Input");
            break;
    }

}
void addToDo()
{
    Console.WriteLine("Enter Your Task");
    string add = Console.ReadLine();
    if (add.Length > 0)
    {
        list.Add(add);
    }
    else 
    { 
       Console.WriteLine("Invalid Input");
        addToDo();
    }
}

void showToDo()
{
    foreach(string i in list)
    {
        Console.WriteLine($"Value: {i}");
    }
}
void removeToDo()
{
    Console.WriteLine("Enter string to remove");
    string remove = Console.ReadLine();
    list.Remove(remove);
}