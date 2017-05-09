using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace nat20sDD
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			//InitializeComponent();


            var title = new Label
            {
                Text = "Totally Not Dungeons and Dragons",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };

            var dude = new Hero();
            dude.setName("Jacob");
            dude.setHP(500);
            dude.setlvl(100);
            dude.setStr(999);


            var teamSelectBtn = new Button { Text = "Select Team" };
            var autoPlayBtn = new Button { Text = "Auto-Play Game" };
            var charButton = new Button { Text = "Character Detail Prototype" };

            teamSelectBtn.Clicked += delegate
            {
				Hero hero1 = new Hero();
				hero1.setName("Hero 1");
				Hero hero2 = new Hero();
				hero2.setName("Hero 2");
				Hero hero3 = new Hero();
				hero3.setName("Hero 3");
				Hero hero4 = new Hero();
				hero4.setName("Hero 4");
                Navigation.PushModalAsync(new TeamPage(hero1, hero2, hero3, hero4));
            };

            autoPlayBtn.Clicked += delegate
            {
                Game game1 = new Game();

                Navigation.PushModalAsync(new GameResultPage(game1));
            };

            charButton.Clicked += delegate
            {
                Navigation.PushModalAsync(new CharPage(dude));
            };

            autoPlayBtn.Clicked += delegate
            {
                Game game = new Game();
            };

            var monsterButton = new Button { Text = "Monster Detail Prototype" };

            monsterButton.Clicked += delegate
            {
                Navigation.PushModalAsync(new MonsterPage());
            };

            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = { title, teamSelectBtn, autoPlayBtn, charButton, monsterButton }
            };
        }
    }
}
