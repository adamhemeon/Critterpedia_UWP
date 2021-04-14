using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Critterpedia.App.Models;
using Critterpedia.App.Repository;

namespace Critterpedia.App.ViewModels
{
    interface ICritterViewModel : INotifyPropertyChanged
    {
        // Properties
        CritterpediaRepo Repo { get; set; }
        ObservableCollection<Critter> Critters { get; set; }
        List<Critter> AllCritters { get; set; }
        Critter SelectedCritter { get; set; }
        string Filter { get; set; }

        // Methods
        void AddCritter();
        void RemoveCritter();
        void Refresh();
        void PerformFiltering();
    }
}
