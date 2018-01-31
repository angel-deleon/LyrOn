using System;
using System.Collections.Generic;
using LyrOn.Classes;
using Xamarin.Forms;

namespace LyrOn
{
    public partial class ConsultaCanciones : ContentPage
    {
        
        public ConsultaCanciones()
        {
            InitializeComponent();

            btnBuscarAutorNombre.Clicked += async (sender, e) =>
            {
                // Busqueda por autor y nombre
                string art, can;
                art = txtArtista.Text;
                can = txtCancion.Text;
                if (art == null || art.Length < 4)
                {
                    await DisplayAlert("Error en entrada", "Debe introducir al menos 4 caracteres en el autor", "Entendido");
                    return;
                }
                if (can == null || can.Length < 4)
                {
                    await DisplayAlert("Error en entrada", "Debe introducir al menos 4 caracteres en la canción", "Entendido");
                    return;
                }
                // Obtener la lista de canciones
                LyricsWS lyricsWS = new LyricsWS();
                List<SearchLyricResult> lista = await lyricsWS.ListSongs(art, can);
                // Mostrar el resultado
                showResult(lista);
            };

            btnBuscarLetra.Clicked += async (sender, e) =>
            {
                // Búsqueda por letra
                string let;
                let = txtLetra.Text;
                if (let == null || let.Length < 4) {
                    await DisplayAlert("Error en entrada", "Debe introducir al menos 4 caracteres", "Entendido");
                    return;
                }
                // Obtener la lista de canciones
                LyricsWS lyricsWS = new LyricsWS();
                List<SearchLyricResult> lista = await lyricsWS.ListSongs(let);
                // Mostrar el resultado
                showResult(lista);

            };

        }

        private void showResult(List<SearchLyricResult> lista) {
            if (lista.Count > 0) {
                Navigation.PushAsync(new ListaResultados(lista));
            } else {
                Navigation.PushAsync(new NoResults());
            }
        }

    }
}
