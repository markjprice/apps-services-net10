﻿using Serilog; // To use Log, LoggerConfiguration, RollingInterval.
using Serilog.Core; // To use Logger.
using Serilogging.Models; // To use ProductPageView.

// Create a new logger that will write to the console and to
// a text file, one-file-per-day, named with the date.
using Logger log = new LoggerConfiguration()
    // console and file both executed on a background worker.
    .WriteTo.Async(a => a.Console())
    .WriteTo.Async(a => a.File("log.txt", rollingInterval: RollingInterval.Day))
    .CreateLogger();

// Assign the new logger to the static entry point for logging.
Log.Logger = log;
Log.Information("The global logger has been configured.");

// Log some example entries of differing severity.
Log.Warning("Danger, Serilog, danger!");
Log.Error("This is an error!");
Log.Fatal("Fatal problem!");

// Log an object with some properties.
ProductPageView pageView = new()
{
  PageTitle = "Chai",
  SiteSection = "Beverages",
  ProductId = 1
};

Log.Information("{@PageView} occurred at {Viewed}",
  pageView, DateTimeOffset.UtcNow);

// For a log with a buffer, like a text file logger, you
// must flush before ending the app.
Log.CloseAndFlush();
