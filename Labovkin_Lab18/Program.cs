using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labovkin_Lab18
{
    class Program
    {
        // проверка строки на корректность открытых и закрытых скобок
        public static bool check(string str)
        {
            Stack<char> stack = new Stack<char>();
            // обход каждого символа строки
            foreach (var item in str)
            {
                // текущий символ скобка
                switch (item)
                {
                    // одна из открытых скобок
                    case '{':
                    case '(':
                    case '[':
                        stack.Push(item);
                        break;
                    // обработка трех видов закрытых скобок
                    case '}':
                        //если стек пустой или извлек.эл-т не равен обратной скобке
                        if (stack.Count == 0 || stack.Pop() != '{')
                            return false;
                        break;
                    case ']':
                        //если стек пустой или извлек.эл-т не равен обратной скобке
                        if (stack.Count == 0 || stack.Pop() != '[')
                            return false;
                        break;
                    case ')':
                        //если стек пустой или извлек.эл-т не равен обратной скобке
                        if (stack.Count == 0 || stack.Pop() != '(')
                            return false;
                        break;
                }
            }
            // вернет true / false взависимости от валидности строки
            return stack.Count == 0;
        }

        static void Main(string[] args)
        {
            // объявление строки со скобками
            string str = "([y2+x1]{x^2})[y1+x2]";
            Console.Write(str + " is ");
            // вывод результата проверки корректности
            Console.WriteLine(check(str));
            // объявление строки со скобками
            str = "(y2+x1])";
            Console.Write(str + " is ");
            // вывод результата проверки корректности
            Console.WriteLine(check(str));

            Console.ReadKey();
        }
    }
}
