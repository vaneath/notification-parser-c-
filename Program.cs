using System;

namespace NotificationParser
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter the notification title: ");
      string? title = Console.ReadLine();

      if (string.IsNullOrEmpty(title))
      {
        Console.WriteLine("Title cannot be empty.");
        return;
      }
    }
  }
}
