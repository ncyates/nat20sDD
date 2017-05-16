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
	public partial class EditCharPage : ContentPage
	{
		public EditCharPage (Game game, int hero)
		{
			// InitializeComponent ();

			var title = new Label
			{
				Text = "Edit Character Page",
				FontSize = 28,
			};

			var heroName = new Entry()
			{
				Placeholder = "Name",
				Text = game.heroes[hero].getName()
			};

			var heroHP = new Entry()
			{
				Placeholder = "HP",
				Text = game.heroes[hero].getHP().ToString()
                //Text = "HP: " + game.heroes[hero].getHP().ToString()
            };

			var heroStr = new Entry()
			{
				Placeholder = "Strength",
				Text = game.heroes[hero].getStr().ToString()
                //Text = "Strength: " + game.heroes[hero].getStr().ToString()
            };

			var heroSpd = new Entry()
			{
				Placeholder = "Speed",
                Text = game.heroes[hero].getSpd().ToString()
                //Text = "Speed: " + game.heroes[hero].getSpd().ToString()
            };

			var heroDef = new Entry()
			{
				Placeholder = "Defense",
                Text = game.heroes[hero].getDef().ToString()
                //Text = "Defense: " + game.heroes[hero].getDef().ToString()
            };

			var heroDex = new Entry()
			{
				Placeholder = "Dexterity",
                Text = game.heroes[hero].getDex().ToString()
                //Text = "Dexterity: " + game.heroes[hero].getDex().ToString()
			};

			var saveBtn = new Button()
			{
				Text = "Save"
			};

			saveBtn.Clicked += delegate
			{
				game.heroes[hero].setName(heroName.Text);
				game.heroes[hero].setHP(Int32.Parse(heroHP.Text));
				game.heroes[hero].setStr(Int32.Parse(heroStr.Text));
				game.heroes[hero].setSpd(Int32.Parse(heroSpd.Text));
				game.heroes[hero].setDef(Int32.Parse(heroDef.Text));
				game.heroes[hero].setDex(Int32.Parse(heroDex.Text));
				Navigation.PushModalAsync(new TeamPage(game));
			};

			Content = new StackLayout
			{
				Padding = 30,
				Spacing = 10,
				Children = { title, heroName, heroHP, heroStr, heroSpd, heroDef, heroDex, saveBtn }
			};
		}
	}
}
