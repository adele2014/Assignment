
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


//using TexasBar.Persistence.Context;


namespace GenericRepo
{
       
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IUnitOfWork _uow;
        private readonly ApplicationDbContext context;
        public Repository(IUnitOfWork uow)
        {
            _uow = uow;
            context = _uow.Context;
        }
        public IEnumerable<T> All
        {
            get
            {
             return context.Set<T>();
            }
        }
        public IEnumerable<T> AllEager(Expression<Func<T,bool>> filter = null, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = context.Set<T>();
          
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            
            if (filter != null)
            {
               
                    query = query.Where(filter);
                
            }
            return query;
        }
        public T Find(params object[] id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> WhereOne(Expression<Func<T, bool>> predicate)
        {
            var result = context.Set<T>().Where(predicate);
            return result.ToList();
        }
        public T FindOne(Func<T, bool> predicate)
        {
            try
            {
                var result = context.Set<T>().Where(predicate).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Insert(T item)
        {
            try
            {
                context.Entry(item).State = EntityState.Added;
            }
            catch (Exception ex)
            {

            }
           
    
        }

       /// <summary>
       /// Update The Entity in the DbContext
       /// </summary>
       /// <param name="item"></param>
        public void Update(T item)
        {
            context.Set<T>().Attach(item);
            context.Entry(item).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            var item = context.Set<T>().Find(id);
            context.Set<T>().Remove(item);
        }
   
        public void Dispose()
        {
            if (context != null)
                context.Dispose();
        }
    }
}
