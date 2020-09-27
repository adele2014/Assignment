using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;



namespace GenericRepo
{
   public interface IDBContext
    {

    //   void OnModelCreating(ModelBuilder modelBuilder);
        int SaveChanges(string userid);
        void Dispose();
    }
}
