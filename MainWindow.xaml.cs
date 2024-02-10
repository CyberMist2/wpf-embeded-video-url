using System;
using System.Windows;

namespace WPF_Embeded_Video
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // USE HTTP NOT HTTPS
            // USE HTTP NOT HTTPS
            // USE HTTP NOT HTTPS
            // USE HTTP NOT HTTPS
            // USE HTTP NOT HTTPS
            // USE HTTP NOT HTTPS
            //LoadVideo("http://assets.ascension.gg/uploads/994b436d-327d-4757-96ef-e03d281fd111.mp4");
            //LoadVideo("http://assets.ascension.gg/uploads/994b34e8-0b25-476b-bc4d-5e797400f60c.mp4");
            LoadVideo("http://assets.ascension.gg/uploads/994b2d36-a626-4c87-8e06-62bd5180c605.mp4");
            mediaElement.MediaEnded += MediaElement_MediaEnded;
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            mediaElement.Position = TimeSpan.Zero;
            mediaElement.Play();
        }

        private void LoadVideo(string url)
        {
            try
            {
                mediaElement.Source = new Uri(url);
                mediaElement.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading video: " + ex.Message);
            }
        }
    }
}
