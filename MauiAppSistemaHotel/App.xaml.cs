
using MauiAppSistemaHotel.Models;

namespace MauiAppSistemaHotel
{
    public partial class App : Application
    {

        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suite Cobertura",
                ValorDiariaAdulto = 550,
                ValorDiariaCrianca = 180
            },
            new Quarto()
            {
                Descricao = "Suite com Varanda",
                ValorDiariaAdulto = 270,
                ValorDiariaCrianca = 90
            },
            new Quarto()
            {
                Descricao = "Suite Standart",
                ValorDiariaAdulto = 190,
                ValorDiariaCrianca = 40
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 700;
            return window;
        }
    }
}
