using Xamarin.Forms;

namespace DoytaoThai
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            WebView.GoBack();
            return true;
        }
    }
}
