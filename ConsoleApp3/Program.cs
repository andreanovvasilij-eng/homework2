using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                СПОСОБЫ ОБЪЯВЛЕНИЯ 
            //С использованием инициализатора коллекции
            Dictionary<string, int> dict1 = new Dictionary<string, int>
                {
                  {"яблоко", 50},
                  {"банан", 30},
                  {"апельсин", 40}
                };

            //Постепенное добавление элементов
            Dictionary<string, int> dict2 = new Dictionary<string, int>();
            dict2.Add("яблоко", 50);
            dict2["банан"] = 30;

            //Указание начальной емкости
            Dictionary<string, int> dict3 = new Dictionary<string, int>(10);
            
            // Пустой словарь
            Dictionary<string, int> emptyDict = new Dictionary<string, int>();
   
                // ПРИМЕР КОДА
                Dictionary<string, int> prices = new Dictionary<string, int>
        {
            {"Яблоки", 100},
            {"Бананы", 80},
            {"Апельсины", 120}
        };
                Console.WriteLine($"Count: В словаре {prices.Count} элемента");
                Console.WriteLine("Keys: Все ключи словаря:");
                foreach (var key in prices.Keys)
                {
                    Console.WriteLine($"   - {key}");
                }
                Console.WriteLine();
                Console.WriteLine("Values: Все значения словаря:");
                foreach (var value in prices.Values)
                {
                    Console.WriteLine($"   - {value} руб.");
                }
                Console.WriteLine();
                Console.WriteLine("ContainsKey: Проверка наличия ключей:");
                Console.WriteLine($"Яблоки существует: {prices.ContainsKey("Яблоки")}");
                Console.WriteLine($"Виноград существует: {prices.ContainsKey("Виноград")}");
                Console.WriteLine();

                Console.WriteLine("ContainsValue: Проверка наличия значений:");
                Console.WriteLine($"Значение 100 существует: {prices.ContainsValue(100)}");
                Console.WriteLine($"Значение 200 существует: {prices.ContainsValue(200)}");
                Console.WriteLine("TryGetValue: Безопасное получение значений:");
                Console.WriteLine();
                if (prices.TryGetValue("Бананы", out int bananaPrice))
                {
                    Console.WriteLine($"Бананы стоят: {bananaPrice} руб.");
                }

                if (!prices.TryGetValue("Манго", out int mangoPrice))
                {
                    Console.WriteLine($"Манго не найдено в словаре");
                }
                Console.WriteLine();

                Console.WriteLine("Remove: Удаление элементов:");
                bool removed = prices.Remove("Апельсины");
                Console.WriteLine($"Удаление 'Апельсины': {removed}");
                removed = prices.Remove("Киви");              
                Console.WriteLine($"Новая цена яблок: {prices["Яблоки"]} руб.");
                Console.WriteLine("Итоговое состояние словаря:");
                Console.WriteLine($"Всего элементов: {prices.Count}");

                Console.WriteLine("Содержимое:");
                foreach (var item in prices)
                {
                    Console.WriteLine($"   {item.Key}: {item.Value} руб.");
                }        

        }
    }
}
