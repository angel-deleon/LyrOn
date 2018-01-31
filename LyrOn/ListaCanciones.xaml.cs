using System;
using System.Collections.Generic;
using LyrOn.Classes;
using Xamarin.Forms;

namespace LyrOn
{
    public partial class ListaCanciones : ContentPage
    {
        public ListaCanciones()
        {
            InitializeComponent();

            songList.ItemsSource = App.songs.listSongs;
            songList.SelectedItem = null;

            songList.ItemSelected += (sender, e) =>
            {
                var item = e.SelectedItem as Song;
                Navigation.PushAsync(new DetalleCancion(item, false));
            };

        }
    }
}
