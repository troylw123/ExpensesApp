using CoreGraphics;
using ExpensesApp.iOS.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ProgressBar), typeof(CustomProgressBarRenderer))]
namespace ExpensesApp.iOS.CustomRenderers
{
    public class CustomProgressBarRenderer : ProgressBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ProgressBar> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement.Progress <= 0)
                Control.ProgressTintColor = Color.Black.ToUIColor();
            else if (e.NewElement.Progress < 0.25)
                Control.ProgressTintColor = Color.Green.ToUIColor();
            else if (e.NewElement.Progress < 0.5)
                Control.ProgressTintColor = Color.Blue.ToUIColor();
            else if (e.NewElement.Progress < 0.75)
                Control.ProgressTintColor = Color.Yellow.ToUIColor();
            else
                Control.ProgressTintColor = Color.Red.ToUIColor();

            LayoutSubviews();
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            float x = 1.0f;
            float y = 4.0f;

            CGAffineTransform transform = CGAffineTransform.MakeScale(x, y);
            Transform = transform;
        }
    }
}