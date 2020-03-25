using System;
using System.Collections.Generic;
using System.Text;

namespace ForumSystem.Services.Data
{
    public interface ICategoriesService
    {
        IEnumerable<T> GetAll<T>(int? count = null);

        T GetByName<T>(string name);
    }
}
