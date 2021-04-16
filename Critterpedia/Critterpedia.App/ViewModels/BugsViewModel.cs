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
        public ObservableCollection<Bug> Bugs { get; set; }
        public List<Bug> AllBugs = new List<Bug>();
        public Bug _selectedBug { get; set; }
        #endregion
        public string _filter { get; set; }

        public Bug SelectedBug
        {
            get { return _selectedBug; }
            set
            {
                _selectedBug = value;
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
        public void AddBug(Bug bug)
        {
            AllBugs.Add(bug);
            PerformFiltering();
        }

        public void RemoveBug(Bug bug)
        {
            AllBugs.Remove(bug);
            PerformFiltering();

            if (SelectedBug == bug)
            {
                SelectedBug = null;
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
                AllBugs.Where(n => n.name.ToLowerInvariant()
                .Contains(lowerCaseFilter))
                .ToList();

            //Get list of values in current filtered list that we want to remove
            //(ie. don't meet new filter criteria)
            var toRemove = Bugs.Except(result).ToList();

            //Loop to remove items that fail filter
            foreach (var note in toRemove)
            {
                Bugs.Remove(note);
            }

            var resultCount = result.Count;
            // Add back in correct order.
            for (int i = 0; i < resultCount; i++)
            {
                var resultItem = result[i];
                if (i + 1 > Bugs.Count || !Bugs[i].Equals(resultItem))
                {
                    Bugs.Insert(i, resultItem);
                }
            }
        }

        public void Refresh()
        {
            AllBugs.Clear();
            Bugs.Clear();
            GetBugs();

            SelectedBug = null;
        }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public BugsViewModel()
        {
            this.Repo = new CritterpediaRepo();
            Bugs = new ObservableCollection<Bug>();

            Refresh();
            PerformFiltering();
        }

        public async void GetBugs()
        {
            AllBugs = await Repo.GetBugs();
            
            foreach(Bug bug in AllBugs)
            {
                Bugs.Add(bug);
            }
        }
    }
}
