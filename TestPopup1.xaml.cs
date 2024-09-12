using CommunityToolkit.Maui.Views;

namespace MauiComm_IssuePopupCloseMethod;

public partial class TestPopup1 : Popup
{
	public TestPopup1()
	{
		InitializeComponent();
	}

	void btnClose_Clicked(object sender, EventArgs e)
	{
		this.Close();
	}
}