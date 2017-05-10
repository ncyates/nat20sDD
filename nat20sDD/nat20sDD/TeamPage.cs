using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace nat20sDD
{
	public class TeamPage : ContentPage
	{
		public TeamPage(Game game)
		{
			


			var title = new Label
			{
				Text = "Team Detail Page",
				FontSize = 28,
			};
			
			var firstHero = new Button
			{
				Text = game.heroes[0].getName(),
				FontSize = 28,
				HorizontalOptions = LayoutOptions.Center,
			};

			var secondHero = new Button
			{
				Text = game.heroes[1].getName(),
				FontSize = 28,
				HorizontalOptions = LayoutOptions.Center,
			};

			var thirdHero = new Button
			{
				Text = game.heroes[2].getName(),
				FontSize = 28,
				HorizontalOptions = LayoutOptions.Center,
			};

			var fourthHero = new Button
			{
				Text = game.heroes[3].getName(),
				FontSize = 28,
				HorizontalOptions = LayoutOptions.Center,
			};

			firstHero.Clicked += delegate
			{
				Navigation.PushModalAsync(new EditCharPage(game, 0));
			};

			secondHero.Clicked += delegate
			{
				Navigation.PushModalAsync(new EditCharPage(game, 1));
			};

			thirdHero.Clicked += delegate
			{
				Navigation.PushModalAsync(new EditCharPage(game, 2));
			};

			fourthHero.Clicked += delegate
			{
				Navigation.PushModalAsync(new EditCharPage(game, 3));
			};

			var autoPlayBtn = new Button { Text = "Auto-Play Game" };
			var firstBattle = new Button { Text = "First Battle" };

			firstBattle.Clicked += delegate
			{
				
				Navigation.PushModalAsync(new BattlePage(game));
				// Navigate to battle page
				// Navigation.PushModalAsync(new BattlePage(heroes));
				// - Battle battle = new Battle(heroes);
			};

			Content = new StackLayout
			{
				Children = { title, firstHero, secondHero, thirdHero, fourthHero, autoPlayBtn, firstBattle },
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Padding = 30,
				Spacing = 20
			};
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			
		}
	}
}
