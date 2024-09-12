class Program
{
    
    static void Main(string[] args)
    {
        int[] prices = { 7, 1, 5, 3, 6, 4 };
        int maxProfit = MaxProfit(prices);
        Console.WriteLine($"Maximum profit: {maxProfit}");
    }

    static int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int minPrice = int.MaxValue;

        foreach (int price in prices)
        {
            minPrice = Math.Min(minPrice, price);
            maxProfit = Math.Max(maxProfit, price - minPrice);
        }

        return maxProfit;
    }
}