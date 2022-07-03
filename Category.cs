

namespace Exercise_1
{
    // This class should serve as a singleton instance of all categories for validation.
    // TODO: implement as a singleton class.
    public class Category
    {
        private Dictionary<string, bool> _categories { get; set; }

        public Category(Dictionary<string, bool> categories)
        {
            _categories = categories;
        }

        public bool AddCategory(string category)
        {
            ArgumentNullException.ThrowIfNull(category);

            if (!_categories.ContainsKey(category))
                return false;
            else _categories.Add(category, true);

            return true;
        }

        // TODO: Edit recipe references from old category to new category.
        public bool EditCategory(string oldCategoryName, string newCategoryName)
        {
            ArgumentNullException.ThrowIfNull(oldCategoryName);
            ArgumentNullException.ThrowIfNull(newCategoryName);

            if (!_categories.ContainsKey(oldCategoryName))
                return false;

            _categories.Remove(oldCategoryName);
            _categories.Add(newCategoryName, true);

            return true;
        }
        
        // TODO: Decide how to manage removed category recipes.
        public bool RemoveCategory(string categoryName)
        {
            ArgumentNullException.ThrowIfNull(categoryName);

            if (!_categories.ContainsKey(categoryName))
                return false;

            return _categories.Remove(categoryName);
        }
    }
}
