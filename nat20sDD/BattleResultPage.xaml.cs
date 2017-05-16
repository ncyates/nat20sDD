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
	public partial class BattleResultPage : ContentPage
	{
		public BattleResultPage (Game game)
        {
            InitializeComponent();

            

        var title = new Label
            {
                Text = "Battle Result Page",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };

            var gameScore = new Label
            {
                Text = "Game Score: " + game.totalScore.ToString(),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
            };

            var battleNumber = new Label
            {
                Text = "Number of Battles: " + game.battleCount.ToString(),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
            };

            var hero1Name = new Label
            {
                Text = game.heroes[0].getName().ToString()
            };
            var hero1Score = new Label
            {
                Text = "Score: " + game.heroes[0].getScore().ToString()
            };
            var hero1level = new Label
            {
                Text = "Level: " + game.heroes[0].getLvl().ToString()
            };
            var hero1HP = new Label
            {
                Text = "HP: " + game.heroes[0].getHP().ToString()
            };

            var hero2Name = new Label
            {
                Text = game.heroes[1].getName().ToString()
            };
            var hero2Score = new Label
            {
                Text = "Score: " + game.heroes[1].getScore().ToString()
            };
            var hero2level = new Label
            {
                Text = "Level: " + game.heroes[1].getLvl().ToString()
            };
            var hero2HP = new Label
            {
                Text = "HP: " + game.heroes[1].getHP().ToString()
            };

            var hero3Name = new Label
            {
                Text = game.heroes[2].getName().ToString()
            };
            var hero3Score = new Label
            {
                Text = "Score: " + game.heroes[2].getScore().ToString()
            };
            var hero3level = new Label
            {
                Text = "Level: " + game.heroes[2].getLvl().ToString()
            };
            var hero3HP = new Label
            {
                Text = "HP: " + game.heroes[2].getHP().ToString()
            };

            var hero4Name = new Label
            {
                Text = game.heroes[3].getName().ToString()
            };
            var hero4Score = new Label
            {
                Text = "Score: " + game.heroes[3].getScore().ToString()
            };
            var hero4level = new Label
            {
                Text = "Level: " + game.heroes[3].getLvl().ToString()
            };
            var hero4HP = new Label
            {
                Text = "HP: " + game.heroes[3].getHP().ToString()
            };

            var nextBattleBtn = new Button { Text = "Next Battle" };

            nextBattleBtn.Clicked += delegate
            {
                Battle nextbattle = new Battle(game.heroes);
                game.battle = nextbattle;
                game.play();
                Navigation.PushModalAsync(new BattlePage(game));           
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
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
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

            grid.Children.Add(hero1Name, 0, 1);
            grid.Children.Add(hero2Name, 1, 1);
            grid.Children.Add(hero3Name, 2, 1);
            grid.Children.Add(hero4Name, 3, 1);

            grid.Children.Add(hero1Score, 0, 2);
            grid.Children.Add(hero2Score, 1, 2);
            grid.Children.Add(hero3Score, 2, 2);
            grid.Children.Add(hero4Score, 3, 2);

            grid.Children.Add(hero1level, 0, 3);
            grid.Children.Add(hero2level, 1, 3);
            grid.Children.Add(hero3level, 2, 3);
            grid.Children.Add(hero4level, 3, 3);

            grid.Children.Add(hero1HP, 0, 4);
            grid.Children.Add(hero2HP, 1, 4);
            grid.Children.Add(hero3HP, 2, 4);
            grid.Children.Add(hero4HP, 3, 4);

            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 20,
                Children = { title, gameScore, battleNumber, grid, nextBattleBtn }
            };
        }
        protected override void OnDisappearing()
        {
            Navigation.PopModalAsync();
            base.OnAppearing();
        }
    }
}