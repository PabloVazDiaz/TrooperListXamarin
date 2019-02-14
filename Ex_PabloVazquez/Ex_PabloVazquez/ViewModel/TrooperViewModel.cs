using Ex_PabloVazquez.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Ex_PabloVazquez.ViewModel
{
    public class TrooperViewModel : BindableObject
    {

        private int id;
        public int Id { get => id; set => id = value; }
        private string name;
        public string Name { get => name; set => name = value; }
        private int accuracy;
        public int Accuracy { get => accuracy; set => accuracy = value; }

        public TrooperViewModel(Trooper troop)
        {
            Id = troop.Id;
            name = troop.Name;
            accuracy = troop.Accuracy;
        }

    }
}
