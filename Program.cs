using System;
using NotificationParser.Services;

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

      var parserService = new ParserService();
      string result = parserService.ParseNotificationChannels(title);

      Console.WriteLine(result);
    }
  }
}
