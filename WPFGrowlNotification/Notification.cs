using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WPFGrowlNotification
{
    public class Notification : INotifyPropertyChanged
    {
        private string message;
        public string Message
        {
            get { return message; }

            set
            {
                if (message == value) return;
                message = value;
                OnPropertyChanged("Message");
            }
        }

        private string borderColor;
        public string BorderColor
        {
            get { return borderColor; }

            set
            {
                if (borderColor == value) return;
                borderColor = value;
                OnPropertyChanged("BorderColor");
            }
        }

        private int id;
        public int Id
        {
            get { return id; }

            set
            {
                if (id == value) return;
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private string title;
        public string Title
        {
            get { return title; }

            set
            {
                if (title == value) return;
                title = value;
                OnPropertyChanged("Title");
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class Notifications : ObservableCollection<Notification> { }
}