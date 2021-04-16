using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Critterpedia.App.Models;
using Critterpedia.App.Repository;

namespace Critterpedia.App.ViewModels
{
    class SeaCreaturesViewModel// : ICritterViewModel
    {
        public CritterpediaRepo Repo { get; set; }

        #region Collections and lists
        public ObservableCollection<SeaCreature> SeaCreatures { get; set; }
        public List<SeaCreature> AllSeaCreatures = new List<SeaCreature>();
        public SeaCreature _selectedSeaCreature { get; set; }
        #endregion
        public string _filter { get; set; }

        public string SeaCreatureInfo { get; set; }

        //public string SeaCreatureImageUri { get; set; }

        public SeaCreature SelectedSeaCreature
        {
            get { return _selectedSeaCreature; }
            set
            {
                _selectedSeaCreature = value;
                if(value == null)
                {
                    SeaCreatureInfo = "";
                    //SeaCreatureImageUri = "/Assets/src/nh_tab_dsc.png";
                }
                else
                {
                    SeaCreatureInfo = value.ToString();
                    //SeaCreatureImageUri = value.imageUri;
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SeaCreatureInfo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SeaCreatureImageUri"));
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
        public void AddSeaCreature(SeaCreature sc)
        {
            AllSeaCreatures.Add(sc);
            PerformFiltering();
        }

        public void RemoveSeaCreature(SeaCreature sc)
        {
            AllSeaCreatures.Remove(sc);
            PerformFiltering();

            if (SelectedSeaCreature == sc)
            {
                SelectedSeaCreature = null;
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
                AllSeaCreatures.Where(n => n.name.ToLowerInvariant()
                .Contains(lowerCaseFilter))
                .ToList();

            //Get list of values in current filtered list that we want to remove
            //(ie. don't meet new filter criteria)
            var toRemove = SeaCreatures.Except(result).ToList();

            //Loop to remove items that fail filter
            foreach (var note in toRemove)
            {
                SeaCreatures.Remove(note);
            }

            var resultCount = result.Count;
            // Add back in correct order.
            for (int i = 0; i < resultCount; i++)
            {
                var resultItem = result[i];
                if (i + 1 > SeaCreatures.Count || !SeaCreatures[i].Equals(resultItem))
                {
                    SeaCreatures.Insert(i, resultItem);
                }
            }
        }

        public void Refresh()
        {
            AllSeaCreatures.Clear();
            SeaCreatures.Clear();
            GetSeaCreatures();

            SelectedSeaCreature = null;
        }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public SeaCreaturesViewModel()
        {
            this.Repo = new CritterpediaRepo();
            SeaCreatures = new ObservableCollection<SeaCreature>();

            Refresh();
            PerformFiltering();
        }

        public async void GetSeaCreatures()
        {
            AllSeaCreatures = await Repo.GetSeaCreatures();

            foreach (SeaCreature sc in AllSeaCreatures)
            {
                SeaCreatures.Add(sc);
            }
        }
    }
}
