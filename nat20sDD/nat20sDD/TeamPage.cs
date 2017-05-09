using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace nat20sDD
{
	public class TeamPage : ContentPage
	{
		public TeamPage(Hero hero1, Hero hero2, Hero hero3, Hero hero4)
		{

			var title = new Label
			{
				Text = "Team Detail Page",
				FontSize = 28,
			};
			
			var firstHero = new Button
			{
				Text = hero1.getName(),
				FontSize = 28,
				HorizontalOptions = LayoutOptions.Center,
			};

			var secondHero = new Button
			{
				Text = hero2.getName(),
				FontSize = 28,
				HorizontalOptions = LayoutOptions.Center,
			};

			var thirdHero = new Button
			{
				Text = hero3.getName(),
				FontSize = 28,
				HorizontalOptions = LayoutOptions.Center,
			};

			var fourthHero = new Button
			{
				Text = hero4.getName(),
				FontSize = 28,
				HorizontalOptions = LayoutOptions.Center,
			};

			firstHero.Clicked += delegate
			{
				Navigation.PushModalAsync(new EditCharPage(hero1));
			};

			secondHero.Clicked += delegate
			{
				Navigation.PushModalAsync(new EditCharPage(hero2));
			};

			thirdHero.Clicked += delegate
			{
				Navigation.PushModalAsync(new EditCharPage(hero3));
			};

			fourthHero.Clicked += delegate
			{
				Navigation.PushModalAsync(new EditCharPage(hero4));
			};

			var autoPlayBtn = new Button { Text = "Auto-Play Game" };
			var firstBattle = new Button { Text = "First Battle" };

			firstBattle.Clicked += delegate
			{
				List<Hero> heroes = new List<Hero>();
				heroes.Add(hero1);
				heroes.Add(hero2);
				heroes.Add(hero3);
				heroes.Add(hero4);

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
