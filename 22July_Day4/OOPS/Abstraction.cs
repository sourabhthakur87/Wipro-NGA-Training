public abstract class DeliveryPlatform
{

    
    public string PartherName { get; set; }

    public void TrackOrder()
    {
        Console.WriteLine("Order is being Tracked: " + PartherName);
    }

    public abstract void DeliveryOrder();
}