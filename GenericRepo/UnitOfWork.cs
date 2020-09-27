using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 


namespace GenericRepo
{
    
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        public UnitOfWork()
        {
                     }
        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
        }
        public int Save(string userid)
        {
         return context.SaveChanges();
        }
        public ApplicationDbContext Context
        {
            get
            {
                return context;
            }
        }
        public void Dispose()
        {
            if (context != null)
                context.Dispose();
        }
    }
}
