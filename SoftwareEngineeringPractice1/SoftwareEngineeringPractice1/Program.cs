

string? age = "";

while (true)
{
    Console.WriteLine("How old are you?");
    age = Console.ReadLine();
    if (int.TryParse(age, out int age2))
    {
        Console.WriteLine("You are " + age2 + " years old!");
        break;
    } else
    {
        Console.WriteLine("Invalide input... try again!\nPress any button to continue...");
        Console.ReadKey();
        Console.Clear();
    }
}

