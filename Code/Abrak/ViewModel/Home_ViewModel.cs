using Abrak.Base;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WeatherAPI;

namespace Abrak.ViewModel;

    class Home_ViewModel : BaseINotify
    {

    private string _cityTextBox;

        public string CityTextBox
        {
            get { return _cityTextBox; }
            set {
                    _cityTextBox = value;
                    CityListView_ViewModel.Cities.Clear();
                  _ = CityListView_ViewModel.LoadWeatherDataServer( new List<string> { CityTextBox});
                      OnPropertyChanged();
                  }
        }

        public Home_ViewModel()
        {

        }

    
    }
    

