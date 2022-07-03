using Microsoft.AspNetCore.Components.WebView;
using Microsoft.Extensions.DependencyInjection;
namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void BlazorWebView_BlazorWebViewInitializing(object sender, Microsoft.AspNetCore.Components.WebView.BlazorWebViewInitializingEventArgs e)
	{
       
    }

	private void BlazorWebView_BlazorWebViewInitialized(object sender, Microsoft.AspNetCore.Components.WebView.BlazorWebViewInitializedEventArgs e)
	{
	}

	private async void BlazorWebView_UrlLoading(object sender, UrlLoadingEventArgs e)
	{
        if (e.Url.Host != "0.0.0.0")
        {
            e.UrlLoadingStrategy = UrlLoadingStrategy.CancelLoad;
            await Navigation.PushAsync(new WebViewPage(e.Url));
        }
    }
}
