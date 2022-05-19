namespace fptedu.se1622;
class Customer
{
    public int Id { get; set; }
    public int Name { get; init; }
    public Customer(int id, int name)
    {
        Id = id;
        Name = name;
    }
    public Customer()
    {
        Id=10;
        Name = 20;
    }
}
class Program
{
    static void Main()
    {
        Customer customer = new Customer {Id = 1, Name = 20 };
      
        Console.WriteLine($"{customer.Id}, {customer.Name}");
        Customer customer2 = new Customer();
        Console.WriteLine($"{customer2.Id}, {customer2.Name}");
        Customer customer3 = new Customer(30, 50);
        Console.WriteLine($"{customer3.Id}, {customer3.Name}");
        Console.ReadLine();
    }
}