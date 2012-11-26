using System.Windows;

namespace WPFGrowlNotification
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private const double topOffset = 20;
        private const double leftOffset = 380;
        readonly GrowlNotifiactions growlNotifications = new GrowlNotifiactions();
        
        public MainWindow()
        {
            InitializeComponent();
            growlNotifications.Top = SystemParameters.WorkArea.Top + topOffset;
            growlNotifications.Left = SystemParameters.WorkArea.Left + SystemParameters.WorkArea.Width - leftOffset;
        }

        private void ButtonClick1(object sender, RoutedEventArgs e)
        {
            growlNotifications.AddNotification(new Notification { Title = "Mesage #1", ImageUrl = "pack://application:,,,/Resources/notification-icon.png", Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            growlNotifications.AddNotification(new Notification { Title = "Mesage #2", ImageUrl = "pack://application:,,,/Resources/microsoft-windows-8-logo.png", Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });
        }

        private void ButtonClick2(object sender, RoutedEventArgs e)
        {
            growlNotifications.AddNotification(new Notification { Title = "Mesage #3", ImageUrl = "pack://application:,,,/Resources/facebook-button.png", Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });
        }

        private void ButtonClick3(object sender, RoutedEventArgs e)
        {
            growlNotifications.AddNotification(new Notification { Title = "Mesage #4", ImageUrl = "pack://application:,,,/Resources/Radiation_warning_symbol.png", Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });
        }

        protected override void OnClosed(System.EventArgs e)
        {
            growlNotifications.Close();
            base.OnClosed(e);
        }

        private void WindowLoaded1(object sender, RoutedEventArgs e)
        {
            //this will make minimize restore of notifications too
            //growlNotifications.Owner = GetWindow(this);
        }
    }
}
