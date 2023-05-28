Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Привет Машенька");
}
else
{
    Console.Write("Ну привет ");
    Console.WriteLine(username);
}

    