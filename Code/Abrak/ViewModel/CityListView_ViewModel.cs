using Abrak.Model;
using Abrak.View;
using System.Collections.ObjectModel;
using WeatherAPI;

namespace Abrak.ViewModel;

class CityListView_ViewModel
{
    public static ObservableCollection<CityMini_ViewModel>? Cities { get; set; }

    static bool HomeAlreadyLoaded = false;

    public CityListView_ViewModel()
    {
        Cities = new ObservableCollection<CityMini_ViewModel>();
        Home.TabChanged += OnTabChanged;
    }

    private async void OnTabChanged(bool isSearchTab)
    {
        Console.WriteLine($"📢 Received TabChanged event! isSearchTab: {isSearchTab} and {HomeAlreadyLoaded}");
        //   Cities.Clear();

        if (isSearchTab)
        {
            Cities.Clear();
            return;
        }

        if (!isSearchTab && !HomeAlreadyLoaded)  // Home Tab and noting was ever loaded 
        {
            await LoadWeatherDataServer(HomeCities.HomeCitiesListName);
            HomeAlreadyLoaded = true;
        }
         if (!isSearchTab && HomeAlreadyLoaded && !HomeCities.isChanged)  // We just went back to Home tab after Loaded
        {

            FillCityListView(HomeCities.HomeCitiesListData);
        }
        if (!isSearchTab && HomeCities.isChanged)
        {
            Cities.Clear();
            await LoadWeatherDataServer(HomeCities.HomeCitiesListName);
            HomeCities.isChanged = false;
        }


    }

    public static async Task LoadWeatherDataServer(List<string> cityNames)
    {
        Console.WriteLine("Loading from server");
        List<WeatherData> weatherDataCities = new List<WeatherData> { };

        foreach (string cityName in cityNames)
        {
            weatherDataCities.Add(await WeatherService.GetWeatherData(cityName));
            if(!HomeAlreadyLoaded || HomeCities.isChanged)
                HomeCities.HomeCitiesListData = weatherDataCities;
        }
        FillCityListView(weatherDataCities);
    }

    public static void FillCityListView(List<WeatherData> weatherDataCities)
    {
        Cities.Clear();

        foreach (var item in weatherDataCities)
        {
            if (item != null)
                Cities.Add(new CityMini_ViewModel(item));
        }
    }


}

