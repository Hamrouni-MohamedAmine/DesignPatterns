namespace Strategy
{
    /// <summary>
    /// Context
    /// </summary>
    public class Order
    {
        public string Customer { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public Order(string customer, int amount, string name)
        {
            Customer = customer;
            Amount = amount;
            Name = name;
        }

        public void Export(IExportservice? exportService)
        {
            if(exportService is null)
            {
                throw new ArgumentNullException();
            }
           
            exportService?.Export(this);
        }
    }

    /// <summary>
    /// Strategy
    /// </summary>
    public interface IExportservice
    {
        void Export(Order order);
    }

    /// <summary>
    /// ConcreteStrategy
    /// </summary>
    public class JsonExportService : IExportservice
    {
        public void Export(Order order)
        {
            Console.WriteLine($"Exporting  {order.Name} to Json");
        }
    }

    /// <summary>
    /// ConcreteStrategy
    /// </summary>
    public class XMLExportService : IExportservice
    {
        public void Export(Order order)
        {
            Console.WriteLine($"Exporting  {order.Name} to XML");
        }
    }

    /// <summary>
    /// ConcreteStrategy
    /// </summary>
    public class CSVExportService : IExportservice
    {
        public void Export(Order order)
        {
            Console.WriteLine($"Exporting  {order.Name} to CSV");
        }
    }
}
