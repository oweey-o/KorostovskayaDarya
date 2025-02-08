namespace App;

public static class Prices
{
    public static string GetCurrencyAlias(int price, bool isShorNotation, bool isFirstCapital)
    {
        var n = price % 10;
        if (!isShorNotation)
        {
            switch (n)
            {
                case 0:
                case 5:
                case 6: 
                case 7:
                case 8:
                case 9:
                    Console.WriteLine($"{price} рублей");
                    break;
                case 1:
                    Console.WriteLine($"{price} рубль");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine($"{price} рубля");
                    break;
            }
            for (int i = 11; i < 20; i++)
            {
                if (price % 100 == i)
                {
                    Console.WriteLine($"{price} рублей");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine($"{price} руб.");
        }
    }
}
