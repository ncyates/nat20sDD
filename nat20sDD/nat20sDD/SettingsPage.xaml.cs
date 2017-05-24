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
    public partial class SettingsPage : ContentPage
    {


        public SettingsPage(Game game)
        {
            InitializeComponent();

            Label debuglabel = new Label
            {
                Text = "Debug Mode is On: False",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };


            Label random_results_label = new Label
            {
                Text = "Random Results are On: False",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Switch random_results_switcher = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            random_results_switcher.Toggled += random_results_switcher_Toggled;

            void random_results_switcher_Toggled(object sender, ToggledEventArgs e)
            {
                random_results_label.Text = String.Format("Random Results are on: {0}:", e.Value);
                game.randomItemsOn = !game.randomItemsOn;
                
            };

            Label super_results_label = new Label
            {
                Text = "Super Results are On: False",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Switch super_results_switcher = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            super_results_switcher.Toggled += super_results_switcher_Toggled;

            void super_results_switcher_Toggled(object sender, ToggledEventArgs e)
            {
                super_results_label.Text = String.Format("Super Results are on: {0}:", e.Value);
                game.superItemsOn = !game.superItemsOn;
            };

            Label server_items_label = new Label
            {
                Text = "Server Items are On: False",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Switch server_items_switcher = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            server_items_switcher.Toggled += server_items_switcher_Toggled;


            // maybe changing not on/off, but get new set of items
            void server_items_switcher_Toggled(object sender, ToggledEventArgs e)
            {
                if (server_items_switcher.IsToggled == false)
                {
                    
                    random_results_switcher.IsToggled = false;
                    random_results_switcher.IsEnabled = false;
                    game.randomItemsOn = false;
                    super_results_switcher.IsToggled = false;
                    super_results_switcher.IsEnabled = false;
                    game.superItemsOn = false;
                }
                else
                {
                    random_results_switcher.IsEnabled = true;
                    super_results_switcher.IsEnabled = true;
                }
                game.serverItemsOn = !game.serverItemsOn;
                server_items_label.Text = String.Format("Server Items are on: {0}:", e.Value);
            };    




            Label critical_hit_label = new Label
            {
                Text = "Critical Hits are On: False",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label critical_miss_label = new Label
            {
                Text = "Critical Misses are On: False",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };


            Switch critical_hit_switcher = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            critical_hit_switcher.Toggled += critical_hit_switcher_Toggled;

            Switch critical_miss_switcher = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            critical_miss_switcher.Toggled += critical_miss_switcher_Toggled;

            void critical_hit_switcher_Toggled(object sender, ToggledEventArgs e)
            {
                critical_hit_label.Text = String.Format("Critical Hits are on: {0}:", e.Value);
                game.forceCritHit = !game.forceCritHit;
            };


            void critical_miss_switcher_Toggled(object sender, ToggledEventArgs e)
            {
                game.forceCritMiss = !game.forceCritMiss;
                critical_miss_label.Text = String.Format("Critical Misses are on: {0}:", e.Value);
                if (critical_miss_switcher.IsToggled == true)
                {
                    critical_hit_switcher.IsToggled = false;
                    critical_hit_switcher.IsEnabled = false;
                    game.forceCritHit = false;
                }
                else
                {
                    critical_hit_switcher.IsEnabled = true;
                }
            };


            Label item_use_label = new Label
            {
                Text = "Item Usage is On: False",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Switch item_use_switcher = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            item_use_switcher.Toggled += item_use_switcher_Toggled;

            void item_use_switcher_Toggled(object sender, ToggledEventArgs e)
            {
                item_use_label.Text = String.Format("Item Usage is on: {0}:", e.Value);
                game.itemUsageOn = !game.itemUsageOn;
            };


            Label magic_use_label = new Label
            {
                Text = "Magic Usage is On: False",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Switch magic_use_switcher = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            magic_use_switcher.Toggled += magic_use_switcher_Toggled;

            void magic_use_switcher_Toggled(object sender, ToggledEventArgs e)
            {
                magic_use_label.Text = String.Format("Magic Usage is on: {0}:", e.Value);
                game.magicEnabled = !game.magicEnabled;
            };


            Label healing_use_label = new Label
            {
                Text = "Healing Usage is On: False",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Switch healing_use_switcher = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            healing_use_switcher.Toggled += healing_use_switcher_Toggled;

            void healing_use_switcher_Toggled(object sender, ToggledEventArgs e)
            {
                healing_use_label.Text = String.Format("Healing Usage is on: {0}:", e.Value);
                game.healingEnabled = !game.healingEnabled;
            };


            Label battle_events_label = new Label
            {
                Text = "Battle Events are On: False",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Switch battle_events_switcher = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            battle_events_switcher.Toggled += battle_events_switcher_Toggled;

            void battle_events_switcher_Toggled(object sender, ToggledEventArgs e)
            {
                battle_events_label.Text = String.Format("Battle Events are on: {0}:", e.Value);
                game.battleEventsOn = !game.battleEventsOn;
            };



            Switch debugswitcher = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            debugswitcher.Toggled += debugswitcher_Toggled;



            void debugswitcher_Toggled(object sender, ToggledEventArgs e)
            {
                if (debugswitcher.IsToggled == false)
                {
                    //turn everything off
                    turnOffButtons();

                } else
                {
                    turnOnButtons();
                }
                debuglabel.Text = String.Format("Debug Mode is on: {0}", e.Value);
            };


            // Accomodate iPhone status bar.
            //this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            /* doesn't work?
            var scroll = new ScrollView();
            Content = scroll;
            var stack = new StackLayout();
            stack.Children.Add(header);
            stack.Children.Add(debugswitcher);
            stack.Children.Add(debuglabel);
            stack.Children.Add(server_items_switcher);
            stack.Children.Add(server_items_label);
            stack.Children.Add(random_results_switcher);
            stack.Children.Add(random_results_label);
              */


            var layout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Padding = 0
            };

            turnOnButtons();
            
            
            layout.Children.Add(server_items_switcher);
            layout.Children.Add(server_items_label);            
            layout.Children.Add(random_results_switcher);
            layout.Children.Add(random_results_label);            
            layout.Children.Add(super_results_switcher);
            layout.Children.Add(super_results_label);

            debugswitcher.IsEnabled = true;
            game.debugModeOn = true;
            debugswitcher.IsToggled = true;
            layout.Children.Add(debugswitcher);
            layout.Children.Add(debuglabel);

            layout.Children.Add(critical_hit_switcher);
            critical_hit_switcher.IsToggled = false;
            game.forceCritHit = false;
            layout.Children.Add(critical_hit_label);

            layout.Children.Add(critical_miss_switcher);
            layout.Children.Add(critical_miss_label);
            critical_miss_switcher.IsToggled = false;
            game.forceCritMiss = false;

            layout.Children.Add(item_use_switcher);
            layout.Children.Add(item_use_label);

            layout.Children.Add(magic_use_switcher);
            layout.Children.Add(magic_use_label);

            layout.Children.Add(healing_use_switcher);
            layout.Children.Add(healing_use_label);

            layout.Children.Add(battle_events_switcher);
            layout.Children.Add(battle_events_label);


            var scrollView = new ScrollView { Content = layout };
            Content = scrollView;


             void turnOffButtons()
            {
                //server_items_switcher.IsToggled = false;
                //server_items_switcher.IsEnabled = false;

                //random_results_switcher.IsToggled = false;
                //random_results_switcher.IsEnabled = false;

                //super_results_switcher.IsToggled = false;
                //super_results_switcher.IsEnabled = false;

                critical_hit_switcher.IsToggled = false;
                critical_hit_switcher.IsEnabled = false;
                game.forceCritHit = false;

                critical_miss_switcher.IsToggled = false;
                critical_miss_switcher.IsEnabled = false;
                game.forceCritMiss = false;

                item_use_switcher.IsToggled = false;
                item_use_switcher.IsEnabled = false;
                game.itemUsageOn = false;


                magic_use_switcher.IsToggled = false;
                magic_use_switcher.IsEnabled = false;
                game.magicEnabled = false;

                healing_use_switcher.IsToggled = false;
                healing_use_switcher.IsEnabled = false;
                game.healingEnabled = false;

                battle_events_switcher.IsToggled = false;
                battle_events_switcher.IsEnabled = false;
                game.battleEventsOn = false;
            }

            void turnOnButtons()
            {
                server_items_switcher.IsToggled = true;
                server_items_switcher.IsEnabled = true;
                game.serverItemsOn = true;

                random_results_switcher.IsToggled = true;
                random_results_switcher.IsEnabled = true;
                game.randomItemsOn = true;

                super_results_switcher.IsToggled = true;
                super_results_switcher.IsEnabled = true;
                game.superItemsOn = true;

                
                critical_hit_switcher.IsEnabled = true;
                               
                critical_miss_switcher.IsEnabled = true;

                item_use_switcher.IsToggled = true;
                item_use_switcher.IsEnabled = true;
                game.itemUsageOn = true;

                magic_use_switcher.IsToggled = true;
                magic_use_switcher.IsEnabled = true;
                game.magicEnabled = true;

                healing_use_switcher.IsToggled = true;
                healing_use_switcher.IsEnabled = true;
                game.healingEnabled = true;

                battle_events_switcher.IsToggled = true;
                battle_events_switcher.IsEnabled = true;
                game.battleEventsOn = true;
            }
        }
    }
}
