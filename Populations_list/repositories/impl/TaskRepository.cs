using Microsoft.EntityFrameworkCore;
using Populations_list.EF;
using Populations_list.entities;
using Populations_list.repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Populations_list.repositories.impl
{
    public class TaskRepository
        : BaseRepository<task>, ITaskRepository
    {
        public TaskRepository(DbContext context) : base(context)
        {
        }

        public TaskRepository(taskContext context) : base(context)
        {

        }
    }
}
