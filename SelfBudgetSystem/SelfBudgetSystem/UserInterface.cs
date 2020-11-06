using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfBudgetSystem
{
    class UserInterface
    {
        private AnalyticService analytic;
        private CreationAndGroupingFactory factory;
        private User user;
        private UserRepository userRepository;

        public UserInterface()
        {
            this.analytic = new AnalyticService();
            this.factory = new CreationAndGroupingFactory();
            this.userRepository = new UserRepository();
        }

        private void SignIn()
        {
            string login;
            string password;

            Console.Write("Введите логин: ");
            login = Console.ReadLine();
            Console.Write("Введите пароль: ");
            password = Console.ReadLine();

            User u = userRepository.GetUser(login);
            if (u == null)
            {
                throw new Exception("Такого пользователя не существует");
            }
            if (u.password != password)
            {
                throw new Exception("Вы ввели неправильный логин/пароль");
            }

            user = u;
        }
        private void SignUp()
        {
            string name;
            string login;
            string password;

            Console.Write("Введите Ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Введите логин: ");
            login = Console.ReadLine();
            Console.Write("Введите пароль: ");
            password = Console.ReadLine();

            user = userRepository.AddUser(new User(name, login, password));
        }

        private void Help()
        {
            Console.WriteLine("Список доступных комманд:");
            Console.WriteLine("income - внести доходы");
            Console.WriteLine("consume - внести расходы");
            Console.WriteLine("analytic - показать аналитику");
            Console.WriteLine("exit - завершить работу");
        }

        public void Run()
        {
            string input = "";
            do
            {
                Console.WriteLine("Введите \"signIn\" чтобы войти или \"signUp\" чтобы зарегистрироваться");
                input = Console.ReadLine();
            } while (!(input.Equals("signIn") ^ input.Equals("signUp")));
                
            if (input.Equals("signIn"))
            {
                SignIn();
            }
            else
            {
                SignUp();
            }

            Console.WriteLine();
            Console.WriteLine("Здравствуйте, {0}.", user.name);
            Console.WriteLine();
            Help();
            
            while (true)
            {
                Console.WriteLine();
                Console.Write("Введите команду: ");
                input = Console.ReadLine();

                if (input.Equals("income"))
                {
                    Console.WriteLine();
                    Console.Write("Введите количество дохода: ");
                    double amount = double.Parse(Console.ReadLine());

                    Console.Write("Введите дату получения дохода в формате ДД/ММ/ГГГГ: "); //на данном этапе пользователю разрешено вводить любые даты, в том числе будущие
                    DateTime userDateTime;
                    DateTime.TryParse(Console.ReadLine(), out userDateTime);

                    Console.Write("Выберите категорию для дохода: \"Зарплата\", \"Премия\", \"Проценты по вкладу\" \nИли введите свою: ");
                    string category = Console.ReadLine();

                    factory.AcceptIncome(amount, userDateTime, category);
                }
                else if (input.Equals("consume"))
                {
                    Console.WriteLine();
                    Console.Write("Введите количество расхода: ");
                    double amount = double.Parse(Console.ReadLine());

                    Console.Write("Введите дату совершения расхода в формате ДД/ММ/ГГГГ: "); //на данном этапе пользователю разрешено вводить любые даты, в том числе будущие
                    DateTime userDateTime;
                    DateTime.TryParse(Console.ReadLine(), out userDateTime);

                    Console.Write("Выберите категорию для расхода: \"Продукты\", \"Транспорт\", \"Коммунальные платежи\" \nИли введите свою: ");
                    string category = Console.ReadLine();

                    factory.AcceptConsumtion(amount, userDateTime, category);
                }
                else if (input.Equals("analytic")) 
                {
                    Console.WriteLine();
                    Console.WriteLine(analytic.GetAnalytic());
                }
                else if (input.Equals("exit"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Help();
                }
            }
        }
    }
}
