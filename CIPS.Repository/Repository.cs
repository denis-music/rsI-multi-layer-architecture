using Microsoft.EntityFrameworkCore;

namespace CIPS.Repository
{


    public interface IRepository<TEntity>
    {
        List<TEntity> GetAll();
        TEntity Get(int id);    
        TEntity Add(TEntity entity);
    }    

    public interface IUnitOfWork { }
    public class UnitOfWork : IUnitOfWork
    {
        CIPSContext _context;
    }

    public class Repositor<TEntity> : IRepository<TEntity> where TEntity : class
    {        
        CIPSContext _context;
        DbSet<TEntity> _dbSet;        

        public Repositor(CIPSContext context)
        {
            _context =  context;
            _dbSet= _context.Set<TEntity>();
        }
        
        public TEntity Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity Get(int id)
        {
            return _dbSet.Find(id);
        }

        public List<TEntity> GetAll()
        {            
            return _dbSet.ToList();
        }
    }
}