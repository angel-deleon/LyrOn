using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LyrOn
{
    public partial class ListaCanciones : ContentPage
    {
        public ListaCanciones()
        {
            InitializeComponent();

            songList.ItemsSource = App.songs.listSongs;

            songList.ItemSelected += (sender, e) =>
            {
                var item = e.SelectedItem;
                DisplayAlert("Seleccionado", "elemento seleccionado: " + item.ToString(), "Entendido");
            };

        }
    }
}
