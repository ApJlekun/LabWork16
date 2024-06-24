using System;
using System.Reflection.Metadata;
using Task1;

class Program
{
    static void Main()
    {
        Пользователь user = new Пользователь();
        user.PropertyChanged += (sender, e) =>
        {
            Console.WriteLine($"Изменено свойство: {e.PropertyName}");
        };

        user.Login = "new_login";
        user.Password = "new_password";
    }
}