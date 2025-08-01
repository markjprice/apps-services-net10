> **IMPORTANT!** [Common Mistakes, Improvements, and Errata aka list of corrections](docs/errata/README.md)

# Apps and Services with .NET 10, Third Edition

Repository for the Packt Publishing book titled "Apps and Services with .NET 10" by Mark J. Price. This book is planned to be published in December 2025.

> **[FAQs](https://github.com/markjprice/markjprice/blob/main/FAQs.md)**

> Join the Packt community on Discord: https://packt.link/apps_and_services_dotnet10. After accepting the Discord invite, find the channel for this book named **apps_and_services_3e**.


- [Apps and Services with .NET 10, Third Edition](#apps-and-services-with-net-10-third-edition)
- [Free PDF of the book and how to contact the publisher Packt](#free-pdf-of-the-book-and-how-to-contact-the-publisher-packt)
- [Author's books](#authors-books)
  - [Technologies covered in the book](#technologies-covered-in-the-book)
  - [Code solutions](#code-solutions)
  - [Chapters and code solutions](#chapters-and-code-solutions)
  - [Important](#important)
  - [Microsoft .NET community support](#microsoft-net-community-support)
  - [Interviews with me](#interviews-with-me)

# Free PDF of the book and how to contact the publisher Packt

If you have purchased the paperback or Kindle edition, then you can request a free PDF copy and its supplementary content (like Appendix - Answers to the Test Your Knowledge Questions and Graphics Bundle PDF) at the following link: https://download.packt.com/free-ebook/9781835462201. If the book-specific link doesn't work, you can always use this general link that works for all Packt books: https://download.packt.com/free-ebook

For questions about book pricing, distribution, and so on, please contact the publisher Packt at the following email address: customercare@packt.com

# Author's books

My author page on Amazon: https://www.amazon.com/Mark-J-Price/e/B071DW3QGN/ 

All of my books on my publisher Packt's website: https://subscription.packtpub.com/search?query=mark+j.+price

My author page on Goodreads: https://www.goodreads.com/author/show/14224500.Mark_J_Price

## Technologies covered in the book

![Technologies covered in Apps and Services with .NET 10](docs/assets/apps-services-net10-diagram.png)

## Code solutions

Visual Studio, VS Code + C# Dev Kit, and Rider can use the same code solution files and projects for each chapter, found here: [/code](/code). 

> **For VS Code:** To use the chapter solution files with VS Code, install the **C# Dev Kit** extension. Then open the `ChapterNN` folder that contains a `ChapterNN.sln` solution file and wait for the **SOLUTION EXPLORER** pane to appear at the bottom of the **EXPLORER**.

> **Warning!** If you use multiple code editors to open these solutions, then be aware that the build process can conflict. This is because Visual Studio has its own non-standard build server that is different from the standard build server used by .NET SDK CLI. My recommendation is to only have a solution open in one code editor at any time. You should also clean the solutions between closing and opening in different code editors. For example, after closing the solution in one code editor, I delete the `bin` and `obj` folders before then opening in a different code editor.

## Chapters and code solutions

**Introduction**
- Chapter 1 Introducing Apps and Services with .NET: [code/Chapter01](code/Chapter01)
  - [code/nuget.config](code/nuget.config)
  - [code/Directory.Packages.props](code/Directory.Packages.props)

**Apps**
- Chapter 2 Building Mobile Apps Using .NET MAUI: [code/Chapter02](code/Chapter02)
- Chapter 3 Building Desktop Apps Using Avalonia: [code/Chapter03](code/Chapter03)
- Chapter 4 Building Web Apps Using Blazor: [code/Chapter04](code/Chapter04)

**Specialized Libraries**
- Chapter 5 Implementing Popular Third-Party Libraries: [code/Chapter05](code/Chapter05)
- Chapter 6 Handling Dates, Times, and Internationalization: [code/Chapter06](code/Chapter06)

**Data**
- Chapter 7 Managing Relational Data Using SQL: [code/Chapter07](code/Chapter07)
- Chapter 8 Building Entity Models Using EF Core: [code/Chapter08](code/Chapter08)

**Services**
- Chapter 9 Building a Custom LLM-based Service: [code/Chapter09](code/Chapter09)
- Chapter 10 Building and Securing Minimal API Web Services: [code/Chapter10](code/Chapter10)
- Chapter 11 Caching, Queuing, and Resilient Background Services: [code/Chapter11](code/Chapter11)
- Chapter 12 Broadcasting Real-Time Communication Using SignalR: [code/Chapter12](code/Chapter12)
- Chapter 13 Combining Data Sources Using GraphQL: [code/Chapter13](code/Chapter13)
- Chapter 14 Building Efficient Microservices Using gRPC: [code/Chapter14](code/Chapter14)

**Appendices**
- Appendix A, Answers to the Test Your Knowledge Questions
- Appendix B, Setting Up Your Development Environment
- Both are included with the PDF bundle: https://download.packt.com/free-ebook/9781835462201

**Extra**
- Chapter X1 Building Serverless Nanoservices Using Azure Functions: [code/ChapterX1](code/ChapterX1)
- Chapter X2 Managing NoSQL Data Using Azure Cosmos DB: [code/ChapterX2](code/ChapterX2)

## Important
Corrections for typos and other mistakes and improvements like refactoring code. Useful links to other related material. 
- [Online-only sections](docs/README.md)
- [Common Mistakes, Improvements, and Errata aka list of corrections](docs/errata/README.md)
- [Book Links](docs/book-links.md)
- [Command-Lines](docs/command-lines.md) page lists all commands as a single line that can be copied and pasted to make it easier to enter commands at the prompt.
- [Third edition's support for .NET 11](docs/dotnet11.md)

## Microsoft .NET community support
- [.NET Developer Community](https://dotnet.microsoft.com/platform/community)
- [.NET Tech Community Forums for topic discussions](https://techcommunity.microsoft.com/t5/net/ct-p/dotnet)
- [Q&A for .NET to get your questions answered](https://docs.microsoft.com/en-us/answers/products/dotnet)
- [Technical questions about the C# programming language](https://docs.microsoft.com/en-us/answers/topics/dotnet-csharp.html)
- [If you'd like to apply to be a reviewer](https://authors.packtpub.com/reviewers/)

## Interviews with me
Podcast interviews with me:
- [The Modern .NET Show Podcast - January 26, 2024](https://dotnetcore.show/season-6/the-net-trilogy-and-learning-net-with-mark-j-price/)
- [The .NET Core Podcast - March 3, 2023](https://dotnetcore.show/episode-117-our-perspectives-on-the-future-of-net-with-mark-j-price/)
- [Yet Another Podcast with Jesse Liberty - December 2022](https://jesseliberty.com/2022/12/10/mark-price-on-c-11-fixed/)
- [The .NET Core Podcast - February 4, 2022](https://dotnetcore.show/episode-91-c-sharp-10-and-dotnet-6-with-mark-j-price/)
- [Yet Another Podcast with Jesse Liberty - May 2021](http://jesseliberty.com/2021/05/16/mark-price-on-c9-and-net-6/)
- [The .NET Core Podcast - February 7, 2020](https://dotnetcore.show/episode-44-learning-net-core-with-mark-j-price/)
- [Yet Another Podcast with Jesse Liberty - February 2020](http://jesseliberty.com/2020/02/23/mark-price-c-net-core/)
- [Packt Podcasts](https://soundcloud.com/packt-podcasts/csharp-8-dotnet-core-3-the-evolution-of-the-microsoft-ecosystem)

Written interviews with me:
- [C# 9 and .NET 5: Book Review and Q&A](https://www.infoq.com/articles/book-interview-mark-price/?itm_source=infoq&itm_campaign=user_page&itm_medium=link)
- [Q&A with Episerver's Mark J. Price, author of C# 9 and .NET 5 - Modern Cross-Platform Development](https://www.episerver.com/articles/q-and-a-with-mark-price)

![Apps and Services with .NET 10 cover](B31467_Cover.png)
