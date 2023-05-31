using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Task2
{
    /*
     Використовуючи Visual Studio, створіть проєкт за шаблоном Console Application. 
     Потрібно: 
     Інсталюйте необхідні пакети для роботи з Entity Framework 
     Створіть контекст бази даних MyDatabaseContext та, 
     використовуючи матеріали завдання 1 (цього уроку), перенесіть ваш список у якості колекції DbSet, 
     виконайте міграцію 
     Заповніть таким самим способом, що і в першому завдані, через контекст MyDatabaseContext вашу колекцію тими самими значеннями. 
     Переконайтесь, що дані збереглись у базу. 
     Знайти та вивести > 1, 5, 0, 7 з Product/User/Order (ваш варінт) контексту за ім’ям
     */
    internal class Program
    {
        // Scaffold-DbContext 'Server=localhost\SQLEXPRESS;Database=Userbase;Trusted_Connection=True;' Microsoft.EntityFrameworkCore.SqlServer
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Создание экземпляра контекста базы данных
            //using (var database = new MyDatabaseContext())
            //{
            //    // Очистка таблицы Users
            //    database.Users.RemoveRange(context.Users);
            //    // Добавление пользователей из DatabaseMoq
            //    database.Users.AddRange(DatabaseMoq.Users);
            //    // Сохранение изменений в базе данных
            //    database.SaveChanges();
            //}

            using (var database = new MyDatabaseContext())
            {
                string[] namesToFind = { "User1", "User5", "User0", "User7" };

                foreach (var name in namesToFind)
                {
                    int index = await GetUserIndexByNameAsync(database, name);
                    if (index != -1)
                    {
                        Console.WriteLine($"Індекс користувача з іменем: {name}: {index}");
                    }
                    else
                    {
                        Console.WriteLine($"Користувач з іменем {name} не знайдено.");
                    }
                }
                await database.SaveChangesAsync();
            }
            Console.ReadLine();
        }
        static async Task<int> GetUserIndexByNameAsync(MyDatabaseContext context, string name)
        {
            var users = await context.Users.ToListAsync();
            return users.FindIndex(user => user.Name == name);
        }
    }
}