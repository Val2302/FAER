using Faer.Src.Controllers;
using Faer.Src.Views;

using System.Windows.Forms;

namespace Faer.Src.Contexts
{
    public class MainContext : ApplicationContext
    {
        private readonly MainController Contorller;

        public MainContext()
        {
            MainForm = new MainForm();
            Contorller = new MainController(MainForm);
        }
    }
}
