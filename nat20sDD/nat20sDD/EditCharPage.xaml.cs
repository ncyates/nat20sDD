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
		public EditCharPage (Hero hero)
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
				Text = hero.getName()
			};

			var heroHP = new Entry()
			{
				Placeholder = "HP",
				Text = hero.getHP().ToString()
			};

			var heroStr = new Entry()
			{
				Placeholder = "Strength",
				Text = hero.getStr().ToString()
			};

			var heroSpd = new Entry()
			{
				Placeholder = "Speed",
				Text = hero.getSpd().ToString()
			};

			var heroDef = new Entry()
			{
				Placeholder = "Defense",
				Text = hero.getDef().ToString()
			};

			var heroDex = new Entry()
			{
				Placeholder = "Dexterity",
				Text = hero.getDex().ToString()
			};

			var saveBtn = new Button()
			{
				Text = "Save"
			};

			saveBtn.Clicked += delegate
			{
				hero.setName(heroName.Text);
				hero.setHP(Int32.Parse(heroHP.Text));
				hero.setStr(Int32.Parse(heroStr.Text));
				hero.setSpd(Int32.Parse(heroSpd.Text));
				hero.setDef(Int32.Parse(heroDef.Text));
				hero.setDex(Int32.Parse(heroDex.Text));
				Navigation.PopModalAsync();
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
