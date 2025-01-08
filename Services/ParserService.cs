using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NotificationParser.Services
{
  public class ParserService
  {
    private readonly HashSet<string> _validChannels = new HashSet<string> { "BE", "FE", "QA", "Urgent" };

    public string ParseNotificationChannels(string title)
    {
      MatchCollection matches = ExtractMatches(title);
      HashSet<string> channels = ExtractValidChannels(matches);

      return FormatResult(channels);
    }

    private MatchCollection ExtractMatches(string title)
    {
      Regex tagRegex = new Regex(@"\[([A-Za-z]+)\]");
      return tagRegex.Matches(title);
    }

    private HashSet<string> ExtractValidChannels(MatchCollection matches)
    {
      var channels = new HashSet<string>();
      foreach (Match match in matches)
      {
        string tag = match.Groups[1].Value;
        if (_validChannels.Contains(tag))
        {
          channels.Add(tag);
        }
      }
      return channels;
    }

    private string FormatResult(HashSet<string> channels)
    {
      if (channels.Count > 0)
      {
        return "Receive channels: " + string.Join(", ", channels);
      }
      else
      {
        return "No valid channels found.";
      }
    }
  }
}
