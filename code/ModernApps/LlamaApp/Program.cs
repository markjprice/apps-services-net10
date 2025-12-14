using OllamaSharp; // To use OllamaApiClient.
using OllamaSharp.Models; // To use Model.
using Spectre.Console; // To use Table.
using System.Diagnostics; // To use Stopwatch.

// Default port for the Ollama API is 11434.
string port = "11434";
Uri uri = new($"http://localhost:{port}");

OllamaApiClient ollama = new(uri);

Table table = new();
table.AddColumn("Name");
table.AddColumn("Size");

// Get the list of models.
IEnumerable<Model> models = await ollama.ListLocalModelsAsync();
foreach (Model model in models)
{
  table.AddRow(model.Name, model.Size.ToString("N0"));
}

AnsiConsole.Write(table);

string modelName = "llama3.1:latest";

WriteLine();
WriteLine($"Selected model: {modelName}");
ollama.SelectedModel = modelName;

ConsoleKey key = ConsoleKey.A;

while (key is not ConsoleKey.X)
{
  Write("Please enter your prompt: ");
  string? prompt = ReadLine();
  if (string.IsNullOrWhiteSpace(prompt))
  {
    WriteLine("Prompt is required. Exiting the app.");
    return;
  }

  Stopwatch timer = Stopwatch.StartNew();

  await foreach (GenerateResponseStream? response in
    ollama.GenerateAsync(prompt))
  {
    Write(response?.Response);
  }

  timer.Stop();
  WriteLine();
  WriteLine($"Elapsed time: {timer.ElapsedMilliseconds:N0} ms");
  timer.Restart();

  WriteLine();
  WriteLine("Press X to exit or any other key to ask another question.");
  key = ReadKey(intercept: true).Key;
}
