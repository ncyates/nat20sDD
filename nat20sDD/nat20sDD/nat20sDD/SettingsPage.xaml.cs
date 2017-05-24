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


        public SettingsPage()
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



            void server_items_switcher_Toggled(object sender, ToggledEventArgs e)
            {
                if (server_items_switcher.IsToggled == false)
                {
                    random_results_switcher.IsToggled = false;
                    random_results_switcher.IsEnabled = false;
                    super_results_switcher.IsToggled = false;
                    super_results_switcher.IsEnabled = false;
                }
                else
                {
                    random_results_switcher.IsEnabled = true;
                    super_results_switcher.IsEnabled = true;
                }
                server_items_label.Text = String.Format("Server Items are on: {0}:", e.Value);
            };







            Switch debugswitcher = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            debugswitcher.Toggled += debugswitcher_Toggled;



            void debugswitcher_Toggled(object sender, ToggledEventArgs e)
            {
                debuglabel.Text = String.Format("Debug Mode is on: {0}", e.Value);
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
            };


            void critical_miss_switcher_Toggled(object sender, ToggledEventArgs e)
            {
                critical_miss_label.Text = String.Format("Critical Misses are on: {0}:", e.Value);
                if (critical_miss_switcher.IsToggled == true)
                {
                    critical_hit_switcher.IsToggled = false;
                    critical_hit_switcher.IsEnabled = false;
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


            layout.Children.Add(server_items_switcher);
            layout.Children.Add(server_items_label);            
            layout.Children.Add(random_results_switcher);
            layout.Children.Add(random_results_label);
            random_results_switcher.IsEnabled = false;
            layout.Children.Add(super_results_switcher);
            layout.Children.Add(super_results_label);
            super_results_switcher.IsEnabled = false;
            layout.Children.Add(debugswitcher);
            layout.Children.Add(debuglabel);
            layout.Children.Add(critical_hit_switcher);
            layout.Children.Add(critical_hit_label);
            layout.Children.Add(critical_miss_switcher);
            layout.Children.Add(critical_miss_label);
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

            /*
            // Build the page.
            this.Content = new StackLayout

            {
                Children =
                {
                    header,
                    debugswitcher,
                    debuglabel,
                    server_items_switcher,
                    server_items_label,
                    random_results_switcher,
                    random_results_label,
                    super_results_switcher,
                    super_results_label,
                    critical_hit_switcher,
                    critical_hit_label,
                    critical_miss_switcher,
                    critical_miss_label,
                    item_use_switcher,
                    item_use_label,
                    magic_use_switcher,
                    magic_use_label,
                    healing_use_switcher,
                    healing_use_label,
                    battle_events_switcher,
                    battle_events_label
                }
            };

            */
        }
    }
}
