using Northwind.EntityModels; // To use Category and Product.
using System.Collections.ObjectModel; // To use ObservableCollection<T>.
using System.Linq; // To use LINQ methods.

namespace Northwind.DesktopApp.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public string Greeting { get; } = "Welcome to Apps and Services with .NET 10 with Avalonia!";

        public ObservableCollection<CategoryViewModel> Categories { get; } = [];
        public ObservableCollection<Product> Products { get; } = [];

        private CategoryViewModel? _selectedCategory;

        public CategoryViewModel? SelectedCategory
        {
            get => _selectedCategory;
            set
            {
                if (!SetProperty(ref _selectedCategory, value))
                    return;

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
            using NorthwindContext db = new();

            CategoryViewModel[]? categories = db.Categories
              .Select(c => new CategoryViewModel
              {
                  CategoryId = c.CategoryId,
                  CategoryName = c.CategoryName,
                  Description = c.Description,
                  Picture = c.Picture,
                  Products = c.Products
              }).ToArray();

            if (categories is null)
                return;

            foreach (CategoryViewModel category in categories)
            {
                Categories.Add(category);
            }

            SelectedCategory = Categories[0];
        }
    }
}
