# NotificationParser

I program this notification parser in C# that parses notification titles to extract valid channels. The application identifies specific tags within the title and returns a formatted string indicating the channels found.

## Files

### Program.cs

The `Program.cs` file contains the entry point of the application. It prompts the user to enter a notification title, uses the `ParserService` to parse the title, and then displays the result.

### ParserService.cs

The `ParserService.cs` file contains the `ParserService` class, which is responsible for parsing the notification title. It uses regular expressions to extract tags and checks them against a predefined set of valid channels.

## Test Examples

```bash
dotnet run
```

Here are five test examples you can use to verify the functionality of the application:

1. **Input:** `[BE] New feature release`
   - **Expected Output:** `Receive channels: BE`

2. **Input:** `[FE][QA] Bug fixes and improvements`
   - **Expected Output:** `Receive channels: FE, QA`

3. **Input:** `[Urgent] System outage`
   - **Expected Output:** `Receive channels: Urgent`

4. **Input:** `[Invalid] No valid channels`
   - **Expected Output:** `No valid channels found.`

5. **Input:** `[BE][FE][QA][Urgent] All hands meeting`
   - **Expected Output:** `Receive channels: BE, FE, QA, Urgent`

Feel free to modify and expand upon this README as needed.
