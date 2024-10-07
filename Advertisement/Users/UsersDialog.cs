using Advertisement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement.Users;

internal class UsersDialog
{
    /// <summary>
    ///  Provides dialog with user
    /// </summary>
    public static void Dialog()
    {
        Console.WriteLine("Назовите свое имя или логин:");
        UsersOperations usersOperation = new UsersOperations();
        User user = usersOperation.FindUser(Console.ReadLine());
        if (user == null)
        {
            (string Name, string Login, bool IsPremium) registrationData;
            Console.WriteLine("Пользователь с такими данными отсутствует. Необходимо зарегистрироваться");
            Console.WriteLine("Введите имя: "); registrationData.Name = Console.ReadLine();
            Console.WriteLine("Введите логин: "); registrationData.Login = Console.ReadLine();
            registrationData.IsPremium = false;
            usersOperation.RegistrateUser(registrationData);
            AdvertisementOffer.ShowAds();
        }
        else
        {
            Console.WriteLine($"Приветствуем вас, {user.Name}");
            if (!user.IsPremium)
            {
                AdvertisementOffer.ShowAds();
            }
            else
            {
                Console.WriteLine("Благодарим вас за использование премиум-подписки");
            }
        }
    }
}
