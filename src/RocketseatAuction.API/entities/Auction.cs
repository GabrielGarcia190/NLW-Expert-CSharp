namespace RocketseatAuction.API.entities;

public class Auction
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Starts { get; set; }
    public DateTime Ends { get; set; }
    public List<Item> Items { get; set; } = new List<Item>();
    // no .NET 8, pode simplificar para:
    //public List<Item> Itens { get; set; } = []
}
