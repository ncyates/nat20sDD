using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace nat20sDD
{
	public partial class BattlePage : ContentPage
	{
		public BattlePage(Game game)
		{
			InitializeComponent();

			var heroList = new Label {
				Text = "Heroes",
				HorizontalOptions = LayoutOptions.Center,
				FontSize = 16,
				FontAttributes = FontAttributes.Bold,
			};

			//Hero 1
			var h1name = new Button {
				Text = game.heroes[0].getName(),
				HeightRequest = 40,
			};

			h1name.Clicked += delegate {
				Navigation.PushModalAsync(new CharPage(game.heroes[0]));
			};

			var h1lvl = new Label {
				Text = "Lvl: " + game.heroes[0].getLvl().ToString(),
			};

			var h1Hp = new Label {
				Text = "HP: " + game.heroes[0].getHP().ToString(),
			};

			var h1expbar = new ProgressBar
			{
				Progress = ((double)game.heroes[0].getHP()/100.0)
			};

			StackLayout h1stats = new StackLayout 
			{
				Children = {h1name, h1lvl, h1Hp},
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};


			var h1Pic = new Image
			{
				Source = game.heroes[0].imgUri,
				WidthRequest = 10,
				HeightRequest = 20,
				VerticalOptions = LayoutOptions.CenterAndExpand,    
			};

			StackLayout h1Viz = new StackLayout
			{
				Children = {h1Pic, h1expbar}
			};

			StackLayout h1 = new StackLayout
			{
				Children = {h1Viz, h1stats },
                Orientation = StackOrientation.Horizontal,
                //HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

			// Hero 2
			var h2name = new Button
			{
				Text = game.heroes[1].getName(),
				HeightRequest = 40,
			};
			h2name.Clicked += delegate {
				Navigation.PushModalAsync(new CharPage(game.heroes[1]));
			};


			var h2lvl = new Label
			{
				Text = "Lvl: " + game.heroes[1].getLvl().ToString(),
			};

			var h2Hp = new Label
			{
				Text = "HP: " + game.heroes[1].getHP().ToString(),
			};

			var h2expbar = new ProgressBar
			{
				Progress = ((double)game.heroes[1].getHP() / 100.0)
			};

			StackLayout h2stats = new StackLayout
			{
				Children = { h2name, h2lvl, h2Hp },
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};


			var h2Pic = new Image
			{
				Source = game.heroes[1].imgUri,
				WidthRequest = 10,
				HeightRequest = 20,
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};


			StackLayout h2Viz = new StackLayout
			{
				Children = { h2Pic, h2expbar }
			};

			StackLayout h2 = new StackLayout
			{
				Children = { h2Viz, h2stats },
				Orientation = StackOrientation.Horizontal,
				//HorizontalOptions = LayoutOptions.CenterAndExpand,    
			};

			//Hero 3
			var h3name = new Button
			{
				Text = game.heroes[2].getName(),
				HeightRequest = 40,
			};

			h3name.Clicked += delegate {
				Navigation.PushModalAsync(new CharPage(game.heroes[2]));
			};


			var h3lvl = new Label
			{
				Text = "Lvl: " + game.heroes[2].getLvl().ToString(),
			};

			var h3Hp = new Label
			{
				Text = "HP: " + game.heroes[2].getHP().ToString(),
			};

			var h3expbar = new ProgressBar
			{
				Progress = ((double)game.heroes[2].getHP() / 100.0)
			};

			StackLayout h3stats = new StackLayout
			{
				Children = { h3name, h3lvl, h3Hp },
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};


			var h3Pic = new Image
			{
				Source = game.heroes[2].imgUri,
				WidthRequest = 10,
				HeightRequest = 20,
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};


			StackLayout h3Viz = new StackLayout
			{
				Children = { h3Pic, h3expbar }
			};

			StackLayout h3 = new StackLayout
			{
				Children = { h3Viz, h3stats },
				Orientation = StackOrientation.Horizontal,
				//HorizontalOptions = LayoutOptions.CenterAndExpand, 
			};

			//Hero 4
			var h4name = new Button
			{
				Text = game.heroes[3].getName(),
				HeightRequest = 40,
			};
			h4name.Clicked += delegate {
				Navigation.PushModalAsync(new CharPage(game.heroes[3]));
			};

			var h4lvl = new Label
			{
				Text = "Lvl: " + game.heroes[3].getLvl().ToString(),
			};

			var h4Hp = new Label
			{
				Text = "HP: " + game.heroes[3].getHP().ToString(),
			};

			var h4expbar = new ProgressBar
			{
				Progress = ((double)game.heroes[3].getHP() / 100.0)
			};

			StackLayout h4stats = new StackLayout
			{
				Children = { h4name, h4lvl, h4Hp },
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};


			var h4Pic = new Image
			{
				Source = game.heroes[3].imgUri,
				WidthRequest = 20,
				HeightRequest = 30,
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};


			StackLayout h4Viz = new StackLayout
			{
				Children = { h4Pic, h4expbar }
			};

			StackLayout h4 = new StackLayout
			{
				Children = { h4Viz, h4stats },
				Orientation = StackOrientation.Horizontal,
				//HorizontalOptions = LayoutOptions.CenterAndExpand			};
			};

			StackLayout heroes = new StackLayout
			{
				Children = { heroList, h1, h2, h3, h4 },
				Padding = new Thickness(20,20,20,0),
				VerticalOptions = LayoutOptions.FillAndExpand,
			};



			//Monsters
			//M1

			var monsList = new Label
			{
				Text = "Monsters",
				HorizontalOptions = LayoutOptions.Center,
				FontSize = 16,
				FontAttributes = FontAttributes.Bold,
			};

			var m1Hp = new Label
			{
			Text = "HP: " + game.battle.monsters[0].getHP().ToString(),
			};

			var m1bar = new ProgressBar
			{
			Progress = ((double)game.battle.monsters[0].getHP() / 70.0)
			};

			var m1pic = new Image 
			{
				Source = game.battle.monsters[0].imgUri,
				WidthRequest = 20,
				HeightRequest = 30,
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};
			StackLayout m1top = new StackLayout
			{
				Children = { m1Hp, m1pic },
				Orientation = StackOrientation.Horizontal,
				//HorizontalOptions = LayoutOptions.CenterAndExpan
			};
			StackLayout m1 = new StackLayout
			{
				Children = { m1top, m1bar },
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};

			//M2

			var m2Hp = new Label
			{
			Text = "HP: " + game.battle.monsters[1].getHP().ToString(),
			};

			var m2bar = new ProgressBar
			{
			Progress = ((double)game.battle.monsters[1].getHP() / 70.0)
			};

			var m2pic = new Image
			{
			Source = game.battle.monsters[1].imgUri,
			WidthRequest = 20,
			HeightRequest = 30,
			VerticalOptions = LayoutOptions.CenterAndExpand,
			};

			StackLayout m2top = new StackLayout
			{
			Children = { m2Hp, m2pic },
			Orientation = StackOrientation.Horizontal,
			//HorizontalOptions = LayoutOptions.CenterAndExpan
			};
			StackLayout m2 = new StackLayout
			{
				Children = { m2top, m2bar },
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};

			//M3

			var m3Hp = new Label
			{
			Text = "HP: " + game.battle.monsters[2].getHP().ToString(),
			};

			var m3bar = new ProgressBar
			{
			Progress = ((double)game.battle.monsters[2].getHP() / 70.0)
			};

			var m3pic = new Image
			{
			Source = game.battle.monsters[2].imgUri,
				WidthRequest = 20,
			HeightRequest = 30,
			VerticalOptions = LayoutOptions.CenterAndExpand,
			};

			StackLayout m3top = new StackLayout
			{
			Children = { m3Hp, m3pic },
			Orientation = StackOrientation.Horizontal,
			//HorizontalOptions = LayoutOptions.CenterAndExpan
			};
			StackLayout m3 = new StackLayout
			{
				Children = { m3top, m3bar },
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};

			//M4

			var m4Hp = new Label
			{
			Text = "HP: " + game.battle.monsters[3].getHP().ToString(),
			};

			var m4bar = new ProgressBar
			{
			Progress = ((double)game.battle.monsters[3].getHP() / 70.0)
			};

			var m4pic = new Image
			{
			Source = game.battle.monsters[3].imgUri,
			WidthRequest = 20,
			HeightRequest = 30,
			VerticalOptions = LayoutOptions.CenterAndExpand,
			};
			StackLayout m4top = new StackLayout
			{
			Children = { m4Hp, m4pic },
			Orientation = StackOrientation.Horizontal,
			//HorizontalOptions = LayoutOptions.CenterAndExpan
			};
			StackLayout m4 = new StackLayout
			{
				Children = { m4top, m4bar },
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};

			StackLayout Monsters = new StackLayout {
				Children = { monsList, m1, m2, m3, m4 },
				Padding = new Thickness(20,20,20,0),
				VerticalOptions = LayoutOptions.FillAndExpand,
			};


			StackLayout lists = new StackLayout {
				Children = {heroes, Monsters},
				Orientation = StackOrientation.Horizontal,
			};

			var title = new Label {
				Text = "Battle Page",
				FontSize = 20,
				HorizontalOptions = LayoutOptions.Center,
				FontAttributes = FontAttributes.Bold,
			};

			var battle = new StackLayout()
			{
				Children = { title, lists },
				VerticalOptions = LayoutOptions.FillAndExpand
			};

            //if hero team lives
            if (game.heroTeamLives())
            {
                //if all monsters dead
                if (!game.monsterTeamLives(game.battle.monsters))
                {
                    DisplayAlert("Victory!", "You have slain all the monsters.", "OK");

                    var resultButton = new Button { Text = "Show Battle Results" };
                    resultButton.Clicked += delegate
                    {
                        Navigation.PushModalAsync(new BattleResultPage(game));
                    };

                    battle.Children.Add(resultButton);
                }
                else // battle is unfinished
                {
                    var runButton = new Button{ Text = "Run Battle Sequence" };
                    runButton.Clicked += delegate
                    {
                        game.prepareNextBattle();
                        game.playOneBattle();
                        Navigation.PushModalAsync(new BattlePage(game));
                    };

                    var resultsButton = new Button
                    {
                        Text = "Skip to End Results",
                    };

                    resultsButton.Clicked += delegate {
                        game.playAllBattles();
                        DisplayAlert("Game Over!", "Your heroes have been killed.", "OK");
                        Navigation.PushModalAsync(new GameResultPage(game));
                    };

                    battle.Children.Add(runButton);
                    battle.Children.Add(resultsButton);
                }
            }
            else //hero team all dead
            {
                DisplayAlert("Game Over!", "Your heroes have been killed.", "OK");
                Navigation.PushModalAsync(new GameResultPage(game));
            }

            Content = battle;
		}
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Navigation.PopModalAsync();
        }
    }
}
