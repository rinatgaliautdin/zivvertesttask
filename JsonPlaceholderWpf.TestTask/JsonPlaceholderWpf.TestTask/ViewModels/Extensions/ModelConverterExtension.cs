using JsonPlaceholderWpf.TestTask.Domain;
using JsonPlaceholderWpf.TestTask.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace JsonPlaceholderWpf.TestTask.ViewModels.Extensions
{
    public static class ModelConverterExtension
    {
        /// <summary>
        /// ToMessagePost
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        public static MessagePost ToMessagePost(this Post post)
        {
            if (post == null) return null;

            return new MessagePost {
                 Id = post.Id,
                 UserId = post.UserId,
                 Body = post.Body,
                 Title = post.Title,
                 FrontTitle = post.Id
            };
        }


        /// <summary>
        /// ToMessagePostList
        /// </summary>
        /// <param name="posts"></param>
        /// <returns></returns>
        public static ObservableCollection<MessagePost> ToMessagePostObservableCollection(this List<Post> posts)
        {
            if (posts == null) return null;

            var result = new ObservableCollection<MessagePost>();

            foreach(var post in posts)
            {
                result.Add(new MessagePost
                {
                    Id = post.Id,
                    UserId = post.UserId,
                    Body = post.Body,
                    Title = post.Title,
                    FrontTitle = post.Id
                });
            }

            return result;
        }

    }
}
