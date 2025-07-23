class ZomatoPartner : DeliveryPlatform, IPaymentGateway
{
    public override void DeliveryOrder()
    {
        Console.WriteLine("Delivered in 20 mins");
    }

    public void ProcessPayment()
    {
        Console.WriteLine("Payment Started.......In Process");
    }
}