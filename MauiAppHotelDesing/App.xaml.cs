using Microsoft.Extensions.DependencyInjection;

namespace MauiAppHotelDesing
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Mudando o tamanho da janela de inicialização para 400x600

            var window = base.CreateWindow(activationState);
            
            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}