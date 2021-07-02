using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4.MVVM.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        
        public HomeView()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var sunInfo = await SunProcessor.LoadSunInformation();

            var tempInfo = await WeatherProcessor.LoadWeather();
            var typeInfo = await WeatherProcessor.LoadWeatherType();


            weatherTypeText.Text = typeInfo[0].Main;

            tempText.Text = tempInfo.Temp;
            tempHighText.Text = tempInfo.Temp_Max;
            tempLowText.Text = tempInfo.Temp_Min;
            humidityText.Text = tempInfo.Humidity;


        }
    }
}
