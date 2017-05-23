using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace nat20sDD
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutPage : ContentPage
	{
		public AboutPage ()
		{
			InitializeComponent ();
            info.Text = "CPSC - 4910 - Mobile Application Development\n\nGroup: Nat20's\n\nTeam Members:\n\tJacob Lee\n\tSean Taings\n\tMatthew Wenala\n\tNick Yates\n\n" + DateTime.Now.ToString();
        }
	}
}
