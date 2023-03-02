using ApiCLass;
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
using System.Windows.Shapes;

namespace demo
{
    /// <summary>
    /// Interaction logic for sunSide.xaml
    /// </summary>
    public partial class sunSide : Window
    {
        public sunSide()
        {
            InitializeComponent();
        }

        private async void LoadInfo_Click(object sender, RoutedEventArgs e)
        {
            var suninfo = await SunProcessor.LoadSunInfomation();

            sunrise_text.Text = $"Mặt trời mọc là { suninfo.Sunrise.ToLocalTime().ToShortTimeString() }";
            sunset_text.Text = $"Mặt trời lặn là { suninfo.Sunset.ToLocalTime().ToShortTimeString() }";

        }

        
    }
}
