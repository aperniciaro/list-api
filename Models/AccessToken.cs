using System.Collections.Generic;

namespace list_api.Models
{
  public class AccessToken
  {
    public List<Item> Items { get; set; } = new List<Item>();
    public int User_Id { get; set; }
  }
}