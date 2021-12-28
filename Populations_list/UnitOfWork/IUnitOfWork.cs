using Populations_list.repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Populations_list.UnitOfWork
{
    public interface IUnitOfWork
        : IDisposable
    {
        ICityRepository citys { get; }
        ITaskRepository tasks { get; }
        void Save();
    }
}
