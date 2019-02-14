using Ex_PabloVazquez.Model;
using Ex_PabloVazquez.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Ex_PabloVazquez.ViewModel
{
    public class MainViewModel : BindableObject
    {
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
            troopers = getTrooperService.GetAllTroopers().Result;
            ExecuteRefreshList = new Command(ResfreshList);
        }

        private void ResfreshList(object obj)
        {
        }

        public Command ExecuteRefreshList;

    }
}
