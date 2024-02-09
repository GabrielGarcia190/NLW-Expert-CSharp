using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.entities;
using RocketseatAuction.API.Repositories;

namespace RocketseatAuction.API.UseCases;

public class GetCurrentAuctionCase
{
    public Auction? Executar()
    {
        var repository = new RocketseatAuctionDbContext();

        var today = DateTime.Now;

        return repository
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today > auction.Starts && today <= auction.Ends );
    }
}
