namespace CadastroEventos_TrabalhoEtec.Resources.Views;

public partial class EventoCadastrado : ContentPage
{
	public EventoCadastrado()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {

            App.Current.MainPage = new NavigationPage(new CadastrarEvento());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Fechar");
        }
    }
}