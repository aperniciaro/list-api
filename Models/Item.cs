using System;

namespace list_api.Models
{
  public class Item
  {
    public int Id { get; set; }

    public int User_Id { get; set; }

    public string Text { get; set; }

    public bool Complete { get; set; }

    public DateTime Created_At { get; set; } = DateTime.Now;

    public DateTime Updated_At { get; set; } = DateTime.Now;

  }
}