using ViagemOnboardingPage.ViewModels;

namespace ViagemOnboardingPage.Views;

public partial class ViagemPage : ContentPage
{
	public ViagemPage(ViagemOnboardingViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}