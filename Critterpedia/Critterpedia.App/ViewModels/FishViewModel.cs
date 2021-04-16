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
    class FishViewModel// : ICritterViewModel
    {
        public CritterpediaRepo Repo { get; set; }

        #region Collections and lists
        public ObservableCollection<Fish> Fish { get; set; }
        public List<Fish> AllFish = new List<Fish>();
        public Fish _selectedFish { get; set; }
        #endregion
        public string _filter { get; set; }

        public Fish SelectedFish
        {
            get { return _selectedFish; }
            set
            {
                _selectedFish = value;
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
        public void AddFish(Fish fish)
        {
            AllFish.Add(fish);
            PerformFiltering();
        }

        public void RemoveFish(Fish fish)
        {
            AllFish.Remove(fish);
            PerformFiltering();

            if (SelectedFish == fish)
            {
                SelectedFish = null;
            }
        }

        public void PerformFiltering()
        {
            if (_filter == null)
            {
                _filter = "";
            }
            //If _filter has a value (ie. user entered something in Filter textbox)
            //Lower-case and trim string
            var lowerCaseFilter = Filter.ToLowerInvariant().Trim();

            //Use LINQ query to get all personmodel names that match filter text, as a list
            var result =
                AllFish.Where(n => n.name.ToLowerInvariant()
                .Contains(lowerCaseFilter))
                .ToList();

            //Get list of values in current filtered list that we want to remove
            //(ie. don't meet new filter criteria)
            var toRemove = Fish.Except(result).ToList();

            //Loop to remove items that fail filter
            foreach (var note in toRemove)
            {
                Fish.Remove(note);
            }

            var resultCount = result.Count;
            // Add back in correct order.
            for (int i = 0; i < resultCount; i++)
            {
                var resultItem = result[i];
                if (i + 1 > Fish.Count || !Fish[i].Equals(resultItem))
                {
                    Fish.Insert(i, resultItem);
                }
            }
        }

        public void Refresh()
        {
            AllFish.Clear();
            Fish.Clear();
            GetFish();

            SelectedFish = null;
        }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public FishViewModel()
        {
            this.Repo = new CritterpediaRepo();
            Fish = new ObservableCollection<Fish>();

            Refresh();
            PerformFiltering();
        }

        public async void GetFish()
        {
            AllFish = await Repo.GetFish();

            foreach (Fish fish in AllFish)
            {
                Fish.Add(fish);
            }
        }
    }
}
