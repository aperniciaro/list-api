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

    [HttpGet("access_token={access_token}")]
    public ActionResult<IList<Item>> GetAllItems()
    {
      var items = db.Items.OrderBy(o => o.Updated_At).ToList();

      return items;
    }

    // working

    [HttpGet("{id}/access_token={access_token}")]
    public ActionResult<Item> GetSingleItem(int id)
    {
      var item = db.Items.FirstOrDefault(f => f.Id == id);
      return item;
    }

    // working
    [HttpPost("access_token={access_token}")]
    public ActionResult<Item> CreateItem([FromBody] ItemViewModel newItem)
    {
      db.Items.Add(newItem.item);
      db.SaveChanges();
      return newItem.item;
    }

    // PUT api/values/5
    [HttpPut("{id}/access_token={access_token}")]
    public ActionResult<Item> UpdateMovie(int id)
    {
      var item = db.Items.FirstOrDefault(f => f.Id == id);
      item.Complete = !item.Complete;
      item.Updated_At = DateTime.Now;
      db.SaveChanges();
      return item;
    }

    // working
    [HttpDelete("{id}/access_token={access_token}")]
    public ActionResult DeleteSingleItem(int id)
    {
      var item = db.Items.FirstOrDefault(f => f.Id == id);
      db.Items.Remove(item);
      db.SaveChanges();
      return Ok();
    }
  }
}
