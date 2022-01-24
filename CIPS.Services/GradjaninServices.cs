using CIPS.Core;
using CIPS.Repository;

namespace CIPS.Services
{

    public interface IGradjaninServices
    {
        List<Gradjanin> GetAll();
        Gradjanin Get(int id);
        Gradjanin Add(Gradjanin entity);
    }

    public class GradjaninServices : IGradjaninServices
    {

        IRepository<Gradjanin> _db;
        public GradjaninServices(IRepository<Gradjanin> db)
        {
            _db = db;
        }

        public Gradjanin Add(Gradjanin entity)
        {
            return _db.Add(entity);
        }

        public Gradjanin Get(int id)
        {
           return _db.Get(id);
        }

        public List<Gradjanin> GetAll()
        {
            return _db.GetAll();
        }
    }
}