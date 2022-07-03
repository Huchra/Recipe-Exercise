using Spectre.Console;

namespace Exercise_1
{
    class Program
    {
        public static void Main()
        {
            Manipulator manipulator = new Manipulator();

            var recipeTable = new Table()
                .Border(TableBorder.Rounded)
                .Title("[underline]Recipes")
                .Expand();

            if (manipulator.Recipes.Count > 0)
            {
                recipeTable
                    .AddColumn(new TableColumn("Title"))
                    .AddColumn(new TableColumn("Ingredients"))
                    .AddColumn(new TableColumn("Instructions"))
                    .AddColumn(new TableColumn("Categories"))
                    .Centered();

                foreach (Recipe recipe in manipulator.Recipes)
                {

                }
            }
           
            AnsiConsole.Write(recipeTable);



        }
    }

}
