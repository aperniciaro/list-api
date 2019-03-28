using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace list_api.Controllers

// OH HIIIIIIIIIIII Andrew!
//Wazzzzuuuuuuppppppp
{
  [Route("api/[controller]")]
  [ApiController]
  public class ItemsController : ControllerBase
  {
    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> GetAllItems()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> GetSingleItem(int id)
    {
      return "value";
    }

    // POST api/values
    [HttpPost]
    public void PostNewItem([FromBody] string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void PutItemUpdate(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void DeleteSingleItem(int id)
    {
    }
  }
}
