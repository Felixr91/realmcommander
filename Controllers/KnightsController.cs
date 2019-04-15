using Microsoft.AspNetCore.Mvc;

namespace Realm_Commander.Controllers
{
  // data attributes
  [Route("api/[controller]")]
  public class KnightsController : ControllerBase
  {

    // After the word public you specify a return type 'void' will act as a placeholder until we write all of our methods

    // Get All
    [HttpGet]
    public void GetAll()
    {

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

    }

    // Edit one
    [HttpPut("{id}")]
    public void Update(int id)
    {

    }

    // Delete one
    [HttpDelete("{id}")]
    public void Delete(int id)
    {

    }

  }
}