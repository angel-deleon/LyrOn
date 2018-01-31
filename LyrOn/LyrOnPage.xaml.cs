using System;
using Xamarin.Forms;

namespace LyrOn
{
    public partial class LyrOnPage : ContentPage
    {
        public LyrOnPage()
        {
            InitializeComponent();

            btnMostrar.Clicked += (sender, e) =>
            {
                // Pasar a la pantalla con la lista de canciones.
                Navigation.PushAsync(new ListaCanciones());
            };

            btnBuscar.Clicked += (sender, e) =>
            {
                // Pasar a la pantalla de búsqueda.
                Navigation.PushAsync(new ConsultaCanciones());
            };

        }

    }
}
