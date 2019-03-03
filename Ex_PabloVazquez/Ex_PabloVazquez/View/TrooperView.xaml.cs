using Ex_PabloVazquez.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ex_PabloVazquez.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrooperView : ContentPage
	{
		public TrooperView (TrooperViewModel viewModel)
		{
			InitializeComponent ();
            this.BindingContext = viewModel;
            this.Title = "Briefing";
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("", $"{(this.BindingContext as TrooperViewModel).Name} road to mission", "Ok");
        }
    }
}