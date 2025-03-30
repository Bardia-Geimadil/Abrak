using Abrak.Base;
using Abrak.Model;
using System.Windows.Input;
using WeatherAPI;

namespace Abrak.ViewModel
{
    public class CityMini_ViewModel : BaseINotify
    {
        private WeatherData _city;
        public WeatherData City
        {
            get { return _city; }
            set { _city = value; OnPropertyChanged(); }
        }

        private bool _isFavorite;
        public bool IsFavorite
        {
            get { return _isFavorite; }
            set { _isFavorite = value; OnPropertyChanged(); }
        }

        public ICommand ToggleFavoriteCommand { get; }

        public CityMini_ViewModel(WeatherData cityData)
        {
            City = cityData;
            ToggleFavoriteCommand = new RelayCommand(_ => ToggleFavorite());
            if (HomeCities.HomeCitiesListName.Contains(City.Name))
                IsFavorite = true;

        }

        private void ToggleFavorite()
        {
            IsFavorite = !IsFavorite;
            HomeCities.isChanged = true;

            if (IsFavorite)
                HomeCities.HomeCitiesListName.Add(City.Name); // Add to favorites
            else
            {

                HomeCities.HomeCitiesListData.RemoveAll(item => item.Name == City.Name);
                HomeCities.HomeCitiesListName.Remove(City.Name);
                CityListView_ViewModel.FillCityListView(HomeCities.HomeCitiesListData);
            }

        }
    }
}
