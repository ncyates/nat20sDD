using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json.Linq;

namespace nat20sDD
{
	public partial class MainPage : ContentPage
	{
		public MainPage(Game game)
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
          

            teamSelectBtn.Clicked += async delegate
            {

				List<Item> items = new List<Item>();
				List<BattleEvent> events = new List<BattleEvent>();

				string url = "http://gamehackathon.azurewebsites.net/api/GetItemsList";
				string itemListRequest = await PostRequestAsync(url);
				var result = JObject.Parse(itemListRequest);
				foreach (var item in result["data"])
				{
					Item i = item.ToObject<Item>();
					items.Add(i);
				}

				url = "http://gamehackathon.azurewebsites.net/api/GetBattleEffects";
				string eventListRequest = await PostRequestAsync(url);
				result = JObject.Parse(eventListRequest);
				foreach (var battleEvent in result["data"])
				{
					BattleEvent e  = battleEvent.ToObject<BattleEvent>();
					events.Add(e);
				}

				game.items = items;
				game.events = events;
				await Navigation.PushModalAsync(new TeamPage(game));
            };


            autoPlayBtn.Clicked += async delegate
            {
				List<Item> items = new List<Item>();
				List<BattleEvent> events = new List<BattleEvent>();

				string url = "http://gamehackathon.azurewebsites.net/api/GetItemsList";
				string itemListRequest = await PostRequestAsync(url);
				var result = JObject.Parse(itemListRequest);
				foreach (var item in result["data"])
				{
					Item i = item.ToObject<Item>();
					items.Add(i);
				}

				url = "http://gamehackathon.azurewebsites.net/api/GetBattleEffects";
				string eventListRequest = await PostRequestAsync(url);
				result = JObject.Parse(eventListRequest);
				foreach (var battleEvent in result["data"])
				{
					BattleEvent e = battleEvent.ToObject<BattleEvent>();
					events.Add(e);
				}

				game.items = items;
				game.events = events;
                game.playAllBattles();
                await Navigation.PushModalAsync(new GameResultPage(game));
               	
            };

           

            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = { title, mainIMG, teamSelectBtn, autoPlayBtn, }
            };
        }

		private async Task<String> PostRequestAsync(string url)
		{
			var client = new HttpClient();
			var values = new Dictionary<string, string>
			{
				{"randomItemOption", "1" },
				{"superItemOption", "0" },
			};

			var content = new FormUrlEncodedContent(values);
			var response = await client.PostAsync(url, content);
			var responseString = await response.Content.ReadAsStringAsync();

			return responseString;
		}
	}


}
