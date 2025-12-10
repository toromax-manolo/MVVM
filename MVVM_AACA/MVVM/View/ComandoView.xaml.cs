using MVVM_AACA.MVVM.ViewModel;

namespace MVVM_AACA.MVVM.View;

public partial class ComandoView : ContentPage
{
	public ComandoView()
	{
		InitializeComponent();
		BindingContext = new ComandoViewModel();
	}

    
}