using System;
class MainClass
 {
        public static void Main(string[] args)
        {
        Console.Write("Введите имя:");
        var name = Console.ReadLine();

        Console.Write("Введите возраст:");
        var age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя {0} и Ваш возраст {1}", name, age);

        Console.Write("Ваш день рожденья:");
        var birthdate = Console.ReadLine();
        Console.WriteLine("Ваш день рожденья " + birthdate);

        Console.ReadKey();
        }
}