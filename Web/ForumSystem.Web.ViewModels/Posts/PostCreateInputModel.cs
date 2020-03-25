using ForumSystem.Data.Models;
using ForumSystem.Services.Mapping;
using ForumSystem.Web.ViewModels.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ForumSystem.Web.ViewModels.Posts
{
    public class PostCreateInputModel : IMapFrom<Post>
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public string UserId { get; set; }

        public IEnumerable<CategoryDropDownViewModel> Categories { get; set; }
    }
}
