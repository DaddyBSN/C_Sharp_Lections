﻿Console.Write("Введи имя пользователя: ");
string username = Console.ReadLine() ?? "0";

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это Маша!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
