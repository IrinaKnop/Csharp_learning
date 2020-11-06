using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfBudgetSystem
{
    //На данном этапе class UserRepository заменяет БД пользователей без реализации хранения данных
    class UserRepository
    {
        private Dictionary<string, User> users;
        public UserRepository()
        {
            users = new Dictionary<string, User>();
            User user = new User("Ваня", "ivan", "123456");
            users[user.login] = user;
        }
        public User AddUser(User user)
        {
            users[user.login] = user;
            return user;
        }
        public User GetUser(string login)
        {
            User user;
            users.TryGetValue(login, out user);
            return user;
        }
    }
}
