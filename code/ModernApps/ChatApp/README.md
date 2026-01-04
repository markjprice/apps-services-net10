# AI Chat with Custom Data

This project is an AI chat application that demonstrates how to chat with custom data using an AI language model. Please note that this template is currently in an early preview stage. If you have feedback, please take a [brief survey](https://aka.ms/dotnet-chat-templatePreview2-survey).

>[!NOTE]
> Before running this project you need to configure the API keys or endpoints for the providers you have chosen. See below for details specific to your choices.

# Configure the AI Model Provider
## Using OpenAI

To call the OpenAI REST API, you will need an API key. To obtain one, first [create a new OpenAI account](https://platform.openai.com/signup) or [log in](https://platform.openai.com/login). Next, navigate to the API key page and select "Create new secret key", optionally naming the key. Make sure to save your API key somewhere safe and do not share it with anyone.

Configure your API key for this project, using .NET User Secrets:

1. In Visual Studio, right-click on your project in the Solution Explorer and select "Manage User Secrets".
2. This will open a secrets.json file where you can store your API key without them being tracked in source control. Add the following key and value to the file:

   ```json
   {
     "OpenAI:Key": "YOUR-API-KEY"
   }
   ```

