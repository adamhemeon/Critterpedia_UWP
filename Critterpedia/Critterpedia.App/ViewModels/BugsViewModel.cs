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
    class BugsViewModel// : ICritterViewModel
    {

        public CritterpediaRepo Repo { get; set; }

        #region Collections and lists
        public ObservableCollection<Critter> Critters { get; set; }
        public List<Critter> AllCritters { get; set; }
        public Critter _selectedCritter { get; set; }
        #endregion
        public string _filter { get; set; }

        public Critter SelectedCritter
        {
            get { return _selectedCritter; }
            set
            {
                _selectedCritter = value;
            }
        }

        public string Filter
        {
            get { return _filter; }
            set
            {
                if (value == _filter) { return; }
                _filter = value;
                PerformFiltering();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Filter)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #region Methods
        public void AddCritter()
        {
            throw new NotImplementedException();
            /*Critter newCritter = new Critter(?);
            AllCritters.Add(newCritter);
            PerformFiltering();*/
        }

        public void PerformFiltering()
        {
            //throw new NotImplementedException();
            /*if (_filter == null)
            {
                _filter = "";
            }

            var lowerCaseFilter = Filter.ToLowerInvariant().Trim();

            var result = AllCritters.Where(d => d.name?).ToList();

            var toRemove = Critters.Except(result).ToList();

            foreach(var x in toRemove)
            {
                Critters.Remove(x);
            }

            var resultCount = result.Count;

            for(int i = 0; i < resultCount; i++)
            {
                var resultItem = resultCount[i];
                if(i + 1 > Critters.Count || !Critters[i].Equals(resultItem))
                {
                    Critters.Insert(i, resultItem);
                }
            }*/
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public void RemoveCritter()
        {
            throw new NotImplementedException();
            /*AllCritters.Remove(SelectedCritter);
            SelectedCritter = null;
            PerformFiltering();*/
        }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public BugsViewModel()
        {
            this.Repo = new CritterpediaRepo();
            Repo.GetBugs();
            AllCritters = new List<Critter>();
            PerformFiltering();

        }
    }
}
