using ForumSystem.Data.Models;
using ForumSystem.Services.Mapping;
using System;

namespace ForumSystem.Web.ViewModels.Categories
{
    public class PostInCategoryViewModel : IMapFrom<Post>
    {
        public string Title { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Content { get; set; }

        public string UserUserName { get; set; }

        public int CommentsCount { get; set; }

    }
}