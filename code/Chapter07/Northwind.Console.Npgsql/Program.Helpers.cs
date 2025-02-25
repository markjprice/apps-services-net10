using System.Globalization; // To use CultureInfo.

partial class Program
{
  private static void ConfigureConsole(string culture = "en-US",
    bool useComputerCulture = false)
  {
    // To enable Unicode characters like Euro symbol in the console.
    OutputEncoding = System.Text.Encoding.UTF8;

    if (!useComputerCulture)
    {
      CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
    }
    WriteLine($"CurrentCulture: {CultureInfo.CurrentCulture.DisplayName}");
  }

  private static void WriteLineInColor(string value, 
    ConsoleColor color = ConsoleColor.Black)
  {
    ConsoleColor previousColor = ForegroundColor;
    ForegroundColor = color;
    WriteLine(value);
    ForegroundColor = previousColor;
  }
}