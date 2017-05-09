using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace nat20sDD
{
    class CharPage : ContentPage
    {



        public CharPage(Hero C)
        {

            var title = new Label
            {
                Text = "Character Detail Page",
                FontSize = 28,
            };

            var name = new Label
            {
                Text = C.getName(),
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center,
            };
            var lvl = new Label
            {
                Text = "Level" + C.getLvl(),
                FontSize = 18,
            };

            var lvlProg = new ProgressBar
            {
                Progress = .3,
            };

            StackLayout level = new StackLayout
            {
                Children = { lvl, lvlProg },
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };



            var health = new Label
            {
                Text = "Hp - " + C.getHP(),
            };

            var str = new Label
            {
                Text = "Str- " + +C.getStr(),
            };

            var spd = new Label
            {
                Text = "Spd - 10"
            };


            var def = new Label
            {
                Text = "Def - 10"
            };

            var dex = new Label
            {
                Text = "Dex - 10"
            };

            StackLayout stats = new StackLayout
            {
                Children = { health, str, spd, def, dex },
                VerticalOptions = LayoutOptions.EndAndExpand,
            };

            var charPic = new Image
            {
                Source = "https://s-media-cache-ak0.pinimg.com/originals/dd/ac/24/ddac24e8b1291f8f27d9826cb9b54f94.jpg",
                WidthRequest = 100,
                HeightRequest = 200,
                VerticalOptions = LayoutOptions.Center,
            };

            StackLayout mid = new StackLayout
            {
                Children = { stats, charPic },
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            var score = new Label
            {
                Text = "Score - 10,495",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
            };
            var invButton = new Button { Text = "Show Inventory", VerticalOptions = LayoutOptions.EndAndExpand, HorizontalOptions = LayoutOptions.Center, };

            invButton.Clicked += delegate
            {
                Navigation.PushModalAsync(new MainPage());
            };

            Content = new StackLayout
            {
                Children = { title, name, level, mid, score, invButton },
                HorizontalOptions = LayoutOptions.CenterAndExpand,

            };

        }




    }
}
