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
        public Command ExecuteGetTroops;
        private int MaxSkill;
        private int MinSkill;
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
        public MainViewModel( int minSkill, int maxSkill)
        {
            getTrooperService = new GetTropeersService();
            ExecuteGetTroops = new Command(GetTroops);
            ExecuteRefreshList = new Command(ResfreshList);
            MaxSkill = maxSkill;
            MinSkill = minSkill;
        }

        private async void GetTroops()
        {
            if (Troopers == null)
            {
                allTroopers = await getTrooperService.GetAllTroopers();
                Troopers =allTroopers.Where(x => x.Accuracy >= MinSkill && x.Accuracy < MaxSkill).OrderBy(x=>x.Accuracy).ToList();
            }
            
        }

        private void ResfreshList()
        {
            
            troopers.Where(x => x.Accuracy < 25).ToList();
            
        }

        public Command ExecuteRefreshList;

    }
}
