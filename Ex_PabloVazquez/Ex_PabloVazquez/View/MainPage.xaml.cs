using Ex_PabloVazquez.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ex_PabloVazquez
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainViewModel();
        }

        private void TrooperListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync();

        }
    }
}
