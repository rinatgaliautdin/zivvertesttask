namespace JsonPlaceholderWpf.TestTask.Models
{
    public class MessagePost : ViewModelBase
    {
        private int _userId;
        public int UserId
        {
            get
            {
                return _userId;
            }
            set
            {
                if (_userId != value)
                {
                    _userId = value;
                    OnPropertyChanged("UserId");
                }
            }
        }

        public int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged("Id");
                }
            }
        }


        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged("Title");
                }
            }
        }


        private string _body;
        public string Body
        {
            get
            {
                return _body;
            }
            set
            {
                if (_body != value)
                {
                    _body = value;
                    OnPropertyChanged("Body");
                }
            }
        }


        private int _frontTitle;
        public int FrontTitle
        {
            get
            {
                return _frontTitle;
            }
            set
            {
                if (_frontTitle != value)
                {
                    _frontTitle = value;
                    OnPropertyChanged("FrontTitle");
                }
            }
        }


    }
}
