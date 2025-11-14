using CadastroEventos_TrabalhoEtec.Resources.Models;

namespace CadastroEventos_TrabalhoEtec.Resources.Views;

public partial class CadastrarEvento : ContentPage
{
	public CadastrarEvento()
	{
        InitializeComponent();

        dtpck_datainicio.MinimumDate = DateTime.Now;
        dtpck_datainicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_datafim.MinimumDate = dtpck_datainicio.Date.AddDays(1);
        dtpck_datafim.MaximumDate = dtpck_datainicio.Date.AddMonths(6);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Button botao = (Button)sender;
            if (botao != null)
            {

                Evento ev = new Evento { 
                    nome = txt_nomeevento.Text,
                    dataInicio = dtpck_datainicio.Date,
                    dataFim = dtpck_datafim.Date,
                    local = txt_localevento.Text,
                    numeroParticipantes = int.Parse(txt_numeroparticipantes.Text),
                    valorIngresso = double.Parse(txt_valoringresso.Text),
                };

                App.Current.MainPage = new EventoCadastrado() { BindingContext = ev };
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Fechar");
        }
    }

    private void dtpck_datainicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;
        DateTime data_selecionada_checkinicio = elemento.Date;

        dtpck_datafim.MinimumDate = data_selecionada_checkinicio.AddDays(1);
        dtpck_datafim.MaximumDate = data_selecionada_checkinicio.AddMonths(6);
    }

    private void dtpck_datafim_DateSelected(object sender, DateChangedEventArgs e)
    {

    }
}