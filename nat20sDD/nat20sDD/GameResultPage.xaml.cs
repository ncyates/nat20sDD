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
        public GameResultPage(Game game)
        {
            InitializeComponent();
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

            var newGame = new Button { Text = "Return Home" };

            newGame.Clicked += delegate
            {
                Game g = new Game();
                App.Current.MainPage = new TabbedPage
                {
                    Children =
                    {
                        new NavigationPage(new nat20sDD.MainPage(g))
                        {
                            Title = "Home",
                            Icon = Device.OnPlatform<string>("tab_feed.png", null, null)
                        },
                        new NavigationPage(new nat20sDD.AboutPage())
                        {
                            Title = "About",
                            Icon = Device.OnPlatform<string>("tab_about.png", null, null)
                        },
                        new NavigationPage(new nat20sDD.SettingsPage(g))
                        {
                            Title = "Settings",
                            Icon = Device.OnPlatform<string>("tab_about.png", null, null)
                        },
                    }
                };
            };

            var charPic1 = new Image
            {
                Source = game.heroes[0].imgUri,
                WidthRequest = 100,
                HeightRequest = 100,
            };
            var charPic2 = new Image
            {
                Source = game.heroes[1].imgUri,
                WidthRequest = 100,
                HeightRequest = 100,
            };
            var charPic3 = new Image
            {
                Source = game.heroes[2].imgUri,
                WidthRequest = 100,
                HeightRequest = 100,
            };
            var charPic4 = new Image
            {
                Source = game.heroes[3].imgUri,
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
                Children = { title, gameScore, grid, newGame }
            };

        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Navigation.PopModalAsync();
        }
    }
}
