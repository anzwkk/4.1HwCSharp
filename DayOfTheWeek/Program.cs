internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введіть номер дня тижня (1-7): ");
        int weekNum = int.Parse(Console.ReadLine());

        switch (weekNum)
        {
            case 1:
                Console.WriteLine("День неділі - Понеділок");
                break;
            case 2:
                Console.WriteLine("День неділі - Вівторок");
                break;
            case 3:
                Console.WriteLine("День неділі - Середа");
                break;
            case 4:
                Console.WriteLine("День неділі - Четверг");
                break;
            case 5:
                Console.WriteLine("День неділі - П'ятниця");
                break;
            case 6:
                Console.WriteLine("День неділі - Субота");
                break;
            case 7:
                Console.WriteLine("День неділі - Неділя");
                break;

        }

    }
}