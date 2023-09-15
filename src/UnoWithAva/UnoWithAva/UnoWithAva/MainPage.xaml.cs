using Avalonia.Browser;

namespace UnoWithAva
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            Grid g = this.FindName("TheGridToReplace") as Grid;

            string htmlId = g.GetHtmlId();

            //AvaloniaView avaloniaView;
            //AvaloniaView avaloniaView = new AvaloniaView(htmlId)
            //{
            //   // Content = new AvaloniaLibrary.MyAvaloniaControl()
            //};
        }
    }
}