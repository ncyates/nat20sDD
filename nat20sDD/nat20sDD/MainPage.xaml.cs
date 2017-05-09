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
                Navigation.PushModalAsync(new TeamPage());
            };

            charButton.Clicked += delegate
            {
                Navigation.PushModalAsync(new CharPage(dude));
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
                Children = { title, teamSelectBtn, charButton, monsterButton }
            };
        }
    }
}
