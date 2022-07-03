using Microsoft.AspNetCore.Components.WebView;

namespace MauiApp1;

public partial class WebViewPage : ContentPage
{
    public WebViewPage(Uri uri)
    {
        InitializeComponent();

        //webView.Source = uri;
        rootComponent.Parameters = new Dictionary<string, object>
        {
            {"uri",uri }
        };
    }

    private void BlazorWebView_UrlLoading(object sender, Microsoft.AspNetCore.Components.WebView.UrlLoadingEventArgs e)
    {
        if (e.Url.Host != "0.0.0.0")
        {
            e.UrlLoadingStrategy = UrlLoadingStrategy.OpenInWebView;
        }
    }
}