﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using list_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace list_api.Controllers

{
  [Route("api/[controller]")]
  [ApiController]
  public class ItemsController : ControllerBase
  {
    private DatabaseContext db;

    public ItemsController()
    {
      this.db = new DatabaseContext();
    }

    // working

    [HttpGet]
    public ActionResult<IList<Item>> GetAllItems()
    {
      var items = db.Items.OrderBy(o => o.Updated_At).ToList();

      return items;
    }

    // working

    [HttpGet("{id}")]
    public ActionResult<Item> GetSingleItem(int id)
    {
      var item = db.Items.FirstOrDefault(f => f.Id == id);
      return item;
    }

    // working

    [HttpPost]
    public ActionResult<Item> CreateItem([FromBody] Item newItem)
    {
      db.Items.Add(newItem);
      db.SaveChanges();
      return newItem;
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void PutItemUpdate(int id, [FromBody] string value)
    {

    }

    // working
    [HttpDelete("{id}")]
    public ActionResult DeleteSingleItem(int id)
    {
      var item = db.Items.FirstOrDefault(f => f.Id == id);
      db.Items.Remove(item);
      db.SaveChanges();
      return Ok();
    }
  }
}
