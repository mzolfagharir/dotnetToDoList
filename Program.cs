List<string> list = new List<string>();
bool taskInput  = false;

while (taskInput = true)
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
            Console.WriteLine("Exit!");
            break;

        default:
            Console.WriteLine("Invalid Input");
            taskInput = false;
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
        Console.WriteLine(i + " " + i.IndexOf(i));
    }
}
Console.ReadLine();

void removeToDo()
{
    Console.WriteLine("Enter string to remove");
    string remove = Console.ReadLine();
    list.Remove(remove);
}