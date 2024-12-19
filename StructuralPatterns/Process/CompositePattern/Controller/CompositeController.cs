using StructuralPatterns.Process.CompositePattern.Model;
using StructuralPatterns.Process.CompositePattern.View;

namespace StructuralPatterns.Process.CompositePattern.Controller
{
    public class CompositeController
    {
        public static void ComposeMenu()
        {
            var menu = new Menu();
            var option = CompositeMenu.Show(menu);

            while (option != 3)
            {
                switch (option)
                {
                    case 1:
                        CompositeMenu.AddItem(menu);
                        break;
                    case 2:
                        CompositeMenu.DisplayMenu(menu);
                        break;
                    default:
                        break;
                }
                option = CompositeMenu.Show(menu);
            }
        }
    }
}
