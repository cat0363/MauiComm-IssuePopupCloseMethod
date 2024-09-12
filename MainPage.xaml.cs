using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Views;

namespace MauiComm_IssuePopupCloseMethod
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnClose_Clicked(object sender, EventArgs e)
        {
            TestPopup1 popup = new TestPopup1();
            App.Current.MainPage.ShowPopup(popup);
        }

        private void btnCloseAsync_Clicked(object sender, EventArgs e)
        {
            TestPopup2 popup = new TestPopup2();
            App.Current.MainPage.ShowPopup(popup);
        }
    }

}
