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
                Text = "Game Result Page"
            };

            var gameScore = new Label
            {
                Text = game.totalScore
            };

            var hero1Score = new Label
            {
                Text = game.heroes[1].getName().ToString() + ": " + game.heroes[1].getScore().ToString()
            };

            var hero2Score = new Label
            {
                Text = game.heroes[2].getName().ToString() + ": " + game.heroes[2].getScore().ToString()
            };

            var hero3Score = new Label
            {
                Text = game.heroes[3].getName().ToString() + ": " + game.heroes[3].getScore().ToString()
            };

            var hero4Score = new Label
            {
                Text = game.heroes[4].getName().ToString() + ": " + game.heroes[4].getScore().ToString()
            };

            var autoPlayBtn = new Button { Text = "Auto-Play Game" };

            autoPlayBtn.Clicked += delegate
            {
                Game game1 = new Game();

                Navigation.PushModalAsync(new GameResultPage(game1));
            };

            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = { title, gameScore, hero1Score, hero2Score, hero3Score, hero4Score, autoPlayBtn }
            };
        }
	}
}
