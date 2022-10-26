using Android.Content;
using ExpensesApp.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(Xamarin.Forms.ProgressBar), typeof(CustomProgressBarRenderer))]
namespace ExpensesApp.Droid.CustomRenderers
{
    public class CustomProgressBarRenderer : ProgressBarRenderer
    {
        public CustomProgressBarRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ProgressBar> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement.Progress <= 0)
                Control.ProgressDrawable.SetTint(Color.Black.ToAndroid());
            else if (e.NewElement.Progress < 0.25)
                Control.ProgressDrawable.SetTint(Color.Green.ToAndroid());
            else if (e.NewElement.Progress < 0.5)
                Control.ProgressDrawable.SetTint(Color.Blue.ToAndroid());
            else if (e.NewElement.Progress < 0.75)
                Control.ProgressDrawable.SetTint(Color.Orange.ToAndroid());
            else
                Control.ProgressDrawable.SetTint(Color.Red.ToAndroid());

            Control.ScaleY = 4.0f;
        }
    }
}