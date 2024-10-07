using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement.Users;

internal class UsersData
{
    public List<User> Users = new List<User>
    {
        new User {Login = "1", Name = "Михаил", IsPremium = true},
        new User {Login = "2", Name = "Иван", IsPremium = false},
        new User {Login = "3", Name = "Степан", IsPremium = false}
    }; 
}
