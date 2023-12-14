namespace WebViewIssue
{
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
            BindingContext = new WebViewPageViewModel();
        }

    }

}
