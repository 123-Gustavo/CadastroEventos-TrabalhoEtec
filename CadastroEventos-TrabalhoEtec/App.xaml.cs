using CadastroEventos_TrabalhoEtec.Resources.Views;

namespace CadastroEventos_TrabalhoEtec
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CadastrarEvento());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 500;
            window.Height = 900;

            return window;
        }
    }
}