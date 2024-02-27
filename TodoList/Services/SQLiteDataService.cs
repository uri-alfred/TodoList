using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Services
{
    internal class SQLiteDataService : IDataService
    {
        public List<Tarea> Tasks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddTask(Tarea tarea)
        {
            throw new NotImplementedException();
        }

        public List<Tarea> GetTasks()
        {
            throw new NotImplementedException();
        }
    }
}
