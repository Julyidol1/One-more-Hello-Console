Console.Write("Введите Ваше имя ");

string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
Console.WriteLine("Ура! Маша тут");
}
else
{
Console.WriteLine("Привет, ");
Console.WriteLine(username);
}