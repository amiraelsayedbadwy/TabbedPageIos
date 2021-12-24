using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabbedPageIos
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            SelectedTabColor = Color.FromHex("#15544C");
            UnselectedTabColor = Color.FromHex("#989b9a");

            NavigationPage shackBuyPage = new NavigationPage(new MyPage());
            shackBuyPage.IconImageSource = "buy.png";
            shackBuyPage.Title = "ShackBuy";
            shackBuyPage.BarTextColor = Color.FromHex("#15544C");

            NavigationPage buyPage = new NavigationPage(new MyPage2());
            buyPage.IconImageSource = "search.png";
            buyPage.Title = "Search";
            buyPage.BarTextColor = Color.FromHex("#15544C");
            NavigationPage listingPage = new NavigationPage(new MyPage3());
            listingPage.IconImageSource = "listing.png";
            listingPage.Title = "Sell";
            listingPage.BarTextColor = Color.FromHex("#15544C");
            NavigationPage settingsPage = new NavigationPage(new MyPage());
            settingsPage.IconImageSource = "settings.png";
            settingsPage.Title = "Account";
            settingsPage.BarTextColor = Color.FromHex("#15544C");
            Children.Add(shackBuyPage);
            Children.Add(buyPage);
            Children.Add(listingPage);
            Children.Add(settingsPage);

        }
    }
}
