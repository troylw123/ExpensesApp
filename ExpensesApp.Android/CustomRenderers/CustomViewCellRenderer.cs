using Android.Content;
using Android.Graphics.Drawables;
using Android.Views;
using ExpensesApp.Droid.CustomRenderers;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ViewCell), typeof(CustomViewCellRenderer))]
namespace ExpensesApp.Droid.CustomRenderers
{
    public class CustomViewCellRenderer : ViewCellRenderer
    {
        private Android.Views.View _cell;
        private bool _isSelected;
        private Drawable _defaultBackground;

        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            _cell = base.GetCellCore(item, convertView, parent, context);
            _isSelected = false;
            _defaultBackground = _cell.Background;
            _cell.SetBackgroundColor(Android.Graphics.Color.Transparent);

            return _cell;
        }

        protected override void OnCellPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnCellPropertyChanged(sender, e);

            if (e.PropertyName == "IsSelected")
            {
                _isSelected = !_isSelected;

                if (_isSelected)
                {
                    _cell.SetBackgroundColor(Android.Graphics.Color.Gray);
                }
                else
                {
                    _cell.SetBackgroundColor(Android.Graphics.Color.Transparent);
                }
            }
        }
    }
}