**Improvements** (2 items)

If you have suggestions for improvements, then please [raise an issue in this repository](https://github.com/markjprice/apps-services-net8/issues) or email me at markjprice (at) gmail.com.

- [Page 38 - Treating warnings as errors](#page-38---treating-warnings-as-errors)
- [Page 40 - Installing Docker and an SQL Server container image](#page-40---installing-docker-and-an-sql-server-container-image)


# Page 38 - Treating warnings as errors

> Thanks to [Kris](https://github.com/kprikratki) for raising [this issue on March 11, 2026](https://github.com/markjprice/apps-services-net10/issues/9) that suggested this improvement.

Kris said, "`Treating warnings as errors` - This topic is pretty "unexpected" at that point in the book. It might be better suited once the first `.csproj` file is actually created - for beginners it might come as a surprise where to find these settings."

I might remove this section completely in the next edition since I explain it in my fundamentals book and I expect the more intermediate readers of my *Apps and Services* book to already know it. I included it mostly as a reminder. Or I might move it to an online-only section about good practice linked at the end of the chapter.

# Page 40 - Installing Docker and an SQL Server container image

> Thanks to [DrAvriLev](https://github.com/DrAvriLev) for raising [this issue on March 16, 2026](https://github.com/markjprice/apps-services-net10/issues/10) that suggested this improvement.

In the next edition, I will add a note to explain that although I provide SQL scripts to set up the Northwind database on any of: a Docker container, a local SQL Server, or SQL Azure in the cloud, one reason that I recommend using Docker for the SQL Server is because experience with Docker is an important developer skill and the reader can also use Docker to set up other containers for use later in the book. 

For example, in *Chapter 11, Caching, Queuing, and Resilient Background Services*, the reader will set up RabbitMQ in a Docker container to implement queuing, and there is an optional exercise to implement Redis for distributed caching. Of course, if the reader already has SQL Server installed locally, they can use it instead of a Docker-hosted SQL Server. And/or if the reader already has or is willing to install Redis and RabbitMQ locally then they don't need Docker for those either. 

