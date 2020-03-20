﻿using ForumSystem.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumSystem.Data.Models
{
    public class Comment : BaseDeletableModel<int>
    {
        public int PostId { get; set; }

        public virtual Post Post { get; set; }

        public string Content { get; set; }

        public int UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
