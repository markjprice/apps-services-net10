**Errata** (12 items)

If you find any mistakes, then please [raise an issue in this repository](https://github.com/markjprice/apps-services-net10/issues) or email me at markjprice (at) gmail.com.

- [Page 6 - Building web and other services](#page-6---building-web-and-other-services)
- [Page 67 - Getting help on Discord and other chat forums](#page-67---getting-help-on-discord-and-other-chat-forums)
- [Page 38 - Treating warnings as errors](#page-38---treating-warnings-as-errors)
- [Page 72 - Customizing Copilot responses](#page-72---customizing-copilot-responses)
- [Page 74 - Using future versions of .NET with this book](#page-74---using-future-versions-of-net-with-this-book)
- [Page 92 - Enabling Windows developer mode](#page-92---enabling-windows-developer-mode)
- [Page 96 - Adding shell navigation and more content pages](#page-96---adding-shell-navigation-and-more-content-pages)
- [Page 97 - Adding shell navigation and more content pages](#page-97---adding-shell-navigation-and-more-content-pages)
- [Page 117 - Exercise 2.3 – Implementing Model-View-ViewModel for .NET MAUI](#page-117---exercise-23--implementing-model-view-viewmodel-for-net-maui)
- [Page 212 - Avoid logging sensitive data](#page-212---avoid-logging-sensitive-data)
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

# Page 776 - Microsoft Learn documentation MCP server

During writing, I decided to replace individual solutions for each chapter named `Chapter01`, `Chapter02`, and so on, with larger solutions that could share projects across multiple chapters. But there are a few places were I forgot to rename the solution or folder names.

In Step 1, I wrote, "In the `\cs14net10\Chapter01` folder" but there is no `Chapter01` folder. I should have written "In the `\cs14net10\ModernApps` folder" as shown in the following link: https://github.com/markjprice/apps-services-net10/blob/main/code/ModernApps/.mcp.json

In Step 3, replace "the `Chapter01` solution" with "the `ModernApps` solution".

# Page 780 - Getting definitions of types and their members

In Step 1, replace "open the solution/folder named `Chapter01`" with "open the solution/folder named `ModernApps`".
