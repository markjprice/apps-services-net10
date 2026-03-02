**Command-Lines**

To make it easier to enter commands at the prompt, this page lists all commands as a single line that can be copied and pasted. 

- [Chapter 1 - Introducing Apps and Services with .NET](#chapter-1---introducing-apps-and-services-with-net)
  - [Page 19 - Managing Visual Studio Code extensions at the command prompt](#page-19---managing-visual-studio-code-extensions-at-the-command-prompt)
  - [Page 20 - Using other project templates](#page-20---using-other-project-templates)
  - [Page 25 - Defining project properties to reuse version numbers](#page-25---defining-project-properties-to-reuse-version-numbers)
  - [Page 40 - Installing Docker and an SQL Server container image](#page-40---installing-docker-and-an-sql-server-container-image)
  - [Page 42 - Running the SQL Server container image](#page-42---running-the-sql-server-container-image)
  - [Page 50 - Removing Docker resources](#page-50---removing-docker-resources)
  - [Page 50 - Setting up the EF Core CLI tool](#page-50---setting-up-the-ef-core-cli-tool)
  - [Page 52 - Creating a class library for entity models](#page-52---creating-a-class-library-for-entity-models)
  - [Page 58 - Setting the user and password for SQL Server authentication](#page-58---setting-the-user-and-password-for-sql-server-authentication)
  - [Page 66 - Getting help for the dotnet tool](#page-66---getting-help-for-the-dotnet-tool)
- [Chapter 2 - Buildling Mobile Apps Using .NET MAUI](#chapter-2---buildling-mobile-apps-using-net-maui)
  - [Page 86 - Installing .NET MAUI workloads manually](#page-86---installing-net-maui-workloads-manually)
  - [Page 99 - Adding shell navigation and more content pages](#page-99---adding-shell-navigation-and-more-content-pages)
  - [Page 104 - Defining resources to share across an app](#page-104---defining-resources-to-share-across-an-app)
- [Chapter 3 - Building Desktop Apps Using Avalonia](#chapter-3---building-desktop-apps-using-avalonia)
  - [Page 122 - Installing the Avalonia project templates](#page-122---installing-the-avalonia-project-templates)
- [Chapter 4 - Building Web Apps Using Blazor](#chapter-4---building-web-apps-using-blazor)
  - [Page 161 - Reviewing the new Blazor project template](#page-161---reviewing-the-new-blazor-project-template)
  - [Page 167 - Reviewing the new Blazor project template](#page-167---reviewing-the-new-blazor-project-template)
- [Chapter 9 - Building an LLM-Based Chat Service](#chapter-9---building-an-llm-based-chat-service)
  - [Page 385 - Understanding the AI Chat Web App project template](#page-385---understanding-the-ai-chat-web-app-project-template)
  - [Page 387 - Building the chat app](#page-387---building-the-chat-app)
  - [Page 408 - Ollama models](#page-408---ollama-models)
  - [Page 409 - Ollama CLI](#page-409---ollama-cli)
- [Chapter 10 - Building and Securing Web Services Using Minimal APIs](#chapter-10---building-and-securing-web-services-using-minimal-apis)
  - [Page 488 - Authenticating service clients using JWT bearer authentication](#page-488---authenticating-service-clients-using-jwt-bearer-authentication)
- [Chapter 11 - Caching, Queuing, and Resilient Background Services](#chapter-11---caching-queuing-and-resilient-background-services)
  - [Page 528 - Setting up RabbitMQ using Docker](#page-528---setting-up-rabbitmq-using-docker)
  - [Page 544 - Processing queued message using a worker service](#page-544---processing-queued-message-using-a-worker-service)
- [Chapter 12 - Broadcasting Real-Time Communication Using SignalR](#chapter-12---broadcasting-real-time-communication-using-signalr)
  - [Page 570 - Building a web client using the SignalR JavaScript library](#page-570---building-a-web-client-using-the-signalr-javascript-library)
- [Chapter 13 - Combining Data Sources Using GraphQL](#chapter-13---combining-data-sources-using-graphql)
  - [Page 633 - Creating a console app client using Strawberry Shake](#page-633---creating-a-console-app-client-using-strawberry-shake)
- [Chapter 14 - Building Efficient Microservices Using gRPC](#chapter-14---building-efficient-microservices-using-grpc)
  - [Page 686 - Improving a gRPC service with native AOT publish](#page-686---improving-a-grpc-service-with-native-aot-publish)

# Chapter 1 - Introducing Apps and Services with .NET

## Page 19 - Managing Visual Studio Code extensions at the command prompt

```shell
code --list-extensions
```

```shell
code --install-extension ms-dotnettools.csdevkit
```

## Page 20 - Using other project templates

Listing all installed project templates:
```shell
dotnet new list
```

Installing a new project template:
```shell
dotnet new --install "Vue.Simple.Template"
```

## Page 25 - Defining project properties to reuse version numbers

After making changes, at the terminal or command prompt, run the following command:
```shell
dotnet restore
```

## Page 40 - Installing Docker and an SQL Server container image

Pull down the latest container image for SQL Server 2025, as shown in the following command:
```shell
docker pull mcr.microsoft.com/mssql/server:2025-latest
```

## Page 42 - Running the SQL Server container image

Run the container image for SQL Server with a strong password and name the container `nw-container`, as shown in the following command:
```shell
docker run --cap-add SYS_PTRACE -e 'ACCEPT_EULA=1' -e 'MSSQL_SA_PASSWORD=s3cret-Ninja' -p 1433:1433 --name nw-container -d mcr.microsoft.com/mssql/server:2025-latest
```

Ask Docker to list all containers, both running and stopped, as shown in the following command:
```shell
docker ps -a
```

## Page 50 - Removing Docker resources

Stop the `nw-container` container, as shown in the following command:
```shell
docker stop nw-container
```

Remove the `nw-container` container, as shown in the following command:
```shell
docker rm nw-container
```

Remove the image to release its disk space, as shown in the following command:
```shell
docker rmi mcr.microsoft.com/mssql/server:2025-latest
```

## Page 50 - Setting up the EF Core CLI tool

Check if you have already installed `dotnet-ef` as a global tool, as shown in the following command:
```shell
dotnet tool list --global
```

If an old version is installed, then update the tool, as shown in the following command:
```shell
dotnet tool update --global dotnet-ef
```

If it is not already installed, then install the latest version, as shown in the following command:
```shell
dotnet tool install --global dotnet-ef
```

To update to the latest .NET 11 preview or release candidate version (which will be available from February 2026 to October 2026), use the following command with a version wildcard:
```shell
dotnet tool update --global dotnet-ef --version 11.0-*
```

You can also remove the tool, as shown in the following command:
```shell
dotnet tool uninstall --global dotnet-ef
```

## Page 52 - Creating a class library for entity models

Generate entity class models for all tables, as shown in the following command:
```shell
dotnet ef dbcontext scaffold "Data Source=tcp:127.0.0.1,1433;Initial Catalog=Northwind;User Id=sa;Password=s3cret-Ninja;TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer --namespace Northwind.EntityModels --data-annotations
```

**Common connection strings**

Local SQL Server (default instance):
```
"Data Source=.;Initial Catalog=Northwind;Integrated Security=true;TrustServerCertificate=true;"
```

Local SQL Server (replace `<your_instance_name>` with named instance):
```
"Data Source=.\<your_instance_name>;Initial Catalog=Northwind;Integrated Security=true;TrustServerCertificate=true;"
```

Azure SQL Database (replace `<your_server_name>`, `<your_user_name>`, and `<your_password>`):
```
"Data Source=tcp:<your_server_name>.database.windows.net,1433;Initial Catalog=Northwind;User ID=<your_user_name>;Password=<your_password>;Persist Security Info=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;"
```

## Page 58 - Setting the user and password for SQL Server authentication

Set the two environment variables at the command prompt or terminal, as shown in the following commands:
- On Windows:
```shell
setx MY_SQL_USR <your_user_name>
setx MY_SQL_PWD <your_password>
```
- On macOS and Linux:
```shell
export MY_SQL_USR=<your_user_name>
export MY_SQL_PWD=<your_password>
```

## Page 66 - Getting help for the dotnet tool

Getting help for a `dotnet` command like `build` in a web browser:
```
dotnet help build
```

Getting help for a `dotnet` command like `build` at the command prompt:
```
dotnet build -?
```

# Chapter 2 - Buildling Mobile Apps Using .NET MAUI

## Page 86 - Installing .NET MAUI workloads manually

To see which workloads are currently installed, enter the following command:
```shell
dotnet workload list
```

To install the .NET MAUI workloads for all platforms, enter the following command at the command line or terminal:
```shell
dotnet workload install maui
```

To update all existing workload installations, enter the following command:
```shell
dotnet workload update
```

To add missing workload installations required for a project, in the folder containing the project file, enter the following command:
```shell
dotnet workload restore <projectname>
```

To remove leftover and unneeded workloads, as shown in the following command:
```shell
dotnet workload clean
```

## Page 99 - Adding shell navigation and more content pages

You can create this item using the CLI, as shown in the following command:
```shell
dotnet new maui-page-xaml --name SettingsPage.xaml
```

## Page 104 - Defining resources to share across an app

You can create this item using the CLI, as shown in the following command:
```shell
dotnet new maui-dict-xaml --name Northwind.xaml
```

# Chapter 3 - Building Desktop Apps Using Avalonia

## Page 122 - Installing the Avalonia project templates

To install the Avalonia project templates, as shown in the following command:
```shell
dotnet new install Avalonia.Templates
```

# Chapter 4 - Building Web Apps Using Blazor

## Page 161 - Reviewing the new Blazor project template

Create a new project using the Blazor Web App project template:
```
dotnet new blazor --interactivity None -o Northwind.Blazor
```

## Page 167 - Reviewing the new Blazor project template

Start the `Northwind.Blazor` project, using its `https` profile without debugging:
```shell
dotnet run --launch-profile https
```

# Chapter 9 - Building an LLM-Based Chat Service

## Page 385 - Understanding the AI Chat Web App project template

To install the AI Chat Web App project template, at the command prompt or terminal, enter the following command:
```shell
dotnet new install Microsoft.Extensions.AI.Templates
```

## Page 387 - Building the chat app

Add a user secrets entry for your OpenAI key, as shown in the following command:
```shell
dotnet user-secrets set OpenAi:Key <your-OpenAI-key>
```

## Page 408 - Ollama models

To quickly download and run an Ollama model in interactive mode, use the following command:
```shell
ollama run <model>
```

## Page 409 - Ollama CLI

To check its version, as shown in the following command:
```shell
ollama --version
```

To pull down a named model like Meta’s Llama3 or Google’s Gemma3, as shown in the following command:
```shell
ollama pull gemma3:1b
```

To list the available local models:
```shell
ollama list
```

To run a named model (which will also download it if not already pulled), as shown in the following command:
```shell
ollama run gemma3:1b
```

# Chapter 10 - Building and Securing Web Services Using Minimal APIs

## Page 488 - Authenticating service clients using JWT bearer authentication

Create a local JWT, as shown in the following command:
```shell
dotnet user-jwts create
```

Print all the information for the ID that was assigned, as shown in the following command:
```shell
dotnet user-jwts print d7e22000 --show-all
```

# Chapter 11 - Caching, Queuing, and Resilient Background Services

## Page 528 - Setting up RabbitMQ using Docker

Pull down the latest container image for RabbitMQ on Docker and run it, opening ports `5672` and `15672` to the container, which are used by default by AMQP, as shown in the following command:
```shell
docker run -it --rm --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.13.7-management
```

## Page 544 - Processing queued message using a worker service

Start the RabbitMQ container, as shown in the following command:
```shell
docker run -it --rm --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.13.7-management
```

# Chapter 12 - Broadcasting Real-Time Communication Using SignalR

## Page 570 - Building a web client using the SignalR JavaScript library

Install the Library Manager CLI tool, as shown in the following command:
```shell
dotnet tool install -g Microsoft.Web.LibraryManager.Cli
```

Add the `signalr.js` and `signalr.min.js` libraries to the project from the unpkg source, as shown in the following command:
```shell
libman install @microsoft/signalr@latest -p unpkg -d wwwroot/js/signalr --files dist/browser/signalr.js --files dist/browser/signalr.min.js
```

# Chapter 13 - Combining Data Sources Using GraphQL

## Page 633 - Creating a console app client using Strawberry Shake

Create a tools manifest file, as shown in the following command:
```shell
dotnet new tool-manifest
```

Install Strawberry Shake tools for the local project, as shown in the following command:
```shell
dotnet tool install StrawberryShake.Tools --local
```

Add a client for your GraphQL service, as shown in the following command:
```shell
dotnet graphql init https://localhost:5131/graphql/ -n NorthwindClient
```

# Chapter 14 - Building Efficient Microservices Using gRPC

## Page 686 - Improving a gRPC service with native AOT publish

Run `Northwind.Grpc.Service.exe` and explicitly specify the URL with the port number to use, as shown in the following command:
```shell
Northwind.Grpc.Service.exe --urls "https://localhost:5141"
```
