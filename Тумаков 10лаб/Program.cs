using System;
using Тумаков_10лаб.Classes;
using Тумаков_10лаб.Exercise_2;

namespace Тумаков_10лаб
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Упр 10.1 - Декодирование и кодирование сообщений
            Console.WriteLine("Упр 10.1 - Декодирование и кодирование сообщений\n");
            string message = "Hello, world!";

            ICipher aCipher = new ACipher();
            string encodedMessageA = aCipher.Encode(message);
            string decodedMessageA = aCipher.Decode(encodedMessageA);

            ICipher bCipher = new BCipher();
            string encodedMessageB = bCipher.Encode(message);
            string decodedMessageB = bCipher.Decode(encodedMessageB);

            Console.WriteLine("Оригинал: " + message);
            Console.WriteLine("Закодированное сообщение (ACipher): " + encodedMessageA);
            Console.WriteLine("Декодированное сообщение (ACipher): " + decodedMessageA);
            Console.WriteLine("Закодированное сообщение (BCipher): " + encodedMessageB);

            // Упр 10.2 - Геометрические фигуры - их цвет,состояние.Потомки - точка,прямоугольник,окружность.
            Console.WriteLine("\nУпр 10.2 - Геометрические фигуры - их цвет,состояние.Потомки - точка,прямоугольник,окружность.\n");
            Circle circle = new Circle("Красный", true, 5);
            circle.Display();
            Console.WriteLine("Площадь: " + circle.CalculateArea());

            Rectangle rectangle = new Rectangle("Синий", false, 3, 4);
            rectangle.Display();
            Console.WriteLine("Площадь: " + rectangle.CalculateArea());
        }
    }
}
