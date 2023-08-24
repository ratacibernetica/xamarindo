using Android.Net.Http;
using Android.Webkit;

namespace AwesomeApp.Droid
{
    public class CustomWebViewClient : WebViewClient
    {
        public override void OnReceivedSslError(Android.Webkit.WebView view, SslErrorHandler handler, SslError error)
        {
            // Ignore SSL errors and continue loading
            handler.Proceed();
        }
    }
}