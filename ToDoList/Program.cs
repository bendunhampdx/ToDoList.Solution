using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{

  public class Program
  {

    public static void Main()
    {
      if (Item.Instances.Count == 0)
    {
      Console.WriteLine($"Welcome to the To Do List");
    }
      Console.WriteLine($"Would you like to add an item to your list or view your list? (Type \"Add\" or \"View\")");
      string action = Console.ReadLine();
      Console.WriteLine($"You typed {action}");
      if (action.ToLower() == "add")
    {
      Console.WriteLine("Enter the description for the new item.");
      string description = Console.ReadLine();
      Item newItem = new Item(description);
      Console.WriteLine($"Your new task is {newItem.Description}");
      Main();
    }
    else if (action.ToLower() == "view")
    {
      if (Item.Instances.Count == 0) {
        Console.WriteLine("Please add an item to your list first.");
        Main();
      }
      else
      {
        for (int i = 0; i < Item.Instances.Count; i++)
        {
          Console.WriteLine($"{i + 1}: {Item.Instances[i].Description}");
        }
        Main();
      }
    }
    else
      {
        Console.WriteLine("Sorry, please enter add or view only.");
        Main();
      }
    }
  }
}