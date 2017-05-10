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
                Text = "Nat20's Cave Crawler",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };

           
			var mainIMG = new Image {
				Source = "https://i.kinja-img.com/gawker-media/image/upload/s--f1QZSW4S--/c_scale,fl_progressive,q_80,w_800/nbeoyoc4o5bp8bgtlfan.png",
				HeightRequest = 200,
			};



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
                Children = { title, mainIMG, teamSelectBtn, autoPlayBtn, }
            };
        }
    }
}
