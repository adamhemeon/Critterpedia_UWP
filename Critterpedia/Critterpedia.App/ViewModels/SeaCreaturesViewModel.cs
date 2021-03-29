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
    class SeaCreaturesViewModel : ICritterViewModel
    {
        public CritterpediaRepo Repo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObservableCollection<Critter> Critters { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Critter> AllCritters { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Critter SelectedCritter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Filter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event PropertyChangedEventHandler PropertyChanged;

        public void AddCritter()
        {
            throw new NotImplementedException();
        }

        public void PerformFiltering()
        {
            throw new NotImplementedException();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public void RemoveCritter()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public SeaCreaturesViewModel()
        {
            this.Repo = new CritterpediaRepo();
            // Repo.GetSeaCreatures();
        }
    }
}
