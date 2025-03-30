using Abrak.Base;
using Abrak.View;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Input;

namespace Abrak.ViewModel;

    public class MainView_ViewModel : BaseINotify
    {
        private UserControl _currentView;
        public UserControl CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand ViewChangeCommand { get; }

        public MainView_ViewModel()
        {
            ViewChangeCommand = new RelayCommand(ChangeView);
            // Initialize with default view (optional)
            CurrentView = new Home(); // Or HomeView, etc.
        }

        private void ChangeView(object viewName)
        {
            switch (viewName.ToString())
            {
                case "Home":
                        CurrentView = new Home();
                    break;
                case "Settings":
                     CurrentView = new SettingsPage();
                    break;
                case "About Us":
                    CurrentView = new AboutUs();
                    break;
            }
        }
    }

