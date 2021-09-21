using JsonPlaceholderWpf.TestTask.BLL;
using JsonPlaceholderWpf.TestTask.Commands;
using JsonPlaceholderWpf.TestTask.Domain;
using JsonPlaceholderWpf.TestTask.Models;
using JsonPlaceholderWpf.TestTask.ViewModels.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace JsonPlaceholderWpf.TestTask.ViewModels
{
    public class JsonPlaceholderViewModel: ViewModelBase
    {
        //public ObservableCollection<MessagePost> Messages { get; set; }

        private string _postsServiceUrl;

        public JsonPlaceholderViewModel()
        {
            _postsServiceUrl = ConfigurationManager.AppSettings["PostsUrl"];

            IsShowingId = true;

            Task.Run(() => Inititialize());
        }

        private ObservableCollection<MessagePost> _messages = new ObservableCollection<MessagePost>();

        public ObservableCollection<MessagePost> Messages
        {
            get
            {
                return _messages;
            }
            set
            {
                _messages = value;
                OnPropertyChanged("Messages");
            }
        }

        private MessagePost _selectedMessagePost;
        public MessagePost SelectedMessagePost
        {
            get
            {
                return _selectedMessagePost;
            }
            set
            {
                if (_selectedMessagePost != value)
                {
                    _selectedMessagePost = value;
                    OnPropertyChanged("SelectedMessagePost");
                }
            }
        }


        private bool _isShowingId;
        public bool IsShowingId
        {
            get
            {
                return _isShowingId;
            }
            set
            {
                if (_isShowingId != value)
                {
                    _isShowingId = value;
                    OnPropertyChanged("IsShowingId");

                    NotifyCollection(IsShowingId);
                }
            }
        }


        #region Private methods

        /// <summary>
        /// NotifyCollection
        /// </summary>
        /// <param name="isShowingId"></param>
        private void NotifyCollection(bool isShowingId)
        {
            if (Messages != null)
            {
                foreach (var msg in Messages)
                {
                    msg.FrontTitle = isShowingId ? msg.Id : msg.UserId;
                }
            }
        }

        /// <summary>
        /// Inititialize
        /// </summary>
        /// <returns></returns>
        private async Task Inititialize()
        {
            try
            {
                var svc = new DataRetreiver<List<Post>>();
                var posts = await svc.GetPosts(_postsServiceUrl);

                Messages = posts != null ? posts.ToMessagePostObservableCollection() : new ObservableCollection<MessagePost>();
            }
            catch (Exception)
            {
                MessageBox.Show("Some error occured while trying to make Http request. It has not been logged as it would be overkill!");
            }
        }

        #endregion


        #region Commands


        private DelegateCommand _messagePostCommand;


        public ICommand MessagePostCommand
        {
            get
            {
                if (_messagePostCommand == null)
                    _messagePostCommand = new DelegateCommand(new Action(MessagePostExecuted), new Func<bool>(MessagePostCanExecute));

                return _messagePostCommand;
            }
        }


        /// <summary>
        /// MessagePostCanExecute
        /// </summary>
        /// <returns></returns>
        public bool MessagePostCanExecute()
        {
            return true; 
        }


        /// <summary>
        /// MessagePostExecuted
        /// </summary>
        public void MessagePostExecuted()
        {
            IsShowingId = !IsShowingId;
        }
 

        #endregion


    }//class
}
