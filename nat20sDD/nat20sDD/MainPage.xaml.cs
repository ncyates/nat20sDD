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
			InitializeComponent();

            var dude = new Character();
            dude.setName("Jacob");
            dude.setHP(500);
            dude.setlvl(100);
            dude.setStr(999);
            var title = new Label
            {
                Text = "Dungeons and Dragons",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };


            var charButton = new Button { Text = "Character Detail Prototype" };

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
                Children = { title, charButton, monsterButton }
            };
        }
    }
}
