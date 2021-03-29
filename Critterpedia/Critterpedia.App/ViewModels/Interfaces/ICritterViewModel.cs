using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Critterpedia.App.Models;
using Critterpedia.App.Commands;
using Critterpedia.App.Repository;
using Windows.Storage;
using System.Diagnostics;

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
