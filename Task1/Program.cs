using System.Text;

namespace Task1

/*
 Завдання 1
 Розробіть консольну програму з використанням  списку з типом (List< User >).

  2. Користувач – User
  1) + Id: Guid
  2) + Name: string
  3) + LastName: string
  4) + Login: string
  5) + Password: string
  6) + Email: string

  Заповніть ваш список значеннями (10 значень).
  Виведіть на екран значення за індексом > 1, 5, 0, 7
  Знайдіть та виведіть індекси > 1, 5 за властивістю Id
  Знайдіть та виведіть індекси > 0, 7 за властивістю Name
 */
{
    internal class Program
    {
        static void ShowMenu()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Out.WriteLine(@"
Chose menu
1 -  Виведіть на екран значення за індексом > 1, 5, 0, 7
2  - Знайдіть та виведіть індекси > 1, 5 за властивістю Id
3 -  Знайдіть та виведіть індекси > 0, 7 за властивістю Name
4 -  Delete
5 -  ShowAll
0 -  End");
        }
        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if (result == 0)
                    { break; }
                    else if (result == 1) { FirstQuestion(); }
                    else if (result == 2) { SecondQuestion(); }
                    else if (result == 3) { ThirdQuestion(); }
                    else if (result == 4) { DeleteUsers(); }
                    else if (result == 5) { ShowAllUsers(); }
                }
            }
        }
        static void FirstQuestion()
        {
            var users = DatabaseMoq.Users;
            int indexToFind1 = 1;
            int indexToFind2 = 5;
            int indexToFind3 = 0;
            int indexToFind4 = 7;

            Console.WriteLine("Значення за індексом");
            Console.WriteLine($"{indexToFind1}:  " + users[indexToFind1]);
            Console.WriteLine($"{indexToFind2}:  " + users[indexToFind2]);
            Console.WriteLine($"{indexToFind3}:  " + users[indexToFind3]);
            Console.WriteLine($"{indexToFind4}:  " + users[indexToFind4]);
        }

        static void SecondQuestion()
        {
            var users = DatabaseMoq.Users;
            Guid idToFind1 = users[1].Id;
            Guid idToFind2 = users[5].Id;
            int index1 = users.FindIndex(u => u.Id == idToFind1);
            int index2 = users.FindIndex(u => u.Id == idToFind2);
            Console.WriteLine($"Індекси за властивістю Id: {idToFind1}: {index1}");
            Console.WriteLine($"Індекси за властивістю Id: {idToFind2}: {index2}");
        }

        static void ThirdQuestion()
        {
            var users = DatabaseMoq.Users;
            string nameToFind1 = users[0].Name;
            string nameToFind2 = users[7].Name;
            int index1 = users.FindIndex(u => u.Name == nameToFind1);
            int index2 = users.FindIndex(u => u.Name == nameToFind2);
            Console.WriteLine($"Індекси за властивістю Name: {nameToFind1}: {index1}");
            Console.WriteLine($"Індекси за властивістю Name: {nameToFind2}: {index2}");
        }
        static void DeleteUsers()
        {
            Console.WriteLine("Enter number for delete");
            if (int.TryParse(Console.ReadLine(), out int numDelete))
            {
                DatabaseMoq.Users.RemoveAt(numDelete);
            }


        }
        static void ShowAllUsers()
        {
            var users = DatabaseMoq.Users;
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine(i + ") (" + users[i].Id + ") " + users[i]);
            }
        }

    }
}