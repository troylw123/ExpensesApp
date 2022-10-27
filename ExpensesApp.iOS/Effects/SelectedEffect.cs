using ExpensesApp.iOS.Effects;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("DMI")]
[assembly: ExportEffect(typeof(SelectedEffect), "SelectedEffect")]
namespace ExpensesApp.iOS.Effects
{
    public class SelectedEffect : PlatformEffect
    {

        UIColor selectedColor;
        protected override void OnAttached()
        {
            selectedColor = UIColor.SystemBlue;
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if (args.PropertyName == "IsFocused")
            {
                if (Control.BackgroundColor != selectedColor)
                {
                    Control.BackgroundColor = selectedColor;
                }
            }
            else
            {
                Control.BackgroundColor = UIColor.White;
            }
        }

        protected override void OnDetached()
        {

        }
    }
}