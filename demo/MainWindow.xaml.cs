
using ApiCLass;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int maxNumber = 0;
        private int currentNumber = 0;

        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.initializeClient();
            nextImage.IsEnabled = false;

        }

        private async Task loadImage(int imageNumber = 0)
        {
            var commic = await CommicProfess.LoadCommic(imageNumber);
            if (imageNumber == 0)
            {
                maxNumber = commic.Num;
            }
            currentNumber = commic.Num;

            var uriSource = new Uri(commic.Img, UriKind.Absolute);
            commicImage.Source = new BitmapImage(uriSource);
            
        }

        private async void window_loaded(object sender, RoutedEventArgs e)
        {
            await loadImage();
        }

       

        private async void perviousImage_Click(object sender, RoutedEventArgs e)
        {
            if(currentNumber > 1)
            {
                currentNumber -= 1;
                nextImage.IsEnabled = true;
                await loadImage(currentNumber);
            }
            else
            {
                currentNumber = 1;
                perviousImage.IsEnabled = false;
            }
        }

        private async void nextImage_Click(object sender, RoutedEventArgs e)
        {
            if(currentNumber < maxNumber)
            {
                currentNumber += 1;
                perviousImage.IsEnabled=true;

                await loadImage(currentNumber); 
                if(currentNumber == maxNumber)
                {
                    nextImage.IsEnabled = false;
                }
            }
        }

        private void sunInformation_Click(object sender, RoutedEventArgs e)
        {
            sunSide sunSide = new sunSide();
            sunSide.Show();
        }
    }
}
