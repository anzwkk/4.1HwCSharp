internal class Program
{
    private static void Main(string[] args)
    {
        do
        {
                Console.WriteLine("Введіть номер дня тижня (1-7): ");
                string input = Console.ReadLine();
                int weekNum;
                int.TryParse(input, out weekNum);

                switch (weekNum)
                {
                    case 1:
                        Console.WriteLine("День тижня - Понеділок");
                        break;
                    case 2:
                        Console.WriteLine("День тижня - Вівторок");
                        break;
                    case 3:
                        Console.WriteLine("День тижня - Середа");
                        break;
                    case 4:
                        Console.WriteLine("День тижня - Четверг");
                        break;
                    case 5:
                        Console.WriteLine("День тижня - П'ятниця");
                        break;
                    case 6:
                        Console.WriteLine("День тижня - Субота");
                        break;
                    case 7:
                        Console.WriteLine("День тижня - Неділя");
                        break;
                    default:
                        Console.WriteLine("Некоректне число. Введіть від 1-7");
                        break;

                }
            
        } while (true);
                
    }
}