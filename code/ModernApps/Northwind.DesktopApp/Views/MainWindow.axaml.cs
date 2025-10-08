using Avalonia.Controls;

namespace Northwind.DesktopApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

  private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
  {
    DockPanelWindow dpw = new();
    dpw.Show();
  }

  private void ExitMenu_Click(object? sender,
    Avalonia.Interactivity.RoutedEventArgs e)
  {
    Close();
  }

}