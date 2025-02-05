using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Implementations;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class SupplierService : ISupplierService
    {

        IUnidadDeTrabajo _unidadDeTrabajo;

        public SupplierService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public void AddSupplier(SupplierDTO supplier)
        {

            var supplierEntity = new Supplier()
            {
                CategoryName = category.CategoryName

            };

            _unidadDeTrabajo.SupplierDAL.Add(supplierEntity);
            _unidadDeTrabajo.Complete();
        }

        public void DeleteSupplier(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetSuppliers()
        {
            throw new NotImplementedException();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _unidadDeTrabajo.SupplierDAL.Update(supplier);
            _unidadDeTrabajo.Complete();
        }
    }
}
