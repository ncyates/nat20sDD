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
        public BattleResultPage(Game game)
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

            var hero1HPBar = new ProgressBar
            {
                Progress = ((double)game.heroes[0].getHP() / 100.0)
            };
            var hero2HPBar = new ProgressBar
            {
                Progress = ((double)game.heroes[1].getHP() / 100.0)
            };
            var hero3HPBar = new ProgressBar
            {
                Progress = ((double)game.heroes[2].getHP() / 100.0)
            };
            var hero4HPBar = new ProgressBar
            {
                Progress = ((double)game.heroes[3].getHP() / 100.0)
            };

            var nextBattle = new Button { Text = "Next Battle" };
            nextBattle.Clicked += delegate
            {
                game.prepareNextBattle(); 
                Navigation.PushModalAsync(new BattlePage(game));
            };

            var playAll = new Button { Text = "Play Till Dead" };
            playAll.Clicked += delegate
            {
                game.playAllBattles();
                DisplayAlert("Game Over!", "Your heroes have been killed.", "OK");
                Navigation.PushModalAsync(new GameResultPage(game));
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

            grid.Children.Add(hero1HPBar, 0, 1);
            grid.Children.Add(hero2HPBar, 1, 1);
            grid.Children.Add(hero3HPBar, 2, 1);
            grid.Children.Add(hero4HPBar, 3, 1);

            ListView battleActionList = new ListView
            {
                ItemsSource = game.battle.battleActions,
            };

            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 20,
                Children = { title, gameScore, grid, nextBattle, playAll, battleActionList }
            };
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Navigation.PopModalAsync();
        }
    }
}