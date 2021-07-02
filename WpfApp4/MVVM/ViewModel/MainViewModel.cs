using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Core;

namespace WpfApp4.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand homeViewCommand { get; set; }
        public RelayCommand discoveryViewCommand { get; set; }
        public RelayCommand bibleViewCommand { get; set; }
        public HomeViewModel homeVM { get; set; }
        public DiscoveryViewModel discoveryVM { get; set; }
        public BibleViewModel bibleVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            homeVM = new HomeViewModel();
            discoveryVM = new DiscoveryViewModel();
            bibleVM = new BibleViewModel();

            CurrentView = homeVM;

            homeViewCommand = new RelayCommand(o =>
            {
                CurrentView = homeVM;
            });

            discoveryViewCommand = new RelayCommand(o => 
            {
                CurrentView = discoveryVM;
            });
            bibleViewCommand = new RelayCommand(o =>
            {
                CurrentView = bibleVM;
            });
        }
    }
}
