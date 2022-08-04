Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "виола")
{
    Console.WriteLine("Ура, это же Виола!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
