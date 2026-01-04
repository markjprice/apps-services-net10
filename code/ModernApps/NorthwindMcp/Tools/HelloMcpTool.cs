using ModelContextProtocol.Server; // To use [McpServerToolType] and [McpServerTool].
using System.ComponentModel; // To use [Description].

[McpServerToolType]
public static class HelloMcpTool
{
  [McpServerTool]
  [Description("Responds with a greeting back to the client.")]
  public static string HelloMcp(string name) => $"Hello, {name}";
}
