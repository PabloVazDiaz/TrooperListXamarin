using Ex_PabloVazquez.Model;
using Ex_PabloVazquez.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;

namespace Ex_PabloVazquez.ViewModel
{
    public class MainViewModel : BindableObject
    {
        private List<Trooper> allTroopers;
        private List<Trooper> troopers;
        public List<Trooper> Troopers
        {
            get => troopers;
            set
            {
                troopers = value;
                OnPropertyChanged();
            }
        }
        public IGetTroopersService getTrooperService;
        public MainViewModel()
        {
            getTrooperService = new GetTropeersService();
            allTroopers = getTrooperService.GetAllTroopers().Result;
            troopers = allTroopers;
            ExecuteRefreshList = new Command(ResfreshList);
        }

        private void ResfreshList()
        {
            
            troopers.Where(x => x.Accuracy < 25).ToList();
            
        }

        public Command ExecuteRefreshList;

    }
}
