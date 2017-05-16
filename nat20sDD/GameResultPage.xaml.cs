using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace nat20sDD
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GameResultPage : ContentPage
	{
		public GameResultPage (Game game)
		{
			InitializeComponent ();
            var title = new Label
            {
                Text = "Game Result Page",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };

            var gameScore = new Label
            {
                Text = "Game Score: " + game.totalScore.ToString(),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
            };

            var hero1Score = new Label
            {
                Text = game.heroes[0].getName().ToString() + ": " + game.heroes[0].getScore().ToString()
            };

            var hero2Score = new Label
            {
                Text = game.heroes[1].getName().ToString() + ": " + game.heroes[1].getScore().ToString()
            };

            var hero3Score = new Label
            {
                Text = game.heroes[2].getName().ToString() + ": " + game.heroes[2].getScore().ToString()
            };

            var hero4Score = new Label
            {
                Text = game.heroes[3].getName().ToString() + ": " + game.heroes[3].getScore().ToString()
            };

            var homeBtn = new Button { Text = "Return Home" };

            homeBtn.Clicked += delegate
            {
                Game game1 = new Game();
                Navigation.PushModalAsync(new MainPage());
            };

            var charPic1 = new Image
            {
                Source = "https://s-media-cache-ak0.pinimg.com/originals/dd/ac/24/ddac24e8b1291f8f27d9826cb9b54f94.jpg",
                WidthRequest = 100,
                HeightRequest = 100,
            };
            var charPic2 = new Image
            {
                Source = "https://s-media-cache-ak0.pinimg.com/originals/dd/ac/24/ddac24e8b1291f8f27d9826cb9b54f94.jpg",
                WidthRequest = 100,
                HeightRequest = 100,
            };
            var charPic3 = new Image
            {
                Source = "https://s-media-cache-ak0.pinimg.com/originals/dd/ac/24/ddac24e8b1291f8f27d9826cb9b54f94.jpg",
                WidthRequest = 100,
                HeightRequest = 100,
            };
            var charPic4 = new Image
            {
                Source = "https://s-media-cache-ak0.pinimg.com/originals/dd/ac/24/ddac24e8b1291f8f27d9826cb9b54f94.jpg",
                WidthRequest = 100,
                HeightRequest = 100,
            };

            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            grid.Children.Add(charPic1, 0, 0);
            grid.Children.Add(charPic2, 1, 0);
            grid.Children.Add(charPic3, 2, 0);
            grid.Children.Add(charPic4, 3, 0);

            grid.Children.Add(hero1Score, 0, 1);
            grid.Children.Add(hero2Score, 1, 1);
            grid.Children.Add(hero3Score, 2, 1);
            grid.Children.Add(hero4Score, 3, 1);



            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 20,
                Children = { title, gameScore, grid, homeBtn }
            };
        }
        protected override void OnDisappearing()
        {
            Navigation.PopModalAsync();
            base.OnAppearing();
        }
    }
}
