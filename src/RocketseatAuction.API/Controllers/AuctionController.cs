using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.entities;
using RocketseatAuction.API.UseCases;

namespace RocketseatAuction.API.Controllers;

[ApiController]
[Route("[controller]")]
public class AuctionController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetCurrentAuction()
    {
        var useCase = new GetCurrentAuctionCase();
        
        var result = useCase.Executar();

        if (result is null) 
            return NoContent();

        return Ok(result);
    }
}