using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UWP1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowPopUp : PopupPage
    {
        public ObservableCollection<model1> models { get; set; }
        public ShowPopUp()
        {
            InitializeComponent();
            models = new ObservableCollection<model1>()
            {
                new model1(){name="Cherry"},
                new model1(){name="barry"}
            };
            this.BindingContext = this;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }

    public class model1
    {
        public string name { get; set; }
    }
}