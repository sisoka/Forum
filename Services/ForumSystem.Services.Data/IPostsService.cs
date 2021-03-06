﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem.Services.Data
{
    public interface IPostsService
    {
        Task<int> CreateAsync(string title, string content, int categoryId, string userId);

        T GetPostById<T>(int id);
    }
}
