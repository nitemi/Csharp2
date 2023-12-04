using Csharp;
public class Program
{
    //Icollection
    //dictionary
    //list, stack, queue and set
    private static void Main(string[] args)
    {
        
        Party party1 = new Party()
        {
          Id = 1,
         Price = 100000,
         Name = "Birthday Celebration",
         Description = "Ade's birthday celebration"
            
        };
        Party party2 = new Party()
        {
            Id = 2,
            Price = 200000,
            Name = "Naming Ceremony",
            Description = "Mr & Mrs Adeyi naming celebration"

        };
        Party party3 = new Party()
        {
            Id = 3,
            Price = 450000,
            Name = "Corporate Event ",
            Description = "Walure Mananagement Event"
        };
        Party party4 = new Party()
        {
            Id = 4,
            Price = 250000,
            Name = "House Warming",
            Description = "Blessed House Opening",
        };
        Party party5 = new Party()
        {
            Id = 5,
            Price = 100000,
            Name = "Graduation",
            Description = "Adebisi's Graduation",
        };

        List<Party> parties = new List<Party>(3);

        parties.Add(party1);
        parties.Add(party2);
        parties.Add(party3);
        parties.Add(party4);

        //Party lisparty = parties[3];
        //foreach (var lisparty in parties)
        //Console.WriteLine("Id = {0}, Name = {1}, Description = {2}, Price = {3}", lisparty.Id, lisparty.Name, lisparty.Description, lisparty.Price);

        Party p  = parties.Find(x => x.Price > 150000);
        Console.WriteLine("Id = {0}, Name = {1}, Description = {2}, Price = {3}", p.Id, p.Name, p.Description, p.Price);

    }
}