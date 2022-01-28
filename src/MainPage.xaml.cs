using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HeightGained
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<string> units = new ObservableCollection<string>();
        public MainPage()
        {
            this.InitializeComponent();
            units.Add("Miles");
            units.Add("Meters");
            unitsComboBox.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            resultsView.Text = "";
            bool metricSystem = unitsComboBox.SelectedIndex == 1;

            double grade, distance;
            if (!Double.TryParse(distanceTxtBox.Text, out distance))
            {
                return;
            }
            if (!Double.TryParse(gradeTxtBox.Text, out grade))
            {
                return;
            }

            double rise;
            string resultToDisplay;
            if (!metricSystem)
            {
                rise = (grade / 100.0) * (distance * 5280.0);
                resultToDisplay = "Height gained (in feet): ";
            }
            else
            {
                rise = (grade / 100.0) * (distance);
                resultToDisplay = "Height gained (in meters): ";
            }
            resultToDisplay += string.Format("{0:0.00}", rise);
            resultsView.Text = resultToDisplay;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
