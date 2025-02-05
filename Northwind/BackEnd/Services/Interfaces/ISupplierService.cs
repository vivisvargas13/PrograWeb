using BackEnd.DTO;
using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface ISupplierService
    {
        void AddSupplier(SupplierDTO supplier);
        void UpdateSupplier(Supplier supplier);
        void DeleteSupplier(int id);
        List<Category> GetSuppliers();
    }
}
