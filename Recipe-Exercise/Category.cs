

namespace Exercise_1
{
    // This class should serve as a singleton instance of all categories for validation.
    // TODO: implement as a singleton class.
    public class Category
    {
        public Dictionary<string, bool> Categories { get; set; }

        public Category(Dictionary<string, bool> categories)
        {
            Categories = categories;
        }

        public bool AddCategory(string category)
        {
            ArgumentNullException.ThrowIfNull(category);

            if (!Categories.ContainsKey(category))
            {
                Categories.Add(category, true);
                return true;
            }
            else return false;
        }

        // TODO: Edit recipe references from old category to new category.
        public bool EditCategory(string oldCategoryName, string newCategoryName)
        {
            ArgumentNullException.ThrowIfNull(oldCategoryName);
            ArgumentNullException.ThrowIfNull(newCategoryName);

            if (!Categories.ContainsKey(oldCategoryName))
                return false;

            Categories.Remove(oldCategoryName);
            Categories.Add(newCategoryName, true);

            return true;
        }
        
        // TODO: Decide how to manage removed category recipes.
        public bool RemoveCategory(string categoryName)
        {
            ArgumentNullException.ThrowIfNull(categoryName);

            if (!Categories.ContainsKey(categoryName))
                return false;

            return Categories.Remove(categoryName);
        }
    }
}
