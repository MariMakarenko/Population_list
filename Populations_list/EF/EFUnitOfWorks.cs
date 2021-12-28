﻿using Populations_list.UnitOfWork;
using Populations_list.repositories.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Populations_list.repositories.interfaces;
using Populations_list.entities;

namespace Populations_list.EF
{
    public class EFUnitOfWork
        : IUnitOfWork
    {
        private cityContext db;
        private CityRepository cityRepository;
        private TaskRepository taskRepository;        
        public EFUnitOfWork(DbContextOptions options)
        {
            db = new cityContext(options);
        }

        public ICityRepository citys
        {
            get
            {
                if (cityRepository == null)
                    cityRepository = new CityRepository(db);
                return cityRepository;
            }
        }

        public ITaskRepository tasks
        {
            get 
            {
                if (taskRepository == null)
                    taskRepository = new TaskRepository(db);
                return taskRepository; 
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
