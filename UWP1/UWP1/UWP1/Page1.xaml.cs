using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UWP1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
            //Entry txtMeasures = new Entry { WidthRequest = 100, Text = "32", TextColor = Color.Black };
            //stacklayout1.Children.Add(txtMeasures);
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new ShowPopUp());
        }
    }
}