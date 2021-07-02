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
    /// Interaction logic for DiscoveryView.xaml
    /// </summary>
    public partial class DiscoveryView : UserControl
    {
        private int maxNumber = 0;
        private int currentNumber = 0;
        public DiscoveryView()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            nextBtn.IsEnabled = false;
        }

        private async Task LoadImage(int imageNumber = 0)
        {
            var comic = await ComicProcessor.LoadComic(imageNumber);


            if(imageNumber == 0)
            {
                maxNumber = comic.Num;
            }
            currentNumber = comic.Num;

            var uriSource = new Uri(comic.Img, UriKind.Absolute);
            comicImage.Source = new BitmapImage(uriSource);


        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadImage();
        }

        private async void previousBtn_Click(object sender, RoutedEventArgs e)
        {
            if(currentNumber > 1)
            {
                currentNumber -= 1;
                nextBtn.IsEnabled = true;
                await LoadImage(currentNumber);

                if(currentNumber == 1)
                {
                    previousBtn.IsEnabled = false;
                }
            }
        }

        private async void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            if(currentNumber < maxNumber)
            {
                currentNumber += 1;
                previousBtn.IsEnabled = true;
                await LoadImage(currentNumber);

                if(currentNumber == maxNumber)
                {
                    nextBtn.IsEnabled = false;
                }
            }
        }
    }
}
