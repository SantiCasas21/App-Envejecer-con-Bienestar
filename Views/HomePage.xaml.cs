using EnvejecerConBienestar.ViewModels;

namespace EnvejecerConBienestar.Views;

public partial class HomePage : ContentPage
{
    public HomePage(HomeViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    // Navegar a la pestaña de Medicamentos al pulsar el acceso rápido
    private async void OnVerMedicamentosClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//medicamentos");
    }
}
