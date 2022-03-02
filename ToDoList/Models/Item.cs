using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public static List<Item> Instances = new List<Item> {};

    public Item(string description)
    {
      Description = description;
      Instances.Add(this);
    }

    public static List<Item> GetAll()
    {
      return Instances;
    }

    public static void ClearAll()
    {
      Instances.Clear();
    }

  }
}