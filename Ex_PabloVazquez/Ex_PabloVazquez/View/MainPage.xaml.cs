using Ex_PabloVazquez.Model;
using Ex_PabloVazquez.View;
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
        public MainPage(int minSkill, int maxSkill)
        {
            InitializeComponent();
            this.BindingContext = new MainViewModel(minSkill, maxSkill);
        }

        private async void TrooperListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var troop = e.SelectedItem as Trooper;
            if (troop == null)
                return;
            await Navigation.PushAsync(new TrooperView(new TrooperViewModel(troop)));

            TrooperListView.SelectedItem = null;
        }

        

        protected override void OnAppearing()
        {
            (this.BindingContext as MainViewModel).ExecuteGetTroops.Execute(null);
            base.OnAppearing();
        }
    }
}
