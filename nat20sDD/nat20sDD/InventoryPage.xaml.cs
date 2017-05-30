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
	public partial class InventoryPage : ContentPage
	{
        public InventoryPage(Hero h, Game game)
        {
            InitializeComponent();

            var title = new Label
            {
                Text = "Inventory Page",
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center,
                FontAttributes = FontAttributes.Bold,
            };




            var inv = new StackLayout()
            {
                Children = { title },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            List<String> itemNames = new List<String>();
            for(int j = 0; j < game.heroes.Count; j++)
            {
                itemNames.Add(game.heroes[j].getName());
            }
            
            for (int i = 0; i < game.heroes[0].inventory.Count; i++)
            {
                itemNames.Add(game.heroes[0].inventory[i].name);
            }
            var invListView = new ListView();
            invListView.ItemsSource = itemNames;
            
            inv.Children.Add(invListView);
            Content = inv;
		}
	}
}
