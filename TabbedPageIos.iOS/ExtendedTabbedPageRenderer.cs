using System;
using TabbedPageIos.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(TabbedPage), typeof(ExtendedTabbedPageRenderer))]
namespace TabbedPageIos.iOS
{
    public class ExtendedTabbedPageRenderer : TabbedRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            if (TabBar?.Items == null)
                return;

            var tabs = Element as TabbedPage;
            if (tabs != null)
            {
                for (int i = 0; i < TabBar.Items.Length; i++)
                {
                    UpdateTabBarItem(TabBar.Items[i], tabs.Children[i].Icon);
                }
            }

            base.ViewWillAppear(animated);
        }

        private void UpdateTabBarItem(UITabBarItem item, string icon)
        {
            if (item == null || icon == null)
                return;

            // Set the font for the title.
            item.SetTitleTextAttributes(new UITextAttributes() { Font = UIFont.FromName("NunitoSans-Regular", 16), TextColor = Color.FromHex("#3C9BDF").ToUIColor() }, UIControlState.Selected);

            item.SetTitleTextAttributes(new UITextAttributes() { Font = UIFont.FromName("NunitoSans-Regular", 16), TextColor = Color.FromHex("#757575").ToUIColor() }, UIControlState.Normal);
        }
    }
}