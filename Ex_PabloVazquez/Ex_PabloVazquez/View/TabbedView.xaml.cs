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
    public partial class TabbedView : TabbedPage
    {
        public TabbedView ()
        {
            
            InitializeComponent();
            ContentPage cp = new MainPage(0, 25);
            cp.Title = "Fail";
            Children.Add(cp);
            cp = new MainPage(25, 75);
            cp.Title = "Mid Level";
            Children.Add(cp);
            cp = new MainPage(75, 100);
            cp.Title = "High Level";
            Children.Add(cp);
            
        }
    }
}