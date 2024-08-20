using restoranas3.Models;

namespace restoranas3.Repository.Interfaces
{
    public interface ITableRepository
    {
        List<Table> GetAll();
        Table GetById(int id);
        //void Add(Table table);
        void Update(Table table);
        //void Delete(int id);
    }
}