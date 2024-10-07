using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement.Users;

internal class UsersOperations
{
    UsersData usersData = new UsersData();
    
    /// <summary>
    /// Finds user by name or login
    /// </summary>
    /// <param name="usersInfo"></param>
    /// <returns></returns>
    public User FindUser(string usersInfo)
    {
        User user = usersData.Users.Find(element => (element.Name == usersInfo ||
                                                     element.Login == usersInfo));
        return user;
    }

    /// <summary>
    /// Registrates new user
    /// </summary>
    /// <param name="registrationData"></param>
    public void RegistrateUser((string name, string login, bool premium) registrationData)
    {
        User user = new User();
        {
            user.Name = registrationData.name;
            user.Login = registrationData.login;
            user.IsPremium = registrationData.premium;
        };
        usersData.Users.Add(user);
        Console.WriteLine($"Приветствуем вас, {user.Name}");
    }
}
