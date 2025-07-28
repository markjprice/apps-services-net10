**Book Links**

- [Chapter 1 - Introducing Apps and Services with .NET](#chapter-1---introducing-apps-and-services-with-net)
  - [Visual Studio for Windows](#visual-studio-for-windows)
  - [VS Code](#vs-code)
  - [.NET](#net)
  - [Help and learning](#help-and-learning)
- [Chapter 2 - Building Mobile Apps Using .NET MAUI](#chapter-2---building-mobile-apps-using-net-maui)
  - [Implementing Model-View-ViewModel for .NET MAUI](#implementing-model-view-viewmodel-for-net-maui)
  - [Integrating .NET MAUI Apps with Blazor and Native Platforms](#integrating-net-maui-apps-with-blazor-and-native-platforms)
- [Chapter 3 - Building Desktop Apps Using Avalonia](#chapter-3---building-desktop-apps-using-avalonia)
- [Chapter 4 - Building Web Apps Using Blazor](#chapter-4---building-web-apps-using-blazor)
  - [Blazor hosting models](#blazor-hosting-models)
  - [Blazor components](#blazor-components)
  - [Advanced techniques](#advanced-techniques)
  - [Leveraging Open-Source Blazor Component Libraries](#leveraging-open-source-blazor-component-libraries)
- [Chapter 5 - Implementing Popular Third-Party Libraries](#chapter-5---implementing-popular-third-party-libraries)
- [Chapter 6 - Handling Dates, Times, and Internationalization](#chapter-6---handling-dates-times-and-internationalization)
- [Chapter 7 - Managing Relational Data Using SQL](#chapter-7---managing-relational-data-using-sql)
  - [Microsoft SQL Server](#microsoft-sql-server)
  - [Dapper and comparing to EF Core performance](#dapper-and-comparing-to-ef-core-performance)
- [Chapter 8 - Building Entity Models Using EF Core](#chapter-8---building-entity-models-using-ef-core)
  - [EF Core](#ef-core)
  - [EF Core database providers](#ef-core-database-providers)
  - [EF Core models](#ef-core-models)
  - [EF Core querying and manipulating](#ef-core-querying-and-manipulating)
- [Chapter 9 - Building a Custom LLM-based Chat Service](#chapter-9---building-a-custom-llm-based-chat-service)
  - [OpenAI](#openai)
  - [Semantic Kernel](#semantic-kernel)
  - [Local models](#local-models)
- [Chapter 10 - Building and Securing Minimal API Web Services](#chapter-10---building-and-securing-minimal-api-web-services)
  - [Web service technologies and design](#web-service-technologies-and-design)
  - [Web service routing](#web-service-routing)
  - [Web service clients](#web-service-clients)
  - [Documenting web services](#documenting-web-services)
  - [Ahead-of-time (AOT) compilation](#ahead-of-time-aot-compilation)
  - [Securing web services](#securing-web-services)
- [Chapter 11 - Caching, Queuing, and Resilient Background Services](#chapter-11---caching-queuing-and-resilient-background-services)
  - [Understanding service architecture](#understanding-service-architecture)
  - [Caching with ASP.NET Core and Redis](#caching-with-aspnet-core-and-redis)
  - [Resilience with Polly](#resilience-with-polly)
  - [Queueing with RabbitMQ, Azure Service Bus, and Event Hub](#queueing-with-rabbitmq-azure-service-bus-and-event-hub)
  - [Background services](#background-services)
  - [Health checks and reliable web services](#health-checks-and-reliable-web-services)
- [Chapter 12 - Broadcasting Real-Time Communication Using SignalR](#chapter-12---broadcasting-real-time-communication-using-signalr)
- [Chapter 13 - Combining Data Sources Using GraphQL](#chapter-13---combining-data-sources-using-graphql)
- [Chapter 14 - Building Efficient Microservices Using gRPC](#chapter-14---building-efficient-microservices-using-grpc)
- [Chapter X1 - Managing NoSQL Data Using Azure Cosmos DB](#chapter-x1---managing-nosql-data-using-azure-cosmos-db)
  - [NoSQL data stores](#nosql-data-stores)
  - [Azure Cosmos DB](#azure-cosmos-db)
  - [Gremlin](#gremlin)
- [Chapter X2 - Building Serverless Nanoservices Using Azure Functions](#chapter-x2---building-serverless-nanoservices-using-azure-functions)
- [Epilogue](#epilogue)
  - [Introducing the Survey Project Challenge](#introducing-the-survey-project-challenge)
  - [Next steps on your C# and .NET learning journey](#next-steps-on-your-c-and-net-learning-journey)
  - [Alternatives to using Azure resources](#alternatives-to-using-azure-resources)
  - [Learn from other Packt books](#learn-from-other-packt-books)

# Chapter 1 - Introducing Apps and Services with .NET

## Visual Studio for Windows
- [Download Visual Studio for Windows](https://visualstudio.microsoft.com/downloads/)
- [Visual Studio for Windows documentation](https://learn.microsoft.com/en-us/visualstudio/windows/)
- [MSBuild and 64-bit Visual Studio 2022](https://devblogs.microsoft.com/dotnet/msbuild-and-64-bit-visual-studio-2022/)

## VS Code
- [Download VS Code](https://code.visualstudio.com/)
- [Set up VS Code](https://code.visualstudio.com/docs/setup/setup-overview)
- [VS Code user interface](https://code.visualstudio.com/docs/getstarted/userinterface)
- [VS Code support for C#](https://code.visualstudio.com/docs/languages/csharp)
- [VS Code key bindings and shortcuts](https://code.visualstudio.com/docs/getstarted/keybindings)
  - [Windows keyboard shortcuts PDF](https://code.visualstudio.com/shortcuts/keyboard-shortcuts-windows.pdf)
  - [macOS keyboard shortcuts PDF](https://code.visualstudio.com/shortcuts/keyboard-shortcuts-macos.pdf)
  - [Linux keyboard shortcuts PDF](https://code.visualstudio.com/shortcuts/keyboard-shortcuts-linux.pdf)

## .NET
- [Download .NET SDK](https://www.microsoft.com/net/download)
- [Official list of .NET 10 supported operating systems](https://github.com/dotnet/core/blob/main/release-notes/10.0/supported-os.md)
- [.NET Support Policy](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core)
- [.NET versions](https://learn.microsoft.com/en-us/dotnet/core/versions/)
- [.NET Uninstall Tool](https://learn.microsoft.com/en-us/dotnet/core/additional-tools/uninstall-tool)
- [How to remove the .NET Runtime and SDK](https://learn.microsoft.com/en-us/dotnet/core/install/remove-runtime-sdk-versions)
- [.NET Runtime](https://github.com/dotnet/runtime/blob/main/README.md)
- [.NET Release Schedule](https://github.com/dotnet/core/blob/master/roadmap.md)

## Help and learning
- [Raise an issue with the book](https://github.com/markjprice/apps-services-net10/issues)
- [Microsoft Learn](https://learn.microsoft.com/)
- [Official .NET Blog written by the .NET engineering teams](https://devblogs.microsoft.com/dotnet/)
- [Stack Overflow](https://stackoverflow.com/)
- [Google Advanced Search](https://www.google.com/advanced_search)
- [.NET Videos](https://dotnet.microsoft.com/en-us/learn/videos)

# Chapter 2 - Building Mobile Apps Using .NET MAUI

- [State of .NET MAUI | .NET Conf 2022](https://www.youtube.com/watch?v=Z6UPJmerTo8)
- [.NET Multi-platform App UI](https://dotnet.microsoft.com/en-us/apps/maui)
- [.NET Multi-platform App UI documentation](https://learn.microsoft.com/en-us/dotnet/maui/)
- [.NET Multi-platform App UI (.NET MAUI) Support Policy](https://dotnet.microsoft.com/en-us/platform/support/policy/maui)
- [What's new in .NET MAUI and Desktop Apps | .NET Conf 2022](https://www.youtube.com/watch?v=nu6sv94QvAg)
- [.NET Conf Focus on MAUI – That’s a wrap!](https://devblogs.microsoft.com/dotnet/dotnet-conf-focus-on-maui-recap/)
- [.NET Podcasts - Sample Application](https://github.com/microsoft/dotnet-podcasts)
- [.NET MAUI eBook Now Available – Enterprise Application Pattern](https://devblogs.microsoft.com/dotnet/dotnet-maui-ebook-released/)
- [Announcing .NET MAUI support for Xcode 14 and iOS 16](https://devblogs.microsoft.com/dotnet/dotnet-maui-xcode-14/)
- [Introducing .NET MAUI – One Codebase, Many Platforms](https://devblogs.microsoft.com/dotnet/introducing-dotnet-maui-one-codebase-many-platforms/)
- [Introducing .NET Multi-platform App UI](https://devblogs.microsoft.com/dotnet/introducing-net-multi-platform-app-ui/)
- [Layouts](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/layouts/)
- [Pages - ContentPage](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pages/contentpage)
- [Add a splash screen to a .NET MAUI app project](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/images/splashscreen)
- [Inspect the visual tree of a .NET MAUI app](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/live-visual-tree)
- [Phone dialer](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/communication/phone-dialer)
- [Connect to local web services from Android emulators and iOS simulators](https://learn.microsoft.com/en-us/dotnet/maui/data-cloud/local-web-services)
- [.NET MAUI - Workshop](https://github.com/dotnet-presentations/dotnet-maui-workshop)
- [Build mobile and desktop apps with .NET MAUI learning path](https://learn.microsoft.com/en-gb/learn/paths/build-apps-with-dotnet-maui/)
- [Forums](https://learn.microsoft.com/en-us/answers/topics/dotnet-maui.html)
- [Building Windows apps with WinUI 3 with .NET | .NET Conf 2022](https://www.youtube.com/watch?v=sYBCFTRmHOA)
- [Accelerate your WinUI 3 app with the Windows Community Toolkit | .NET Conf 2022](https://www.youtube.com/watch?v=WH-vRxvY95M)
- [OSS Spotlight - Build amazing cross-platform UI for .NET with Avalonia UI!](https://www.youtube.com/watch?v=qcZSr2ejH5I)

## Implementing Model-View-ViewModel for .NET MAUI

- [MVVM is easier than ever before with Source Generators, .NET 7, and the MVVM Toolkit| .NET Conf 2022](https://www.youtube.com/watch?v=oQluWTag-e4)

## Integrating .NET MAUI Apps with Blazor and Native Platforms

- [Create native desktop & mobile apps using web skills in Blazor Hybrid | .NET Conf 2022](https://www.youtube.com/watch?v=ojcvL8KCOwo)
- [Host a Blazor web app in a .NET MAUI app using BlazorWebView](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/blazorwebview)
- [Enterprise Application Patterns Using .NET MAUI](https://learn.microsoft.com/en-us/dotnet/architecture/maui/)
- [CarouselView](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/carouselview/)
- [Display a menu bar in a .NET MAUI desktop app](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/menubar)
- [Xamarin.Essentials 1.7 and introducing .NET MAUI Essentials](https://devblogs.microsoft.com/xamarin/xamarin-essentials-1-7-and-introducing-net-maui-essentials/)
- [Platform integration](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/)
- [Permissions](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/appmodel/permissions)
- [Connectivity](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/communication/networking)
- [Device information](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/device/information)
- [Geolocation](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/device/geolocation)
- [App actions](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/appmodel/app-actions)
- [File picker](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/storage/file-picker)
- [Media picker](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/device-media/picker)
- [Clipboard](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/data/clipboard)
- [Secure storage](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/storage/secure-storage)
- [Modernize your WPF and Windows Forms application with Blazor | .NET Conf 2022](https://www.youtube.com/watch?v=niX1DbFwgq4)

# Chapter 3 - Building Desktop Apps Using Avalonia

# Chapter 4 - Building Web Apps Using Blazor

## Blazor hosting models
- [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
- [Official list of supported Blazor platforms](https://learn.microsoft.com/en-us/aspnet/core/blazor/supported-platforms)
- [Blazor hosting models](https://learn.microsoft.com/en-us/aspnet/core/blazor/hosting-models)
- [Blazor Hybrid apps](https://devblogs.microsoft.com/aspnet/hybrid-blazor-apps-in-mobile-blazor-bindings-july-update/)
- [What's new for Blazor in .NET 7 | .NET Conf 2022](https://www.youtube.com/watch?v=evW4Gj4sHsk)
- [.NET ❤️’s WebAssembly in .NET 7 | .NET Conf 2022](https://www.youtube.com/watch?v=Ru-kO77d3F8)

## Blazor components
- [The reason for needing CSS isolation for Blazor components](https://github.com/dotnet/aspnetcore/issues/10170)
- [OI icons](https://iconify.design/icon-sets/oi/)
- [Forms and validation](https://learn.microsoft.com/en-us/aspnet/core/blazor/forms-validation)
- [NavigationManager with Blazor routes](https://learn.microsoft.com/en-us/aspnet/core/blazor/fundamentals/routing#uri-and-navigation-state-helpers)

## Advanced techniques
- [Implementing offline support for Blazor WebAssembly projects](https://learn.microsoft.com/en-us/aspnet/core/blazor/progressive-web-app#offline-support)
- [Lazy loading assemblies](https://learn.microsoft.com/en-us/aspnet/core/blazor/webassembly-lazy-load-assemblies)
- [Routing in Blazor Apps: Comparing the routing of popular web frameworks like React and Angular with Blazor](https://devblogs.microsoft.com/premier-developer/routing-in-blazor-apps/)
- [Use .NET from any JavaScript app in .NET 7](https://devblogs.microsoft.com/dotnet/use-net-7-from-any-javascript-app-in-net-7/)
- [Testing Blazor Applications with Playwright | .NET Conf 2022](https://www.youtube.com/watch?v=gBky9_AskNQ)
- [CSS Techniques for Blazor Developers | .NET Conf 2022](https://www.youtube.com/watch?v=w_x1keHyXAY)

## Leveraging Open-Source Blazor Component Libraries

- [Awesome Blazor: A collection of awesome Blazor resources](https://github.com/AdrienTorris/awesome-blazor)
- [Blazor University: Learn the new .NET SPA framework from Microsoft](https://blazor-university.com)
- [Blazor - app building workshop: In this workshop, we will build a complete Blazor app and learn about the various Blazor framework features along the way](https://github.com/dotnet-presentations/blazor-workshop/)
- [Carl Franklin's Blazor Train](https://www.youtube.com/playlist?list=PL8h4jt35t1wjvwFnvcB2LlYL4jLRzRmoz)
- [Welcome to PACMAN written in C# and running on Blazor WebAssembly](https://github.com/SteveDunn/PacManBlazor)
- [Sortable Lists for Blazor using a SortableJS Component](https://devblogs.microsoft.com/dotnet/introducing-blazor-sortable/)

# Chapter 5 - Implementing Popular Third-Party Libraries

- [ImageSharp](https://github.com/SixLabors/ImageSharp)
- [Humanizer](https://github.com/Humanizr/Humanizer)
- [Serilog](https://serilog.net/)
- [AutoMapper, a convention-based object-object mapper](https://automapper.org)
- [FluentValidation documentation](https://docs.fluentvalidation.net/en/latest/)
- [Fluent Assertions - Introduction](https://fluentassertions.com/introduction)
- [Modern .NET library for PDF document generation](https://www.questpdf.com/)

# Chapter 6 - Handling Dates, Times, and Internationalization

- [Date, Time, and Time Zone Enhancements in .NET 6](https://devblogs.microsoft.com/dotnet/date-time-and-time-zone-enhancements-in-net-6/)
- [.NET 6: Date and Time Structures](https://www.infoq.com/news/2021/04/Net6-Date-Time/)
- [Noda Time: A better date and time API for .NET](https://nodatime.org/)
- [Globalizing and localizing .NET applications](https://learn.microsoft.com/en-us/dotnet/standard/globalization-localization/)
- [Time zones](https://devblogs.microsoft.com/dotnet/cross-platform-time-zones-with-net-core/)

# Chapter 7 - Managing Relational Data Using SQL

## Microsoft SQL Server
- [Try SQL Server on-premises or in the cloud](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Download SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)
- [Quickstart: Connect and query a SQL Server instance using SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/quickstarts/ssms-connect-query-sql-server)
- [Quickstart: Connect and query an Azure SQL Database or an Azure Managed Instance using SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/quickstarts/ssms-connect-query-azure-sql)
- [Use Visual Studio Code to create and run Transact-SQL scripts](https://learn.microsoft.com/en-us/sql/tools/visual-studio-code/sql-server-develop-use-vscode)
- [.NET Interactive with SQL!| .NET Notebooks in Visual Studio Code](https://devblogs.microsoft.com/dotnet/net-interactive-with-sql-net-notebooks-in-visual-studio-code/)

## Dapper and comparing to EF Core performance
- [Dapper](https://github.com/DapperLib/Dapper)
- [Dapper.AOT](https://www.nuget.org/packages/Dapper.AOT) and [How to make libraries compatible with native AOT - Dapper](https://devblogs.microsoft.com/dotnet/creating-aot-compatible-libraries/#dapper)
- [Announcing Entity Framework Core 6.0 Preview 4: Performance Edition](https://devblogs.microsoft.com/dotnet/announcing-entity-framework-core-6-0-preview-4-performance-edition/)
- [Announcing Entity Framework Core 7 Preview 6: Performance Edition](https://devblogs.microsoft.com/dotnet/announcing-ef-core-7-preview6-performance-optimizations/)

# Chapter 8 - Building Entity Models Using EF Core

## EF Core
- [EF Core documentation](https://learn.microsoft.com/en-us/ef/core/)
- [New features in EF Core 8](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-8.0/whatsnew)
- [New features in EF Core 7](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-7.0/whatsnew)
- [New features in EF Core 6](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-6.0/whatsnew)
- [New features in EF Core 5](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-5.0/whatsnew)
- [Get to Know EF Core 6](https://devblogs.microsoft.com/dotnet/get-to-know-ef-core-6/)
- [Plans for Entity Framework Core 6.0 revealed as Microsoft admits it is unlikely to match Dapper for performance](https://www.theregister.com/2021/01/19/entity_framework_core_6/)
- [Entity Framework Community Standup - Performance Tuning an EF Core App](https://www.youtube.com/watch?v=VgNFFEqwZPU)

## EF Core database providers
- [EF Core database providers](https://learn.microsoft.com/en-us/ef/core/providers/)
- [Devart database providers](https://www.devart.com/dotconnect/entityframework.html)
- [Check the latest NuGet package version](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite/)
- [Document Database Providers for Entity Framework Core](https://github.com/BlueshiftSoftware/EntityFrameworkCore)

## EF Core models
- [EF Core model conventions](https://learn.microsoft.com/en-us/ef/core/modeling/)
- [Data seeding](https://learn.microsoft.com/en-us/ef/core/modeling/data-seeding)
- [Humanizer library](http://humanizr.net)
- [Scaffolding](https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding?tabs=dotnet-core-cli)
- [Deep Dive into Many-to-Many: A Tour of EF Core 5.0](https://channel9.msdn.com/Shows/On-NET/Deep-Dive-into-Many-to-Many-A-Tour-of-EF-Core-50-pt-2)
- [Naming Conventions for Entity Framework Core Tables and Columns](https://github.com/efcore/EFCore.NamingConventions)
- [Table-per-concrete-type (TPC) inheritance mapping](https://learn.microsoft.com/en-gb/ef/core/what-is-new/ef-core-7.0/whatsnew#table-per-concrete-type-tpc-inheritance-mapping)
- [T4 goodness with Entity Framework Core 7 | .NET Conf 2022](https://www.youtube.com/watch?v=PUexkGWErNk)

## EF Core querying and manipulating
- [Filtered include](https://learn.microsoft.com/en-us/ef/core/querying/related-data/eager#filtered-include)
- [Simple logging](https://learn.microsoft.com/en-us/ef/core/logging-events-diagnostics/simple-logging)
- [Query tags](https://learn.microsoft.com/en-us/ef/core/querying/tags)
- [Loading patterns](https://learn.microsoft.com/en-us/ef/core/querying/related-data)
- [Pooling database contexts](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-2.0#dbcontext-pooling)

# Chapter 9 - Building a Custom LLM-based Chat Service

## OpenAI
- [Announcing the stable release of the official OpenAI library for .NET](https://devblogs.microsoft.com/dotnet/announcing-the-stable-release-of-the-official-open-ai-library-for-dotnet/)
- [Stack Overflow and OpenAI’s partnership](https://stackoverflow.co/company/press/archive/openaipartnership)
- [OpenAI and Reddit’s partnership](https://openai.com/index/openai-and-redditpartnership/)
- [Microsoft Designer](https://designer.microsoft.com/)
- [GPT 3.5 Turbo model](https://platform.openai.com/docs/models/gpt-3-5-turbo)
- [Create an Azure OpenAI resource](https://learn.microsoft.com/azure/ai-services/openai/how-to/create-resource)
- [OpenAI platform signup](https://platform.openai.com/signup)
- [OpenAI account API keys](https://platform.openai.com/api-keys)
- [OpenAI account billing](https://platform.openai.com/account/billing/overview)
- [OpenAI Playground](https://platform.openai.com/playground?model=gpt-3.5-turbo)
- [OpenAI usage](https://platform.openai.com/usage)
- [OpenAI official .NET package](https://github.com/openai/openai-dotnet)

## Semantic Kernel
- [Semantic Kernel NuGet package](https://www.nuget.org/packages/Microsoft.SemanticKernel)
- [Working with Environment Variables](https://github.com/markjprice/cs12dotnet8/blob/main/docs/ch09-environment-variables.md)
- [Introducing Semantic Kernel](https://devblogs.microsoft.com/semantic-kernel/hello-world/)
- [Semantic Kernel Embeddings and Memories: Explore GitHub Repos with Chat UI](https://devblogs.microsoft.com/semantic-kernel/semantic-kernel-embeddings-and-memories-explore-github-repos-with-chat-ui/)
- [Making AI powered .NET apps more consistent and intelligent with Redis](https://devblogs.microsoft.com/semantic-kernel/making-ai-powered-net-apps-more-consistent-and-intelligent-with-redis/)
- [Building AI-powered Microsoft Copilot with SignalR and other open-source tools](https://devblogs.microsoft.com/dotnet/building-ai-powered-bing-chat-with-signalr-and-other-open-source-tools/)
- [Build Intelligent Applications using ChatGPT & Azure Cosmos DB](https://devblogs.microsoft.com/cosmosdb/chatgpt-azure-cosmos-db/)
- [Using Hugging Face models with the Semantic Kernel](https://devblogs.microsoft.com/semantic-kernel/how-to-use-hugging-face-models-with-semantic-kernel/)
- [Semantic Kernel documentation](https://learn.microsoft.com/en-us/semantic-kernel/)
- [Planning with Semantic Kernel using Automatic Function Calling](https://devblogs.microsoft.com/semantic-kernel/planning-with-semantic-kernel-using-automatic-function-calling/)
- [The future of Planners in Semantic Kernel](https://devblogs.microsoft.com/semantic-kernel/the-future-of-planners-in-semantic-kernel/)
- [Model as a Service (MaaS) Available for Semantic Kernel](https://devblogs.microsoft.com/semantic-kernel/model-as-a-service-maas-available-for-semantic-kernel/)

## Local models
- [.NET 9 tokenizers](https://github.com/dotnet/core/blob/main/release-notes/9.0/preview/preview4/libraries.md#tokenizer-library-enhancements)
- [Hugging Face](https://huggingface.co/)
- [Ollama](https://ollama.com/)
- [Llama 2 Uncensored](https://erichartford.com/uncensored-models)
- [Llama 3 license](https://llama.meta.com/llama3/license/)
- [Ollama CLI reference](https://github.com/ollama/ollama#cli-reference)
- [OllamaSharp](https://github.com/awaescher/OllamaSharp)
- [OllamaSharp NuGet package](https://www.nuget.org/packages/OllamaSharp)
- [LM Studio](https://lmstudio.ai/)

# Chapter 10 - Building and Securing Minimal API Web Services

## Web service technologies and design
- [Media types](http://en.wikipedia.org/wiki/Media_type)
- [HTTP OPTIONS method and other HTTP methods](https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods/OPTIONS)
- [HTTP POST requests](https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods/POST)
- [Create web APIs with ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/web-api/)
- [RESTful web API design](https://learn.microsoft.com/en-us/azure/architecture/best-practices/api-design)
- [Making the Most of Minimal APIs in .NET 7 | .NET Conf 2022](https://www.youtube.com/watch?v=HXHwtEjQoyM)
- [Building modern high performance services with ASP.NET Core and .NET 7](https://www.youtube.com/watch?v=P7lmBFuw92s)

## Web service routing
- [Endpoint routing](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/routing)
- [Previous routing system](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-2.1)
- [Route constraints](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/routing#route-constraint-reference)
- [Dependency injection for ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection)
- [Proposed standard for Problem Details for HTTP APIs](https://tools.ietf.org/html/rfc7807)
- [Implementing problem details](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.problemdetails)
- [Design decisions around endpoint routing](https://devblogs.microsoft.com/aspnet/asp-net-core-2-2-0-preview1-endpoint-routing/)

## Web service clients
- [REST Client](https://github.com/Huachao/vscode-restclient/blob/master/README.md)
- [It is the BaseAddress and DefaultRequestHeaders properties that you should treat with caution with multiple threads](https://medium.com/@nuno.caneco/c-httpclient-should-not-be-disposed-or-should-it-45d2a8f568bc)
- [You're using HttpClient wrong and it is destabilizing your software](https://aspnetmonsters.com/2016/08/2016-08-27-httpclientwrong/)
- [How to initiate HTTP requests](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/http-requests)
- [Issues with the original HttpClient class available in .NET](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net)
- [HttpClient extension methods for easily working with JSON](https://github.com/dotnet/designs/blob/main/accepted/2020/json-http-extensions/json-http-extensions.md)

## Documenting web services
- [Swagger](https://swagger.io/)
- [Swagger Tools](https://swagger.io/tools/)
- [Swashbuckle for ASP.NET Core](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
- [How Swagger can support multiple versions of an API](https://stackoverflow.com/questions/30789045/leverage-multipleapiversions-in-swagger-with-attribute-versioning/30789944)
- [Importance of documenting services](https://idratherbewriting.com/learnapidoc/)
- [Benefits of setting version compatibility](https://learn.microsoft.com/en-us/aspnet/core/mvc/compatibility-version)
- [Check latest version of analyzers package](http://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Api.Analyzers/)

## Ahead-of-time (AOT) compilation
- [Native AOT deployment](https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/)
- [How to make libraries compatible with native AOT](https://devblogs.microsoft.com/dotnet/creating-aot-compatible-libraries/)
- [ASP.NET Core support for native AOT](https://devblogs.microsoft.com/dotnet/announcing-asp-net-core-in-dotnet-8/#asp-net-core-support-for-native-aot)

## Securing web services
- [Verifying that the tokens used to call your web APIs are requested with the expected claims](https://learn.microsoft.com/en-us/azure/active-directory/develop/scenario-protected-web-api-verification-scope-app-roles)
- [CORS can be enabled to allow different origin requests](https://learn.microsoft.com/en-us/aspnet/core/security/cors)
- [Common HTTP security headers that you might want to add](https://www.meziantou.net/security-headers-in-asp-net-core.htm)
- [Built-in features for compliance with modern privacy requirements like GDPR](https://learn.microsoft.com/en-us/aspnet/core/security/gdpr)
- [ASP.NET Core's support for authenticator apps](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity-enable-qrcodes)
- [Identity UI library](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?tabs=netcore-cli)
- [Authorization](https://learn.microsoft.com/en-us/aspnet/core/security/authorization/introduction)
- [Anti-forgery tokens](https://learn.microsoft.com/en-us/aspnet/core/security/anti-request-forgery)

# Chapter 11 - Caching, Queuing, and Resilient Background Services

## Understanding service architecture

- [Are networks now faster than disks?](https://serverfault.com/questions/238417/are-networks-now-faster-than-disks)
- [The Infinite Space Between Words](https://blog.codinghorror.com/the-infinite-space-between-words/)

## Caching with ASP.NET Core and Redis
- [Overview of caching in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/performance/caching/overview)
- [Cache in-memory in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/performance/caching/memory)
- [Distributed caching in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/performance/caching/distributed)
- [Distributed Redis Cache](https://learn.microsoft.com/en-us/aspnet/core/performance/caching/distributed#distributed-redis-cache)
- [Redis C#/.NET guide](https://redis.io/docs/clients/dotnet/)
- [Response caching in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/performance/caching/response)

## Resilience with Polly
- [The Polly Project](http://www.thepollyproject.org/)
- [Resilience policies](https://github.com/App-vNext/Polly#resilience-policies)
- [Retry with jitter](https://github.com/App-vNext/Polly/wiki/Retry-with-jitter)
- [Transient fault handling and proactive resilience engineering](https://github.com/App-vNext/Polly/wiki/Transient-fault-handling-and-proactive-resilience-engineering)
- [Resilience and chaos engineering](https://devblogs.microsoft.com/dotnet/resilience-and-chaos-engineering/)

## Queueing with RabbitMQ, Azure Service Bus, and Event Hub

## Background services
- [Worker services in .NET](https://learn.microsoft.com/en-us/dotnet/core/extensions/workers)
- [Background tasks with hosted services in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/host/hosted-services)
- [Implement the IHostedService interface](https://learn.microsoft.com/en-us/dotnet/core/extensions/timer-service)
- [Hangfire](https://www.hangfire.io/)
- [Quartz.NET](https://www.quartz-scheduler.net/)
- [Quartz.NET GitHub repository](https://github.com/quartznet/quartznet)

## Health checks and reliable web services
- [Health checks in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/host-and-deploy/health-checks)
- [How to extend the health check response](https://blogs.msdn.microsoft.com/webdev/2018/08/22/asp-net-core-2-2-0-preview1-healthcheck/)
- [How Polly can make your web services more reliable](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/implement-http-call-retries-exponential-backoff-polly)
- [Use HttpClientFactory to implement resilient HTTP requests](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests)

# Chapter 12 - Broadcasting Real-Time Communication Using SignalR

- [Overview of ASP.NET Core SignalR](https://learn.microsoft.com/en-us/aspnet/core/signalr/introduction)
- [SignalR GitHub repository](https://github.com/dotnet/aspnetcore/tree/main/src/SignalR)
- [Azure SignalR Service](https://azure.microsoft.com/en-gb/services/signalr-service/)

# Chapter 13 - Combining Data Sources Using GraphQL

- [GraphQL](https://graphql.org/)
- [HotChocolate - ChilliCream GraphQL Platform](https://chillicream.com/docs/hotchocolate)
- [HotChocolate GitHub repository](https://github.com/ChilliCream/hotchocolate)
- [Getting started with GraphQL and HotChocolate](https://learn.microsoft.com/en-us/shows/on-net/getting-started-with-hotchocolate)
- [Say hello to Hot Chocolate 12!](https://chillicream.com/blog/2021/09/27/hot-chocolate-12)

# Chapter 14 - Building Efficient Microservices Using gRPC

- [gRPC](https://grpc.io/)
- [gRPC - Architecting Cloud Native .NET Applications for Azure](https://learn.microsoft.com/en-us/dotnet/architecture/cloud-native/grpc)
- [Introduction to gRPC on .NET](https://learn.microsoft.com/en-us/aspnet/core/grpc/)
- [Protocol Buffers](https://developers.google.com/protocol-buffers/docs/overview)
- [ASP.NET Core gRPC for WCF Developers](https://learn.microsoft.com/en-us/dotnet/architecture/grpc-for-wcf-developers/)
- [Introduction to HTTP/2](https://web.dev/performance-http2/)
- [High-performance services with gRPC: What's new in .NET 7 | .NET Conf 2022](https://www.youtube.com/watch?v=et_2NBk4N4Y)
- [From RESTful HTTP API to gRPC | .NET Conf 2022](https://www.youtube.com/watch?v=o7MHxvcjFm4)
- [Using CoreWCF to unblock modernization of WCF apps | .NET Conf 2022](https://www.youtube.com/watch?v=jbcNF-QsxNs)

# Chapter X1 - Managing NoSQL Data Using Azure Cosmos DB

## NoSQL data stores
- [Use NoSQL databases as a persistence infrastructure](https://learn.microsoft.com/en-us/dotnet/standard/microservices-architecture/microservice-ddd-cqrs-patterns/nosql-database-persistence-infrastructure)

## Azure Cosmos DB
- [Welcome to Azure Cosmos DB](https://learn.microsoft.com/en-us/azure/cosmos-db/introduction)
- [Azure Cosmos DB .NET SDK v3 for SQL API: Download and release notes](https://learn.microsoft.com/en-us/azure/cosmos-db/sql/sql-api-sdk-dotnet-standard)
- [Data modeling in Azure Cosmos DB](https://learn.microsoft.com/en-us/azure/cosmos-db/sql/modeling-data)
- [How to model and partition data on Azure Cosmos DB using a real-world example](https://learn.microsoft.com/en-us/azure/cosmos-db/sql/how-to-model-partition-example)
- [Getting started with SQL queries](https://learn.microsoft.com/en-us/azure/cosmos-db/sql/sql-query-getting-started)
- [Azure Cosmos DB query cheat sheets](https://learn.microsoft.com/en-us/azure/cosmos-db/sql/query-cheat-sheet)
- [Stored procedures, triggers, and user-defined functions](https://learn.microsoft.com/en-us/azure/cosmos-db/sql/stored-procedures-triggers-udfs)
- [Manage consistency levels in Azure Cosmos DB](https://learn.microsoft.com/en-us/azure/cosmos-db/sql/how-to-manage-consistency)
- [Create a container in Azure Cosmos DB SQL API](https://learn.microsoft.com/en-us/azure/cosmos-db/sql/how-to-create-container)
- [Query an Azure Cosmos container](https://learn.microsoft.com/en-us/azure/cosmos-db/sql/how-to-query-container)
- [Best practices for Azure Cosmos DB .NET SDK](https://learn.microsoft.com/en-us/azure/cosmos-db/sql/best-practice-dotnet)
- [Diagnose and troubleshoot issues when using Azure Cosmos DB .NET SDK](https://learn.microsoft.com/en-us/azure/cosmos-db/sql/troubleshoot-dot-net-sdk)
- [Migrate one-to-few relational data into Azure Cosmos DB SQL API account](https://learn.microsoft.com/en-us/azure/cosmos-db/sql/migrate-relational-to-cosmos-db-sql-api)
- [Frequently asked questions about different APIs in Azure Cosmos DB](https://learn.microsoft.com/en-us/azure/cosmos-db/faq)

## Gremlin

- [What is Azure Cosmos DB for Apache Gremlin?](https://learn.microsoft.com/en-us/azure/cosmos-db/gremlin/introduction)
- [Apache TinkerPop](https://tinkerpop.apache.org/gremlin.html)
- [Getting started with Gremlin's API](https://www.gremlin.com/community/tutorials/getting-started-with-gremlins-api/)

# Chapter X2 - Building Serverless Nanoservices Using Azure Functions

- [.NET 7 comes to Azure Functions & Visual Studio 2022](https://devblogs.microsoft.com/dotnet/dotnet-7-comes-to-azure-functions/)
- [Azure Functions](https://azure.microsoft.com/en-us/services/functions/)
- [Azure Functions documentation](https://learn.microsoft.com/en-us/azure/azure-functions/)
- [Azure serverless community library](https://www.serverlesslibrary.net/)
- [Building Serverless Applications with .NET 7 and Azure functions | .NET Conf 2022](https://www.youtube.com/watch?v=ITpcihRwbTc)

# Epilogue

## Introducing the Survey Project Challenge
- [Survey Monkey Question Types](https://help.surveymonkey.com/en/create/question-types/)

## Next steps on your C# and .NET learning journey
- [Follow the Framework Design Guidelines](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/)
- [Follow the code style rules](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/)
- [Cloud-Native learning resources for .NET developers](https://devblogs.microsoft.com/dotnet/cloud-native-learning-resources-for-net-developers/)

## Alternatives to using Azure resources
- [.NET on AWS Documentation & Developer Guides](https://aws.amazon.com/developer/language/net/net-developer-docs/)

## Learn from other Packt books
- [Mobile Development with .NET](https://www.packtpub.com/product/mobile-development-with-net-second-edition/9781800204690)
- [Enterprise Application Development with C# 10 and .NET 6](https://www.packtpub.com/product/enterprise-application-development-with-c-10-and-net-6-second-edition/9781803232973)
- [Software Architecture with C# 10 and .NET 6](https://www.packtpub.com/product/software-architecture-with-c-10-and-net-6-third-edition/9781803235257)
- [An Atypical ASP.NET Core 6 Design Patterns Guide](https://www.packtpub.com/product/an-atypical-aspnet-core-6-design-patterns-guide-second-edition/9781803249841)
- [Customizing ASP.NET Core 6.0](https://www.packtpub.com/product/customizing-aspnet-core-60-second-edition/9781803233604)
- [ASP.NET Core 5 Secure Coding Cookbook](https://www.packtpub.com/product/aspnet-core-5-secure-coding-cookbook/9781801071567)
- [ASP.NET Core 5 and React](https://www.packtpub.com/product/asp-net-core-5-and-react-second-edition/9781800206168)
- [ASP.NET Core 6 and Angular](https://www.packtpub.com/product/aspnet-core-6-and-angular-fifth-edition/9781803239705)
- [ASP.NET Core and Vue.js](https://www.packtpub.com/product/aspnet-core-and-vuejs/9781800206694)
- [Practical Microservices with Dapr and .NET](https://www.packtpub.com/product/practical-microservices-with-dapr-and-net/9781800568372)
- [Web Development with Blazor](https://www.packtpub.com/product/web-development-with-blazor-second-edition/9781803241494)
- [Building Blazor WebAssembly Applications with gRPC](https://www.packtpub.com/product/building-blazor-webassembly-applications-with-grpc/9781804610558)
- [Mastering Windows Presentation Foundation](https://www.packtpub.com/product/mastering-windows-presentation-foundation-second-edition/9781838643416)
