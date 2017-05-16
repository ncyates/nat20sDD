using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace nat20sDD
{
    public partial class InventoryPage : ContentPage
    {
        public InventoryPage(Hero C)
        {
            InitializeComponent();
            Item sword = new Item("sword", 10, 10, 10, 10, 10);
            Item shield = new Item("shield", 10, 10, 10, 10, 10);
            Item boots = new Item("boots", 10, 10, 10, 10, 10);
            C.pickUp(sword);
            C.pickUp(shield);
            C.pickUp(boots);
            ItemsView.ItemsSource = C.getInv();
        }
    }
}
