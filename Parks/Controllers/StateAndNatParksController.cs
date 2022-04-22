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
    public async Task<ActionResult<IEnumerable<StateAndNatPark>>> Get(string name, string type, string locationbystate)
    {
      var query = _db.StateAndNatParks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }

      if (locationbystate != null)
      {
        query = query.Where(entry => entry.LocationByState == locationbystate);
      }

      return await query.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<StateAndNatPark>> Post(StateAndNatPark stateAndNatPark)
    {
      _db.StateAndNatParks.Add(stateAndNatPark);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetStateAndNatPark), new { id = stateAndNatPark.StateAndNatParkId }, stateAndNatPark);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<StateAndNatPark>> GetStateAndNatPark(int id)
    {
      var stateAndNatPark = await _db.StateAndNatParks.FindAsync(id);

      if (stateAndNatPark == null)
      {
        return NotFound();
      }

      return stateAndNatPark;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, StateAndNatPark stateAndNatPark)
    {
      if (id != stateAndNatPark.StateAndNatParkId)
      {
        return BadRequest();
      }
      
      _db.Entry(stateAndNatPark).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!StateAndNatParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStateAndNatPark(int id)
    {
      var stateAndNatPark = await _db.StateAndNatParks.FindAsync(id);
      if (stateAndNatPark == null)
      {
        return NotFound();
      }

      _db.StateAndNatParks.Remove(stateAndNatPark);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool StateAndNatParkExists(int id)
    {
      return _db.StateAndNatParks.Any(e=> e.StateAndNatParkId == id);
    }
  }
}