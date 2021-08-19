using Xamarin.Forms;
using MarcTron.Plugin;

namespace franee
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CrossMTAdmob.Current.OnRewardedVideoAdLoaded += (s, args) =>
            {
                CrossMTAdmob.Current.ShowRewardedVideo();
            };

            CrossMTAdmob.Current.OnInterstitialLoaded += (s, args) =>
            {
                CrossMTAdmob.Current.ShowInterstitial();
            };
        }

        void Button_Clicked(object sender, System.EventArgs e)
        {
            CrossMTAdmob.Current.LoadRewardedVideo("ca-app-pub-1430833140613652/7977366946");
        }


        void Button_Clicked_1(object sender, System.EventArgs e)
        {
            CrossMTAdmob.Current.LoadInterstitial("ca-app-pub-1430833140613652/1911292671");
        }
    }
}
