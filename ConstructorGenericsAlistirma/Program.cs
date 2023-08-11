namespace ConstructorGenericsAlistirma
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Customer customer = new Customer { Id=1, FirstName = "Ömer", LastName= "Atik", City = "Bursa"}; //{} parametre değildir.

            Customer customer3 = new Customer(); //Yukarıdaki yazım şekli ile aynıdır.
            customer3.Id = 3;
            
            
            
            
            Customer customer2 = new Customer ( 2, "Ahmet", "Atik", "Bursa"  );

            
            
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer2.LastName);
        }

	}
	class Customer
	{
        public Customer()
        {
                
        }

        public Customer(int id, string fistName, string lastName, string city)
        {
            Id = id;
            FirstName = fistName;
            LastName = lastName;
            City = city;
        }


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string City  { get; set; }
    }
}