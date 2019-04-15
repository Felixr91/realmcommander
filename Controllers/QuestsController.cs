using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using realm_commander.Models;

namespace Realm_Commander.Controllers
{
  // data attributes
  [Route("api/[controller]")]
  public class QuestsController : ControllerBase
  {

    // After the word public you specify a return type 'void' will act as a placeholder until we write all of our methods

    // Get All
    [HttpGet]
    public ActionResult<IEnumerable<Quest>> Get()
    {
      //return Quests[]
      return Ok(new Quest[] { new Quest() });
    }

    // Get one by ID
    [HttpGet("{id}")]
    public void GetById()
    {

    }

    // Create one
    [HttpPost]
    public void Create()
    {
      // Create failed
      // bad data
      BadRequest(new { error = "bad data" });
    }

    // Edit one
    [HttpPut("{id}")]
    public void Update(int id)
    {

    }

    // Delete one
    [HttpDelete("{id)")]
    public void Delete(int id)
    {

    }

  }
}