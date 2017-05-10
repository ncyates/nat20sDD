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
          

            teamSelectBtn.Clicked += delegate
            {
				Game game = new Game();
                Navigation.PushModalAsync(new TeamPage(game));
            };


            autoPlayBtn.Clicked += delegate
            {
                Game game = new Game();
               	game.play();
            };

           

            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = { title, teamSelectBtn, autoPlayBtn, }
            };
        }
    }
}
