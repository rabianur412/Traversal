using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context context = new Context();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Delete(T t)
        {
            var deletedEntity = context.Entry(t);
            deletedEntity.State = EntityState.Deleted;
            //_object.Remove(t);
            context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);//bir dizide ya da listede sadece bir tane ifade döndüren linq 
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetList()
        {
            return _object.ToList();
        }
        public List<T> GetList(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Insert(T t)
        {
            var addedEntity = context.Entry(t);//entry = giriş
            addedEntity.State = EntityState.Added;
            // _object.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            var updatedEntity = context.Entry(t);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
