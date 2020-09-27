﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericRepo
{
    public interface IUnitOfWork : IDisposable
    {
        int Save(string userid);
        ApplicationDbContext Context { get; }

     
    }
}
