using CommunityToolkit.Maui.Views;

namespace MauiComm_IssuePopupCloseMethod;

public partial class TestPopup2 : Popup
{
	public TestPopup2()
	{
		InitializeComponent();
	}

	async void btnClose_Clicked(object sender, EventArgs e)
	{
		await this.CloseAsync();
	}
}