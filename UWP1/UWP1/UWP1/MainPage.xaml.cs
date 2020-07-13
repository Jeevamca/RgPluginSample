using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UWP1
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<ListItemModel> listItems { get; set; }
        public MainPage()
        {
            InitializeComponent();
            listItems = new ObservableCollection<ListItemModel>();

            listItems.Add(new ListItemModel { Name = "First", Quantity = 1, Value = "10.00" });
            listItems.Add(new ListItemModel { Name = "Secound", Quantity = 2, Value = "20.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });
            listItems.Add(new ListItemModel { Name = "Third", Quantity = 3, Value = "30.00" });

            InitializeComponent();

            MyList.ItemsSource = listItems;
           
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
    public class ListItemModel
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Value { get; set; }
    }
}
