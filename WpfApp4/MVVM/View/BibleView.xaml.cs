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
    /// Interaction logic for BibleView.xaml
    /// </summary>
    public partial class BibleView : UserControl
    {
        public BibleView()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var verse = await BibleProcessor.LoadBibleVerse();

            chapterAndVerseText.Text = verse.Book + " " + verse.Chapter + ":" + verse.Number;
            scriptureText.Text = verse.Verse;
        }

        private async void newVerseBtn_Click(object sender, RoutedEventArgs e)
        {
            var verse = await BibleProcessor.LoadRandomVerse();

            chapterAndVerseText.Text = verse.Book + " " + verse.Chapter + ":" + verse.Number;
            scriptureText.Text = verse.Verse;
        }
    }
}
