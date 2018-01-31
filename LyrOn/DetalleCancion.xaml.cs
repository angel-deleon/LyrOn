using System;
using System.Collections.Generic;
using LyrOn.Classes;
using Xamarin.Forms;

namespace LyrOn
{
    public partial class DetalleCancion : ContentPage
    {

        public Song song;

        public DetalleCancion(Song song, bool canBeAdded)
        {
            this.song = song;
            this.BindingContext = this.song;
            InitializeComponent();

            if(canBeAdded) {
                btnAgrega.IsVisible = true;
            }

            btnAgrega.Clicked += (sender, e) =>
            {
                // Agrega a la lista de canciones
                App.songs.listSongs.Add(song);
                // Regresar a la pantalla principal.
                Navigation.PopToRootAsync();
            };

        }

    }
}
