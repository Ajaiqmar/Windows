using Microsoft.UI.Xaml.Controls;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IQEditor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private WebView2 WebViewControl = null;

        public MainPage()
        {
            this.InitializeComponent();
            InitialiseWebView2();
        }

        private void WebView2_Loading(FrameworkElement sender, object args)
        {
            
        }

        private async void InitialiseWebView2()
        {
            WebViewControl = new WebView2() { Name = "WebViewCtrl" };

            await WebViewControl.EnsureCoreWebView2Async();
            var path = Path.Combine(Environment.CurrentDirectory,"static/html/mailIndex.html");

            WebViewControl.Source = new Uri(path);
            WebViewControl.CoreWebView2Initialized += WebViewCtrl_CoreWebView2Initialized;
        }

        private void WebViewCtrl_CoreWebView2Initialized(WebView2 sender, CoreWebView2InitializedEventArgs args)
        {
            
        }

        private void OpenEditorBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenEditorBtn.Visibility = Visibility.Collapsed;
            WebViewBorder.Child = WebViewControl;
        }
    }
}
