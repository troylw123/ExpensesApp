using Android.Content;
using Android.Views;
using ExpensesApp.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TextCell), typeof(CustomTextCellRenderer))]
namespace ExpensesApp.Droid.CustomRenderers
{
    public class CustomTextCellRenderer : TextCellRenderer
    {
        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            var cell = base.GetCellCore(item, convertView, parent, context);

            switch (item.StyleId)
            {
                case "none":
                    cell.SetBackgroundColor(Android.Graphics.Color.DarkRed);
                    break;
                case "checkmark":
                    cell.SetBackgroundColor(Android.Graphics.Color.GhostWhite);
                    break;
                case "detail-button":
                    cell.SetBackgroundColor(Android.Graphics.Color.DarkSalmon);
                    break;
                case "detail-disclosure-button":
                    cell.SetBackgroundColor(Android.Graphics.Color.DarkViolet);
                    break;
                case "disclosure":
                default:
                    cell.SetBackgroundColor(Android.Graphics.Color.LightGray);
                    break;
            }

            return cell;
        }
    }
}