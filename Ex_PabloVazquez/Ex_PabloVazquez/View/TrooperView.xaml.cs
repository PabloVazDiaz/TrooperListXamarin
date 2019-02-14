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
		}
	}
}