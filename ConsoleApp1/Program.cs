using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace TextAnalyzer
    {
        internal class Program
        {    
            static Dictionary<string, string> positiveWords = new Dictionary<string, string>
        {
            {"хороший", "+"}, {"отличный", "+"}, {"супер", "+"},{"спасибо", "+"},{"радость", "+"}, {"счастье", "+"},
        };
            static Dictionary<string, string> negativeWords = new Dictionary<string, string>
        {
            {"плохой", "-"}, {"ужасный", "-"}, {"грустный", "-"}, {"злой", "-"},{"проблема", "-"}, {"ошибка", "-"},         
        };
            static void Main(string[] args)
            {              
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("ТЕКСТОВЫЙ АНАЛИЗАТОР\n");
                    Console.WriteLine("1 - Анализ одного текста");
                    Console.WriteLine("2 - Анализ нескольких текстов");                
                    Console.WriteLine("3 - Выход");
                    Console.Write("\nВыберите действие: ");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            AnalyzeSingleText();
                            break;
                        case "2":
                            AnalyzeMultipleTexts();
                            break;
                        case "3":
                            Console.WriteLine("\nДо свидания!");
                            break;
                        default:
                            Console.WriteLine("\nОшибка! Выберите 1-3");
                            Console.ReadKey();
                            break;
                    }
                }
            }
            static void AnalyzeSingleText()
            {
                Console.Clear();
                Console.WriteLine("АНАЛИЗ ТЕКСТА\n");
                Console.Write("Введите текст: ");
                string text = Console.ReadLine();
                AnalyzeAndSave(text);               
                Console.ReadKey();
            }
            static void AnalyzeMultipleTexts()
            {
                Console.Clear();
                Console.WriteLine("Анализ НЕСКОЛЬКИХ текстов\n");
                Console.Write("Сколько текстов анализировать? ");
                if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
                {
                    Console.WriteLine("Ошибка! Введите число больше 0");
                    Console.ReadKey();
                    return;
                }
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"Текст {i + 1}");
                    Console.Write("Введите текст: ");
                    string text = Console.ReadLine();
                    AnalyzeAndSave(text);
                }
                Console.WriteLine("Анализ завершен!");
                Console.ReadKey();
            }
            static void AnalyzeAndSave(string text)
            {             
                string[] words = text.ToLower().Split(new char[] { ' ', '.', ',', '!', '?'},
                    StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, int> uniqueWords = new Dictionary<string, int>();
                foreach (string word in words)
                {
                    if (uniqueWords.ContainsKey(word))
                        uniqueWords[word]++;
                    else
                        uniqueWords[word] = 1;
                }
                int positive = 0;
                int negative = 0;
                foreach (string word in words)
                {
                    if (positiveWords.ContainsKey(word)) 
                        positive++;
                    if (negativeWords.ContainsKey(word)) 
                        negative++;
                }
                string tone = "Нейтральный";
                if (positive > negative) 
                    tone = "Позитивный";
                else if (negative > positive) 
                    tone = "Негативный";
                Console.WriteLine("\n РЕЗУЛЬТАТЫ ");
                Console.WriteLine($"Всего слов: {words.Length}");
                Console.WriteLine($"Уникальных слов: {uniqueWords.Count}");
                Console.WriteLine($"Позитивных слов: {positive}");
                Console.WriteLine($"Негативных слов: {negative}");
                Console.WriteLine($"Тональность: {tone}");
            }                            
        }
    }  
}
