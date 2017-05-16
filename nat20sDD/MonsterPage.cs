using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace nat20sDD
{ 
    public class MonsterPage : ContentPage
{
    public MonsterPage(Monster monster)
    {

        var title = new Label
        {
            Text = "Monster Detail Page",
            FontSize = 28,
        };

        var name = new Label
        {
            Text = monster.getName(),
            FontSize = 20,
            HorizontalOptions = LayoutOptions.Center,
        };





        var health = new Label
        {
            Text = "HP - " + monster.getHP()
        };

        var str = new Label
        {
            Text = "Strength - " + monster.getStr()
        };

        var spd = new Label
        {
            Text = "Speed - " + monster.getSpd()
        };


        var def = new Label
        {
            Text = "Defense - " + monster.getDef()
        };

        var dex = new Label
        {
            Text = "Dexterity - " + monster.getDex()
        };

        StackLayout stats = new StackLayout
        {
            Children = { health, str, spd, def, dex },
            VerticalOptions = LayoutOptions.EndAndExpand,
        };

        var monsterPic = new Image
        {
            Source = "https://s-media-cache-ak0.pinimg.com/originals/dd/ac/24/ddac24e8b1291f8f27d9826cb9b54f94.jpg",
            WidthRequest = 100,
            HeightRequest = 200,
            VerticalOptions = LayoutOptions.Center,
        };


        StackLayout mid = new StackLayout
        {
            Children = { stats, monsterPic },
            Orientation = StackOrientation.Horizontal,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
        };


        var invButton = new Button { Text = "Show Inventory", VerticalOptions = LayoutOptions.EndAndExpand, HorizontalOptions = LayoutOptions.Center, };

        invButton.Clicked += delegate
        {
			Navigation.PopModalAsync();
        };

        Content = new StackLayout
        {
            Children = { title, name, mid, invButton },
            HorizontalOptions = LayoutOptions.CenterAndExpand,

        };

    }
}
}

