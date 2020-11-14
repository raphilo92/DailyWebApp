﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDoWebApp.Data
{
    public interface ISQLAccess
    {
        Task<List<T>> LoadData<T, TU>(string sql, TU param);
        Task UpdateData<T>(string sql, T param);
    }
}