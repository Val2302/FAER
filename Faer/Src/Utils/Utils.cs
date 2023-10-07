
using System.Windows.Forms;

namespace Faer.Src.Utils
{
    public static class Utils
    {
        public static bool IsWrittenName(TextBox name)
        {
            return !string.IsNullOrEmpty(name.Text);
        }

        public static bool IsWrittenDate(DateTimePicker date)
        {
            return !string.IsNullOrEmpty(date.Text);
        }
    }
}
