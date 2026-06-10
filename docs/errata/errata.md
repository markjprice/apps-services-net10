**Errata** (26 items)

If you find any mistakes, then please [raise an issue in this repository](https://github.com/markjprice/apps-services-net10/issues) or email me at markjprice (at) gmail.com.

- [Page 6 - Building web and other services](#page-6---building-web-and-other-services)
- [Page 67 - Getting help on Discord and other chat forums](#page-67---getting-help-on-discord-and-other-chat-forums)
- [Page 38 - Treating warnings as errors](#page-38---treating-warnings-as-errors)
- [Page 72 - Customizing Copilot responses](#page-72---customizing-copilot-responses)
- [Page 74 - Using future versions of .NET with this book](#page-74---using-future-versions-of-net-with-this-book)
- [Page 80 - Simplifying code using XAML](#page-80---simplifying-code-using-xaml)
- [Page 92 - Enabling Windows developer mode](#page-92---enabling-windows-developer-mode)
- [Page 96 - Adding shell navigation and more content pages](#page-96---adding-shell-navigation-and-more-content-pages)
- [Page 97 - Adding shell navigation and more content pages](#page-97---adding-shell-navigation-and-more-content-pages)
- [Page 117 - Exercise 2.3 – Implementing Model-View-ViewModel for .NET MAUI](#page-117---exercise-23--implementing-model-view-viewmodel-for-net-maui)
- [Page 139 - Implementing a simple desktop app for data](#page-139---implementing-a-simple-desktop-app-for-data)
- [Page 141 - Implementing a simple desktop app for data](#page-141---implementing-a-simple-desktop-app-for-data)
- [Page 147 - Adding images to the project](#page-147---adding-images-to-the-project)
- [Page 161 - Reviewing the new Blazor project template](#page-161---reviewing-the-new-blazor-project-template)
- [Page 185 - Getting entities into a Blazor component](#page-185---getting-entities-into-a-blazor-component)
- [Page 212 - Avoid logging sensitive data](#page-212---avoid-logging-sensitive-data)
- [Page 216 - Defining mappers for an AutoMapper configuration](#page-216---defining-mappers-for-an-automapper-configuration)
- [Page 250 - Date and time calculations](#page-250---date-and-time-calculations)
- [Page 256 - Localizing the DayOfWeek enum](#page-256---localizing-the-dayofweek-enum)
- [Page 259 - Unit testing with a time provider](#page-259---unit-testing-with-a-time-provider)
- [Page 288 - Testing globalization and localization](#page-288---testing-globalization-and-localization)
- [Page 317 - Executing queries and working with data readers using ADO.NET](#page-317---executing-queries-and-working-with-data-readers-using-adonet)
- [Page 401 - Using .NET to build an MCP server](#page-401---using-net-to-build-an-mcp-server)
- [Page 776 - Microsoft Learn documentation MCP server](#page-776---microsoft-learn-documentation-mcp-server)
- [Page 780 - Getting definitions of types and their members](#page-780---getting-definitions-of-types-and-their-members)


> **Warning!** Avoid copying and pasting links that break over multiple lines and include hyphens or dashes because your PDF reader might remove a hyphen thinking that it being helpful but break the link! Just click on the links and they will work. Or carefully check that your PDF reader has not removed a hyphen after pasting into your web browser address bar. [See an example of this issue here](https://github.com/markjprice/cs13net9/issues/77).

# Page 6 - Building web and other services

> Thanks to [Kris](https://github.com/kprikratki) for raising [this issue on March 11, 2026](https://github.com/markjprice/apps-services-net10/issues/9).

The second time I mention Roy Fielding, I mistyped his last name, "...defined by Roy Field in his dissertation about REST APIs." It should be "...defined by Roy Fielding in his dissertation about REST APIs."

# Page 67 - Getting help on Discord and other chat forums

> Thanks to [Kris](https://github.com/kprikratki) for raising [this issue on March 11, 2026](https://github.com/markjprice/apps-services-net10/issues/9).

In the second bullet, **Research before asking**, I mistakenly used the errata page link for my other book, *C# 14 and .NET 10*. The link should be:
https://github.com/markjprice/apps-services-net10/blob/main/docs/errata/README.md

# Page 38 - Treating warnings as errors

In the output at the bottom of the page, the path includes `Chapter14` instead of `ModernServices`.

# Page 72 - Customizing Copilot responses

> Thanks to [Giuseppe Guerra](https://github.com/giuseppe-guerra) for raising [this issue on March 4, 2026](https://github.com/markjprice/apps-services-net10/issues/8).

I wrote, "We can do this for Copilot using a special Markdown file:"
```
<project_folder>\.gihub\copilot-instructions.md"
```

The path is missing a "t" in ".gihub". It should be:
```
<project_folder>\.github\copilot-instructions.md"
```

# Page 74 - Using future versions of .NET with this book

In Step 3, I wrote, "You can also use new features in EF Core 11 because it will continue to target .NET 10."

And on page 342, I wrote, "When EF Core 11 is released in November 2026, we can expect it to target .NET 10 or later, so you can upgrade EF Core while still getting long-term support for the .NET 10 platform. The EF Core team is responsible for making sure that you will be able to swap 10 for 11 in the version number of their packages and your code should still work. They are usually very good at that, and they will document any needed changes to your code in the official release notes for EF Core 11."

On February 10, 2026, the EF Core team published packages for EF Core 11 Preview 1, and a page for what's new: https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-11.0/whatsnew

It includes an important note: "EF11 requires the .NET 11 SDK to build and requires the .NET 11 runtime to run. EF11 will not run on earlier .NET versions, and will not run on .NET Framework."

In the past, the EF Core team often targeted the latest LTS .NET so you could adopt the new EF Core STS version without moving your whole app runtime. Microsoft’s own “Supported .NET implementations” page even states that as the general approach: “In general, we target the latest LTS release of .NET… There may be exceptions… as runtime features sometimes get added that require us to depend on the latest version of .NET.” From: https://learn.microsoft.com/en-us/ef/core/miscellaneous/platforms

But EF Core 11 is now explicitly saying that it requires the .NET 11 SDK to build and the .NET 11 runtime to run, and it won’t run on earlier .NET versions.

Why? The EF team’s own platform guidance acknowledges that sometimes they must depend on the latest .NET due to runtime features. In practice, “won’t run on earlier .NET” usually means they’re compiling against and taking dependencies on assemblies/APIs that simply are not present (or not the same versions) on earlier runtimes, and the team has decided not to carry the extra compatibility shims or multi-targeting.

Net result: EF Core 11 only running on .NET 11 is the documented requirement. If you want to stay on .NET 10 LTS, EF Core 10 is the ceiling. If you move to .NET 11 (STS), EF Core 11 becomes available.

# Page 80 - Simplifying code using XAML

> Thanks to [Moisés Sirvente](https://github.com/es-moises) for raising [this issue on June 4, 2026](https://github.com/markjprice/apps-services-net10/issues/31).

In the XAML code example, the end tag should be `</HorizontalStackPanel>` not `</StackPanel>`.

# Page 92 - Enabling Windows developer mode

> Thanks to [zkazz](https://github.com/zkazz) for raising [this issue on March 31, 2026](https://github.com/markjprice/apps-services-net10/issues/15).

In Step 1, I wrote, "Navigate to **Start** | **Settings** | **Privacy & security** | **For developers**, and then switch on **Developer Mode**. (You can also search for “developers”.)"

This setting has moved, so it should say, "Navigate to **Start** | **Settings** | **System** | **Advanced**, and then in the **For developers** section, toggle on **Developer Mode**. (You can also search for “developers”.)"

# Page 96 - Adding shell navigation and more content pages

> Thanks to [zkazz](https://github.com/zkazz) for raising [this issue on March 31, 2026](https://github.com/markjprice/apps-services-net10/issues/16).

In Step 2, I mistakenly showed the .NET 8 generation MAUI code where you must set the `MainPage` property:
```cs
namespace Northwind.Maui.Client;

public partial class App : Application
{
  public App()
  {
    InitializeComponent();
    MainPage = new AppShell();
  }
}
```

The .NET 10 generation MAUI code overrides the `CreateWindow` method:
```cs
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Maui.Client
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
      return new Window(new AppShell());
    }
  }
}
```

The code was correct in the GitHub repository:
https://github.com/markjprice/apps-services-net10/blob/main/code/ModernApps/Northwind.Maui.Client/App.xaml.cs

# Page 97 - Adding shell navigation and more content pages

> Thanks to [Sammy Lastre Silveira](https://github.com/Sammy-Lastre) for raising [this issue on February 28, 2026](https://github.com/markjprice/apps-services-net10/issues/7).

In Step 4, the information box includes a link to download some images, but the link is wrong. It should be: https://github.com/markjprice/apps-services-net10/tree/main/code/ModernApps/Northwind.Maui.Client/Resources/Images

# Page 117 - Exercise 2.3 – Implementing Model-View-ViewModel for .NET MAUI

> Thanks to [DrAvriLev](https://github.com/DrAvriLev) for raising [this issue on March 17, 2026](https://github.com/markjprice/apps-services-net10/issues/14).

The link is broken. It should be: https://github.com/markjprice/apps-services-net10/blob/main/docs/ch02-mvvm.md

# Page 139 - Implementing a simple desktop app for data

> Thanks to [zkazz](https://github.com/zkazz) for raising [this issue on April 2, 2026](https://github.com/markjprice/apps-services-net10/issues/17).

In Step 1, `Northwind.Blazor.csproj` should be `Northwind.DesktopApp.csproj`.

In Step 2, `Northwind.Blazor` should be `Northwind.DesktopApp`.

# Page 141 - Implementing a simple desktop app for data

> Thanks to [zkazz](https://github.com/zkazz) for raising [this issue on April 2, 2026](https://github.com/markjprice/apps-services-net10/issues/18).

In Step 6, inclusion of `ConverterCulture='en-US'` causes an error in the following text block:
```xml
<TextBlock Text="{Binding UnitPrice, StringFormat='C2',
                 ConverterCulture='en-US'}"
           Width="100" TextAlignment="Right"/>
```

This element was already correct in the GitHub repository:
https://github.com/markjprice/apps-services-net10/blob/main/code/ModernApps/Northwind.DesktopApp/Views/MainWindow.axaml#L65

# Page 147 - Adding images to the project

> Thanks to a reader who emailed my publisher about this issue.

The image of the category in the top-left corner of the desktop app window is currently fixed showing a default image of all categories. To dynamically update the image, we can define a class to convert between the selected category ID and the image asset for that category.

In the project folder, add a class file named `CategoryIdToBitmapConverter.cs` with the following code:
```cs
using Avalonia.Data.Converters; // To use IValueConverter.
using Avalonia.Media.Imaging; // To use Bitmap.
using Avalonia.Platform; // To use AssetLoader.
using System; // To use Uri and Type.
using System.Globalization; // To use CultureInfo.

namespace Northwind.DesktopApp.ViewModels
{
  internal class CategoryIdToBitmapConverter : IValueConverter
  {
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
      if (value == null)
      {
        return new Bitmap(AssetLoader.Open(new Uri($"avares://Northwind.DesktopApp/Assets/categories-small.jpeg")));
      }

      var categoryId = (int)value;

      return new Bitmap(AssetLoader.Open(new Uri($"avares://Northwind.DesktopApp/Assets/category{categoryId}-small.jpeg")));
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
```

In the `Views` folder, in `MainWindow.axaml`, add markup to define an instance of the converter:
```xaml
<Window.Resources>
  <vm:CategoryIdToBitmapConverter x:Key="CategoryIdToBitmapConverter" />
</Window.Resources>
```

Also in `MainWindow.axaml`, change the `Source` of the image to use the converter:
```xaml
<Image Source="{Binding CategoryId, Converter={StaticResource CategoryIdToBitmapConverter}}"
       Height="135" Width="200" />
```

# Page 161 - Reviewing the new Blazor project template

> Thanks to [zkazz](https://github.com/zkazz) for raising [this issue on April 12, 2026](https://github.com/markjprice/apps-services-net10/issues/19).

In Step 1, in the bullet list of project options, I included **Interactivity location: Per page/component**. But when the previous option **Interactive render mode: None** is set, the **Interactivity location** option disappears because it is not relevant when there is no interactivity. 

In the next edition, I will remove the **Interactivity location** bullet.

# Page 185 - Getting entities into a Blazor component

> Thanks to [zkazz](https://github.com/zkazz) for raising [this issue on April 15, 2026](https://github.com/markjprice/apps-services-net10/issues/20).

In Step 4, in the code at the top of page 185, in the `OnParametersSetAsync()` method, I declared a variable and set a local variable:
```cs
Employee[]? employeesArray = null;
```
This causes an error since the variable `employeesArray` is assigned but never used. This statement is not included in the code on GitHub. It should be deleted in the book. 

Also, Step 6 should be deleted because there is no `Northwind.MinimalApi.Service` project:
6. Start the `Northwind.MinimalApi.Service` project, using its `https` profile without debugging.

# Page 212 - Avoid logging sensitive data

> Thanks to [Kris](https://github.com/kprikratki) for raising [this issue on March 16, 2026](https://github.com/markjprice/apps-services-net10/issues/12).

The API for the `Serilog.Enrichers.Sensitive` package has changed so that you must now always provide an `options` parameter to configure it, although you can supply an empty object. 

For example, to use it in the `Serilogging` project:

1. In `Directory.Packages.props`, define the package version:
    ```xml
    <PackageVersion Include="Serilog.Enrichers.Sensitive" Version="2.1.0" />
    ```
2. In `Serilogging.csproj`, add a package reference:
    ```xml
    <PackageReference Include="Serilog.Enrichers.Sensitive" />
    ```
3. In `Program.cs`, import the namespace to use the extension method:
   ```cs
   using Serilog.Enrichers.Sensitive; // To use WithSensitiveDataMasking().
   ```
4. In the statement that creates the `Logger`, access the `Enrich` object and call the `WithSensitiveDataMasking` method with an empty `options` parameter:
   ```cs
   // Create a new logger that will write to the console and to
   // a text file, one-file-per-day, named with the date.
   using Logger log = new LoggerConfiguration()
     .Enrich.WithSensitiveDataMasking(options => { }) // add the enricher
        
     // console and file both executed on a background worker.
     .WriteTo.Async(a => a.Console())
     .WriteTo.Async(a => a.File("log.txt", rollingInterval: RollingInterval.Day))
     .CreateLogger();
   ```

# Page 216 - Defining mappers for an AutoMapper configuration

> Thanks to [zkazz](https://github.com/zkazz) for raising [this issue on April 27, 2026](https://github.com/markjprice/apps-services-net10/issues/21).

In Step 5, if you reference the latest version of AutoMapper then you will get a compile error because the [API has changed](https://github.com/markjprice/apps-services-net10/blob/main/code/PopularPackages/MappingObjects.Mappers/CartToSummaryMapper.cs#L12).

The book uses [AutoMapper `14.0.0`](https://github.com/markjprice/apps-services-net10/blob/main/code/Directory.Packages.props#L81) because that is the last version that does not require a license. This is why downloads have dramatically dropped: from `12.0.1` with 135 million downloads, `13.0.1` with 138 million downloads, and `14.0.0` with 40 million downloads, down to the latest version `16.1.1` with only 2 million downloads. 

Unfortunately all versions except `15.1.3` and `16.1.1` now have a security vulnerability. I have temporarily [disabled the warning for this in the project file](https://github.com/markjprice/apps-services-net10/blob/main/code/PopularPackages/MappingObjects.Mappers/MappingObjects.Mappers.csproj#L8) so that the project compiles but that isn't a good solution. I recommend avoiding AutoMapper completely and skipping the AutoMapper section of my book.

In the next edition, I will replace the AutoMapper example with an alternative, or more likely, turn the mapping section into a discussion of why almost all mapping libraries should be avoided but you need to know about them because so many legacy projects use them. And expand on the content about using manual mappings with extension methods and similar.

# Page 250 - Date and time calculations

> Thanks to [zkazz](https://github.com/zkazz) for raising [this issue on May 5, 2026](https://github.com/markjprice/apps-services-net10/issues/22).

In Step 1, in the code, the following statement is missing an end brace `}` after `xmas.Year`:
```cs
WriteLine($"There are {untilXmas.Days} days and {untilXmas.Hours
  } hours until Christmas {xmas.Year.");
```
It should be:
```cs
WriteLine($"There are {untilXmas.Days} days and {untilXmas.Hours
  } hours until Christmas {xmas.Year}.");
```

The next `WriteLine` statement is missing the `$` prefix that makes the first string interpolated:
```cs
WriteLine("There are {untilXmas.TotalHours:N0} hours " +
  $"until Christmas {xmas.Year}.");
```
It should be:
```cs
WriteLine($"There are {untilXmas.TotalHours:N0} hours " +
  $"until Christmas {xmas.Year}.");
```

Or we could combine the two strings by moving the line break inside the braces:
```cs
WriteLine($"There are {untilXmas.TotalHours:N0
  } hours "until Christmas {xmas.Year}.");
```

Both these coding mistakes were only in the print book. They were correct in the GitHub repository:
https://github.com/markjprice/apps-services-net10/blob/main/code/Internationalization/WorkingWithTime/Program.cs#L41

# Page 256 - Localizing the DayOfWeek enum

> Thanks to [zkazz](https://github.com/zkazz) for raising [this issue on May 7, 2026](https://github.com/markjprice/apps-services-net10/issues/23).

In Step 1, in the code, I forgot the `$` prefix for two of the three `WriteLine` statements. The complete code for Step 1 should be:
```cs
SectionTitle("Localizing the DayOfWeek enum");

CultureInfo previousCulture = Thread.CurrentThread.CurrentCulture;

// Explicitly set culture to Danish (Denmark).
Thread.CurrentThread.CurrentCulture =
  CultureInfo.GetCultureInfo("da-DK");

// DayOfWeek is not localized to Danish.
WriteLine($"Culture: {Thread.CurrentThread.CurrentCulture
  .NativeName}, DayOfWeek: {DateTime.Now.DayOfWeek}";

// Use dddd format code to get day of the week localized.
WriteLine($"Culture: {Thread.CurrentThread.CurrentCulture
  .NativeName}, DayOfWeek: {DateTime.Now:dddd}");

// Use GetDayName method to get day of the week localized.
WriteLine($"Culture: {Thread.CurrentThread.CurrentCulture
  .NativeName}, DayOfWeek: {DateTimeFormatInfo.CurrentInfo
  .GetDayName(DateTime.Now.DayOfWeek)}");

Thread.CurrentThread.CurrentCulture = previousCulture;
```

Both these coding mistakes were only in the print book (and online version). They were correct in the GitHub repository: https://github.com/markjprice/apps-services-net10/blob/main/code/Internationalization/WorkingWithTime/Program.cs#L120

# Page 259 - Unit testing with a time provider

> Thanks to [zkazz](https://github.com/zkazz) for raising [this issue on May 7, 2026](https://github.com/markjprice/apps-services-net10/issues/24).

In Step 7, I wrote, "In the `TestingWithTimeProvider` project, rename `Test1.cs` to `TimeTests.cs`." But the default name of the example test file is `UnitTest1.cs` not `Test1.cs`."

# Page 288 - Testing globalization and localization

> Thanks to [nthnhwrdprmn](https://github.com/nthnhwrdprmn) for raising [this issue on June 10, 2026](https://github.com/markjprice/apps-services-net10/issues/36).

I wrote, "Microsoft has an online tool (found at the following link: https://www.microsoft.com/en-us/Language/) that can help you translate text in your user interfaces."

The Microsoft Language Portal has effectively been replaced by Microsoft’s Globalization documentation and Power BI-based terminology search.

Use these links instead:

Microsoft Terminology reference page:
https://learn.microsoft.com/en-us/globalization/reference/microsoft-terminology

Microsoft Language Resources page:
https://learn.microsoft.com/en-us/globalization/reference/microsoft-language-resources

Microsoft Terminology Search:
https://msit.powerbi.com/view?r=eyJrIjoiODJmYjU4Y2YtM2M0ZC00YzYxLWE1YTktNzFjYmYxNTAxNjQ0IiwidCI6IjcyZjk4OGJmLTg2ZjEtNDFhZi05MWFiLTJkN2NkMDExZGI0NyIsImMiOjV9

Microsoft says terminology can now be downloaded in `.tbx` format from the Microsoft Download Center, and the language resources page points users to the terminology search page for querying Microsoft terminology. https://learn.microsoft.com/en-us/globalization/reference/microsoft-terminology

For ordinary machine translation rather than Microsoft product terminology, the current Microsoft Translator page is: https://www.microsoft.com/en-us/translator/

# Page 317 - Executing queries and working with data readers using ADO.NET

> Thanks to [zkazz](https://github.com/zkazz) for raising [this issue on May 16, 2026](https://github.com/markjprice/apps-services-net10/issues/25).

In Step 7, I wrote, "Run the console app," but at this point we only have code that sets up, creates, and opens the connection, without closing it. Later I give multiple step instructions that reference closing the connection. The simplest solution to this errata is to explcitly add a statement to close the connection despite the connection automatically closing (and disposing) when it goes out of scope at the end of the implicit `Main` method.

In the next edition, before Step 7, I will add a new step to say, "At the end of `Program.cs`, after the end of the `#region` for creating and opening the connection, add a statement to explicitly close the connection, as shown in the following code:"
```cs
connection.Close(); // Explicitly close the connection.
```

# Page 401 - Using .NET to build an MCP server

> Thanks to [zkazz](https://github.com/zkazz) for raising [this issue on June 1, 2026](https://github.com/markjprice/apps-services-net10/issues/27).

In Steps 6 and 7, I wrote `HelloMcpTool.cs` when I should have written `NorthwindTool.cs`.

In Step 8, I wrote "add statements to x" but it should be "add statements to create a host application builder, add logging to the console, add an MCP server with tools automatically loaded from the current assembly, and then run the host asynchronously."

# Page 776 - Microsoft Learn documentation MCP server

During writing, I decided to replace individual solutions for each chapter named `Chapter01`, `Chapter02`, and so on, with larger solutions that could share projects across multiple chapters. But there are a few places were I forgot to rename the solution or folder names.

In Step 1, I wrote, "In the `\cs14net10\Chapter01` folder" but there is no `Chapter01` folder. I should have written "In the `\cs14net10\ModernApps` folder" as shown in the following link: https://github.com/markjprice/apps-services-net10/blob/main/code/ModernApps/.mcp.json

In Step 3, replace "the `Chapter01` solution" with "the `ModernApps` solution".

# Page 780 - Getting definitions of types and their members

In Step 1, replace "open the solution/folder named `Chapter01`" with "open the solution/folder named `ModernApps`".
