using Android.Content;
using AwesomeApp.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(WebView), typeof(SSLBypassWebViewRenderer))]
namespace AwesomeApp.Droid
{
    public class SSLBypassWebViewRenderer : WebViewRenderer
    {
        public SSLBypassWebViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // Enable JavaScript and handle SSL bypass
                Control.Settings.JavaScriptEnabled = true;
                Control.SetWebViewClient(new CustomWebViewClient());
            }
        }
    }
}
