﻿using System.Windows;
using System.Windows.Media;

namespace WPFGrowlNotification
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private const double topOffset = 20;
        private const double leftOffset = 380;
        readonly GrowlNotifications growlNotifications = new GrowlNotifications();
        
        public MainWindow()
        {
            InitializeComponent();
            growlNotifications.Top = SystemParameters.WorkArea.Top + topOffset;
            growlNotifications.Left = SystemParameters.WorkArea.Left + SystemParameters.WorkArea.Width - leftOffset;
        }

        private void ButtonClick1(object sender, RoutedEventArgs e)
        {
            var icon = PathGeometry.Parse("F1 M 31.6667,19L 44.3333,19L 57,31.6667L 57,44.3333L 44.3333,57L 31.6667,57L 19,44.3333L 19,31.6667L 31.6667,19 Z M 26.4762,45.0454L 30.9546,49.5238L 38,42.4783L 45.0454,49.5238L 49.5237,45.0454L 42.4783,38L 49.5238,30.9546L 45.0454,26.4763L 38,33.5217L 30.9546,26.4762L 26.4762,30.9546L 33.5217,38L 26.4762,45.0454 Z");
            
            growlNotifications.AddNotification(new Notification { Title = "Mesage #1", IconData = icon, Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var icon = PathGeometry.Parse("F1 M 31.6667,19L 44.3333,19L 57,31.6667L 57,44.3333L 44.3333,57L 31.6667,57L 19,44.3333L 19,31.6667L 31.6667,19 Z M 26.4762,45.0454L 30.9546,49.5238L 38,42.4783L 45.0454,49.5238L 49.5237,45.0454L 42.4783,38L 49.5238,30.9546L 45.0454,26.4763L 38,33.5217L 30.9546,26.4762L 26.4762,30.9546L 33.5217,38L 26.4762,45.0454 Z");

            growlNotifications.AddNotification(new Notification { Title = "Mesage #2", IconData = icon, Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });
        }

        private void ButtonClick2(object sender, RoutedEventArgs e)
        {
            var icon = PathGeometry.Parse("F1 M 58.5832,55.4172L 17.4169,55.4171C 15.5619,53.5621 15.5619,50.5546 17.4168,48.6996L 35.201,15.8402C 37.056,13.9852 40.0635,13.9852 41.9185,15.8402L 58.5832,48.6997C 60.4382,50.5546 60.4382,53.5622 58.5832,55.4172 Z M 34.0417,25.7292L 36.0208,41.9584L 39.9791,41.9583L 41.9583,25.7292L 34.0417,25.7292 Z M 38,44.3333C 36.2511,44.3333 34.8333,45.7511 34.8333,47.5C 34.8333,49.2489 36.2511,50.6667 38,50.6667C 39.7489,50.6667 41.1666,49.2489 41.1666,47.5C 41.1666,45.7511 39.7489,44.3333 38,44.3333 Z");

            growlNotifications.AddNotification(new Notification { Title = "Mesage #3", IconData = icon, Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });
        }

        private void ButtonClick3(object sender, RoutedEventArgs e)
        {
            var icon = PathGeometry.Parse("F1 M 32.6227,68.9728C 33.1208,70.2446 33.7077,71.4719 34.3757,72.6471C 35.567,72.7702 36.7761,72.8333 38,72.8333C 40.6447,72.8333 43.2205,72.5386 45.6965,71.9802C 42.2807,68.5449 40.1698,63.8107 40.1698,58.5835C 40.1698,48.0901 48.6764,39.5835 59.1698,39.5835C 64.2047,39.5835 68.7822,41.5419 72.182,44.7385C 72.6094,42.5584 72.8333,40.3053 72.8333,38C 72.8333,36.442 72.731,34.908 72.5328,33.4041C 70.4772,32.3109 68.2718,31.4621 65.9554,30.8963L 65.6219,22.7367C 63.5664,22.3692 61.4511,22.1741 59.2916,22.1671L 57.491,30.1322C 54.2845,30.3184 51.2204,31.0348 48.3848,32.1949L 43.318,25.7887C 41.3995,26.7177 39.5749,27.8102 37.8622,29.0479L 41.0883,36.5527C 38.6742,38.5364 36.5919,40.9091 34.9373,43.575L 27.0703,41.3697C 26.073,43.2256 25.2319,45.178 24.5646,47.2093L 31.5867,51.385C 30.9883,53.6844 30.6698,56.0968 30.6698,58.5835L 30.746,60.6839L 23.0854,63.5239C 23.3743,65.6539 23.8474,67.7255 24.4881,69.7219L 32.6227,68.9728 Z M 27.0669,37.1755L 34.9338,39.3807C 35.9312,37.5248 36.7723,35.5724 37.4395,33.5412L 30.4175,29.3654C 31.0159,27.066 31.3344,24.6537 31.3344,22.1669L 31.2581,20.0665L 38.9187,17.2265C 38.6299,15.0965 38.1568,13.0249 37.5161,11.0285L 29.3815,11.7776C 28.4787,9.47258 27.2844,7.31377 25.8439,5.34655C 22.7943,6.48232 19.9467,8.03307 17.3698,9.93015C 20.1557,13.2359 21.8344,17.5054 21.8344,22.1669C 21.8344,32.5019 13.5826,40.9096 3.30816,41.1611C 3.60321,44.4411 4.35293,47.59 5.49381,50.5444C 8.34489,50.2806 11.0742,49.5968 13.6194,48.5555L 18.6861,54.9617C 20.6046,54.0327 22.4293,52.9403 24.142,51.7025L 20.9158,44.1977C 23.3299,42.2141 25.4123,39.8414 27.0669,37.1755 Z ");

            growlNotifications.AddNotification(new Notification { Title = "Mesage #4", IconData = icon, Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });
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
