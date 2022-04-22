using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parks.Models;
using Microsoft.AspNetCore.Http;

namespace Parks.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StateAndNatParksController : ControllerBase
  {
    private readonly StateAndNatParkContext _db;

    public StateAndNatParksController(StateAndNatParkContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<StateAndNatPark>>> Get()
    {
      return await _db.Animals.ToListAsync();
    }
  }
}