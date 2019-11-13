using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProyectoEmail.Interfaces
{
  
        public interface ISQLiteDB
        {
        SQLiteAsyncConnection GetConnection();
        }
    }

