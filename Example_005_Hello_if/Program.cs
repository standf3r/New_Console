Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "max")
{
    Console.Write("Привет хозяин");
}
else 
{
    Console.Write("Привет, ");
    Console.Write(username);
}

