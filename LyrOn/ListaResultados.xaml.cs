using System;
using System.Collections.Generic;
using LyrOn.Classes;
using Xamarin.Forms;

namespace LyrOn
{
    public partial class ListaResultados : ContentPage
    {
        public ListaResultados(List<SearchLyricResult> lista)
        {
            InitializeComponent();
            resultList.ItemsSource = lista;

            resultList.ItemSelected += async (sender, e) =>
            {
                var item = e.SelectedItem as SearchLyricResult;
                //await DisplayAlert("Seleccionado", "elemento seleccionado: " + item.ToString(), "Entendido");
                // Crear nueva canción
                SearchLyricResult search = item;
                LyricsWS lyricsWS = new LyricsWS();
                GetLyricResult lyricResult = await lyricsWS.GetSong(search.lyricId, search.lyricChecksum);
                Song song = new Song(lyricResult);
                // Pasarla
                await Navigation.PushAsync(new DetalleCancion(song, true));
            };

        }
    }
}
