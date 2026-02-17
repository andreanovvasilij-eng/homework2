using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static int coffee = 10;
        static int milk = 5;
        static int sugar = 15;
        static bool CheckerResourses(int coffeeNeeded, int milkNeeded, int sugarNeeded)
        {
            if (coffee >= coffeeNeeded && milk >= milkNeeded && sugar >= sugarNeeded)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Недостаточно ингредиентов!");
                return false;
            }
        }
        static void MakeEcspresso()
        {
            if (CheckerResourses(1, 0, 0))
            {
                coffee -= 1;
                Console.WriteLine("Экспрессо готов");
            }
            else
            {
                Console.WriteLine("Не хватает ингридеентов (кофе отсутсвует)");
            }
        }
        static void MakeLatte()
        {
            if (CheckerResourses(1, 2, 0))
            {
                coffee -= 1;
                milk -= 2;
                Console.WriteLine("Латте приготовленно");
            }
            else
            {
                Console.WriteLine("Не хватает ингридеентов (кофе отсутсвует,молоко отстутсвует)");
            }
        }
        static void MakeCapuchino()
        {
            if (CheckerResourses(1, 1, 0))
            {
                coffee -= 1;
                milk -= 1;
                Console.WriteLine("Капучино приготовленно");
            }
            else
            {
                Console.WriteLine("Не хватает ингридеентов (кофе отсутсвует,молоко отстутсвует)");
            }
        }
        static void addSugar()
        {
            if (sugar > 0)
            {
                sugar -= 1;
                Console.WriteLine("Сахар добавлен");
            }
            else
            {
                Console.WriteLine("Не хватает ингридеентов (сахар отсутсвует)");
            }
        }
        static void ShowResourses()
        {
            Console.WriteLine($"Остатки кофе {coffee}, остатки молока {milk}, остатки сахара {sugar}");
        }
        static void fuel()
        {
            Console.WriteLine("Выбирите какой ингредиент вы хотите пополнить");
            Console.WriteLine("1 - кофе, 2 - молоко, 3 - сахар");
            int resourse = Convert.ToInt32(Console.ReadLine());
            switch (resourse)
            {
                case 1:
                    Console.WriteLine("Введите количество кофе");
                    int coffePlus = Convert.ToInt32(Console.ReadLine());
                    coffee = coffee + coffePlus;
                    break;
                case 2:
                    Console.WriteLine("Введите количество молока");
                    int milkPlus = Convert.ToInt32(Console.ReadLine());
                    milk = milk + milkPlus;
                    break;
                case 3:
                    Console.WriteLine("Введите количество сахара");
                    int sugarPlus = Convert.ToInt32(Console.ReadLine());
                    sugar = coffee + sugarPlus;
                    break;
            }
            Console.WriteLine("Вы заправили кофе машину!");
        }       
        static void Main(string[] args)
        {                   
                int choice;
                do
                {
                    Console.WriteLine("Меню кофемашины:");
                    Console.WriteLine("1 - Эспрессо");
                    Console.WriteLine("2 - Латте");
                    Console.WriteLine("3 - Капучино");
                    Console.WriteLine("4 - Добавить сахар");
                    Console.WriteLine("5 - Показать остатки");
                    Console.WriteLine("6 - Заправить кофемашину");
                    Console.WriteLine("7 - Выход");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: MakeEcspresso(); break;
                        case 2: MakeLatte(); break;
                        case 3: MakeCapuchino(); break;
                        case 4: addSugar(); break;
                        case 5: ShowResourses(); break;
                        case 6: fuel(); 
                        break;
                        case 7: Console.WriteLine("До свидания!"); break;
                        default: Console.WriteLine("Неверный выбор. Попробуйте ещё раз."); break;
                    }
                } while (choice != 7);
        }
    }
}

