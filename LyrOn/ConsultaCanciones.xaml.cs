using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LyrOn
{
    public partial class ConsultaCanciones : ContentPage
    {
        private string artista, cancion, texto;

        public ConsultaCanciones()
        {
            InitializeComponent();

            btnBuscarAutorNombre.Clicked += (sender, e) =>
            {
                // Busqueda por autor y nombre
                string art, can;
                art = txtArtista.Text;
                can = txtCancion.Text;
                DisplayAlert("Búsqueda", "Artista: " + art + ", Cancion: " + can, "Entendido");

            };

            btnBuscarLetra.Clicked += (sender, e) =>
            {
                // Búsqueda por letra
                string let;
                let = txtLetra.Text;
                DisplayAlert("Búsqueda", "Letra: " + let, "Entendido");

            };

        }
    }
}
