using System;
using System.ComponentModel;

namespace JsonPlaceholderWpf.TestTask.Models
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        private string _error = string.Empty;
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Error
        /// </summary>
        public string Error
        {
            get
            {
                return _error;
            }
            set
            {
                _error = value;
            }
        }

        /// <summary>
        /// OnPropertyChanged
        /// </summary>
        /// <param name="propertyName"></param>
        protected void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }//class
}
