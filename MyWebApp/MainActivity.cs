using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;
using Java.Lang;
using Android.Views;

namespace MyWebApp
{
    [Activity(Label = "MyWebApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            this.RequestWindowFeature(WindowFeatures.NoTitle);
    
            this.Window.SetFlags(WindowManagerFlags.Fullscreen, WindowManagerFlags.Fullscreen);


            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //var webView = FindViewById<WebView>(Resource.Id.webView1);
            //申明WebView的配置
            //WebSettings settings = webView.Settings;
            //设置允许执行JS
          //  settings.JavaScriptEnabled = true;
            //设置可以通过JS打开窗口
          //  settings.JavaScriptCanOpenWindowsAutomatically = true;
            //这里是自己创建的WebView客户端类
           // var webc = new MyCommWebClient();
            //设置自己的WebView客户端
           // webView.SetWebViewClient(webc);

           // webView.LoadUrl("http://www.cnblogs.com/GuZhenYin/p/7016798.html");
        }
    }

    class MyCommWebClient : WebViewClient
    {
        //重写页面加载的方法
        public   override  bool  ShouldOverrideUrlLoading(WebView view, string url)
        {
            //使用本控件加载
            view.LoadUrl(url);
            //并返回true
            return true;
        }
    }
}

