using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
            static void Main(string[] args)
            {
                string password;
                bool IsTrue;
                do
                {
                    Console.WriteLine("Ввидите пароль для проверки");
                    password = Console.ReadLine();
                    IsTrue = IsValidPassword(password);
                    CheckPassword(password);
                } while (!IsTrue);
                Console.WriteLine("Пароль  подходит!");  
            }
            static bool CheckLength(string password)
            {
                return password.Length >= 8;
            }
            static bool CheckDigits(string password)
            {
                foreach (char c in password)
                {
                    if (char.IsDigit(c))
                        return true;
                }
                return false;
            }

            static bool CheckUppercase(string password)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                        return true;
                }
                return false;
            }
            static bool IsValidPassword(string password)
            {
                return CheckLength(password) && CheckDigits(password) && CheckUppercase(password);
            }

            static void CheckPassword(string password)
            {
                bool length0k = CheckLength(password);
                bool digits0k = CheckDigits(password);
                bool uppercase0k = CheckUppercase(password);
                bool valid = IsValidPassword(password);

                Console.WriteLine("Отчет по проверке пароля:");
                Console.WriteLine($"1. Длина не менее 8 символов:{(length0k ? "выполнено" : "не выполнено")}");
                Console.WriteLine($"2. Наличие хотя бы одной цифры:{(digits0k ? "выполнено" : "не выполнено")}");
                Console.WriteLine($"3. Наличие хотя бы одной заглавной буквы:{(uppercase0k ? "выполнено" : "не выполнено")}");
                Console.WriteLine($"4. Можно ли использовать этот пароль:{(valid ? "да" : "нет")}");
            }
        }
    }
