using Northwind.DesktopApp.Services; // To use DataService.
using System.Collections.ObjectModel; // To use ObservableCollection<T>.

namespace Northwind.DesktopApp.ViewModels
{
  public partial class MainWindowViewModel : ViewModelBase
  {
    public string Greeting { get; } = "Welcome to Apps and Services with .NET 10 with Avalonia!";

    public ObservableCollection<Category> Categories { get; } = [];
    public ObservableCollection<Product> Products { get; } = [];

    private Category? _selectedCategory;

    public Category? SelectedCategory
    {
      get => _selectedCategory;
      set
      {
        _selectedCategory = value;
        Products.Clear();
        if (value != null)
        {
          foreach (var product in value.Products)
            Products.Add(product);
        }
      }
    }

    public MainWindowViewModel()
    {
      Category[]? categories = DataService.LoadCategories();

      if (categories is null)
        return;

      foreach (Category category in categories)
      {
        Categories.Add(category);
      }

      SelectedCategory = Categories[0];
    }
  }
}
