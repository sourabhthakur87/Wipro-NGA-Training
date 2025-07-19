class CampusCouponTracker
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number of coupons: ");
        int coupons = Convert.ToInt32(Console.ReadLine());
        if (coupons > 100)
        {
            Console.WriteLine("At most 100 coupons are issued per day.");
        }
        else
        {


            int[] couponsValue = new int[coupons];

            Console.WriteLine("Enter The Coupons value: ");
            for (int i = 0; i < coupons; i++)
            {
                couponsValue[i] = Convert.ToInt32(Console.ReadLine());
            }
            int TotalValue = 0;
            int maxValue = 0, couponNumber = 0;
            int small = 0, medium = 0, large = 0;

            for (int i = 0; i < coupons; i++)
            {

                TotalValue = TotalValue + couponsValue[i];
                if (couponsValue[i] > maxValue)
                {
                    maxValue = couponsValue[i];
                    couponNumber = i;
                }
                // Console.Write(couponsValue[i] + "  ");

                if (couponsValue[i] <= 50)
                {
                    small++;
                }
                else if (couponsValue[i] >= 51 && couponsValue[i] <= 100)
                {
                    medium++;
                }
                else
                {
                    large++;
                }
            }
            Console.WriteLine($"Total coupons redeemed : {coupons}");
            Console.WriteLine($"Total value collected : {TotalValue}");
            Console.WriteLine($"Highest coupon redeemed : {maxValue} (coupon #{couponNumber + 1})");


            Console.WriteLine();
            Console.WriteLine("Category BreakDown");
            Console.WriteLine($"Small   (<=50)  :     {small}");
            Console.WriteLine($"Medium  (51-100):     {medium}");
            Console.WriteLine($"Large   (>100)  :     {large}");



        }


    }
}
