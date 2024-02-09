using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.entities;

namespace RocketseatAuction.API.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=C:\dev\NLW-Expert-Trilha_CSharp\leilaoDbNLW.db");
    }
}
