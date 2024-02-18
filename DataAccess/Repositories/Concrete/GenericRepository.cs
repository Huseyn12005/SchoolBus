using Library_Models.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using SchoolBus_DataAccess.Context;
using SchoolBus_DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus_DataAccess.Repositories.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
    {
        internal readonly SchoolBusDbContext? _context;



        public GenericRepository()
        {
            _context = new SchoolBusDbContext();
        }

        public ICollection<T>? GetAll()
        {
            return _context?.Set<T>().ToList();
        }

        public void Add(T entity)
        {
            if (entity is null) throw new Exception("Entity is NUll");
            _context?.Set<T>().Add(entity);
        }

        public T? GetById(int id)
        {
            if (id <= 0) throw new Exception("Id is not valid");
            var entity = _context?.Set<T>().FirstOrDefault(x => x.Id == id);
            return entity;
        }

        public void Remove(int id)
        {
            if (id <= 0) throw new Exception("Id is not valid");
            var entity = _context?.Set<T>().FirstOrDefault(x => x.Id == id);
            if (entity is null) throw new Exception("Entity is NUll");
            _context?.Set<T>().Remove(entity);
        }

        public void Save()
        {
            _context?.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity is null) throw new Exception("Entity is NUll");
            _context?.Set<T>().Update(entity);
        }

        public string Remove(T entity)
        {
            try
            {
                _context?.Set<T>().Remove(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Succesfully deleted!";
        }
    }
}
